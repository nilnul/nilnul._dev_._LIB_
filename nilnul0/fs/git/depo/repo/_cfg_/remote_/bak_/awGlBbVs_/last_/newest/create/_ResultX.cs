using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs_.last_.next.create
{
	static public class _ResultX
	{
		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.git.ModuleI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{

			try
			{
				

				return new _op.result_.explain_.RetTxt($"created fro {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(_CreateX.Urls(gitTop,git))}");



			}
			catch (Exception e)
			{
				return _op.result_.explain_.RetTxt.FroXpn(e.Message);
				//throw;
			}

		}
		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.git.Module gitTop,
			nilnul.win.prog_.Git git = null
		)
		=> Result(gitTop as ModuleI, git);

		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.folder_.git_.Top gitTop,
			nilnul.win.prog_.Git git = null
		)
		=> Result(new nilnul.fs.git.Module(gitTop), git);
	}
}
