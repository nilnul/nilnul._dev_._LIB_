using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_
{
	/// <summary>
	/// sometimes, we need to introduce other's open source project into our src.
	/// for such project, we can:
	///		1) don't change it or just give minor meta changes
	///			1.1) the version of such project should be versioned not using auto-incrementing patch/build, but manually set major&minor. for such project doesnot change frequently and we need to keep the dependency to it not necessary to maintain intensively.
	///		2) if there are major change, consider create a new project of ours and introduce the source code, or add that project from others as dependency.
	/// </summary>
	interface IFroOther
	{
	}
}
