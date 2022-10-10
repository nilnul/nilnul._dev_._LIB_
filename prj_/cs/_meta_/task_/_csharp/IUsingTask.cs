using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs._meta_.task_._csharp
{
	class IUsingTask
	{

		/*
<?xml version="1.0" encoding="utf-8"?>
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003" DefaultTargets="Test">

  <Target Name="Test">

    <GetTimeStamp>
      <Output PropertyName="StartTimeStamp" TaskParameter="TimeStamp" />
    </GetTimeStamp>

    <Message Text="Starting timestamp: $(StartTimeStamp)"/>

    <!-- Do some stuff. For this example, we'll launch notepad and wait for it to exit. -->
    <Exec Command="notepad"/>

    <GetElapsedTimeSpan StartTicks="$(StartTimeStamp)">
      <Output PropertyName="EndTimeSpan" TaskParameter="ElapsedTimeSpan" />
    </GetElapsedTimeSpan>

    <Message Text="Elapsed time: $(EndTimeSpan)"/>
  </Target>

  <UsingTask TaskName="GetTimeStamp" TaskFactory="CodeTaskFactory" AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v4.0.dll">
    <ParameterGroup><TimeStamp ParameterType="System.Int64" Output="true" /></ParameterGroup>
    <Task>
      <Using Namespace="System.Diagnostics" />
      <Code Type="Fragment" Language="cs">
        <![CDATA[ TimeStamp = System.Diagnostics.Stopwatch.GetTimestamp(); ]]>
      </Code>
    </Task>
  </UsingTask>

  <UsingTask TaskName="GetElapsedTimeSpan" TaskFactory="CodeTaskFactory" AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v4.0.dll">
    <ParameterGroup>
      <ElapsedTimeSpan ParameterType="System.String" Output="true" />
      <StartTicks ParameterType="System.Int64" Required="true" />
    </ParameterGroup>
    <Task>
      <Using Namespace="System.Diagnostics" />
      <Code Type="Fragment" Language="cs">
        <![CDATA[

        // We can get the current timestamp and then calculate the elapsed ticks. To improve
        // accuracy of the benchmark, you could expose another task parameter to allow passing in the
        // current ticks, so that the overhead of calling this task isn't included in the elapsed
        // calculation.
        var currentTicks = Stopwatch.GetTimestamp();
        var elapsedTicks = currentTicks - StartTicks;

        // This code is taken from a combination of the static constructor and private GetElapsedDateTimeTicks method in Stopwatch.
        if (Stopwatch.IsHighResolution)
        {
            var tickFrequency = 10000000.0d / (double) Stopwatch.Frequency;
            elapsedTicks = (long) ((double) elapsedTicks * tickFrequency);
        }

        // Now we can get a more human-readable elapsed time. Unfortunately we can't return the TimeSpan
        // as a parameter, as it doesn't implement IConvertible. So we'll just convert it to a string.
        // If you really want to do more with the resulting TimeSpan, you could always refactor this to return the ticks,
        // and create the TimeSpan using property functions as in the DateTime example (the Elapsed property).
        ElapsedTimeSpan = TimeSpan.FromTicks(elapsedTicks).ToString();

        ]]>
      </Code>
    </Task>
  </UsingTask>

</Project>		 

robokiwi.com/blog/2014/07/19/using-msbuild-property-functions-and-inline-tasks-example-doing-performance-calculations/
 gist by DavidMoore

		 */
	}
}
