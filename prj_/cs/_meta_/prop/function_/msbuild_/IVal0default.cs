namespace nilnul.dev.prj_.cs._meta_.prop.function_.msbuild_
{
	interface IVal0default
	{
		/*
		 * 
		 * docs.microsoft.com/en-us/previous-versions/visualstudio/visual-studio-2015/msbuild/property-functions?view=vs-2015&redirectedfrom=MSDN
<Project ToolsVersion="4.0" xmlns="https://schemas.microsoft.com/developer/msbuild/2003">  
  
    <PropertyGroup>  
        <Value1>$([MSBuild]::ValueOrDefault(`$(UndefinedValue)`, `a`))</Value1>  
        <Value2>$([MSBuild]::ValueOrDefault(`b`, `$(Value1)`))</Value2>  
    </PropertyGroup>  
  
    <Target Name="MyTarget">  
        <Message Text="Value1 = $(Value1)" />  
        <Message Text="Value2 = $(Value2)" />  
    </Target>  
</Project>  
  
<!--  
Output:   
  Value1 = a  
  Value2 = b  
-->		 */
	}
}
