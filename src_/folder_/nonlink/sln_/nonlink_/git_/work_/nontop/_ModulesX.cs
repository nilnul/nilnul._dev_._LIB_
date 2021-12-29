using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.nonlink.sln_.nonlink_.git_.work_.nontop
{
	static public class _ModulesX
	{
		static public IEnumerable<nilnul.fs.git.ModuleI> Seq_disregardRepo(
			nilnul.fs.FolderI nonlinkWork
		)
		{
			foreach (
				var item in nilnul.fs.folder.dirs_.excludeVs_.nonlink_._NonNegByNilNulX.Folders(nonlinkWork)

			)
			{
				if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(item))
				{
					foreach (var item1 in src.div_.nonlink_.git_.work_.top._ModulesX.Seq_disregardRepo(item))
					{
						yield return item1;

					}
				}
				else
				{
					foreach (var item1 in src.div_.nonlink_.git_.work_.nontop._ModulesX.Seq_disregardRepo(item))
					{
						yield return item1;

					}
				}
			}
		}
	}
}