using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs
{

	/// <summary>
	/// before editing the src code, we do some preparation, locally:
	///		*) editing the .csproj file;
	///		*) if it's a lib, also upsert the AssemblyInfo.cs
	///		*) establish .snk file
	///		*) upsert the "packages" folder, which is the installed dependencies.
	///		*) determine packageReferences using "package.config"
	///	Note: updating deps is not included here, as it's a time-consuming, network-involved process. And it might introduce some uncertainty as we pull in others' work.
	///	Also updating deps is not idempotent while the actions we define for priming are.
	/// </summary>
	public interface IPrime
	{
	}
}
