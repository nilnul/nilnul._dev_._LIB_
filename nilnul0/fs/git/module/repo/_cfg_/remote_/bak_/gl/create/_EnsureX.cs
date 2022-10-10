using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl.create
{
	static public class _EnsureX
	{
		/// <summary>
		/// not create on the server for gitlab will create a repo automatically when pushed
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="svrRepoName"></param>
		/// <returns></returns>
		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.folder_.git_.Top gitTop
			,
			nilnul.fs.git.svr_.gitlab.repo.Name svrRepoName
		)
		{

			if (nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_._GlX.Exe(

				gitTop
			))
			{
				return new _op.result_.explain_.RetTxt("already creatged");
			}
			try
			{
				_CreateX.Exe(
					gitTop
					,
					svrRepoName
				);
				///will throw if http error
				//var r = nilnul.fs.git.svr_.wellknown_.gl.client_.cfged.repo.create_._PostWithTokenOnlyX.Txt(
				//	svrRepoName
				//);
				//return new _op.result_.explain_.RetTxt( r);
				return new _op.result_.explain_.RetTxt();

			}
			catch (Exception e)
			{
				return new _op.result_.explain_.RetTxt(e.ToString());
				//throw;
			}
		}
		[Obsolete()]
		public static string Ensure(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr_.gitlab.repo.Name svrRepoName)
		{

			if (nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_._GlX.Exe(

				gitTop
			))
			{
				return "already creatged";
			}
			try
			{
				_CreateX.Exe(
								gitTop
									,
								svrRepoName
							);

				///will throw if http error
				var r = nilnul.fs.git.svr_.wellknown_.gl.client_.cfged.repo.create_._PostWithTokenOnlyX.Txt(
					svrRepoName
				);



				return r;

			}
			catch (Exception e)
			{
				return e.Message;
				//throw;
			}

		}


		public static string Ensure(nilnul.fs.folder_.git_.Top gitTop, string remoteCfgKey)
		{
			return Ensure(gitTop, new nilnul.fs.git.svr_.gitlab.repo.Name(remoteCfgKey));
		}

		public static nilnul._op.result_.explain_.RetTxt Result(nilnul.fs.folder_.git_.Top gitTop, string remoteCfgKey)
		{
			return Result(gitTop, new nilnul.fs.git.svr_.gitlab.repo.Name(remoteCfgKey));
		}

		public static string Ensure(nilnul.fs.FolderI gitTop, string remoteCfgKey)
		{
			return Ensure(
				new fs.folder_.git_.Top(gitTop), (remoteCfgKey)
			);
		}

	}
}
