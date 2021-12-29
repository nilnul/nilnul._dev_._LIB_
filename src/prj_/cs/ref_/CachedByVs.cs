using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.ref_
{
	/// <summary>
	/// if you right click in vs Sln panel on one reference, and let the properties panel show the referenced path, the version is not necessarily the same new as in the meta. This will fail the build.
	/// unload and reload project, the cached version is refreshed to the same as in packages.config. And the build will succeed.
	/// </summary>
	class CachedByVs
	{
	}
}
