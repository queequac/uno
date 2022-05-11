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
            this.checkGtk = new System.Windows.Forms.CheckBox();
            this.checkLinux = new System.Windows.Forms.CheckBox();
            this.checkWpf = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkWinUI = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkiOS = new System.Windows.Forms.CheckBox();
            this.checkAndroid = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkCatalyst = new System.Windows.Forms.CheckBox();
            this.checkAppKit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
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
            this.checkWebAssembly.Location = new System.Drawing.Point(22, 35);
            this.checkWebAssembly.Name = "checkWebAssembly";
            this.checkWebAssembly.Size = new System.Drawing.Size(100, 21);
            this.checkWebAssembly.TabIndex = 1;
            this.checkWebAssembly.Text = "WebAssembly";
            this.checkWebAssembly.UseVisualStyleBackColor = true;
            // 
            // checkGtk
            // 
            this.checkGtk.AutoSize = true;
            this.checkGtk.Checked = true;
            this.checkGtk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkGtk.Location = new System.Drawing.Point(3, 30);
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
            this.checkLinux.Location = new System.Drawing.Point(3, 138);
            this.checkLinux.Name = "checkLinux";
            this.checkLinux.Size = new System.Drawing.Size(117, 21);
            this.checkLinux.TabIndex = 1;
            this.checkLinux.Text = "Linux Framebuffer";
            this.checkLinux.UseVisualStyleBackColor = true;
            // 
            // checkWpf
            // 
            this.checkWpf.AutoSize = true;
            this.checkWpf.Location = new System.Drawing.Point(3, 111);
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
            this.buttonOK.Location = new System.Drawing.Point(218, 385);
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
            this.buttonCancel.Location = new System.Drawing.Point(295, 385);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(71, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkWinUI
            // 
            this.checkWinUI.AutoSize = true;
            this.checkWinUI.Checked = true;
            this.checkWinUI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkWinUI.Location = new System.Drawing.Point(3, 3);
            this.checkWinUI.Name = "checkWinUI";
            this.checkWinUI.Size = new System.Drawing.Size(177, 21);
            this.checkWinUI.TabIndex = 2;
            this.checkWinUI.Text = "Windows (Windows App SDK)";
            this.checkWinUI.UseVisualStyleBackColor = true;
            this.checkWinUI.CheckedChanged += new System.EventHandler(this.checkWinUI_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mobile";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.checkiOS);
            this.flowLayoutPanel3.Controls.Add(this.checkAndroid);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(7, 17);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(341, 61);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // checkiOS
            // 
            this.checkiOS.AutoSize = true;
            this.checkiOS.Checked = true;
            this.checkiOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkiOS.Location = new System.Drawing.Point(3, 3);
            this.checkiOS.Name = "checkiOS";
            this.checkiOS.Size = new System.Drawing.Size(50, 21);
            this.checkiOS.TabIndex = 0;
            this.checkiOS.Text = "iOS";
            this.checkiOS.UseVisualStyleBackColor = true;
            // 
            // checkAndroid
            // 
            this.checkAndroid.AutoSize = true;
            this.checkAndroid.Checked = true;
            this.checkAndroid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAndroid.Location = new System.Drawing.Point(3, 30);
            this.checkAndroid.Name = "checkAndroid";
            this.checkAndroid.Size = new System.Drawing.Size(69, 21);
            this.checkAndroid.TabIndex = 1;
            this.checkAndroid.Text = "Android";
            this.checkAndroid.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 186);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desktop";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.checkWinUI);
            this.flowLayoutPanel2.Controls.Add(this.checkGtk);
            this.flowLayoutPanel2.Controls.Add(this.checkCatalyst);
            this.flowLayoutPanel2.Controls.Add(this.checkAppKit);
            this.flowLayoutPanel2.Controls.Add(this.checkWpf);
            this.flowLayoutPanel2.Controls.Add(this.checkLinux);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(7, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(341, 166);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // checkCatalyst
            // 
            this.checkCatalyst.AutoSize = true;
            this.checkCatalyst.Location = new System.Drawing.Point(3, 57);
            this.checkCatalyst.Name = "checkCatalyst";
            this.checkCatalyst.Size = new System.Drawing.Size(114, 21);
            this.checkCatalyst.TabIndex = 3;
            this.checkCatalyst.Text = "macOS (Catalyst)";
            this.checkCatalyst.UseVisualStyleBackColor = true;
            // 
            // checkAppKit
            // 
            this.checkAppKit.AutoSize = true;
            this.checkAppKit.Location = new System.Drawing.Point(3, 84);
            this.checkAppKit.Name = "checkAppKit";
            this.checkAppKit.Size = new System.Drawing.Size(108, 21);
            this.checkAppKit.TabIndex = 2;
            this.checkAppKit.Text = "macOS (AppKit)";
            this.checkAppKit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "If you do not select a platform at this time, you can add it back later by visiti" +
    "ng our documentation.";
            // 
            // UnoOptions
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(378, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkWebAssembly);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.CheckBox checkWebAssembly;
		private System.Windows.Forms.CheckBox checkGtk;
		private System.Windows.Forms.CheckBox checkLinux;
		private System.Windows.Forms.CheckBox checkWpf;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckBox checkWinUI;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkiOS;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.CheckBox checkAndroid;
		private System.Windows.Forms.CheckBox checkCatalyst;
		private System.Windows.Forms.CheckBox checkAppKit;
		private System.Windows.Forms.Label label1;
	}
}
