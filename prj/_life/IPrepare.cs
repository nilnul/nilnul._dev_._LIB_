using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj._life
{
	/// <summary>
	/// create or update the project file, eg: csproj.
	/// also, some misc like:
	///		-) packages.config
	///		-) AssemblyInfo.cs
	///		-) obj/, where some packageReferences configuration shall be cleaned if we switch to sidely packages.config as that would automatically set the deps in packaging.
	///		-) packages/ as a symbolic such that dll relative reference for pacs would not broke across computers.
	///		-) .snk file, usually as symlink to src/someSnk
	///	possibly some in-directory configuration like:
	///		directory.target.config
	///		.editorconfig
	/// </summary>
	/// alias:
	///		init
	///			maybe shall come before this, as prep happens each time, say, daily,  when you begin to update your src; init happens only once at the start of the proj.
	///			so prepare shall be the idempotent version of init.
	///		prime
	///		
	class IPrepare
	{
	}
}
