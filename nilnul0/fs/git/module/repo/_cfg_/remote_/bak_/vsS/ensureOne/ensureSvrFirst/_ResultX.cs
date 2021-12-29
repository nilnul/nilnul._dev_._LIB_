using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vss.ensureOne.ensureSvrFirst
{
	static public class _ResultX
	{

		public static nilnul._op.result_.Explain<bool> NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr_.vs.repo.Name svrRepoName
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
				return _op.result_.Explain<bool>.FroXpn(e.ToString()); /*when name too long*/
				//throw;
			}
		}

		public static nilnul._op.result_.Explain<bool> NewlyCreated(nilnul.fs.git.ModuleI gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return NewlyCreated(gitTop,  nilnul.fs.git.svr_.vs.repo.Name.ByEncode(svrRepoName));

			try
			{
				return NewlyCreated(gitTop,  nilnul.fs.git.svr_.vs.repo.Name.ByEncode(svrRepoName));
			}
			catch (Exception e)
			{
				return _op.result_.Explain<bool>.FroXpn(e.ToString()); /*when name too long*/
			}
		}

		public static nilnul._op.result_.Explain<bool> NewlyCreated(string gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return NewlyCreated( nilnul.fs.git.Module.FroAddress(gitTop), svrRepoName,git);
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
			return NewlyCreated(gitTop,  nilnul.fs.git.svr_.vs.repo.Name.ByEncode(svrRepoName));
		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(nilnul.fs.FolderI gitTop, string svrRepoName)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop), (svrRepoName)
			);
		}

	}
}
