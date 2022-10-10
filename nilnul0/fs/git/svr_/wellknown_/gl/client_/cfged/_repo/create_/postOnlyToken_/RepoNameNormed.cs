using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.gitlab.acc_.wyt_.token_.named._repo.create_.postOnlyToken_
{
	static public class _RepoNameNormedX
	{
		static public string Txt( nilnul.fs.git.svr_.gitlab.repo.name_.Normed prj)
		{
			 return  nilnul.fs.git.svr_.gitlab.acc_.token._repo.create_._NameNormedX.Txt(new web._url._query._entry.Term( Token.TXT), prj);
		}
		static public string Txt(string prj)
		{
			 return Txt(new nilnul.fs.git.svr_.gitlab.repo.Name( prj));
		}

		static public string Result( nilnul.fs.git.svr_.gitlab.repo.name_.Normed prj)
		{
			 return  nilnul.fs.git.svr_.gitlab.acc_.token._repo.create_._NameNormedX.Result(new web._url._query._entry.Term( Token.TXT), prj);
		}



		static public string Result(string prj)
		{
			return Result(new nilnul.fs.git.svr_.gitlab.repo.Name( prj));
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
			return $"https://{Named.NAME}:{Token.TXT}@gitlab.com/wangyoutian/{repoName}.git";
			//throw new NotImplementedException();
		}


	}
}
