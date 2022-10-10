using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs._meta_
{
	class DefineConstant
	{
		/*
stackoverflow.com/questions/14818943/msbuild-3-5-property-functions-in-condition
asked Feb 11, 2013 at 18:57
wuxilixi

edited Apr 5, 2018 at 10:12
Cœur


I would like to get the .Net version number in C# code, so in the .csproj file, I added the following line:

<DefineConstants Condition=" $(TargetFrameworkVersion.Replace('v', '')) &gt;= 3.5 ">$(DefineConstants);NET35_ABOVE</DefineConstants>
Then in the C# code I can use "#if NET35_ABOVE" to check if the current .Net version is newer than 3.5. The line above works OK in MSBuild 4.0, but MSBuild 3.5 doesn't recognize the "Replace" function. If I were to dynamically check .Net version in a similar fashion, how can I do it in MSBuild 3.5?		
		 */
	}
}
