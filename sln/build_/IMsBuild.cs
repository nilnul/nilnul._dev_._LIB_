using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.build_
{
	/// learn.microsoft.com/en-us/visualstudio/msbuild/how-to-build-specific-targets-in-solutions-by-using-msbuild-exe?view=vs-2022#troubleshooting
	/// <summary>
	/// MSBuild.exe <SolutionName>.sln
	/// </summary>
	/// <remarks>
	/// Specify the target after the -target: switch in the format
	///		<ProjectName>:<TargetName>
	///	.
	///	If the project name contains any of the characters %, $, @, ;, ., (, ), or ', replace them with an _ in the specified target name.
	///
	/// eg:
	/// The following example executes the Rebuild target of the NotInSlnFolder project, and then executes the Clean target of the InSolutionFolder project, which is located in the NewFolder solution folder.
	///		msbuild SlnFolders.sln -target:NotInSlnfolder:Rebuild; NewFolder\InSolutionFolder:Clean
	///
	/// Building a specific target also triggers other dependent targets to build.
	/// </remarks>
	internal class IMsBuild
	{
	}
}
