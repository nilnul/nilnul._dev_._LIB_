using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.doc_
{
	public class DirectoryBuildProps
	{
		public const string Name = "Directory.Build.props";



		/*

		  <?xml version="1.0" encoding="utf-8"?>
	 <!--
	https://docs.microsoft.com/en-us/visualstudio/msbuild/customize-your-build?view=vs-2019
	-->

	<Project>
	 <PropertyGroup>
	   <Deterministic>true</Deterministic>
	 </PropertyGroup>

	<PropertyGroup>
		<Authors>WangYoutian@nilnul.com</Authors>
	  </PropertyGroup>

		<PropertyGroup Condition="'$(Configuration)|$(Platform)'=='Release|AnyCPU'">
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <WarningsAsErrors />
    <DocumentationFile>$(SolutionDir)Documentation\$(MSBuildProjectFile).xml</DocumentationFile>
  </PropertyGroup>

	</Project>


		 */
		public string Blob()
		{

			return "";
		}

	}
}
