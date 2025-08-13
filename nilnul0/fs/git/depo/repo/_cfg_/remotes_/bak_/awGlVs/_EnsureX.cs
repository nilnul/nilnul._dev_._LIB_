using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.bak_.awGlVs
{
	/// <summary>
	/// ensure svr first
	/// </summary>
	static public class _EnsureX
	{
		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(nilnul.fs.git.ModuleI gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			yield return remote_.bak_.aws.ensureOne_.ohio.ensureSvrFirst._ResultX.NewlyCreated(gitTop, svrRepoName, git);

			yield return new _op.result_.Explain<bool>(remote_.bak_.gls._EnsureOneX.NewlyCreated(gitTop, svrRepoName, git));
			//yield return remote_.bak_.bbs.ensureOne.ensureSvrFirst._ResultX.NewlyCreated(gitTop, svrRepoName, git);

			yield return remote_.bak_.vss.ensureOne.ensureSvrFirst._ResultX.NewlyCreated(gitTop, svrRepoName, git); 

			//yield return remote_.bak_..aw.vsAwGlBb.create._EnsureX.Result(gitTop, git);

		}

		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(
			nilnul.fs.git.Module gitTop
			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null)
		{
			return NewlyCreatedS(gitTop as nilnul.fs.git.ModuleI, svrRepoName, git);

		}

		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(
			nilnul.fs.folder_.git_.Top gitTop
			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null)
		{
			return NewlyCreatedS(gitTop, svrRepoName, git);

		}




		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(
			nilnul.fs.FolderI gitTop
			, 
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null
			
		)
		{
			return NewlyCreatedS(new fs.folder_.git_.Top(gitTop), svrRepoName,git);

		}

		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(string gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return NewlyCreatedS(nilnul.fs.Folder.FroAddress(gitTop), svrRepoName, git);
		}



	}
}
