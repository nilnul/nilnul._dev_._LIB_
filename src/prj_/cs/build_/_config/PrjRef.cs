using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.build_._config
{
	/*
	<ItemGroup>
    <ProjectReference Include="..\_LINQ_\nilnul._num_._LINQ_.csproj">
      <Project>{4f91ad6d-3d75-4292-abe9-68e85050db8a}</Project>
      <Name>nilnul._num_._LINQ_</Name>
    </ProjectReference>
  </ItemGroup>

	considering one example:
	Prj A is built using config:X before being pushed to nuget server, and later is built again using Config:Y and pushed to nuget server.
	Prj:B has a prjRef of A. When B is built using Config:X, the builder first check whether Prj:A has a already-built dll in config:X before determining whether to build A anew. The builder would find one and skip building A. But the found version of A is not the newest nuget pac; So B, when pushed to nuget server, stills references an old version of A.

	 */
	public interface IPrjRef
	{
	}
}
