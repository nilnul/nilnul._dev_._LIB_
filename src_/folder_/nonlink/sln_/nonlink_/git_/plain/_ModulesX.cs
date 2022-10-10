using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.nonlink.sln_.nonlink_.git_.plain
{
	static public class _ModulesX
	{

		static public IEnumerable<nilnul.fs.git.ModuleI> Seq_disregardRepo(
			nilnul.fs.FolderI nonlinkPlainSln
		)
		{
			foreach (
				var item in nilnul.fs.folder.dirs_.excludeVs_.nonlink_._NonNegByNilNulX.Folders(nonlinkPlainSln)
			)
			{
				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(item))
				{
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
						foreach (var item1 in src.div_.nonlink_.git_.plain._ModulesX.Seq_disregardRepo(item))
						{
							yield return item1;
						}
						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
						//must be top
						foreach (var item1 in src.div_.nonlink_.git_.work_.top._ModulesX.Seq_disregardRepo(item))
						{
							yield return item1;

						}
						break;
					
					default:
						throw new UnexpectedReachException();
						break;
				}
				
			}
		}

	}
}
