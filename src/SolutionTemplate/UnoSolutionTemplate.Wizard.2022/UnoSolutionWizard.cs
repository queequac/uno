#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TemplateWizard;
using Microsoft.VisualStudio.Utilities;
using UnoSolutionTemplate.Wizard.Forms;

namespace UnoSolutionTemplate.Wizard
{
	public class UnoSolutionWizard : IWizard
	{
		private const string ProjectKinds_vsProjectKindSolutionFolder = "{66A26720-8FB5-11D2-AA7E-00C04F688DDE}";
		private readonly bool _enableNuGetConfig;
		private readonly string _vsSuffix;
		private string? _targetPath;
		private string _projectName;
		private DTE2? _dte;
		private IServiceProvider? _visualStudioServiceProvider;
		private WizardData wizardData;
		private string _useWebAssembly;
		private string _useMobile;
		private string _useGtk;
		private string _useFramebuffer;
		private string _useWpf;

		public UnoSolutionWizard(bool enableNuGetConfig, string vsSuffix)
		{
			_enableNuGetConfig = enableNuGetConfig;
			_vsSuffix = vsSuffix;
		}

		protected IServiceProvider VisualStudioServiceProvider
		{
			get
			{
				if (_visualStudioServiceProvider == null)
				{
					_visualStudioServiceProvider = _dte as IServiceProvider;
					if (_visualStudioServiceProvider == null)
					{
						var serviceProvider = (Microsoft.VisualStudio.OLE.Interop.IServiceProvider?)((_dte is Microsoft.VisualStudio.OLE.Interop.IServiceProvider) ? _dte : null);
						_visualStudioServiceProvider = (IServiceProvider)new Microsoft.VisualStudio.Shell.ServiceProvider(serviceProvider);
					}
				}
				return _visualStudioServiceProvider;
			}
		}

		public void BeforeOpeningFile(ProjectItem projectItem)
		{
		}

		public void ProjectFinishedGenerating(Project project)
		{
			ThreadHelper.ThrowIfNotOnUIThread();

			if (_dte?.Solution is Solution2 solution)
			{
				var platforms = solution.Projects.OfType<Project>().FirstOrDefault(p => p.Name == "Platforms");

				if (platforms.Object is SolutionFolder platformsFolder)
				{
					if (_useWebAssembly == true.ToString())
					{
						var projectName = $"{_projectName}.Wasm";
						platformsFolder.AddFromTemplate(solution.GetProjectTemplate("Wasm.winui.net6.vstemplate", "CSharp"), Path.Combine(_targetPath, projectName), projectName);
					}

					if (_useMobile == true.ToString())
					{
						var projectName = $"{_projectName}.Mobile";
						platformsFolder.AddFromTemplate(solution.GetProjectTemplate("Mobile.winui.net6.vstemplate", "CSharp"), Path.Combine(_targetPath, projectName), projectName);
					}

					if (_useGtk == true.ToString())
					{
						var projectName = $"{_projectName}.Skia.Gtk";
						platformsFolder.AddFromTemplate(solution.GetProjectTemplate("SkiaGtk.winui.net6.vstemplate", "CSharp"), Path.Combine(_targetPath, projectName), projectName);
					}

					if (_useFramebuffer == true.ToString())
					{
						var projectName = $"{_projectName}.Skia.Linux.FrameBuffer";
						platformsFolder.AddFromTemplate(solution.GetProjectTemplate("SkiaLinuxFrameBuffer.winui.net6.vstemplate", "CSharp"), Path.Combine(_targetPath, projectName), projectName);
					}

					if (_useWpf == true.ToString())
					{
						var projectName = $"{_projectName}.Skia.Wpf";
						platformsFolder.AddFromTemplate(solution.GetProjectTemplate("SkiaWpf.winui.net6.vstemplate", "CSharp"), Path.Combine(_targetPath, projectName), projectName);

						var hostProjectName = $"{_projectName}.Skia.Wpf.Host";
						platformsFolder.AddFromTemplate(solution.GetProjectTemplate("SkiaWpfHost.winui.net6.vstemplate", "CSharp"), Path.Combine(_targetPath, hostProjectName), hostProjectName);
					}
				}
				else
				{
					throw new InvalidOperationException("Unable to find the Platforms solution folder");
				}
			}
		}

