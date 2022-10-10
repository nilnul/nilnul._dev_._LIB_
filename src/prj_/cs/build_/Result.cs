using nilnul.fs.address_.spear_;
using nilnul.win.prog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.build_
{
	static public class _ResultX
	{
		

		static public win.prog._run.Result BuildSyn_assumeCs(string prjFile)
		{
			return Result_assumeCs(ParentDoc.Parse(prjFile));
		}





		public static win.prog._run.Result Result_assumeCs(ParentDoc located)
		{
			return nilnul.win.prog_.deV_.build.run_.Result.Singleton.run(
				located.parent.ToString()
				,
				new nilnul.win.prog._run.Args(
					located.doc.ToString()
					
				) 
			);
		}
	
		
		static public win.prog._run.Result Result_assumeCs_cfgAsRelease(string prjFile)
		{
			return Result_assumeCs_cfgAsRelease(
				ParentDoc.Parse(prjFile)
			);
		}

		public static win.prog._run.Result Result_assumeCs_cfgAsRelease(ParentDoc located)
		{
			return Result_assumeCs_assumeCfg(located, "Release");

		}
		public static win.prog._run.Result Result_assumeCs_cfgAsSymbols(string located)
		{
			return Result_assumeCs_cfgAsSymbols(ParentDoc.Parse( located ));
		}
		public static win.prog._run.Result Result_assumeCs_cfgAsSymbols(nilnul.fs.address_.SpearI located)
		{
			return Result_assumeCs_cfgAsSymbols(new ParentDoc( located ));
		}
		public static win.prog._run.Result Result_assumeCs_cfgAsSymbols(ParentDoc located)
		{
			return Result_assumeCs_assumeCfg(located, "Symbols");
		}

		public static win.prog._run.Result Result_assumeCs_assumeCfg(string located, string config)
		{
			return Result_assumeCs_assumeCfg(
				ParentDoc.Parse(located)
				,
				config
			);
		}
		public static win.prog._run.Result Result_assumeCs_assumeCfg(ParentDoc located, string config)
		{
			return nilnul.win.prog_.deV_.build.run_.Result.Singleton.run(
				located.parent.ToString()
				,
				new nilnul.win.prog._run.Args(
					located.doc.ToString()
					,
					$"/p:Configuration={config}"
				)	//.ToString()
			);
		}

		public static  win.prog._run.Result ThrowXpn(ParentDoc located ,string config)
		{
			var r = nilnul.dev.src.prj_.cs.build_._ResultX.Result_assumeCs_assumeCfg(
				located
				,
				config
			);

			

			nilnul.bit.vow_.True1.Vow(r.exitCode == 0, r.ToString());
			return r;

		}


	}
}
