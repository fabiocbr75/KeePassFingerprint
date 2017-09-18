using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WinBioNET;
using WinBioNET.Enums;
using System.Security.Cryptography;

namespace FingerprintPlugin
{
	public partial class OptionsForm : Form
	{
		private class FingerprintUnit
		{
			public FingerprintUnit(int id, string description)
			{
				Id = id;
				Description = description;
			}
			public int Id
			{
				get;
				set;
			}
			public string Description
			{
				get;
				set;
			}

			public override string ToString()
			{
				return string.Format("{0} - {1}", Id, Description);
			}
		}
		public OptionsForm()
		{
			InitializeComponent();
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.Focus();
			this.BringToFront();
		}

		public string DatabaseName
		{
			get;
			set;
		}

		private void OptionsForm_Load(object sender, EventArgs e)
		{
			Initialize();
		}

		private void Initialize()
		{
			try
			{
				RefreshReaderUnits();

				if (!WinBioConfiguration.DatabaseExists(Shared.DatabaseId))
				{
					gpMasterKey.Enabled = false;
					btnInitialize.Enabled = true;
				}
				else
				{
					gpMasterKey.Enabled = true;
					btnInitialize.Enabled = false;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(Properties.Resources.FingerprintInitError, Properties.Resources.PluginError, MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}

		}

		private void RefreshReaderUnits()
		{
			cbReaderUnit.Items.Clear();

			var units = WinBio.EnumBiometricUnits(WinBioBiometricType.Fingerprint);

			// Check if we have a connected fingerprint sensor
			if (units.Length == 0)
			{
				return;
			}

			foreach (var reader in units)
			{
				cbReaderUnit.Items.Add(new FingerprintUnit(reader.UnitId, reader.Description));
			}

			cbReaderUnit.SelectedIndex = 0;

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!WinBioConfiguration.DatabaseExists(Shared.DatabaseId))
			{
				MessageBox.Show(Properties.Resources.InitializeDatabase, Properties.Resources.PluginError, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			errorProvider.Clear();

			if (String.IsNullOrEmpty(tbxPassword.Text))
			{
				errorProvider.SetError(tbxPassword, FingerprintPlugin.Properties.Resources.EmptyPasswordError);
				return;
			}
			else
			{
				errorProvider.SetError(tbxPassword, String.Empty);

				if (tbxPassword.Text != tbxVerif.Text)
				{
					errorProvider.SetError(tbxVerif, FingerprintPlugin.Properties.Resources.PasswordMismatchError);
					return;
				}
				else
				{
					errorProvider.SetError(tbxVerif, String.Empty);
				}
			}

			DbMasterKeyManager dbManager = new DbMasterKeyManager();
			var protectedPassword = tbxPassword.Text.Protect("fingerprint");
			dbManager.Save(DatabaseName, protectedPassword);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnInitialize_Click(object sender, EventArgs e)
		{
			var selectedInit = (FingerprintUnit) cbReaderUnit.SelectedItem;

			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + @"\Plugins\EnrollCapture.exe";
			startInfo.Arguments = selectedInit.Id.ToString();
			var process = Process.Start(startInfo);
			process.WaitForExit();
			Initialize();
		}
	}
}
