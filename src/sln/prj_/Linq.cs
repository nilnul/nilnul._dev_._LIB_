using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.prj_
{
	/// <summary>
	/// cuz in linq, with the help of various tools, we need a new domain for many classes that map to db; these classes might conflict the classes in "LIB". So we need to create a prj here. (CFG, which is used to adapt the user storage on an OS, neednot to be an independent project, as there are no new domain of classes to be constructed to overlap with those in "LIB")
	/// </summary>
	/// <example>
	/// </example>
	interface ILinq
	{
	}
}
