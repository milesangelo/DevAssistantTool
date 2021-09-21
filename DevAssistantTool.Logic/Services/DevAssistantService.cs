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

        private List<IService> _services;

        /// <summary>
        /// Initializes an instance of DevAssistantService with a list of services in which to manage.
        /// </summary>
        /// <param name="services"></param>
        public DevAssistantService(List<IService> services)
        {
            _services = services != null ? new List<IService>(services) : new List<IService>(1);
        }

        public void SetupService() 
        {
            
        }

		public void Restart()
		{
            foreach (var service in _services)
            {
                //service.Restart();
            }
		}
	}
}
