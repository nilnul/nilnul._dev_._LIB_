using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj
{
	/// <summary>
	/// build including <see cref="nilnul.lang.compile"/>|<see cref="_build.ICompile"/>;
	/// build is before <see cref="nilnul.dev._pak"/>|<see cref="nilnul.dev.prj.pak"/>
	/// </summary>
	/// <see cref="nilnul.dev.prj.IVersion"/>, which is the source code version, often denoted by a git snapshot (<see cref="nilnul.fs.git.repo.Snap"/>.
	/// 
	/// 
	/// vs:
	///		<see cref="nilnul.lang"/>, where the unit is a document|file|procedure|script, whileas here this is a project|program, which is a collection of documents|files|procedures; So for lang, it's compile, not build, which is for project.
	internal class IBuild
	{
	}


}
