using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlVs_.aliases.vers.last.nulable_.nil.ensure_
{
	/// <summary>
	/// create the key.
	/// ensure the urls
	/// </summary>
	public class _UrlsX
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

			if (notNuls.Any())
			{

				var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, notNuls.First().ToString());
				urls.Add(firstUrl);


				var lastkey = _AwGlVsX.GetLastAsName();


				nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(gitTop, lastkey, firstUrl);
				///append
				///
				notNuls.Skip(1).ForEach(
					x =>
					{
						var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, x.ToString());
						urls.Add(u);
						nilnul.fs.git.module.repo._cfg_.remote.urls_.push._InsX1.Exe(
							gitTop
							,
							lastkey
							//new _remote.Name(
							//	_AwGlBbVsX.GetLastAsName()
							//)
							,
							u
							,
							git
						);
					}
				);
			}
			return ($"created fro {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls)}");
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
