using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_._msbuild_.prop_
{
	/*
	 $(ProjectDir) is only available after Microsoft.Common.Targets has been imported, while $(MSBuildProjectDir) is a reserved property in MSBuild itself.

So using the $(MSBuildXXX) properties will ensure that they are always available to you without needing to import all the necessary references.
	 */
	/*stackoverflow.com/questions/2647373/when-does-msbuild-set-the-projectname-property
	 I don't think $(ProjectDir) is available until after Microsoft.Common.Targets has been imported (which is done by Microsoft.Csharp.targets). Property evaluation is always carried out "in-place" within the file, and not when all the Imports have completed.  
	 */
	/*
	 seealso: $(MSBuildProjectName)
	 */
	class PrjDirectory
	{
	}
}
