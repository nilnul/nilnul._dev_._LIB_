using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.create_.ohio
{
	
		static public class _EnsureX
		{
			public static nilnul._op.result_.explain_.RetTxt Result(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
			{

				if (nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_._AwX.Exe(

					gitTop
				))
				{
					return new _op.result_.explain_.RetTxt( "already created");
				}

				try
				{
					nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.create_._UsEastX1.Void(
						gitTop
							,
						svrRepoName
					);

					var r = nilnul.fs.git.svr_.wellknown_.aw_.ohio.client_.cfged.repo._CreateX.RetTxt(
						svrRepoName
					);



					return new _op.result_.explain_.RetTxt( r);
				}
				catch (Exception x)
				{
					return  _op.result_.explain_.RetTxt.FroXpn( x.ToString());
					//throw;
				}

			}


			/// <summary>
			/// if aws is not configed, create the repo on the svr and cfg it.
			/// </summary>
			/// <param name="gitTop"></param>
			/// <param name="svrRepoName"></param>
			/// <returns></returns>
			[Obsolete()]
		public static string Ensure(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr.repo.Name svrRepoName)
			{

				if (nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_._AwX.Exe(

					gitTop
				))
				{
					return "already created";
				}

				try
				{
					nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.create_._UsEastX1.Void(
						gitTop
							,
						svrRepoName
					);

					var r = nilnul.fs.git.svr_.wellknown_.aw_.ohio.client_.cfged.repo._CreateX.RetTxt(
						svrRepoName
					);



					return r;
				}
				catch (Exception x)
				{
					return x.ToString();
					throw;
				}

			}
		[Obsolete()]

			public static string Ensure(nilnul.fs.folder_.git_.Top gitTop, string svrRepoName)
			{
				return Ensure(gitTop, new nilnul.fs.git.svr.repo.Name(svrRepoName));
			}

			public static nilnul._op.result_.explain_.RetTxt Result(nilnul.fs.folder_.git_.Top gitTop, string svrRepoName)
			{
				return Result(gitTop, new nilnul.fs.git.svr.repo.Name(svrRepoName));
			}

		[Obsolete()]
			public static string Ensure(nilnul.fs.FolderI gitTop, string svrRepoName)
			{
				return Ensure(
					new fs.folder_.git_.Top(gitTop), (svrRepoName)
				);
			}

		}
	}
