using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj
{
	/// <summary>
	/// each project contains an MSBuild project file.The project file is an XML document that contains all the information and instructions that MSBuild needs to build your project. Such information and instructions include the content, platform requirements, versioning information, web server or database server settings, and the tasks to perform.
	/// the prj file in the prj folder; note we might have many prj files, each of which can be taker as a view from some perspective;
	/// </summary>
	/// <remarks>
	/// used in msbuild.
	/// eg:
	///		.csproj
	///		.sqlproj
	///		and some user files such as .csproj.user
	/// </remarks>
	/// alias:
	///		meta
	///			,
	///			like c make files
	///		spec
	///		blob
	///		file
	///		info
	///		data
	///		view
	///		prop
	public interface IMeta
		:
		nilnul.os.prog_.deV_.build_.ms._run.IMake
		//nilnul.fs.IFile
		//,
		//nilnul.fs.file_.ext_.IXml
	{
	}
}
