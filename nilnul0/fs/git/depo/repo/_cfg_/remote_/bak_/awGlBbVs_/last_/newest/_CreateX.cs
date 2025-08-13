using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs_.last_.next
{
	static public class _CreateX
	{
		public static IEnumerable<string> Urls(
			nilnul.fs.git.ModuleI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{


			///get the urls
			///

			var vs = nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs.key._VwX1.LatestOrDefault(gitTop, git);

			var bb = nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb.key._VwX1.LatestOrDefault(gitTop, git);

			var aw = nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.key._VwX1.LatestOrDefault(gitTop, git);

			var gl = nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl.key._VwX1.LatestOrDefault(gitTop, git);

			var notNuls = new[] { aw, gl, bb, vs }.Where(x => x != null);
			var urls = new List<string>();

			if (notNuls.Any())
			{

				var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, notNuls.First().ToString());

				urls.Add(firstUrl);

				var nextKey = nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs_.newest_.next._VwX.NameVer(gitTop, git);
				nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(gitTop, nextKey.ToString(), firstUrl, git);


				//nilnul.fs.git.module.repo._cfg_.remote_.nameInId_.next._CreateX.Void(gitTop, _AwGlBbVsX.GetLastAsName(), firstUrl);

				//var newestKey = newest._VwX.NameVer(gitTop, git);
				///append
				///
				notNuls.Skip(1).ForEach(
					x =>
					{
						var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, x.ToString());

						urls.Add(u);


						nilnul.fs.git.module.repo._cfg_.remote.urls_.push._InsX1.Exe(
							gitTop,
							nextKey.ToString()
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

			return urls;





		}
		public static IEnumerable<string> Urls(
			nilnul.fs.git.Module gitTop,
			nilnul.win.prog_.Git git = null
		)
		=> Urls(gitTop as ModuleI, git);

		public static IEnumerable<string> Urls(
			nilnul.fs.folder_.git_.Top gitTop,
			nilnul.win.prog_.Git git = null
		)
		=> Urls(new nilnul.fs.git.Module(gitTop), git);
	}
}
