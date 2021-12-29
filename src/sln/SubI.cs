using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln
{
	/// <summary>
	/// sub, or subsln,  is the div for a sub sln inside the top sln.
	/// the top sln is a special sub sln.
	/// note: sub doesnot cover the dir where a prj resides. i.e.,  sub + dir = prj
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		sub in subset means a set itself or a smaller set. subsln means the sln itself or a descedant sln
	///		vs:
	///			childSln
	///			grandchildSln
	///			descedent sln
	///			
	/// names shall not be used:
	///			child
	///				as sub might be the top sln itself
	/// alias:
	///		solution
	///			means sln + divOfSubSln
	///	sub is a git module.
	///		in side sub, there might be multiple prjs. we can let individual prj be a gitModule, or we can have only one module for a sub.
	/// </remarks>
	interface ISub
	{
	}
}
