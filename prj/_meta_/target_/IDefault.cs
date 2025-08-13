using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs._meta_.target_
{
	class IDefault
	{
		/*
	 to set default target:

<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Test">

  <Target Name="Test">
    <PropertyGroup>
      <StartTicks>$([System.DateTime]::UtcNow.Ticks)</StartTicks>
    </PropertyGroup>

    <Message Text="Starting ticks: $(StartTicks)"/>

    <!-- Do some stuff. For this example, we'll launch notepad and wait for it to exit. -->
    <Exec Command="notepad"/>

    <PropertyGroup>
      <FinishTicks>$([System.DateTime]::UtcNow.Ticks)</FinishTicks>
      <ElapsedTicks>$([MSBuild]::Subtract($(FinishTicks), $(StartTicks)))</ElapsedTicks>
      <Elapsed>$([System.TimeSpan]::FromTicks($(ElapsedTicks)))</Elapsed>
    </PropertyGroup>
    <Message Text="Elapsed time: $(Elapsed)"/>
  </Target>

</Project>

robokiwi.com/blog/2014/07/19/using-msbuild-property-functions-and-inline-tasks-example-doing-performance-calculations/
by DavidMoore

	 */
	}
}
