using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.deV_.build
{
	public class Run: nilnul.win.prog.Run1
	{

		public Run() : base(MsBuild.Path())
		{
		}
		/*
		 .nuget\nuget restore "%BuildPath%\DotnetMsbuildProject.sln"
		 */
		 void build() {
			/*
			 /property:Configuration=Release

			  or /p:
			 */

		}

		/*
		 SET MSBuildPath=C:\Program Files (x86)\MSBuild\14.0\bin\amd64\
SET BuildPath=C:\MyProjects\BatchFileDemo

CD %BuildPath%

.nuget\nuget restore "%BuildPath%\DotnetMsbuildProject.sln"

"%MSBuildPath%\MSBuild.exe" "%BuildPath%\DotnetMsbuildProject.sln" /t:Clean;Build /p:Configuration=Release /p:TargetFramework=v4.0  /p:SkipPostSharp=True /p:RunCodeAnalysis=False /p:VisualStudioVersion=11.0

"%MSBuildPath%\MSBuild.exe" "%BuildPath%\DotnetMsbuildProject.csproj" /t:Build /p:DeployOnBuild=true /p:Configuration=Release /p:TargetFramework=v4.0 /p:VisualStudioVersion=11.0 /p:PublishProfile=OnRoot_Output /p:RestorePackages=false /p:SkipPostSharp=true

		 */
		 void publish() { }


		static public Run Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Run>.Instance;
			}
		}

	}
}
