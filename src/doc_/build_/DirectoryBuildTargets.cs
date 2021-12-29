using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.doc_
{
	public class DirectoryBuildTargets
	{
		public const string Name = "Directory.Build.targets";

	/*
	  
	  <?xml version="1.0" encoding="utf-8"?>
 <Project>


<Target Name="AddPackageAliases" BeforeTargets="ResolveReferences" Outputs="%(PackageReference.Identity)">
    <PropertyGroup>
        <AliasPackageReference>@(PackageReference->'%(Identity)')</AliasPackageReference>
        <AliasName>@(PackageReference->'%(Alias)')</AliasName>
    </PropertyGroup>

    <ItemGroup>
        <ReferencePath Condition="'%(FileName)'=='$(AliasPackageReference)'">
            <Aliases>$(AliasName)</Aliases>
        </ReferencePath>
    </ItemGroup>
</Target>
</Project>

<!--
and then use it in your csproj in your PackageReference nodes like this:

<ItemGroup>
    <PackageReference Include="StackExchange.Redis.StrongName" Version="1.2.6" Alias="signed" />
</ItemGroup>

-->
	
	 */
		public string Blob()
		{

			return "";
		}


	}
}
