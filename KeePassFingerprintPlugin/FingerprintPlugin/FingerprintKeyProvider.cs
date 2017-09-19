using KeePassLib.Keys;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FingerprintPlugin
{
	public sealed class FingerprintKeyProvider : KeyProvider
	{
		public override string Name
		{
			get
			{
				return "Fingerprint Key Provider";
			}
		}

		public override bool GetKeyMightShowGui => true;

		public override byte[] GetKey(KeyProviderQueryContext ctx)
		{

			//MessageBox.Show(Properties.Resources.FingerprintConfigurationError, Properties.Resources.PluginError, MessageBoxButtons.OK, MessageBoxIcon.Error);
			string pwd = string.Empty;

			string dbName = Path.GetFileNameWithoutExtension(ctx.DatabasePath);
			DbMasterKeyManager db = new DbMasterKeyManager();

			CheckFinger checkFinger = new CheckFinger();
			checkFinger.UnitId = db.GetUnitId(dbName);

			if (checkFinger.ShowDialog() == DialogResult.OK)
			{
				pwd = db.GetMasterKey(dbName, checkFinger.TemplateFingerGuid);
			}

			return Encoding.ASCII.GetBytes(pwd);
		}
	}
}