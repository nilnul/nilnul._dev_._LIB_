using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj.sup.doc_
{
	/*
	 To configure multiple projects, you can create a Directory.Build.props file that contains the <LangVersion> element. You typically do that in your solution directory. Add the following to a Directory.Build.props file in your solution directory:

XML

<Project>
 <PropertyGroup>
   <LangVersion>preview</LangVersion>
 </PropertyGroup>
</Project>
Builds in all subdirectories of the directory containing that file will use the preview C# version. For more information, see the article on Customize your build.
	 */


	/*
	 per: docs.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2019
	 However, now you can add a new property to every project in one step by defining it in a single file called Directory.Build.props in the root folder that contains your source. When MSBuild runs, Microsoft.Common.props searches your directory structure for the Directory.Build.props file (and Microsoft.Common.targets looks for Directory.Build.targets). If it finds one, it imports the property. Directory.Build.props is a user-defined file that provides customizations to projects under a directory.

 Note

Linux-based file systems are case-sensitive. Make sure the casing of the Directory.Build.props filename matches exactly, or it won't be detected during the build process.

See this GitHub issue for more information.


	For example, if you wanted to enable all of your projects to access the new Roslyn /deterministic feature (which is exposed in the Roslyn CoreCompile target by the property $(Deterministic)), you could do the following.

Create a new file in the root of your repo called Directory.Build.props.

Add the following XML to the file.

XML

Copy
<Project>
 <PropertyGroup>
   <Deterministic>true</Deterministic>
 </PropertyGroup>
</Project>
Run MSBuild. Your project’s existing imports of Microsoft.Common.props and Microsoft.Common.targets find the file and import it.


	When searching for a Directory.Build.props file, MSBuild walks the directory structure upwards from your project location ($(MSBuildProjectFullPath)), stopping after it locates a Directory.Build.props file. For example, if your $(MSBuildProjectFullPath) was c:\users\username\code\test\case1, MSBuild would start searching there and then search the directory structure upward until it located a Directory.Build.props file, as in the following directory structure.


Copy
c:\users\username\code\test\case1
c:\users\username\code\test
c:\users\username\code
c:\users\username
c:\users
c:\
The location of the solution file is irrelevant to Directory.Build.props.

Use case: multi-level merging
Suppose you have this standard solution structure:


Copy
\
  MySolution.sln
  Directory.Build.props     (1)
  \src
    Directory.Build.props   (2-src)
    \Project1
    \Project2
  \test
    Directory.Build.props   (2-test)
    \Project1Tests
    \Project2Tests
It might be desirable to have common properties for all projects (1), common properties for src projects (2-src), and common properties for test projects (2-test).

To make MSBuild correctly merge the "inner" files (2-src and 2-test) with the "outer" file (1), you must take into account that once MSBuild finds a Directory.Build.props file, it stops further scanning. To continue scanning and merge into the outer file, place this code into both inner files:

<Import Project="$([MSBuild]::GetPathOfFileAbove('Directory.Build.props', '$(MSBuildThisFileDirectory)../'))" />

A summary of MSBuild's general approach is as follows:

For any given project, MSBuild finds the first Directory.Build.props upward in the solution structure, merges it with defaults, and stops scanning for more
If you want multiple levels to be found and merged, then <Import...> (shown above) the "outer" file from the "inner" file
If the "outer" file does not itself also import something above it, then scanning stops there
To control the scanning/merging process, use $(DirectoryBuildPropsPath) and $(ImportDirectoryBuildProps)
Or more simply: the first Directory.Build.props that doesn't import anything is where MSBuild stops.
	
	 */
	class DirectoryBuildProps
	{
	}
}
