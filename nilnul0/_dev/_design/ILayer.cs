using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._dev._design
{
	/// <summary>
	/// layers:
	///		:intention,often represented by an interface
	///		:implementation/realization, often represented by a class/struc which executes what an interface requires.
	///		:application(usage), often represented by a call from other realm/component/testMethod(as part of procedure)/testClass(as part of data)
	///	;
	///	in the xml explication for a type, the summary is used for intention (as for an interface) and implementation (as for a class/struc), the remark is used for application.
	/// </summary>
	/// 
	/// <remarks>
	/// implementation might be in another prj other than the one for the intention. implementation might be complex, beyond the scope of the prj for intention.
	/// analogously, application might be not so obvious in the project of implementation. But as long as the implementation can make some difference, then it carries some info, which tells us something that might be useful or not so useful in the current prj. So information doesnot mean useness.
	/// </remarks>
	internal class ILayer
	{
	}

}
