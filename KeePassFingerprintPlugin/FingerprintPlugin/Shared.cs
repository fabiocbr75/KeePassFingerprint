using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace FingerprintPlugin
{
	public static class Shared
	{
		public static readonly Guid DatabaseId = new Guid("17DE1D0D-BD7F-4868-AEC6-D385DFE43561");
		public static string Protect(
			this string clearText,
			string optionalEntropy = null,
			DataProtectionScope scope = DataProtectionScope.CurrentUser)
		{
			if (clearText == null)
			{
				throw new ArgumentNullException("clearText");
			}
			byte[] clearBytes = Encoding.UTF8.GetBytes(clearText);
			byte[] entropyBytes = string.IsNullOrEmpty(optionalEntropy)
								  ? null
								  : Encoding.UTF8.GetBytes(optionalEntropy);
			byte[] encryptedBytes = ProtectedData.Protect(clearBytes, entropyBytes, scope);
			return Convert.ToBase64String(encryptedBytes);
		}

		public static string Unprotect(
			this string encryptedText,
			string optionalEntropy = null,
			DataProtectionScope scope = DataProtectionScope.CurrentUser)
		{
			if (encryptedText == null)
			{
				throw new ArgumentNullException("encryptedText");
			}
			byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
			byte[] entropyBytes = string.IsNullOrEmpty(optionalEntropy)
								  ? null
								  : Encoding.UTF8.GetBytes(optionalEntropy);
			byte[] clearBytes = ProtectedData.Unprotect(encryptedBytes, entropyBytes, scope);
			return Encoding.UTF8.GetString(clearBytes);
		}
	}
}
