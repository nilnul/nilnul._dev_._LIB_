using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs.create
{
	static public class _EnsureX
	{
		[Obsolete()]
		public static string ResultTxt(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr_.vs.repo.Name repoName)
		{
			return Result(gitTop, repoName).ToString();
		}

		public static nilnul._op.result_.explain_.RetTxt Result(nilnul.fs.folder_.git_.Top gitTop, nilnul.fs.git.svr_.vs.repo.Name repoName)
		{
			if (nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_.Vs.Exe(
				gitTop
			))
			{
				return new _op.result_.explain_.RetTxt( $@"bak_.vs already created");
			}
			try
			{
				nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs._CreateX.Void(
					gitTop
						,
					repoName
				);

				var r = nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.Ret(
						repoName
				); ;

				return new _op.result_.explain_.RetTxt(r);

			}
			catch (System.Net.WebException e) {

				//if (e.Error.GetType().Name == "WebException")
				//{
					//WebException we =e.Error;
					HttpWebResponse response = (System.Net.HttpWebResponse)e.Response;
				if (response.StatusCode == HttpStatusCode.BadRequest) {
					return _op.result_.explain_.RetTxt.FroXpn("badRequest.possibly the repo has already existed:  " + e.ToString());

				}
				else
				{
					return _op.result_.explain_.RetTxt.FroXpn(e.ToString());

				}
						
				
			}

			catch (Exception e)
			{
				return _op.result_.explain_.RetTxt.FroXpn(e.ToString());
				//throw;
			}
		}
		

		[Obsolete()]
		public static string Ensure(nilnul.fs.folder_.git_.Top gitTop, string remoteCfgKey)
		{
			return ResultTxt(gitTop,  nilnul.fs.git.svr_.vs.repo.Name.ByEncode(remoteCfgKey));
		}

		public static nilnul._op.result_.explain_.RetTxt Result(nilnul.fs.folder_.git_.Top gitTop, string repoName)
		{
			return Result(gitTop,  nilnul.fs.git.svr_.vs.repo.Name.ByEncode(repoName));
		}

		[Obsolete()]
		public static string Ensure(nilnul.fs.FolderI gitTop, string remoteCfgKey)
		{
			return Ensure(
				new fs.folder_.git_.Top(gitTop), (remoteCfgKey)
			);
		}
		public static nilnul._op.result_.explain_.RetTxt Result(string gitTop, string remoteCfgKey)
		{
			return Result(
				 fs.folder_.git_.Top.FroAddress(gitTop)
				, 
				 nilnul.fs.git.svr_.vs.repo.Name.ByEncode(remoteCfgKey)
			);
		}


	}
}
