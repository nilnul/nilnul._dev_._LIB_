using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vsAwGlBb.create
{
	[Obsolete(nameof(awGlBbVs))]
	static public class _EnsureX
	{
		public static string Ensure_result(
			nilnul.fs.folder_.git_.Top gitTop, 
			nilnul.win.prog_.Git git=null
		)
		{

			if (nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_._VsAwGlBbX.Exe(

				gitTop
				
				,git
				
			))
			{
				return "already creatged";
			}
			try
			{
				///get the urls
				///

				var vs = nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs.key._VwX.LatestOrDefault( gitTop,git);

				var bb = nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb.key._VwX.Latest(gitTop,git);

				var aws = nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.key._VwX.LatestOrDefault(gitTop,git);

				var gitlab = nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl.key._VwX.Latest(gitTop,git);

				var notNuls = new[] { vs, bb, aws, gitlab }.Where(x=> x!=null);
				var urls = new List<string>();

				if (notNuls.Any())
				{
					var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, notNuls.First().ToString());

					urls.Add(firstUrl);

					nilnul.fs.git.module.repo._cfg_.remote_.bak_.vsAwGlBb._CreateX.Exe(gitTop, firstUrl);

					///append
					///
					notNuls.Skip(1).ForEach(
						x => {
							var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, x.ToString());

							urls.Add(u);


							nilnul.fs.git.module.repo._cfg_.remote.urls_.push._InsX1.Exe(
								gitTop,
								new _remote.Name(
									_VsAwGlBbX.NewestKey()
								)
								,
								u
								,
								git
							);
						}
					);


				}

				return $"{nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls )}";
				


			}
			catch (Exception e)
			{
				return e.Message;
				throw;
			}

		}


		public static string Ensure_result(
			nilnul.fs.FolderI gitTop,
			nilnul.win.prog_.Git git = null
		)
		{
			return Ensure_result(new nilnul.fs.folder_.git_.Top(gitTop),git);
		}


		public static nilnul._op.result_.explain_.RetTxt Result(
			nilnul.fs.folder_.git_.Top gitTop, 
			nilnul.win.prog_.Git git=null
		)
		{

			if (nilnul.fs.git.module.repo._cfg_.remotes.has_.bak_._VsAwGlBbX.Exe(

				gitTop
				
				,git
				
			))
			{
				return new _op.result_.explain_.RetTxt( "already creatged");
			}
			try
			{
				///get the urls
				///

				var vs = nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs.key._VwX.LatestOrDefault( gitTop,git);

				var bb = nilnul.fs.git.module.repo._cfg_.remote_.bak_.bb.key._VwX.Latest(gitTop,git);

				var aws = nilnul.fs.git.module.repo._cfg_.remote_.bak_.aw.key._VwX.LatestOrDefault(gitTop,git);

				var gitlab = nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl.key._VwX.Latest(gitTop,git);

				var notNuls = new[] { vs, bb, aws, gitlab }.Where(x=> x!=null);
				var urls = new List<string>();

				if (notNuls.Any())
				{
					var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, notNuls.First().ToString());

					urls.Add(firstUrl);

					nilnul.fs.git.module.repo._cfg_.remote_.bak_.vsAwGlBb._CreateX.Exe(gitTop, firstUrl);

					///append
					///
					notNuls.Skip(1).ForEach(
						x => {
							var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, x.ToString());

							urls.Add(u);


							nilnul.fs.git.module.repo._cfg_.remote.urls_.push._InsX1.Exe(
								gitTop,
								new _remote.Name(
									_VsAwGlBbX.NewestKey()
								)
								,
								u
								,
								git
							);
						}
					);


				}

				return new _op.result_.explain_.RetTxt( $"created fro {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls )}");
				


			}
			catch (Exception e)
			{
				return  _op.result_.explain_.RetTxt.FroXpn( e.Message);
				throw;
			}

		}


	}
}
