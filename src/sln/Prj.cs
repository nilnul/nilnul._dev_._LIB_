using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln
{
	/// <summary>
	/// a subfolder, in which a prj file resides. Sometimes, a prj is not directly in a sln, but in a subsln(which is a div of the sln folder)
	/// 
	/// </summary>
	/// <remarks>
	/// when a dev.src.Prj is embedded into a sln, the embedding information is kept here. for example "nilnul.fs._git_._LIB_" contains sln information. Note one prj may be used inside multiple slnS;
	/// this "use" may be a reference, and the prj still resides in one sln
	///
	/// </remarks>
	public interface IPrj:nilnul.dev.src.IPrj
	{
	}
}
