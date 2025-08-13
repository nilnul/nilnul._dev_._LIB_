namespace nilnul.os.prog_.deV_.build_.ms._run._make
{
	/// <summary>
	/// By default, msbuild.exe only executes the first target.
	/// </summary>
	/// <remarks>
	///You can specify a list of targets separated by semi-colons using the /target (shortcut /t). You can also specify such a list using the DefaultTarget attribute of the <Project> tag. If multiple targets are specified, the order of execution is undefined.
	/// </remarks>
	///
	/// srcs:
	/// codeproject.com/Articles/12985/Practical-NET2-and-C-2-An-introduction-to-MSBuild
	/// Patrick Smacchia
	/// 7 Feb 2006
	///

	internal class ITargets
	{

		/*
	<Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />

This Microsoft.CSharp.targets file contains two generic targets:

A target named CreateManifestResourceNames which takes care of the organization of resource files (transformation of .resx files into .resources).
A target named CoreCompile which contains a task named Csc which takes care of building C# files.
		 */
	}

}
