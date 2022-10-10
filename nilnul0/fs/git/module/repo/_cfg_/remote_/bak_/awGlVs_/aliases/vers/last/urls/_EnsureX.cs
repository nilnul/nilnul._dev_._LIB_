using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlVs_.aliases.vers.last.urls
{
	/// <summary>
	/// assume the existence of the key.
	/// ensure the urls
	/// </summary>
	public class _EnsureX
	{
		/// <summary>
		/// assume the newest last exists,
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static string Msg(
			nilnul.fs.git.ModuleI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{


			///get the urls
			///
			var vs = nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs.key._VwX1.LatestOrDefault(gitTop, git);
			var aw = nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.key._VwX1.LatestOrDefault(gitTop, git);
			var gl = nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl.key._VwX1.LatestOrDefault(gitTop, git);

			var notNuls = new[] { vs,  aw, gl }.Where(x => x != null);
			var urls = new List<string>();

			notNuls.ForEach(
				x =>
				{
					var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, x.ToString());
					urls.Add(u);
				}
			);


			var key = last._VwX.NameVer(gitTop, git);

			var oldUrls = nilnul.fs.git.module.repo._cfg_.remote.urls_._PushX.Txts(
				gitTop
				,
				key.ToString()
				,
				git);

			var urls2add = nilnul.web.url.nulable.str.combine_.except_._DelKeyX.Txts(
				urls,
				oldUrls
			);


			urls2add.ForEach(
				x =>
				{

					nilnul.fs.git.module.repo._cfg_.remote.urls_.push._InsX1.Exe(
						gitTop
						,
						key.ToString()
						//new _remote.Name(
						//	_AwGlBbVsX.GetLastAsName()
						//)
						,
						x
						,
						git
					);
				}
			);

			return ($"urls {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls2add)} added for {key}");
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
