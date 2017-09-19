using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FingerprintPlugin
{
	public class DbMasterKeyManager
	{
		List<DbMasterKey> _db = new List<DbMasterKey>();
		string _dbPath = Application.UserAppDataPath + "\\DbMasterKey.dat";

		public DbMasterKeyManager()
		{
			string dbTextFile;
			try
			{
				if (File.Exists(_dbPath))
				{
					dbTextFile = File.ReadAllText(_dbPath);
					_db = JsonConvert.DeserializeObject<List<DbMasterKey>>(dbTextFile);
				}

			}
			catch (IOException e)
			{
				// Inform the user that an error occurred.
				MessageBox.Show("An error occurred while attempting to OpenOrCreate a DbMasterKey.dat" + "The error is:" + e.ToString());
			}

		}
		public void AddOrUpdate(string databaseName, string masterKey, Guid templateGuid, int unitId)
		{
			var protectedPassword = masterKey.Protect(templateGuid.ToString());

			var idx = _db.FindIndex(x => x.DatabaseName == databaseName);
			if (idx >= 0)
			{
				_db.RemoveAt(idx);
			}

			_db.Add(new DbMasterKey()
			{
				DatabaseName = databaseName, MasterKey = protectedPassword, UnitId = unitId
			});
		}

		public string GetMasterKey(string databaseName, Guid templateGuid)
		{
			var pwd = _db.Where(x => x.DatabaseName == databaseName).FirstOrDefault();

			return (pwd == null ? "" : pwd.MasterKey.Unprotect(templateGuid.ToString()));
		}

		public int GetUnitId(string databaseName)
		{
			var pwd = _db.Where(x => x.DatabaseName == databaseName).FirstOrDefault();

			return (pwd == null ? -1 : pwd.UnitId);
		}


		public void Save()
		{
			try
			{
				File.WriteAllText(_dbPath, JsonConvert.SerializeObject(_db));
			}
			catch (IOException e)
			{
				// Inform the user that an error occurred.
				MessageBox.Show("An error occurred while attempting to Save a DbMasterKey.dat" + "The error is:" + e.ToString());
			}

		}
	}
}
