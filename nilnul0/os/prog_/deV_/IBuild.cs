using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.deV_
{
	/// let's put build here in nilnul.dev.raw,
	///		not in nilnul.dev, as build is about src (based on src and prediagnose the src), and build meta such as .csproj is part of src;
	///		not in nilnul.dev.pak, as pak is focusing on nuget package generation and publishing and installing, whilst solving version matching in resolving dependency graph;
	///
	/// <summary>
	/// build the src such as a prj; this is part of a sdk;
	/// </summary>
	/// <remarks>
	/// alias:
	///		build, not break;
	/// 
	/// vs:
	///		compile, which is for a lang, whileas this is for a src which can include resources, etc besides language code;
	/// </remarks>
	internal class IBuild
	{
	}
}
