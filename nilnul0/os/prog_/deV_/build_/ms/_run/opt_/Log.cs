using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.os.prog_.deV_.build_.ms._run.opt_
{
	class Log
	{
		/*
		 REM you'll have to find the "latest" version of where msbuild.exe resides on your machine.. here are some popular versions/locations
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v2.0.50727
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v3.5
REM set msBuildDir=%WINDIR%\Microsoft.NET\Framework\v4.0.30319
REM set msBuildDir=C:\Program Files (x86)\MSBuild\12.0\Bin
set msBuildDir=C:\Program Files (x86)\MSBuild\14.0\Bin

call "%msBuildDir%\msbuild.exe"  MySolution.sln /p:Configuration=Release /l:FileLogger,Microsoft.Build.Engine;logfile=Manual_MSBuild_ReleaseVersion_LOG.log
set msBuildDir=
		 */

		///logger:FileLogger,Microsoft.Build.Engine;logfile=<filePath>
	}

}
