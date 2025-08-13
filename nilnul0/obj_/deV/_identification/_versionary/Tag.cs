using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identification._versionary
{
	internal enum Tag
	{
		/// <summary>
		/// actively developed; there might be bugs, incomplete implementations, empty markers|todos.
		/// </summary>
		Developing
			,
		/// <summary>
		/// not mature; not production ready;
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		Prerelease
			,
		/// <summary>
		/// production ready
		/// </summary>
		/// <remarks>
		/// this tag is often ommitted.
		/// </remarks>
		Release
			,
		///https://github.com/dotnet/runtime/blob/main/src/libraries/System.Linq.Expressions/README.md
		/// <summary>
		/// The library and supporting language features are mature and no longer evolving, and the risk of code change likely exceeds the benefit. We will consider changes that address significant bugs or regressions, or changes that are necessary to continue shipping the binaries. Other changes will be rejected.
		/// </summary>
		Archived
			,
		/// <summary>
		/// will retire; would be superseded.
		/// </summary>
		Obsoleted
	}
}
