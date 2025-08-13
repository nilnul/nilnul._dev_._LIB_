using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._dev._phases
{
	/// <summary>
	/// everything is in code;
	/// every phase as written code; and we need SDKs correspondingly;
	/// </summary>
	internal enum Li_
	{
		Demand
			,
		/// <summary>
		/// including build "_KEN_", and write some prototype code (eg: Marker interface) which is in design branch and can be later used to initiate and act as a stub for development branch;
		/// </summary>
		Design
			,
		Develop
			,
		/// <summary>
		/// including test. and collaborated many systems together;
		/// </summary>
		Debug
			,
		/// <summary>
		/// 
		/// </summary>
		Deploy
			,
		/// <summary>
		/// operation, monitor, diagnose, maintenance, logging, security patching, hot fixing;
		/// </summary>
		/// <remarks>
		/// biz is carried out by other teams than dev team.
		/// </remarks>
		/// alias:
		///		detect
		///		monitor
		///		diagnose
		///			,as the caption in the menu for a UI
		///		监视
		///		检视
		///		
		Diagnose
	}
}
