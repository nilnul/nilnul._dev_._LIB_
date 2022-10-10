using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev
{
	/// <summary>
	/// a prj in its whole lifecycle including: src code, compiled assembly, and runtime AppDomain (a component of process)
	/// </summary>
	/// <remarks>
	/// vs :
	///		src.Prj
	///			c# prj in src may be compiled into a pac, where bytecode is used and you will not tell whether it is in c# or vb. so cs_.Prj is not the same as a Prj.
	///	namespace:
	///		"nilnul.dev".Prj, means the prj is used dev wise, not only in src only. the prj can be pac, taken out of the context of src.sln and some of its properties remains intact indepently of the "src" or other dev.Phase such as pac.
	///
	/// ***
	/// there must be a handle to denote something.
	///		eg: when we talk about the history of a regime, the regime is the handle. not the history, as for only history, we may wonder: history of waht.
	///	the one side of a one-to-many relation
	/// </remarks>
	public interface IPrj
	{
	}
}
