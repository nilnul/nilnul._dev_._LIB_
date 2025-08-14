using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.win.prog_.deV_.build.run_
{
	public class Result
		: nilnul.win.prog.run_.Result0
	{
		

		public Result() : base(
			MsBuild.Defaulted
		)
		{
		}


		public win.prog._run.Result result_ofFile(string x) {
			var parentDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(x);
			return run(
				parentDoc.parent.ToString()
				,
				new[] {

				"-Tp"
				,
				parentDoc.doc.ToString()
				}
			);
		}

		static public Result Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Result>.Instance;
			}
		}

	}
}