		public void ProjectItemFinishedGenerating(ProjectItem projectItem)
		{
		}

		public void RunFinished()
		{
			var vsConfigPath = Path.Combine(_targetPath, "..\\.vsconfig");

			if (!File.Exists(vsConfigPath))
			{
				using var reader = new StreamReader(GetType().Assembly.GetManifestResourceStream($"{GetType().Assembly.GetName().Name}..vsconfig.{_vsSuffix}"));
				File.WriteAllText(vsConfigPath, reader.ReadToEnd());
			}

			var nugetConfigPath = Path.Combine(_targetPath, "..\\NuGet.config");

			if (_enableNuGetConfig && !File.Exists(nugetConfigPath))
			{
				using var reader = new StreamReader(GetType().Assembly.GetManifestResourceStream($"{GetType().Assembly.GetName().Name}.NuGet-netcore.config"));
				File.WriteAllText(nugetConfigPath, reader.ReadToEnd());
			}

			OpenWelcomePage();
			SetStartupProject();
			SetUWPAnyCPUBuildableAndDeployable();
			SetDefaultConfiguration();
		}

		public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
		{
			_targetPath = replacementsDictionary["$destinationdirectory$"];
			_projectName = replacementsDictionary["$projectname$"];

			if (runKind == WizardRunKind.AsMultiProject)
			{
				_dte = (DTE2)automationObject;
			}

			if (replacementsDictionary.TryGetValue("$wizarddata$", out var value) && !string.IsNullOrWhiteSpace(value))
			{
				wizardData = new WizardData("<WizardData>" + value + "</WizardData>");
			}

			using (DpiAwareness.EnterDpiScope(DpiAwarenessContext.SystemAware))
			{
				using DialogParentWindow owner = new DialogParentWindow(IntPtr.Zero, enableModeless: true, VisualStudioServiceProvider);
				using UnoOptions targetPlatformWizardPicker = new UnoOptions(VisualStudioServiceProvider, wizardData);

				switch (targetPlatformWizardPicker.ShowDialog(owner))
				{
					case DialogResult.OK:
						replacementsDictionary["$UseWebAssembly$"] = _useWebAssembly = targetPlatformWizardPicker.UseWebAssembly;
						replacementsDictionary["$UseMobile$"] = _useMobile = targetPlatformWizardPicker.UseMobile;
						replacementsDictionary["$UseGtk$"] = _useGtk = targetPlatformWizardPicker.UseGtk;
						replacementsDictionary["$UseFrameBuffer$"] = _useFramebuffer = targetPlatformWizardPicker.UseFramebuffer;
						replacementsDictionary["$UseWpf$"] = _useWpf = targetPlatformWizardPicker.UseWpf;
						break;

					case DialogResult.Abort:
						MessageBox.Show("Aborted"/*targetPlatformWizardPicker.Error*/);
						throw new WizardCancelledException();

					default:
						throw new WizardBackoutException();
				}
			}
		}

		public bool ShouldAddProjectItem(string filePath) => true;

		public Project[] GetAllProjects()
		{
			var list = new List<Project>();
			if (_dte != null)
			{
				var projects = _dte.Solution.Projects;
				var item = projects.GetEnumerator();
				while (item.MoveNext())
				{
					var project = item.Current as Project;
					if (project == null)
					{
						continue;
					}

					if (project.Kind == ProjectKinds_vsProjectKindSolutionFolder)
					{
						list.AddRange(GetSolutionFolderProjects(project));
					}
					else
					{
						list.Add(project);
					}
				}
			}

			return list.ToArray();
		}

