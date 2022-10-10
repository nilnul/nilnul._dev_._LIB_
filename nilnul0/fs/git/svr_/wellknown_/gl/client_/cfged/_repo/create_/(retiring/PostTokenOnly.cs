using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.gl.client_.cfged.repo.create_
{
	[Obsolete()]
	static public class _PostWithTokenOnlyX
	{
		static public string Txt( nilnul.fs.git.svr_.gitlab.repo.Name prj)
		{
			 return  nilnul.fs.git.svr_.gitlab.acc_.token._repo._CreateX.Txt(new nilnul.web._url._query._entry.Term( Cfged.Ensure().Password), prj);
		}
		static public string Txt(string prj)
		{
			 return Txt(new nilnul.fs.git.svr_.gitlab.repo.Name( prj));
		}

		[Obsolete()]
		static public string Result( nilnul.fs.git.svr_.gitlab.repo.Name prj)
		{
			 return  nilnul.fs.git.svr_.gitlab.acc_.token._repo._CreateX.Result(new web._url._query._entry.Term(Cfged.Ensure().Password), prj);
		}

		static public nilnul._op.result_.explain_.RetTxt Result1( nilnul.fs.git.svr_.gitlab.repo.Name prj)
		{
			 return  nilnul.fs.git.svr_.gitlab.acc_.token._repo._CreateX.Result1(new web._url._query._entry.Term(Cfged.Ensure().Password), prj);
		}

		[Obsolete()]
		static public string Result(string prj)
		{
			return Result(new nilnul.fs.git.svr_.gitlab.repo.Name( prj));
		}

		static public nilnul._op.result_.explain_.RetTxt Result1(string prj)
		{
			return Result1(new nilnul.fs.git.svr_.gitlab.repo.Name( prj));
		}

		public static string GenUrl(string repoName)
		{
			return GenUrl(new nilnul.fs.git.svr_.gitlab.repo.Name(repoName));
		}
		/// <summary>
		/// gen the url usalbe in git config.
		/// </summary>
		/// <param name="repoName"></param>
		/// <returns></returns>
		public static string GenUrl(nilnul.fs.git.svr_.gitlab.repo.Name repoName)
		{
			return $"https://gitlab.com/{Cfged.Ensure().UserName}/{repoName}.git";
			//throw new NotImplementedException();
		}


	}
}
