using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlVs_.aliases.vers.last.nulable.urls
{
	/// <summary>
	/// ensure the key.
	/// ensure the urls
	/// </summary>
	public class _EnsureX
	{
		/// <summary>
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static string Msg(
			nilnul.fs.git.ModuleI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			var key = last.nulable._VwX.NameVer(gitTop, git);
			if (key == null)
			{
				return nulable_.nil.ensure_._UrlsX.Msg(gitTop,git);

			}

			return last.urls._EnsureX.Msg(gitTop,git);

		}



		public static string Msg(
			nilnul.fs.git.Module gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(gitTop as nilnul.fs.git.ModuleI, git);
		}

		public static string Msg(
			nilnul.fs.folder_.git_.Top gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.git.Module(gitTop), git);
		}

		public static string Msg(
			nilnul.fs.FolderI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.folder_.git_.Top(gitTop), git);
		}
	}
}
