using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.deV_.build_.ms._run._make._target.task_._predefineds
{

	///
	///github.com/dotnet/msbuild/blob/main/src/Tasks/Microsoft.Common.CurrentVersion.targets
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// the following list is not exhaustive;
	/// </remarks>
	internal enum Li_
	{
		InitializeSourceControlInformation
			,
Build
			,
/// <summary>
/// intentionaly blank such as to be overriden 
/// </summary>
BeforeBuild
			,
AfterBuild
			,
Rebuild
			,

BeforeRebuild
			,

AfterRebuild
			,

Run
			,
PreBuildEvent
			,
ResolveReferences
			,ResGen
,

		/// <summary>
		/// Building is done when preparing an application for release, which includes compiling, packaging, testing, etc. Compiling is done at any time the compiler is involved in translating programming language code to machine code.
		/// </summary>
		/// <remarks>
		/// compile is done at the language level, whileas build is done at the project evel;
		/// build includes compile as one of the many stages;
		/// </remarks>
		Compile
			,
		Clean
			,
PostBuildEvent
			,
PublishOnly
			,
AfterPublish
			,
/// <summary>
/// msbuild -t:restore
/// </summary>
restore

	}
}
