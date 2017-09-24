namespace FingerprintPlugin
{
	partial class OptionsForm
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
			this.components = new System.ComponentModel.Container();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.panelLeft = new System.Windows.Forms.Panel();
			this.imgLogo = new System.Windows.Forms.PictureBox();
			this.lblProductName = new System.Windows.Forms.Label();
			this.gpReaderConfig = new System.Windows.Forms.GroupBox();
			this.btnInitialize = new System.Windows.Forms.Button();
			this.cbReaderUnit = new System.Windows.Forms.ComboBox();
			this.lblReaderUnit = new System.Windows.Forms.Label();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.gpMasterKey = new System.Windows.Forms.GroupBox();
			this.lblVerif = new System.Windows.Forms.Label();
			this.tbxVerif = new System.Windows.Forms.TextBox();
			this.tbxPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.panelBottom.SuspendLayout();
			this.panelLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
			this.gpReaderConfig.SuspendLayout();
			this.gpMasterKey.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// panelBottom
			// 
			this.panelBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelBottom.Controls.Add(this.btnCancel);
			this.panelBottom.Controls.Add(this.btnSave);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(212, 469);
			this.panelBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(480, 45);
			this.panelBottom.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(243, 3);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(112, 35);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnSave.Location = new System.Drawing.Point(121, 3);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(112, 35);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// panelLeft
			// 
			this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelLeft.Controls.Add(this.imgLogo);
			this.panelLeft.Controls.Add(this.lblProductName);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLeft.Location = new System.Drawing.Point(0, 0);
			this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(212, 514);
			this.panelLeft.TabIndex = 1;
			// 
			// imgLogo
			// 
			this.imgLogo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.imgLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.imgLogo.Location = new System.Drawing.Point(0, 372);
			this.imgLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.Size = new System.Drawing.Size(210, 140);
			this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgLogo.TabIndex = 2;
			this.imgLogo.TabStop = false;
			this.toolTip.SetToolTip(this.imgLogo, "Open www.islog.com");
			// 
			// lblProductName
			// 
			this.lblProductName.AutoSize = true;
			this.lblProductName.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductName.ForeColor = System.Drawing.Color.White;
			this.lblProductName.Location = new System.Drawing.Point(0, 0);
			this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(147, 30);
			this.lblProductName.TabIndex = 2;
			this.lblProductName.Text = "Fingerprint";
			// 
			// gpReaderConfig
			// 
			this.gpReaderConfig.Controls.Add(this.btnInitialize);
			this.gpReaderConfig.Controls.Add(this.cbReaderUnit);
			this.gpReaderConfig.Controls.Add(this.lblReaderUnit);
			this.gpReaderConfig.Dock = System.Windows.Forms.DockStyle.Top;
			this.gpReaderConfig.Location = new System.Drawing.Point(212, 0);
			this.gpReaderConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gpReaderConfig.Name = "gpReaderConfig";
			this.gpReaderConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gpReaderConfig.Size = new System.Drawing.Size(480, 182);
			this.gpReaderConfig.TabIndex = 3;
			this.gpReaderConfig.TabStop = false;
			this.gpReaderConfig.Text = "Reader Configuration";
			// 
			// btnInitialize
			// 
			this.btnInitialize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnInitialize.Image = global::FingerprintPlugin.Properties.Resources.RunAsAdmin1;
			this.btnInitialize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInitialize.Location = new System.Drawing.Point(149, 100);
			this.btnInitialize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnInitialize.Name = "btnInitialize";
			this.btnInitialize.Size = new System.Drawing.Size(231, 72);
			this.btnInitialize.TabIndex = 4;
			this.btnInitialize.Text = "Initialize Unit";
			this.btnInitialize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInitialize.UseVisualStyleBackColor = true;
			this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
			// 
			// cbReaderUnit
			// 
			this.cbReaderUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbReaderUnit.DropDownWidth = 220;
			this.cbReaderUnit.FormattingEnabled = true;
			this.cbReaderUnit.Location = new System.Drawing.Point(148, 49);
			this.cbReaderUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbReaderUnit.Name = "cbReaderUnit";
			this.cbReaderUnit.Size = new System.Drawing.Size(229, 28);
			this.cbReaderUnit.TabIndex = 3;
			// 
			// lblReaderUnit
			// 
			this.lblReaderUnit.AutoSize = true;
			this.lblReaderUnit.Location = new System.Drawing.Point(39, 54);
			this.lblReaderUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblReaderUnit.Name = "lblReaderUnit";
			this.lblReaderUnit.Size = new System.Drawing.Size(99, 20);
			this.lblReaderUnit.TabIndex = 2;
			this.lblReaderUnit.Text = "Reader Unit:";
			// 
			// gpMasterKey
			// 
			this.gpMasterKey.Controls.Add(this.lblVerif);
			this.gpMasterKey.Controls.Add(this.tbxVerif);
			this.gpMasterKey.Controls.Add(this.tbxPassword);
			this.gpMasterKey.Controls.Add(this.lblPassword);
			this.gpMasterKey.Dock = System.Windows.Forms.DockStyle.Top;
			this.gpMasterKey.Location = new System.Drawing.Point(212, 182);
			this.gpMasterKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gpMasterKey.Name = "gpMasterKey";
			this.gpMasterKey.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.gpMasterKey.Size = new System.Drawing.Size(480, 268);
			this.gpMasterKey.TabIndex = 4;
			this.gpMasterKey.TabStop = false;
			this.gpMasterKey.Text = "Master Key";
			// 
			// lblVerif
			// 
			this.lblVerif.AutoSize = true;
			this.lblVerif.Location = new System.Drawing.Point(46, 105);
			this.lblVerif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblVerif.Name = "lblVerif";
			this.lblVerif.Size = new System.Drawing.Size(92, 20);
			this.lblVerif.TabIndex = 9;
			this.lblVerif.Text = "Verification:";
			// 
			// tbxVerif
			// 
			this.tbxVerif.Location = new System.Drawing.Point(148, 100);
			this.tbxVerif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbxVerif.Name = "tbxVerif";
			this.tbxVerif.PasswordChar = '*';
			this.tbxVerif.Size = new System.Drawing.Size(229, 26);
			this.tbxVerif.TabIndex = 7;
			// 
			// tbxPassword
			// 
			this.tbxPassword.Location = new System.Drawing.Point(148, 60);
			this.tbxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbxPassword.Name = "tbxPassword";
			this.tbxPassword.PasswordChar = '*';
			this.tbxPassword.Size = new System.Drawing.Size(229, 26);
			this.tbxPassword.TabIndex = 6;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(56, 65);
			this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(82, 20);
			this.lblPassword.TabIndex = 8;
			this.lblPassword.Text = "Password:";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// OptionsForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(692, 514);
			this.Controls.Add(this.gpMasterKey);
			this.Controls.Add(this.gpReaderConfig);
			this.Controls.Add(this.panelBottom);
			this.Controls.Add(this.panelLeft);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "OptionsForm";
			this.ShowIcon = false;
			this.Text = "KeePass RFID Options";
			this.Load += new System.EventHandler(this.OptionsForm_Load);
			this.panelBottom.ResumeLayout(false);
			this.panelLeft.ResumeLayout(false);
			this.panelLeft.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
			this.gpReaderConfig.ResumeLayout(false);
			this.gpReaderConfig.PerformLayout();
			this.gpMasterKey.ResumeLayout(false);
			this.gpMasterKey.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Panel panelLeft;
		private System.Windows.Forms.PictureBox imgLogo;
		private System.Windows.Forms.Label lblProductName;
		private System.Windows.Forms.GroupBox gpReaderConfig;
		private System.Windows.Forms.ComboBox cbReaderUnit;
		private System.Windows.Forms.Label lblReaderUnit;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.GroupBox gpMasterKey;
		private System.Windows.Forms.Label lblVerif;
		private System.Windows.Forms.TextBox tbxVerif;
		private System.Windows.Forms.TextBox tbxPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.Button btnInitialize;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}