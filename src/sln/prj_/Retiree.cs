using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.prj_
{
	/// <summary>
	/// some project is terminated, for example, due to the transferral.
	/// The project enters maintainance mode, no big change is made any more, but small/hotpatch is still applied. in other words, major and minor version will not change, but patch version can change.
	/// retiree project example includes:
	///		a house, when ownership is transferred to another person. the documents would be need to migrate into new project, but for avoiding overlapping management and keeping history intact as a history, we keep the old project and new project will reference the old project. old project will make some small changes to publish some api to be referenced by, or to be satisfying for the new project.
	///
	/// retiree projects will be included in the new sln.
	///		
	/// </summary>
	/// <example>
	/// </example>
	interface IRetiree
	{
	}
}
