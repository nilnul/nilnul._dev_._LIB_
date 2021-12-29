using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb.create
{
	static public class _EnsureX
	{

		
		//static public nilnul.fs.git.module.repo._cfg_._remote.Name KeyCamel = new _remote.Name(KEY_CAMEL);



		//static public nilnul.fs.git.module.repo._cfg_._remote.Name Key = new _remote.Name(KEY_TXT);
		public static nilnul._op.result_.explain_.RetTxt Result(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{

			if (
				nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_.Bb.Exe(

				gitTop
			))
			{
				return new _op.result_.explain_.RetTxt( "already creatged");
			}

			try
			{
				nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb._CreateX.Void(
					gitTop
						,
					svrRepoName
				);

				///this would throw exception
				var r = nilnul.fs.git.svr_.wellknown_.bb.client_.cfged.repo._CreateX.Ret(
								svrRepoName
				);



				return new _op.result_.explain_.RetTxt( r);

			}
			catch (Exception x)
			{
				return _op.result_.explain_.RetTxt.FroXpn( x.ToString());
				//throw;
			}


		}



		public static string Ensure(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
		{
			return Result(gitTop,svrRepoName).ToString();
/*
			if (
				nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_.Bb.Exe(

				gitTop
			))
			{
				return "already creatged";
			}

			try
			{
				nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb._CreateX.Void(
					gitTop
						,
					svrRepoName
				);

				///this would throw exception
				var r = nilnul.fs.git.svr_.wellknown_.bb.client_.cfged.repo._CreateX.Ret(
								svrRepoName
				);



				return r;

			}
			catch (Exception x)
			{
				return x.ToString();
				throw;
			}

	*/
		}

		public static string Ensure(nilnul.fs.folder_.git_.Top gitTop, string remoteCfgKey)
		{
			return Ensure(gitTop, new nilnul.fs.git.svr.repo.Name(remoteCfgKey));
		}
		public static nilnul._op.result_.explain_.RetTxt Result(nilnul.fs.folder_.git_.Top gitTop, string remoteCfgKey)
		{
			return Result(gitTop, new nilnul.fs.git.svr.repo.Name(remoteCfgKey));
		}


		public static string Ensure(nilnul.fs.FolderI gitTop, string remoteCfgKey)
		{
			return Ensure(
				new fs.folder_.git_.Top(gitTop), (remoteCfgKey)
			);
		}


	}
}
