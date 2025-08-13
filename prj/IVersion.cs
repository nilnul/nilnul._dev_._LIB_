using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj
{
	/// <summary>
	/// the source code version, often denoted by a git snapshot. <see cref="nilnul.fs.git.repo.Snap"/>
	/// </summary>
	/// vs:
	///		<see cref="nilnul._app.lib.version"/>, which is the version of the compiled. That shall be kept unchanged in nilnul.
	///		<see cref="nilnul.dev._pak.version"/>, which is the version of the pak. That shall be increased.
	internal class IVersion
	{
	}
}
