using DevAssistant.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevAssistant.Logic.Services
{
    public class DevAssistantService : IDevAssistantService
    {
        public Task<List<MCBuildArtifact>> GetAvailableArtifacts()
        {
            throw new NotImplementedException();
        }
        public void SetIISAdminServiceStartupType() 
        {
            ServiceController sc = new ServiceController("IISADMIN");
            Console.WriteLine(sc.StartType);
            if (sc.StartType != ServiceStartMode.Manual)
            {
                ServiceHelper.ChangeStartMode(sc, ServiceStartMode.Manual);
            }

            if (sc.Status != ServiceControllerStatus.StartPending &&
                sc.Status != ServiceControllerStatus.Running)
            {
                sc.Start();
            }
            
            sc.Close();
        }
    }
}
