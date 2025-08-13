using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_._msbuild_._props.attr_
{
	/*
	 <PropertyGroup>
        <TargetFrameworks>net45;net48;netstandard2.1;netcoreapp2.1;netcoreapp3.1</TargetFrameworks>
    </PropertyGroup>
	 <PropertyGroup Condition="'$(TargetFramework.TrimEnd(`0123456789`))' == 'net'">
        <!-- Properties for .NET Framework -->
	single quotes are required for empty values
    </PropertyGroup> 
	 */
	class Condition
	{
	}
}
