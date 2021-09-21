using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using DevAssistant.Logic.Services;

namespace DevAssistant.Test
{
	public class ServicesStartupModeHelper
	{
		public static void Disable(string serviceName)
		{
			bool isStartupMode = false;
			ServiceController sc = new ServiceController(serviceName);
			ServiceHelper.ChangeStartMode(sc, ServiceStartMode.Disabled);
			sc.Refresh();
			isStartupMode = sc.StartType == ServiceStartMode.Disabled;
			sc.Close();
		}
	}
}
