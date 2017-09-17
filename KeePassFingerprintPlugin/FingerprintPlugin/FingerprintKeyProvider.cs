using KeePassLib.Keys;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FingerprintPlugin
{
	public sealed class FingerprintKeyProvider : KeyProvider
	{
		public override string Name
		{
			get { return "Fingerprint Key Provider"; }
		}

		public override bool GetKeyMightShowGui => true;

		public override byte[] GetKey(KeyProviderQueryContext ctx)
		{
			MessageBox.Show(Properties.Resources.FingerprintConfigurationError, Properties.Resources.PluginError, MessageBoxButtons.OK, MessageBoxIcon.Error);

			CheckFinger checkFinger = new CheckFinger();
			checkFinger.ShowDialog();
			
			return Encoding.ASCII.GetBytes(@"password");
		}
	}
}