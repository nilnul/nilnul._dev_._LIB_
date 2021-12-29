using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.prj
{
	/// <summary>
	/// the full name of the project, as shown in visual studio properties tab's textbox.
	/// eg:
	///		nilnul.fs._git_._LIB_.csproj.
	///			having:
	///				ext ".csproj"
	///				slnSub "nilnul.fs._git_"
	///			not having:
	///				note: such as nilnul.fs._git_._LIB_(1.csproj
	///					note here the main of the doc is parsed separately, so "(1" is note combined into "(1.csproj" as a whole comment.
	/// </summary>
	interface IName
	{
	}
}
