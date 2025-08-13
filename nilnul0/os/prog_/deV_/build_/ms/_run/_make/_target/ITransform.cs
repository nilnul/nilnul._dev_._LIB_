using nilnul.geometry.planar._area.unit_;

namespace nilnul.os.prog_.deV_.build_.ms._run._make._target
{
	/// learn.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2015/msbuild/msbuild-transforms?view=vs-2015&redirectedfrom=MSDN
	/// <summary>
	/// 
	/// </summary>
	interface ITransform {

		/*
		 <Target Name="CopyOutputs"  
    Inputs="@(BuiltAssemblies)"  
    Outputs="@(BuiltAssemblies -> '$(OutputPath)%(Filename)%(Extension)')">  
  
    <Copy  
        SourceFiles="@(BuiltAssemblies)"  
        DestinationFolder="$(OutputPath)"/>  
  
</Target>

,every file in the BuiltAssemblies item list maps to a file in the destination folder of the task;


If a file in the BuiltAssemblies item list changes, the Copy task will be run only for the changed file and all other files will be skipped.

		 */


		//A target can be built incrementally if the inputs and outputs are specified in the project file.
	}
}
