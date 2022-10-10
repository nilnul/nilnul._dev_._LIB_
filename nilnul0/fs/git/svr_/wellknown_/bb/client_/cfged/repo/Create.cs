using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.bb.client_.cfged.repo
{
	//extern alias git;
	static public class _CreateX
	{

		static public string Ret(string prj)
		{
			 return new nilnul.fs.git.svr_.bitBucket.client.prjs.Add(Cfged.Singleton).exe(prj);
		}
		static public string Result(string prj)
		{
			 return new nilnul.fs.git.svr_.bitBucket.client.prjs.Add(Cfged.Singleton).exe_errAsMsg(prj);
	
		}

		public static string GenUrl(string repoName)
		{
			return $"https://{Bb.DOMAIN}/{Cfged.Credential.UserName}/{repoName}.git";

		}


	}
}
