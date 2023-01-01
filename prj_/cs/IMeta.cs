using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs
{
	/// <summary>
	/// the .csproj file in the prj, which is a folder.
	/// Note: a folder might contain multiple meta, each describes the prj in a different view.
	/// </summary>
	/// <remarks>
	/// meta contains information we need to build
	/// </remarks>
	/// alias:
	///		meta
	///			not identifier, which is <see cref="obj.identy.ITagged"/>
	///			not spec, which is a contexted  identy like: someType, some assembly.
	///		vw
	///		
	///			
	public interface IMeta
	{
	}
}
