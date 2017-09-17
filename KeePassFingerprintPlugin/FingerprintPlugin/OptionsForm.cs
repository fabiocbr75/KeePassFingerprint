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

namespace FingerprintPlugin
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.Focus();
			this.BringToFront();
		}

        private void OptionsForm_Load(object sender, EventArgs e)
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
				return;

			foreach (var reader in units)
			{
				cbReaderUnit.Items.Add(string.Format("{0} - {1}", reader.UnitId, reader.Description));
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
				errorProvider.SetError(tbxPassword, FingerprintPlugin.Properties.Resources.EmptyPasswordError);
			else
			{
				errorProvider.SetError(tbxPassword, String.Empty);

				if (tbxPassword.Text != tbxVerif.Text)
					errorProvider.SetError(tbxVerif, FingerprintPlugin.Properties.Resources.PasswordMismatchError);
				else
				{
					errorProvider.SetError(tbxVerif, String.Empty);

					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}

			this.DialogResult = DialogResult.OK;
            this.Close();
        }

	}
}
