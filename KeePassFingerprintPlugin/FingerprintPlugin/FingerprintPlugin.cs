using KeePass.Plugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WinBioNET;
using WinBioNET.Enums;

namespace FingerprintPlugin
{
	public sealed class FingerprintPluginExt : Plugin
	{
		private IPluginHost m_host = null;
		private FingerprintKeyProvider keyProv = new FingerprintKeyProvider();
		private ToolStripMenuItem optionsMenu;

		public override bool Initialize(IPluginHost host)
		{
			m_host = host;

			// Add menu items
			this.optionsMenu = new ToolStripMenuItem(Properties.Resources.EnableDisableFingerprint);
			this.optionsMenu.Click += OnOptions_Click;
			//this.optionsMenu.Image = Properties.Resources.liblogicalaccess_logo_x32;
			this.m_host.MainWindow.ToolsMenu.DropDownItems.Add(this.optionsMenu);

			// Register key provider
			this.m_host.KeyProviderPool.Add(keyProv);

			return true;
		}

		public override void Terminate()
		{
			// Remove menu items
			this.optionsMenu.Click -= OnOptions_Click;
			this.m_host.MainWindow.ToolsMenu.DropDownItems.Remove(this.optionsMenu);

			// Unregister key provider
			this.m_host.KeyProviderPool.Remove(keyProv);
		}

		private void OnOptions_Click(object sender, EventArgs e)
		{
			if (!this.m_host.Database.IsOpen)
			{
				MessageBox.Show(Properties.Resources.DbNotOpen, Properties.Resources.PluginError, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			var optionsForm = new OptionsForm();
			optionsForm.DatabaseName = Path.GetFileNameWithoutExtension(this.m_host.Database.IOConnectionInfo.Path);

			if (optionsForm.ShowDialog() == DialogResult.OK)
			{
				//var pwd = pwdForm.Password;
				//KeePassRFIDConfig config = options.GetConfiguration();
				//KeePassRFIDConfig.SaveToCurrentSession(config);
			}
		}
	}
}
