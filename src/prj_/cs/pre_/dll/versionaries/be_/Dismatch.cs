using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace nilnul.dev.src.prj_.cs.pre_.dll.versions.be_
{
	/*
	 * 
	 
   <Reference Include="AWSSDK.CodeCommit, Version=3.3.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604, processorArchitecture=MSIL">
      <HintPath>..\..\..\(packages)\AWSSDK.CodeCommit.3.7.0.36\lib\net45\AWSSDK.CodeCommit.dll</HintPath>
    </Reference>
    <Reference Include="AWSSDK.Core, Version=3.3.0.0, Culture=neutral, PublicKeyToken=885c28607f98e604, processorArchitecture=MSIL">
      <HintPath>..\..\..\(packages)\AWSSDK.Core.3.7.0.38\lib\net45\AWSSDK.Core.dll</HintPath>
    </Reference>

	<Reference Include="EntityFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, processorArchitecture=MSIL">
      <HintPath>..\..\..\(packages)\EntityFramework.6.4.4\lib\net45\EntityFramework.dll</HintPath>
    </Reference>
    <Reference Include="EntityFramework.SqlServer, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089, processorArchitecture=MSIL">
      <HintPath>..\..\..\(packages)\EntityFramework.6.4.4\lib\net45\EntityFramework.SqlServer.dll</HintPath>
    </Reference>
	
	 */

	/// <summary>
	/// sometimes version in the "Include" attr is inconsistent with version in the hintPath
	/// </summary>
	public class Dismatch
	{
		static public bool IsDismatch(XElement element)
		{
			return !nilnul.obj_.deV_.pkg._identity.version.nulable.Eq.Singleton.Equals(

				path._VersionX.VersionNulable(element)
				,
				pre_.dll._VersionX.Nulable(element)

			);
		}
	}
}
