using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.win.program_;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs.ensure_
{
	/// <summary>
	/// regard awGlBbVs as nameVer/id
	/// </summary>
	static public class _IdX
	{
		/// <summary>
		/// ensure the key, not the urls
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static string Msg(
			nilnul.fs.git.ModuleI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			if (
				nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs._AnyX.Be(
					gitTop
					, git
				)
			)
			{
				return ("already creatged");
			}

			///get the urls
			///
			var vs = nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs.key._VwX1.LatestOrDefault(gitTop, git);
			var bb = nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb.key._VwX1.LatestOrDefault(gitTop, git);
			var aw = nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.key._VwX1.LatestOrDefault(gitTop, git);
			var gl = nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl.key._VwX1.LatestOrDefault(gitTop, git);

			var notNuls = new[] { vs, bb, aw, gl }.Where(x => x != null);
			var urls = new List<string>();

			if (notNuls.Any())
			{
				var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, notNuls.First().ToString());
				urls.Add(firstUrl);

				var lastkey = _AwGlBbVsX.GetLastAsName();

				nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs_.last._CreateX.Void(gitTop, firstUrl);	//becuz no such remotes found

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
			return Msg(new nilnul.fs.git.Module( gitTop), git);
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
