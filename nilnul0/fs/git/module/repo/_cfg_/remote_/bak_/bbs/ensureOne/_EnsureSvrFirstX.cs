using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.bbs.ensureOne
{

	static public class _EnsureSvrFirstX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			, nilnul.win.prog_.Git git = null
		)
		{
			if (nilnul.fs.git.module.repo._cfg_.remote_.bak_.bbs.vers._AnyX.Be(
				gitTop
				,git
			))
			{
				return false;
			}

			var r = nilnul.fs.git.svr_.bb.client_.cfged.repo.create._EnsureX.Ret(
				svrRepoName,git
			);
			nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb_.newest.create_._WithAccX.Exe(
				gitTop
					,
				svrRepoName
				,git
			);
			return true;
		}

		public static bool NewlyCreated(nilnul.fs.git.ModuleI gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return NewlyCreated(gitTop, new svr.repo.Name(svrRepoName));
		}


		public static bool NewlyCreated(nilnul.fs.git.Module gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return NewlyCreated(gitTop as nilnul.fs.git.ModuleI, svrRepoName);
		}


		public static bool NewlyCreated(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return NewlyCreated(new nilnul.fs.git.Module(gitTop), svrRepoName);
		}

		public static bool NewlyCreated(nilnul.fs.folder_.git_.Top gitTop, string svrRepoName)
		{
			return NewlyCreated(gitTop, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}


		public static bool NewlyCreated(nilnul.fs.FolderI gitTop, string svrRepoName)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop), (svrRepoName)
			);
		}

	}
}
