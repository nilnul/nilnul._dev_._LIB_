using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln._life
{
	/// <summary>
	/// <seealso cref="nilnul.app.life"/>
	/// </summary>
	/// 
	internal enum Phase_
	{
		/// <summary>
		/// an entity(person or org) feels the lack|need to have an information system
		/// </summary>
		/// <remarks>
		/// this stage is important as it might be rules or laws that a sln must abide by and take care all the way from design to deploy.
		/// eg:
		///		court might require a volume of books or a book must conform to a format. And the sln has to conform that in order to be effective, not to be devoided.
		/// </remarks>
		Demand
			,
		/// <summary>
		/// with ken;
		/// </summary>
		/// <remarks>
		/// Design
		/// </remarks>
		/// alias:
		///		design
		///		plan
		Design
			,
		/// <summary>
		/// develop; codeing by software engineer;
		/// </summary>
		/// <remarks>
		/// including source code debug;
		/// </remarks>
		/// alias:
		///		devise
		///		develop9debug
		///		code
		Devise
			,
		/// <summary>
		/// compile, as well as rsc embedding;
		/// </summary>
		/// <remarks>
		/// buildable or not - to check for the error;
		/// different builds to improve performance; for example switch from debug to release mode;
		/// 
		/// </remarks>
		/// alias:
		///		debug
		///		diagnoze
		///		build
		///			,done by <see cref="nilnul.dev.prj._life.Phase_.build"/>
		///	vs:
		///		build
		Debug
			,
		/// <summary>
		/// including _deploy.Test
		/// </summary>
		Deploy
			,
		/// <summary>
		/// feel the need to improve, hotfix or upgrade the system.
		/// sometimes to retire the system;
		/// </summary>
		/// <remarks>
		/// the log of the app needs maintained;
		/// we can also collect user feedback, wishlist, a polling, etc;
		/// </remarks>
		/// alias:
		///		diagnoze
		///			,like the menu in Ui
		///		Monitor
		///		diagnoze4maintenance
		///		control
		///		sustain
		///		maintain
		///		detect
		///		upkeep
		///		support
		///		operate
		///		
		Diagnoze2maintain
	}
}
