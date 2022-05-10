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
            this.label1 = new System.Windows.Forms.Label();
            this.checkWebAssembly = new System.Windows.Forms.CheckBox();
            this.checkMobile = new System.Windows.Forms.CheckBox();
            this.checkGtk = new System.Windows.Forms.CheckBox();
            this.checkLinux = new System.Windows.Forms.CheckBox();
            this.checkWpf = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the following options for your new project.";
            // 
            // checkWebAssembly
            // 
            this.checkWebAssembly.AutoSize = true;
            this.checkWebAssembly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkWebAssembly.Location = new System.Drawing.Point(17, 59);
            this.checkWebAssembly.Name = "checkWebAssembly";
            this.checkWebAssembly.Size = new System.Drawing.Size(136, 24);
            this.checkWebAssembly.TabIndex = 1;
            this.checkWebAssembly.Text = "WebAssembly";
            this.checkWebAssembly.UseVisualStyleBackColor = true;
            // 
            // checkMobile
            // 
            this.checkMobile.AutoSize = true;
            this.checkMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMobile.Location = new System.Drawing.Point(17, 83);
            this.checkMobile.Name = "checkMobile";
            this.checkMobile.Size = new System.Drawing.Size(366, 24);
            this.checkMobile.TabIndex = 1;
            this.checkMobile.Text = "Mobile (iOS, Android, macOS and Mac Catalyst";
            this.checkMobile.UseVisualStyleBackColor = true;
            // 
            // checkGtk
            // 
            this.checkGtk.AutoSize = true;
            this.checkGtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGtk.Location = new System.Drawing.Point(17, 108);
            this.checkGtk.Name = "checkGtk";
            this.checkGtk.Size = new System.Drawing.Size(311, 24);
            this.checkGtk.TabIndex = 1;
            this.checkGtk.Text = "Gtk (Linux, macOS, Windows 7 or later)";
            this.checkGtk.UseVisualStyleBackColor = true;
            this.checkGtk.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkLinux
            // 
            this.checkLinux.AutoSize = true;
            this.checkLinux.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLinux.Location = new System.Drawing.Point(17, 134);
            this.checkLinux.Name = "checkLinux";
            this.checkLinux.Size = new System.Drawing.Size(164, 24);
            this.checkLinux.TabIndex = 1;
            this.checkLinux.Text = "Linux Framebuffer";
            this.checkLinux.UseVisualStyleBackColor = true;
            // 
            // checkWpf
            // 
            this.checkWpf.AutoSize = true;
            this.checkWpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkWpf.Location = new System.Drawing.Point(17, 159);
            this.checkWpf.Name = "checkWpf";
            this.checkWpf.Size = new System.Drawing.Size(214, 24);
            this.checkWpf.TabIndex = 1;
            this.checkWpf.Text = "WPF (Windows 7 or later)";
            this.checkWpf.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(393, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(470, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UnoOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(569, 233);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkWpf);
            this.Controls.Add(this.checkLinux);
            this.Controls.Add(this.checkGtk);
            this.Controls.Add(this.checkMobile);
            this.Controls.Add(this.checkWebAssembly);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(531, 200);
            this.Name = "UnoOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New Uno Platform App";
            this.Load += new System.EventHandler(this.UnoOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkWebAssembly;
		private System.Windows.Forms.CheckBox checkMobile;
		private System.Windows.Forms.CheckBox checkGtk;
		private System.Windows.Forms.CheckBox checkLinux;
		private System.Windows.Forms.CheckBox checkWpf;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}
