using KeePass.Plugins;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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

		private void OnOptions_Click(object sender, EventArgs e)
		{
			var pwdForm = new PasswordForm();

			if (pwdForm.ShowDialog() == DialogResult.OK)
			{
				var pwd = pwdForm.Password;
				//KeePassRFIDConfig config = options.GetConfiguration();
				//KeePassRFIDConfig.SaveToCurrentSession(config);
			}
		}
	}
}
