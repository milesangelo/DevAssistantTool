using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAssistant.Logic.Services
{
	public interface IService
	{
		/// <summary>
		/// Stop the Windows Service.
		/// </summary>
		/// <returns></returns>
		bool Stop();



		//void Setup();

		//void Start();

		//bool Restart();
	}
}
