using nilnul.fs._address;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.deV_
{

	/*
	 * https://stackoverflow.com/questions/328017/path-to-msbuild
	 Poking around the registry, it looks like

HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\2.0
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\3.5
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0
may be what you're after; fire up regedit.exe and have a look.

Query via command line (per Nikolay Botev)
reg.exe query "HKLM\SOFTWARE\Microsoft\MSBuild\ToolsVersions\4.0" /v MSBuildToolsPath
Query via PowerShell (per MovGP0)
dir HKLM:\SOFTWARE\Microsoft\MSBuild\ToolsVersions\
	 */

	/*%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe
	 vswhere.exe is a standalone executable, so you can download and run it from anywhere you have an internet connection. That means your build scripts can check if the environment they're running on is setup correctly, to name one option.
	 */

	/*
	 "C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe"
	 */

	/*Starting with MSBuild 2017 (v15), MSBuild is now installed in a folder under each version of Visual Studio

Here are some examples of where MSBuild.exe is found on my machine:

C:\windows\Microsoft.NET\Framework\v2.0.50727\MSBuild.exe  (v2.0.50727.8745  32-bit)
C:\windows\Microsoft.NET\Framework64\v2.0.50727\MSBuild.exe  (v2.0.50727.8745  64-bit)
C:\Windows\Microsoft.NET\Framework\v3.5\MSBuild.exe  (v3.5.30729.8763 32-bit)
C:\Windows\Microsoft.NET\Framework64\v3.5\MSBuild.exe  (v3.5.30729.8763 64-bit)
C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe  (v4.7.2053.0 32-bit)
C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe  (v4.7.2053.0 64-bit)
C:\Program Files (x86)\MSBuild\12.0\Bin\MSBuild.exe  (v12.0.21005.1 32-bit)
C:\Program Files (x86)\MSBuild\12.0\Bin\amd64\MSBuild.exe (v12.0.21005.1 64-bit)
C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe  (v14.0.25420.1 32-bit)
C:\Program Files (x86)\MSBuild\14.0\Bin\amd64\MSBuild.exe  (v14.0.25420.1 64-bit)
C:\Program Files (x86)\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin\MSBuild.exe  (v15.1.1012+g251a9aec17 32-bit)
C:\Program Files (x86)\Microsoft Visual Studio\2017\BuildTools\MSBuild\15.0\Bin\amd64\MSBuild.exe (v15.1.1012+g251a9aec17 64-bit)
C:\Program Files (x86)\Microsoft Visual Studio\2017\{LicenceName}\MSBuild\Bin\MSBuild.exe (v15.1.1012.6693 32-bit)
C:\Program Files (x86)\Microsoft Visual Studio\2017\{LicenceName}\MSBuild\Bin\amd64\MSBuild.exe (v15.1.1012.6693 64-bit)
share  edit  follow 
edited Nov 16 '18 at 4:05
answered Aug 18 '17 at 20:01

cowlinator
3,66644 gold badges1919 silver badges3838 bronze badges
According to a previous answer, 2017 does in fact store this information in the registry.*/

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	///	 vs Compile:
	///		compile src files
	///		build prjs, slns and dependencies.
	/// </remarks>
	public class MsBuild: nilnul.win.Prog
	{
		public const string DivInVs = @"MSBuild\Current\Bin\";
		public const string Dnt = @"MSBuild.exe";
		public static Denotation Denotation = new nilnul.fs._address.Denotation(
			DivInVs
			,Dnt
			);

		


		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <example>
		/// C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\MSBuild\Current\Bin\MSBuild.exe
		/// </example>
		static public nilnul.fs.address_.SpearI Path() {
			return new nilnul.fs.address_.spear_.ParentDocument(
				prog_.VisualStudio.yr2019Community
				,
				Denotation
			);
		}
		public MsBuild() : base(Path())
		{
		}

		public MsBuild(string s):base(s)
		{

		}

		public MsBuild(SpearI val) : base(val)
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

		static public MsBuild Defaulted = new MsBuild(Path());

	}
}
