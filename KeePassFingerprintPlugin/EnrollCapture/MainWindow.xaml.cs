using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WinBioNET;
using WinBioNET.Enums;

namespace EnrollCapture
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static readonly Guid DatabaseId = new Guid("17DE1D0D-BD7F-4868-AEC6-D385DFE43561");
		public int UnitId { get; set; }
		public MainWindow()
		{
			InitializeComponent();
		}

		public void InitialStart()
		{
			if (WinBioConfiguration.DatabaseExists(DatabaseId))
				return;

			Messages.Items.Add(string.Format("Creating database: {0}", DatabaseId));
			WinBioConfiguration.AddDatabase(DatabaseId, UnitId);
			Messages.Items.Add(string.Format("Adding sensor to the pool: {0}", UnitId));
			WinBioConfiguration.AddUnit(DatabaseId, UnitId);

			// Restart Windows Biometric Service to apply changes
			Messages.Items.Add("Restart Service WbioSrvc");
			RestartService("WbioSrvc", 5000, ServiceMode.Restart);
		}

		public enum ServiceMode
		{
			Restart,
			Stop,
			Start
		}

		private void RestartService(string serviceName, int timeoutMilliseconds, ServiceMode serviceMode)
		{
			ServiceController service = new ServiceController(serviceName);
			try
			{
				int millisec1 = Environment.TickCount;
				TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

				if (serviceMode == ServiceMode.Start)
					goto start;

				service.Stop();
				service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

				if (serviceMode == ServiceMode.Stop)
					return;

				service.Start();

				start:
				// count the rest of the timeout
				int millisec2 = Environment.TickCount;
				timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

				service.WaitForStatus(ServiceControllerStatus.Running, timeout);
			}
			catch
			{
				
			}
		}

	}
}
