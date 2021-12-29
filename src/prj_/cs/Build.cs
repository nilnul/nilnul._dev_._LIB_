using nilnul.fs.address_.spear_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs
{
	static public class _BuildX
	{
		static public void Build_assumeCs(string prjFile)
		{
			nilnul.win.prog_.deV_.build.Run.Singleton.run(
				prjFile


			);
		}

		static public void BuildSyn_assumeCs(string prjFile)
		{
			nilnul.win.prog_.deV_.build.Run.Singleton.runWaitedDispose(
				prjFile
			);
		}





		public static void Build_assumeCs(ParentDoc located)
		{
			Build_assumeCs(located.ToString());
		}
		public static void BuildSyn_assumeCs(ParentDoc located)
		{
			BuildSyn_assumeCs(located.ToString());
		}

		public static void BuildSynRelease_assumeCs(ParentDoc located)
		{
			nilnul.win.prog_.deV_.build.Run.Singleton.runWaitedDispose(
				new nilnul.win.prog._run.Args(
					located.doc.ToString()
					,
					"/p:Configuration=Release"
				).ToString()
				,
				located.parent.ToString()
			);

		}
		public static void Syn_assumeCs_assumeCfg(ParentDoc located, string config)
		{
			nilnul.win.prog_.deV_.build.Run.Singleton.runWaitedDispose(
				new nilnul.win.prog._run.Args(
					located.doc.ToString()
					,
					$"/p:Configuration={config}"
				).ToString()
				,
				located.parent.ToString()
			);
		}

		public static void Syn_assumeCs_cfgAsSymbols(ParentDoc located)
		{
			Syn_assumeCs_assumeCfg(located, "Symbols");
		}

		public static void Syn_assumeCs_cfgAsSymbols(string located)
		{
			Syn_assumeCs_cfgAsSymbols(ParentDoc.Parse( located ));
		}
		public static void Syn_assumeCs_cfgAsSymbols(nilnul.fs.address_.SpearI located)
		{
			Syn_assumeCs_cfgAsSymbols(new ParentDoc( located ));
		}

		static public void BuildSynRelease_assumeCs(string prjFile)
		{
			BuildSynRelease_assumeCs(
				ParentDoc.Parse(prjFile)
			);
		}
	}
}
