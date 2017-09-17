using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EnrollCapture
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private void Application_Startup(object sender, StartupEventArgs e)
		{
			MainWindow wnd = new MainWindow();
			if (e.Args.Length == 1)
			{
				wnd.UnitId = int.Parse(e.Args[0]);
			}

			wnd.Show();
			wnd.InitialStart();
		}
	}
}
