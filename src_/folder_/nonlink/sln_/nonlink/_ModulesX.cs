using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.nonlink.sln_.nonlink
{
	static public class _ModulesX
	{
		//[Obsolete("too slow for .git ")]
		//static public IEnumerable<nilnul.fs.git.ModuleI> Seq(
		//	nilnul.fs.FolderI folder
		//) =>
		//	nilnul.fs.folder._DivsX1.Folders(folder).Where(x => nilnul.fs.folder.be_.git_.Module.Singleton.be(x)).Select(y=> new nilnul.fs.git.Module(y));

		static public IEnumerable<nilnul.fs.git.ModuleI> Seq_disregardRepo(
			nilnul.fs.folder_.Normal nonlinkSln
		)
		{
			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(nonlinkSln.en))
			{
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					return nonlink_.git_.plain._ModulesX.Seq_disregardRepo(nonlinkSln.en);
					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					return nonlink_.git_.work._ModulesX.Seq_disregardRepo(nonlinkSln.en);
					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					return new nilnul.fs.git.ModuleI[0];
					break;
				default:
					throw new UnexpectedReachException();
					break;
			}
		}

	}
}
