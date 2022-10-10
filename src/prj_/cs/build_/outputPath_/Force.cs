using nilnul.fs.address_.spear_;
using nilnul.win.prog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.build_.outputPath_
{
	/// <summary>
	/// rebuild, even there are no changes
	/// </summary>
	static public class _ForceX
	{
		

		


		public static win.prog._run.Result Result_assumeCs_assumeCfg(ParentDoc located, string config)
		{
			return nilnul.win.prog_.deV_.build.run_.Result.Singleton.run(
				located.parent.ToString()
				,
				new nilnul.win.prog._run.Args(
					located.doc.ToString()
					,
					$"/p:Configuration={config}"
					,
					$@"/p:OutputPath=bin\{config}\"
					,
					$"/t:Rebuild"


				)   //.ToString()
			);
		}

		public static win.prog._run.Result Result_assumeCs_cfgAsSymbol(ParentDoc located)
		{
			return Result_assumeCs_assumeCfg(located, "Symbol");
		}
		public static win.prog._run.Result Result_assumeCs_cfgAsRelease(ParentDoc located)
		{
			return Result_assumeCs_assumeCfg(located, "Release");

		}
		static public win.prog._run.Result Result_assumeCs_cfgAsRelease(string prjFile)
		{
			return Result_assumeCs_cfgAsRelease(
				ParentDoc.Parse(prjFile)
			);
		}
		public static win.prog._run.Result Result_assumeCs_cfgAsSymbol(string located)
		{
			return Result_assumeCs_cfgAsSymbol(ParentDoc.Parse( located ));
		}
		public static win.prog._run.Result Result_assumeCs_cfgAsSymbol(nilnul.fs.address_.SpearI located)
		{
			return Result_assumeCs_cfgAsSymbol(new ParentDoc( located ));
		}
		public static win.prog._run.Result Result_assumeCs_assumeCfg(string located, string config)
		{
			return Result_assumeCs_assumeCfg(
				ParentDoc.Parse(located)
				,
				config
			);
		}
		public static  win.prog._run.Result ThrowXpn(ParentDoc located ,string config)
		{
			var r = Result_assumeCs_assumeCfg(
				located
				,
				config
			);

			//if (r.exitCode!=0)
			//{
			//	Trace.TraceError(
			//		$"err when rebuilding {located} with config:{config}:"
			//		+"\r\n"
			//		+

			//		r.ToString()
			//	);


			//}

			nilnul.bit.vow_.True1.Vow(r.exitCode == 0, r.ToString());
			return r;

		}


	}
}
