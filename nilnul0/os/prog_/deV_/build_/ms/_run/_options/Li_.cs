namespace nilnul.os.prog_.deV_.build_.ms._run._options
{
	enum Li_ {
		/// <summary>
		/// eg:
		///		MSBuild /m
		///		use all processors.
		///	eg:
		///		/m:2
		/// </summary>
		/// alias:
		///		multiprocessors
		M
			,
		/// <summary>
		/// msbuild /version
		/// </summary>
		Version
			,
		/// <summary>
		/// msbuild /nologo
		/// </summary>
		Nologo
			,
		/// <summary>
		/// For the most part, MSBuild is being verbose with its output. You could edit it down by setting the /verbosity switch to minimal.
		/// </summary>
		/// <remarks>
		/// eg:
		///		/verbosity:minimal
		///	eg:
		///		-v:normal
		/// </remarks>
		Verbose
			,
		/// <summary>
		/// MSBuild will only run the first Target specified in the Project element. To run a different Target instead, you'll have to pass in the Target name via the "/target" switch (or "/t" for short). You can also instruct MSBuild to execute multiple Targets by separating the Target names with semicolons.
		/// </summary>
		/// <remarks>
		///	eg:
		///			/t:EchoGreeting;EchoDate
		/// </remarks>
		Target
			,
		///
		///
		/// <summary>
		///  Properties can be set when executing an MSBuild script by using the /property switch (or /p for short)
		/// </summary>
		/// <remarks>
		///  eg:
		///		/p:Configuration:Test;BuildPlatform:x86
		/// </remarks>
		Property
			,
		/// <summary>
		/// binary log
		/// the command line:
		///		/bl
		/// Double-click the .binlog file to open it in MSBuild Structured Log Viewer
		/// </summary>
		/// <remarks>
		///The binary log contains and exposes all environment variables from the machine that the build ran on. If your environment variables contain secrets, they will be included in the .binlog file in plaintext.
		/// </remarks>
		///
		///Reading MSBuild .binlogs programmatically
		///Reference the MSBuild.StructuredLogger NuGet package. All you need is to reference StructuredLogger.dll from that package.
		///You may also need to reference MSBuild Microsoft.Build.Framework.
		/// 
		///msbuildlog.com
		///

		Bl
	}
}
