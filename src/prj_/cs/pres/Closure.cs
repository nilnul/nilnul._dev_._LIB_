using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.pres
{
	/// <summary>
	/// find the refs within the srcs recursively till the end, by:
	///		first find refs (including both dll and raw).
	///			then find the prj of the ref, within the scope of srcs
	///		recursively
	/// </summary>
	interface IClosure
	{
	}
}
