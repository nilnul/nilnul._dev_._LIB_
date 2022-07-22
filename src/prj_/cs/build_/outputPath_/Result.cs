using nilnul.fs.address_.spear_;
using nilnul.win.prog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.build_.outputPath_
{

	/// <summary>
	/// keeping get the error:"
	///  You may be seeing this message because you are trying to build a project without a solution file, and have specified a non-default Configuration or Platform that doesn't exist for this project
	///  "
	///  append the outpath to work around.
	///  It seems there might be issues at project with long path.
	/// </summary>
	static public class _ResultX
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

				)	//.ToString()
			);
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
			var r =Result_assumeCs_assumeCfg(
				located
				,
				config
			);

			

			nilnul.bit.vow_.True1.Vow(r.exitCode == 0, r.ToString());
			return r;

		}


	}
}
