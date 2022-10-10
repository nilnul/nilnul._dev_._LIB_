using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.bak_.gls.ensureOne
{

	static public class _EnsureSvrFirstX
	{
		public static bool Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,nilnul.win.program_.Git git=null
		)
		{
			if (nilnul.fs.git.module._cfg_.remote_.bak_.gls.vers._AnyX.Be(
				gitTop
			))
			{
				return ("already created");
			}
			var r = nilnul.fs.git.svr_.gl.client_.cfged.repo..client__.ohio.client_.cfged.repo.create._EnsureX.Ret(
				svrRepoName
			);
			nilnul.fs.git.module._cfg_.remote_.bak_.aw_.newest.create_._OhioX.Void(
				gitTop
					,
				svrRepoName
			);
			return r;
		}
		public static string Msg(nilnul.fs.git.ModuleI gitTop, string svrRepoName, nilnul.win.program_.Git git=null)
		{
			return Msg(gitTop , new svr.repo.Name( svrRepoName));
		}


		public static string Msg(nilnul.fs.git.Module3 gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return Msg(gitTop as nilnul.fs.git.ModuleI, svrRepoName);
		}


		public static string Msg(nilnul.fs.folder_.git_.Top2 gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return Msg(new nilnul.fs.git.Module3(gitTop), svrRepoName);
		}

		public static string Msg(nilnul.fs.folder_.git_.Top2 gitTop, string svrRepoName)
		{
			return Msg(gitTop, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}

		
		public static string Msg(nilnul.fs.FolderI3 gitTop, string svrRepoName)
		{
			return Msg(
				new fs.folder_.git_.Top2(gitTop), (svrRepoName)
			);
		}

	}
}
