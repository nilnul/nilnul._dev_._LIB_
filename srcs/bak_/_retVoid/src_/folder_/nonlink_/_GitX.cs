using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.src_.folder_.nonlink_
{
	static public class _GitX
	{

		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		static public void Exe(
			nilnul.fs.FolderI folder,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null)
		{

			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(folder))
			{
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
					git_._NonRepoX.Exe(folder,cancel,git);

					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					//Trace.TraceWarning($"src {folder} shall not be a git workspace; it shall be a plain folder");
					git_._NonRepoX.Exe(folder, cancel, git);

					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					Trace.TraceError($"src {folder} shall not be a repo (such as .git in name)");
					break;
				default:
					break;
			}


			
		}

		static public void Exe(
			string folder,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder), cancel, git);
		}


	}

}
