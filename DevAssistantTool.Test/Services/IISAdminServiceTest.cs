using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevAssistant.Logic.Services;
using DevAssistant.Logic;
namespace DevAssistant.Test.Services
{
	[TestClass]
	public class IISAdminServiceTest
	{
		[TestMethod]
		public void Start_whenServiceIsDisabled_ifSuccessful_returnsTrue() 
		{
			IISAdminService sut = new IISAdminService();

			ServicesStartupModeHelper.Disable(sut.ServiceName);

			bool result = sut.Start();

			Assert.IsTrue(result, "Could not start IISAdmin service when disabled.");
		} 

		[TestMethod]
		public void Stop_whenServiceIsDisabled_ifSuccessful_returnsTrue() 
		{
			IISAdminService sut = new IISAdminService();

			ServicesStartupModeHelper.Disable(sut.ServiceName);

			bool result = sut.Stop();

			Assert.IsTrue(result, "Could not stop IISAdmin service when disabled.");
		}

		//private void DisableAndStopIISAdminService()
		//{
		//	bool isStartupMode = false;
		//	ServiceController sc = new ServiceController(_serviceName);

		//	try
		//	{
		//		ServiceHelper.ChangeStartMode(sc, startMode);
		//		sc.Refresh();
		//		isStartupMode = sc.StartType == startMode;
		//		sc.Close();
		//		return isStartupMode;
		//	}
		//	catch (Exception ex)
		//	{
		//		sc.Close();
		//		throw ex;
		//	}
		//}

	}
}
