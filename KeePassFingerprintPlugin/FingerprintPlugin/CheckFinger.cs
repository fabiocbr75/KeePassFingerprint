using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WinBioNET;
using WinBioNET.Enums;

namespace FingerprintPlugin
{
	public partial class CheckFinger : Form
	{
		private WinBioSessionHandle _session;
		private int _unitId;
		public CheckFinger()
		{
			InitializeComponent();
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.Focus();
			this.BringToFront();
		}

		public int UnitId
		{
			get
			{
				return _unitId;
			}
			set
			{
				_unitId = value;
			}
		}

		public bool StartEnrollment
		{
			get;
			set;
		}

		public Guid TemplateFingerGuid
		{
			get;
			set;
		}
		private void OpenBiometricSession()
		{
			_session = WinBio.OpenSession(WinBioBiometricType.Fingerprint, WinBioPoolType.Private, WinBioSessionFlag.Basic, new[] { _unitId }, Shared.DatabaseId);
			WriteLog("Session opened: " + _session.Value);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);

			if (StartEnrollment)
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					try
					{
						OpenBiometricSession();
						var identity = AddEnrollment(_session, _unitId, WinBioBiometricSubType.RhIndexFinger);
						TemplateFingerGuid = identity.TemplateGuid;
					}
					catch (WinBioException ex)
					{
						WriteLog(ex.Message);
					}
				});
			}
			else
			{
				ThreadPool.QueueUserWorkItem(delegate
				{
					OpenBiometricSession();
					for (int i = 0; i < 5; i++)
					{
						try
						{
							WinBioIdentity identity;
							WinBioBiometricSubType subFactor;
							WinBioRejectDetail rejectDetail;
							WinBio.Identify(_session, out identity, out subFactor, out rejectDetail);

							TemplateFingerGuid = identity.TemplateGuid;
							this.Invoke(new Action(CloseWindow));
							return;
						}
						catch (WinBioException ex)
						{
							WriteLog("Please retry!! Error:" + ex.Message);
						}
					}
				});

			}
		}

		private void CloseWindow()
		{
			if (_session.IsValid)
			{
				WinBio.CloseSession(_session);
				_session.Invalidate();
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private WinBioIdentity AddEnrollment(WinBioSessionHandle session, int unitId, WinBioBiometricSubType subType)
		{
			WriteLog(string.Format("Beginning enrollment of {0}:", subType));
			WinBio.EnrollBegin(session, subType, unitId);
			var code = WinBioErrorCode.MoreData;
			WinBioRejectDetail rejectDetail;

			int good = 0;
			for (var swipes = 1; code != WinBioErrorCode.Ok; swipes++)
			{
				code = WinBio.EnrollCapture(session, out rejectDetail);
				switch (code)
				{
					case WinBioErrorCode.MoreData:
						WriteLog(string.Format("Swipe {0} was good", swipes));
						good++;
						break;
					case WinBioErrorCode.BadCapture:
						WriteLog(string.Format("Swipe {0} was bad: {1}", swipes, rejectDetail));
						break;
					case WinBioErrorCode.Ok:
						WriteLog(string.Format("Enrollment complete with {0} swipes", swipes));
						break;
					default:
						throw new WinBioException(code, "WinBioEnrollCapture failed");
				}
				Progress(good);
			}
			WriteLog("Committing enrollment..");
			bool isNewTemplate;
			WinBioIdentity identity = null;
			try
			{
				isNewTemplate = WinBio.EnrollCommit(session, out identity);
				WriteLog(isNewTemplate ? "New template committed." : "Template already existing.");
				if (!isNewTemplate)
				{
					WinBio.Identify(session, out identity, out subType, out rejectDetail);
				}

				EnableDisableOk(true);

			}
			catch (Exception e)
			{
				WriteLog("Error on AddEnrollment. Error:" + e.Message);
			}

			return identity;
		}

		private void EnableDisableOk(bool enable)
		{
			if (btnOk.InvokeRequired)
			{
				btnOk.Invoke(new Action<bool>(EnableDisableOk), enable);
				return;
			}
			btnOk.Enabled = true;
		}

		private void Progress(int number)
		{
			if (progressBar.InvokeRequired)
			{
				progressBar.Invoke(new Action<int>(Progress), number);
				return;
			}

			if (number <= progressBar.Maximum)
			{
				progressBar.Value = number;
			}
			
		}
		private void WriteLog(string text)
		{
			if (lblProgress.InvokeRequired)
			{
				lblProgress.Invoke(new Action<string>(WriteLog), text);
				return;
			}
			//MessageBox.Show(text);
			lblProgress.Text = text;

		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			CloseWindow();
		}
	}
}
