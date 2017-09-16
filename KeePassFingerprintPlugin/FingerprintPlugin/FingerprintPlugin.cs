using KeePass.Plugins;
using System;
using System.Collections.Generic;
using System.Text;

namespace FingerprintPlugin
{
	public sealed class FingerprintPlugin : Plugin
	{
		private IPluginHost m_host = null;

		public override bool Initialize(IPluginHost host)
		{
			m_host = host;
			return true;
		}
	}
}
