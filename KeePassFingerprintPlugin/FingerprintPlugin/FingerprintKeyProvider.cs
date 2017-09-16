using KeePassLib.Keys;
using System;
using System.Collections.Generic;
using System.Text;

namespace FingerprintPlugin
{
	public sealed class FingerprintKeyProvider : KeyProvider
	{
		public override string Name
		{
			get { return "Fingerprint Key Provider"; }
		}


		public override byte[] GetKey(KeyProviderQueryContext ctx)
		{
			throw new NotImplementedException();
		}
	}
}