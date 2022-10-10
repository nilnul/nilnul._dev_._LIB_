using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.bbs.ensureOne.ensureSvrFirst
{
	static public class _ResultX
	{

		public static nilnul._op.result_.Explain<bool> NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			, nilnul.win.prog_.Git git = null
		)
		{
			try
			{
				return new nilnul._op.result_.Explain<bool>(
					_EnsureSvrFirstX.NewlyCreated(gitTop, svrRepoName, git)
				);
			}
			catch (Exception e)
			{
				return _op.result_.Explain<bool>.FroXpn(e.ToString());
				//throw;
			}
		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(nilnul.fs.git.ModuleI gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return NewlyCreated(gitTop, new svr.repo.Name(svrRepoName));
		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(nilnul.fs.git.Module gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return NewlyCreated(gitTop as nilnul.fs.git.ModuleI, svrRepoName);
		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return NewlyCreated(new nilnul.fs.git.Module(gitTop), svrRepoName);
		}

		public static nilnul._op.result_.Explain<bool> NewlyCreated(nilnul.fs.folder_.git_.Top gitTop, string svrRepoName)
		{
			return NewlyCreated(gitTop, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(nilnul.fs.FolderI gitTop, string svrRepoName)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop), (svrRepoName)
			);
		}

	}
}
