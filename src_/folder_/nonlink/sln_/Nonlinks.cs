using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.folder_.nonlink.sln_
{
	static public class _NonlinksX
	{
		static public IEnumerable<nilnul.fs.FolderI> exe(
			nilnul.fs.FolderI src
		)
		{

			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(src))
			{
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					return  src_.folder_.nonlink_.giT_.nonRepo.sln_._NonlinksX._Folders_assumeSrc(src);
					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					Trace.TraceError($"src {src} shall not be a repo, bare or not");
					return new nilnul.fs.FolderI[] { };
					break;
				default:
					throw new UnexpectedReachException();
					break;
			}

		}

	}
}
