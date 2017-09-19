namespace FingerprintPlugin
{
	partial class CheckFinger
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
			this.lblProgress = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.btnOk = new System.Windows.Forms.Button();
			this.fingerprintImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.fingerprintImage)).BeginInit();
			this.SuspendLayout();
			//
			// lblProgress
			//
			this.lblProgress.AutoSize = true;
			this.lblProgress.Location = new System.Drawing.Point(12, 276);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(58, 13);
			this.lblProgress.TabIndex = 0;
			this.lblProgress.Text = "lblProgress";
			//
			// progressBar
			//
			this.progressBar.Location = new System.Drawing.Point(12, 240);
			this.progressBar.Maximum = 9;
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(260, 23);
			this.progressBar.Step = 1;
			this.progressBar.TabIndex = 1;
			//
			// btnOk
			//
			this.btnOk.Enabled = false;
			this.btnOk.Location = new System.Drawing.Point(12, 302);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(257, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			//
			// fingerprintImage
			//
			this.fingerprintImage.Image = global::FingerprintPlugin.Properties.Resources.fingerprint;
			this.fingerprintImage.Location = new System.Drawing.Point(62, 12);
			this.fingerprintImage.Name = "fingerprintImage";
			this.fingerprintImage.Size = new System.Drawing.Size(160, 206);
			this.fingerprintImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.fingerprintImage.TabIndex = 3;
			this.fingerprintImage.TabStop = false;
			//
			// CheckFinger
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 339);
			this.Controls.Add(this.fingerprintImage);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblProgress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MinimizeBox = false;
			this.Name = "CheckFinger";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CheckFinger";
			((System.ComponentModel.ISupportInitialize)(this.fingerprintImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblProgress;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.PictureBox fingerprintImage;
	}
}