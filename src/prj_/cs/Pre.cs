using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs
{
	/// <summary>
	/// the refs (including dll, and raw) are converted to prjNomina, and then we find the prj for next level pres.
	/// </summary>
	/// <remarks>
	/// alias:
	///		Prior
	///		premise
	///	nomenclature:
	///		(P)rior to (re)f
	/// </remarks>
	interface IPre
	{
	}
	public enum Pre_
	{
		/*
		 eg:
		   <ItemGroup>
				<Reference Include = "System" />
		 
		 */
		/// <summary>
		/// </summary>
		BuiltIn
		,

		//var xpath =	"/*/*[local-name()='ItemGroup']/*[local-name()='PackageReference']"
		/// <summary>
		/// the dll might be a dll from the installed nuget package. But the dll might be a dll in any location.
		/// </summary>
		DllRef
		,
		/// <summary>
		/// project rerence
		/// </summary>
		Prj

	}
}
