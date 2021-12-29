using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.bak_.vsAwGlBb
{
	[Obsolete(nameof(remotes_.awGlBbVs.powsub.next._EnsureSvrFirstX))]
	static public class _EnsureX
	{
		[Obsolete()]
		static public IEnumerable<string> Txts(string gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return Txts( fs.folder_.git_.Top.FroAddress(gitTop), svrRepoName, git);
		}
		static public IEnumerable<nilnul._op.result_.explain_.RetTxt> Results(string gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return Results( fs.folder_.git_.Top.FroAddress(gitTop), svrRepoName, git);
		}



		[Obsolete()]
		static public IEnumerable<string> Txts(nilnul.fs.folder_.git_.Top gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			yield return remote_.bak_.vs.create._EnsureX.Ensure(gitTop, svrRepoName);
			yield return remote_.bak_.aw.create_.ohio._EnsureX.Ensure(gitTop, svrRepoName);
			yield return remote_.bak_.gl.create._EnsureX.Ensure(gitTop, svrRepoName);
			yield return remote_.bak_.bb.create._EnsureX.Ensure(gitTop, svrRepoName);
			yield return remote_.bak_.vsAwGlBb.create._EnsureX.Ensure_result(gitTop, git);

		}

		static public IEnumerable<nilnul._op.result_.explain_.RetTxt> Results(nilnul.fs.folder_.git_.Top gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			yield return remote_.bak_.vs.create._EnsureX.Result(gitTop, svrRepoName);

			yield return remote_.bak_.aw.create_.ohio._EnsureX.Result(gitTop, svrRepoName);
			yield return remote_.bak_.gl.create._EnsureX.Result(gitTop, svrRepoName);
			yield return remote_.bak_.bb.create._EnsureX.Result(gitTop, svrRepoName);
			yield return remote_.bak_.vsAwGlBb.create._EnsureX.Result(gitTop, git);

		}


		//static public IEnumerable<KeyValuePair<string, nilnul._op.result_.explain_.RetTxt>> ResultsKeyed(nilnul.fs.folder_.git_.Top gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		//{

		//	yield return new KeyValuePair<string, _op.result_.explain_.RetTxt>( remote_.bak_.vs.create._EnsureX.Result(gitTop, svrRepoName)
		//	);
		//	yield return remote_.bak_.aw.create_.ohio._EnsureX.Result(gitTop, svrRepoName);
		//	yield return remote_.bak_.gl.create._EnsureX.Result(gitTop, svrRepoName);
		//	yield return remote_.bak_.bb.create._EnsureX.Result(gitTop, svrRepoName);
		//	yield return remote_.bak_.vsAwGlBb.create._EnsureX.Result(gitTop, git);

		//}



		[Obsolete()]

		static public IEnumerable<string> Txts(nilnul.fs.FolderI gitTop, string svrRepoName)
		{
			return Txts(new fs.folder_.git_.Top(gitTop), svrRepoName);

		}



	}
}
