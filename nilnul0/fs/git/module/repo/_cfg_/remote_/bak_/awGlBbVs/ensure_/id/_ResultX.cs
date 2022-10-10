using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs.ensure_.id
{
	static public class _ResultX
	{
		public static nilnul._op.result_.explain_.RetTxt Exe(
			nilnul.fs.git.ModuleI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			try
			{
				return new _op.result_.explain_.RetTxt(
					_IdX.Msg(gitTop, git)
				);
			}
			catch (Exception e)
			{
				return _op.result_.explain_.RetTxt.FroXpn(e.Message);
			}

		}
		public static nilnul._op.result_.explain_.RetTxt Exe(
			nilnul.fs.git.Module gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			return Exe(gitTop as nilnul.fs.git.ModuleI, git);
		}

		public static nilnul._op.result_.explain_.RetTxt Exe(
			nilnul.fs.folder_.git_.Top gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			return Exe(new nilnul.fs.git.Module(gitTop), git);
		}

		public static nilnul._op.result_.explain_.RetTxt Exe(
			nilnul.fs.FolderI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			return Exe(new nilnul.fs.folder_.git_.Top(gitTop), git);
		}
	}
}