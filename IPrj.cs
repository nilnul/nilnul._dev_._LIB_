using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev
{
	///	 vs:
	///		<see cref="nilnul.lang"/>, which is the grammar about the content of a file|document|file|procedure|script, whileas here this is a project|program, which is a collection of documents|files|procedures that are organized, more broadly than structure.
	///		; So for lang, it's compile, not build, which is for project.
	///		
	/// <summary>
	/// a folder, with a doc called meta to define what's included. Those excluded are also part of the prj, but sidelined.
	/// a prj in its whole lifecycle including: src code, compiled assembly, and runtime AppDomain (a component of process)
	/// </summary>
	/// <remarks>
	/// This refers to a folder, whileas ".csproj" or anyohter proj such as sqlProj is the meta of the folder, just as <see cref="ISln"/> refers to a folder whileas ".sln" stores the meta of that folder;
	/// 
	///You don't have to use solutions or projects in Visual Studio to edit, build, and debug code. You can simply open the folder that contains your source files in Visual Studio and start editing.
	///
	/// It's ideal to have only one <see cref="prj.ISpecification"/> for one <see cref="IPrj"/>; but plural <see cref="prj.ISpecification"/> is also allowed, to present the prj in different views, targeting different runtimes;
	/// </remarks>
	///	alias:
	///		pad
	///			,like lauch pad
	///			, prj is sth to be ejected
	///		synd
	///		syndicate
	///		container
	///		module, as in system;
	///		basis
	///		workbench
	///		platform
	///		stage
	/// vs :
	///		src.Prj
	///			c# prj in src may be compiled into a pac, where bytecode is used and you will not tell whether it is in c# or vb. so cs_.Prj is not the same as a Prj.
	///	namespace:
	///		"nilnul.dev".Prj, means the prj is used dev wise, not only in src only. the prj can be pac, taken out of the context of src.sln and some of its properties remains intact indepently of the "src" or other dev.Phase such as pac.
	///
	/// ***
	/// there must be a handle to denote something.
	///		eg: when we talk about the history of a regime, the regime is the handle. not the history, as for only history, we may wonder: history of waht.
	///	the one side of a one-to-many relation
	///		
	public interface IPrj
				:
		nilnul.fs.IFolder
	{
	}
}
