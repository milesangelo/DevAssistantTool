using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DevAssistant.Logic.Services
{
	public class IISAdminService : IService
	{
		private const string _serviceName = "IISAdmin";
		
		public string ServiceName => _serviceName;


		public bool Start() 
		{
			try
			{
				if (!SetStartupMode(ServiceStartMode.Manual))
				{
					return false;
				}
				ServiceController sc = new ServiceController(_serviceName);
				sc.Start();
				return true;
			}
			catch (Exception ex)
			{
				throw ex.InnerException;			
			}
		}

		public bool Stop()
		{
			try
			{
				ServiceController sc = new ServiceController(_serviceName);
				sc.Stop();
				return true;
			}
			catch (Exception ex)
			{
				throw ex.InnerException;
			}
		}

		private bool SetStartupMode(ServiceStartMode startMode)
		{
			bool isStartupMode = false;
			ServiceController sc = new ServiceController(_serviceName);
			
			try
			{	
				ServiceHelper.ChangeStartMode(sc, startMode);
				sc.Refresh();
				isStartupMode = sc.StartType == startMode;
				sc.Close();
				return isStartupMode;
			}
			catch (Exception ex) 
			{
				sc.Close();	
				throw ex;
			}
		}

		//private void Set()
		//public bool Restart()
		//{
		//	try 
		//	{
		//		

		//		Console.WriteLine(sc.StartType);

		//		if (sc.StartType != ServiceStartMode.Manual)
		//		{
		//			ServiceHelper.ChangeStartMode(sc, ServiceStartMode.Manual);
		//		}

		//		if (sc.Status != ServiceControllerStatus.StartPending &&
		//			sc.Status != ServiceControllerStatus.Running)
		//		{
		//			sc.Start();
		//		}

		//		sc.Close();
		//		return true;
		//	} 
		//	catch (Exception ex) 
		//	{
		//		return false;
		//	}
			
		//	return true;
		//}

		//public void Setup()
		//{
		//	throw new NotImplementedException();
		//}

		//public void Start()
		//{
		//	throw new NotImplementedException();
		//}

		
	}
}
