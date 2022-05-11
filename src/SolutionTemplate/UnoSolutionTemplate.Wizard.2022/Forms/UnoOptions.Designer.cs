namespace UnoSolutionTemplate.Wizard.Forms
{
	partial class UnoOptions
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.labelDescription = new System.Windows.Forms.Label();
            this.checkWebAssembly = new System.Windows.Forms.CheckBox();
            this.checkMobile = new System.Windows.Forms.CheckBox();
            this.checkGtk = new System.Windows.Forms.CheckBox();
            this.checkLinux = new System.Windows.Forms.CheckBox();
            this.checkWpf = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkWinUI = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 9);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(235, 13);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Select the following options for your new project.";
            // 
            // checkWebAssembly
            // 
            this.checkWebAssembly.AutoSize = true;
            this.checkWebAssembly.Checked = true;
            this.checkWebAssembly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWebAssembly.Location = new System.Drawing.Point(3, 3);
            this.checkWebAssembly.Name = "checkWebAssembly";
            this.checkWebAssembly.Size = new System.Drawing.Size(100, 21);
            this.checkWebAssembly.TabIndex = 1;
            this.checkWebAssembly.Text = "WebAssembly";
            this.checkWebAssembly.UseVisualStyleBackColor = true;
            // 
            // checkMobile
            // 
            this.checkMobile.AutoSize = true;
            this.checkMobile.Checked = true;
            this.checkMobile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMobile.Location = new System.Drawing.Point(3, 30);
            this.checkMobile.Name = "checkMobile";
            this.checkMobile.Size = new System.Drawing.Size(258, 21);
            this.checkMobile.TabIndex = 1;
            this.checkMobile.Text = "Mobile (iOS, Android, macOS and Mac Catalyst)";
            this.checkMobile.UseVisualStyleBackColor = true;
            // 
            // checkGtk
            // 
            this.checkGtk.AutoSize = true;
            this.checkGtk.Checked = true;
            this.checkGtk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGtk.Location = new System.Drawing.Point(3, 84);
            this.checkGtk.Name = "checkGtk";
            this.checkGtk.Size = new System.Drawing.Size(219, 21);
            this.checkGtk.TabIndex = 1;
            this.checkGtk.Text = "Gtk (Linux, macOS, Windows 7 or later)";
            this.checkGtk.UseVisualStyleBackColor = true;
            this.checkGtk.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkLinux
            // 
            this.checkLinux.AutoSize = true;
            this.checkLinux.Location = new System.Drawing.Point(3, 111);
            this.checkLinux.Name = "checkLinux";
            this.checkLinux.Size = new System.Drawing.Size(117, 21);
            this.checkLinux.TabIndex = 1;
            this.checkLinux.Text = "Linux Framebuffer";
            this.checkLinux.UseVisualStyleBackColor = true;
            // 
            // checkWpf
            // 
            this.checkWpf.AutoSize = true;
            this.checkWpf.Location = new System.Drawing.Point(3, 138);
            this.checkWpf.Name = "checkWpf";
            this.checkWpf.Size = new System.Drawing.Size(154, 21);
            this.checkWpf.TabIndex = 1;
            this.checkWpf.Text = "WPF (Windows 7 or later)";
            this.checkWpf.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.Location = new System.Drawing.Point(218, 214);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(71, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "Create";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(295, 214);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.checkWebAssembly);
            this.flowLayoutPanel1.Controls.Add(this.checkMobile);
            this.flowLayoutPanel1.Controls.Add(this.checkWinUI);
            this.flowLayoutPanel1.Controls.Add(this.checkGtk);
            this.flowLayoutPanel1.Controls.Add(this.checkLinux);
            this.flowLayoutPanel1.Controls.Add(this.checkWpf);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 182);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // checkWinUI
            // 
            this.checkWinUI.AutoSize = true;
            this.checkWinUI.Checked = true;
            this.checkWinUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWinUI.Location = new System.Drawing.Point(3, 57);
            this.checkWinUI.Name = "checkWinUI";
            this.checkWinUI.Size = new System.Drawing.Size(177, 21);
            this.checkWinUI.TabIndex = 2;
            this.checkWinUI.Text = "Windows (Windows App SDK)";
            this.checkWinUI.UseVisualStyleBackColor = true;
            // 
            // UnoOptions
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(378, 249);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "UnoOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Uno Platform App";
            this.Load += new System.EventHandler(this.UnoOptions_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.CheckBox checkWebAssembly;
		private System.Windows.Forms.CheckBox checkMobile;
		private System.Windows.Forms.CheckBox checkGtk;
		private System.Windows.Forms.CheckBox checkLinux;
		private System.Windows.Forms.CheckBox checkWpf;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.CheckBox checkWinUI;
	}
}