		private void OpenWelcomePage()
			=> _dte?.ItemOperations.Navigate("https://platform.uno/docs/articles/get-started-wizard.html", vsNavigateOptions.vsNavigateOptionsNewWindow);

		private void SetStartupProject()
		{
			try
			{
				if (_dte?.Solution.SolutionBuild is SolutionBuild2 val)
				{
						var uwpProject = GetAllProjects().FirstOrDefault(s => s.Name.EndsWith(".Windows", StringComparison.OrdinalIgnoreCase));

						if (uwpProject is { })
						{
							val.StartupProjects = uwpProject.UniqueName;
						}

						var x86Config = val.SolutionConfigurations
							.Cast<SolutionConfiguration2>()
							.FirstOrDefault(c => c.Name == "Debug" && c.PlatformName == "x86");

						x86Config?.Activate();
				}
				else
				{
					// Unable to set the startup project when running from RunFinished since VS 2022 17.2 Preview 2
					// throw new InvalidOperationException();
				}
			}
			catch (Exception)
			{
			}
		}

		private void SetUWPAnyCPUBuildableAndDeployable()
		{
			if (_dte?.Solution.SolutionBuild is SolutionBuild2 val)
			{
				try
				{
					var anyCpuConfig = val.SolutionConfigurations
						.Cast<SolutionConfiguration2>()
						.FirstOrDefault(c => c.Name == "Debug" && c.PlatformName == "Any CPU");

					foreach (SolutionConfiguration2 solutionConfiguration2 in val.SolutionConfigurations)
					{
						foreach (SolutionContext solutionContext in anyCpuConfig.SolutionContexts)
						{
							if (solutionContext.ProjectName.EndsWith(".Windows.csproj"))
							{
								solutionContext.ShouldBuild = true;
								solutionContext.ShouldDeploy = true;
							}
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}

		private void SetDefaultConfiguration()
		{
			try
			{
				if (_dte?.Solution.SolutionBuild is SolutionBuild2 val)
				{
						var x86Config = val.SolutionConfigurations
							.Cast<SolutionConfiguration2>()
							.FirstOrDefault(c => c.Name == "Debug" && c.PlatformName == "x86");

						x86Config?.Activate();
				}
				else
				{
					// Unable to set the startup project when running from RunFinished since VS 2022 17.2 Preview 2
					// throw new InvalidOperationException();
				}
			}
			catch (Exception)
			{
			}
		}

		private Project[] GetSolutionFolderProjects(Project solutionFolder)
		{
			var list = new List<Project>();
			for (var i = 1; i <= solutionFolder.ProjectItems.Count; i++)
			{
				var subProject = solutionFolder.ProjectItems.Item(i).SubProject;
				if (subProject == null)
				{
					continue;
				}

				// If this is another solution folder, do a recursive call, otherwise add
				if (subProject.Kind == ProjectKinds_vsProjectKindSolutionFolder)
				{
					list.AddRange(GetSolutionFolderProjects(subProject));
				}
				else
				{
					list.Add(subProject);
				}
			}

			return list.ToArray();
		}
	}


	internal class DialogParentWindow : IWin32Window, IDisposable
	{
		private readonly IntPtr handle;

		private bool enableModeless;

		private readonly IServiceProvider serviceProvider;

		public IntPtr Handle => handle;

		public DialogParentWindow(IntPtr handle, bool enableModeless, IServiceProvider serviceProvider)
		{
			this.serviceProvider = serviceProvider;
			object service = this.serviceProvider.GetService(typeof(IVsUIShell));
			IVsUIShell val = (IVsUIShell)((service is IVsUIShell) ? service : null);
			if (this.handle == IntPtr.Zero)
			{
				val.GetDialogOwnerHwnd(out this.handle);
			}
			else
			{
				this.handle = handle;
			}
			if (enableModeless)
			{
				val.EnableModeless(0);
				this.enableModeless = true;
			}
		}

		public void Dispose()
		{
			if (enableModeless)
			{
				enableModeless = false;
				try
				{
					object service = serviceProvider.GetService(typeof(IVsUIShell));
					IVsUIShell val = (IVsUIShell)((service is IVsUIShell) ? service : null);
					val.EnableModeless(1);
				}
				catch
				{
				}
			}
		}
	}

	public class WizardData
	{
		private const string USE_PACKAGE_REFERENCES = "UsePackageReferences";

		private const string MINIMUM_SUPPORTED_VERSION = "MinSupportedVersion";

		private const string SKIP_XAML_COMPILER_CHECK = "SkipXamlCompilerCheck";

		private const string USE_SDK_FALLBACK_FILE = "UseSdkFallbackFile";

		private const string DEFAULT_MIN_SUPPORTED_VERSION = "DefaultMinSupportedVersion";

		private const string USE_WINDOWS_SDK_BUILD_TOOLS_PACKAGE = "UseWindowsSdkBuildToolsPackage";

		public bool UsePackageReferences { get; set; }

		public string MinSupportedVersion { get; set; }

		public bool SkipXamlCompilerCheck { get; set; }

		public bool UseSdkFallbackFile { get; set; }

		public bool UseWindowsSdkBuildToolsPackage { get; set; }

		//public DefaultMinSupportedVersion DefaultMinSupportedVersion { get; set; }

		public WizardData(string xmlStringToParse)
		{
			if (string.IsNullOrWhiteSpace(xmlStringToParse))
			{
				return;
			}
			try
			{
				XDocument xDocument = XDocument.Parse(xmlStringToParse);
				foreach (XElement item in from p in xDocument.Descendants()
										  where !p.HasElements
										  select p)
				{
					switch (item.Name?.LocalName)
					{
						case "UsePackageReferences":
							{
								if (bool.TryParse(item.Value, out var result4))
								{
									UsePackageReferences = result4;
								}
								break;
							}
						case "MinSupportedVersion":
							MinSupportedVersion = item.Value;
							break;
						case "SkipXamlCompilerCheck":
							{
								if (bool.TryParse(item.Value, out var result2))
								{
									SkipXamlCompilerCheck = result2;
								}
								break;
							}
						case "UseSdkFallbackFile":
							{
								if (bool.TryParse(item.Value, out var result5))
								{
									UseSdkFallbackFile = result5;
								}
								break;
							}
						case "DefaultMinSupportedVersion":
							{
								//if (Enum.TryParse<DefaultMinSupportedVersion>(item.Value, out var result3))
								//{
								//	DefaultMinSupportedVersion = result3;
								//}
								break;
							}
						case "UseWindowsSdkBuildToolsPackage":
							{
								if (bool.TryParse(item.Value, out var result))
								{
									UseWindowsSdkBuildToolsPackage = result;
								}
								break;
							}
					}
				}
			}
			catch (Exception)
			{
			}
		}

		public bool HasMinimumProjectVersion()
		{
			return !string.IsNullOrWhiteSpace(MinSupportedVersion);
		}

		//internal bool VersionIsGreaterThanOrEqualToMinVersion(PlatformName p)
		//{
		//	return VersionIsGreaterThanOrEqualToMinVersion(p.Version);
		//}

		internal bool VersionIsGreaterThanOrEqualToMinVersion(Version versionToTest)
		{
			if (HasMinimumProjectVersion())
			{
				Version minProjectAsVersion = GetMinProjectAsVersion();
				if (!(minProjectAsVersion == null))
				{
					return minProjectAsVersion <= versionToTest;
				}
				return true;
			}
			return true;
		}

		private Version GetMinProjectAsVersion()
		{
			Version.TryParse(MinSupportedVersion, out var result);
			return result;
		}
	}

}
