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
using nilnul.fs.folder_.git_;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.bak_.awGlBbVs.ensure
{
	static public class _UpsertOmegaX
	{
		static public string Msg(nilnul.fs.git.ModuleI gitTop, string svrRepoName
			, nilnul.win.prog_.Git git = null
			)
		{
			var newlyCreatedS = _EnsureX.NewlyCreatedS(gitTop, svrRepoName, git).ToArray();


			if (newlyCreatedS.Any(x => x.ret))
			{
				var urls = nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs_.last_.next._CreateX.Urls(gitTop, git);
				return $@"created awGlBbVs_last_next of urls{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(urls)}";
			}
			else
			{
				return remote_.bak_.awGlBbVs_.aliases.vers.last.nulable.urls._EnsureX.Msg(
					gitTop,
					git);
			}
		}
		public static string Msg(
			nilnul.fs.git.Module top2,
			string svrRepoName,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(top2 as nilnul.fs.git.ModuleI, svrRepoName, git);
		}

		public static string Msg(
			Top top2,
			string svrRepoName,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.git.Module(top2), svrRepoName, git);
		}


		static public string Msg(nilnul.fs.FolderI gitTop, string svrRepoName
			,
			nilnul.win.prog_.Git git = null
)
		{
			return Msg(new fs.folder_.git_.Top(gitTop), svrRepoName);

		}


		static public string Msg(string gitTop, string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return Msg( fs.Folder.FroAddress(gitTop), svrRepoName, git);
		}
		



	}
}
