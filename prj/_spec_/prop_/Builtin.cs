using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs._meta_.prop_
{
	/**
MSBuild reserves some property names to store information about the project file and the MSBuild binaries. MSBuildToolsPath is an example of a reserved property. Reserved properties are referenced with the $ notation like any other property. For more information, see How to: Reference the Name or Location of the Project File and MSBuild Reserved and Well-Known Properties.
	
docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2015/msbuild/walkthrough-using-msbuild?view=vs-2015

You can reference environment variables in project files the same way as build properties. For example, to use the PATH environment variable in your project file, use $(Path).

Properties may be defined on the command line using the /property or /p command line switch. Property values received from the command line override property values set in the project file and environment variables.
	
	msbuild buildapp.csproj /t:HelloWorld /p:Configuration=Release 
	 */
	class Builtin
	{

/*
  
 MSBuildProjectDefaultTargets
		<Project DefaultTargets="A;B;C" >


MSBuildProjectDirectory
		-Do not include the final backslash
MSBuildProjectDirectoryNoRoot

MSBuildProjectFullPath
MSBuildProjectFile
MSBuildProjectName
MSBuildProjectExtension
MSBuildStartupDirectory

 * 
 */
	}
}
