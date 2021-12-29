using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.prj._locator
{
	/// <summary>
	/// solution means sln and sub (not having the prj dir)
	/// </summary>
	///
	[Obsolete(nameof(dev.src.sln.sub.dir_._synd._ChooseX))]
	static public class _SubDirX
	{

		static public (nilnul.fs.address_.shield_.BaseDiv, string) _SubDnt_ofMain(
			string main
		) {

	
			var sub = _locator._SlnSubX._SlnSub_ofMain(main);

			var sln = sub.basic;

			var slnAsDenote = sln.stem.div.dirs.Last().denote.en;

			var slnAsDnt2parsed = nilnul.dev.src.sln._NameX._Name_assumeSln(slnAsDenote);


			var subSinceSrc =   sub.descendent.dirs;

			var repoName = slnAsDnt2parsed.asSegs().Select(s=>s.name).Concat(
				nilnul.dev.src.sln.div._RepoNameX.Ids(subSinceSrc)
			);


			

			var mainSplit = main.Split('.');


			//var subSegsCount = sub.basic;

			var mainIdEsRemained = mainSplit.Skip(
				repoName.Count()
			);


			/// prjNameRemained is split into part of sln and prjType
			///  prjDirName might be "sub._Lib(1"
			///
			var prjAsDir_NameWanna =mainIdEsRemained;

			var dirCandidates_inDnts = nilnul.fs.folder._DirsX.Captions(sub).Select(
				dnt => (dnt: dnt, segs: nilnul.dev.src.div.dir.name._ParsedX.ParsedNulable(dnt))
			).Where(
				t => !(t.Item2 is null)
			).Where(t => t.Item2 is nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs).Select(
				t => (t.Item1, segs: t.Item2 as nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs)

			)   /// torso are the same
			.Where(
				segs => nilnul.txts.eq_.CaseInsensitive.Singleton.eq(
					nilnul.objs_.started._TorsoX.Torso(segs.Item2.asSegs())
					,
					nilnul.objs_.started._TorsoX.Torso(prjAsDir_NameWanna)
				)
			)
			// found the prefix that are the same
			;

			(string, nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs) found = (null, null);

			if (dirCandidates_inDnts.Skip(1).Any())
			{
				//find the best

				//exactly match

				var exacted = dirCandidates_inDnts.Where(
					dnt => dnt.segs.asSegs().Last().name == prjAsDir_NameWanna.Last()
				);
				if (exacted.Count() == 1)
				{

					found = exacted.Single();
					goto found;
				}
				else
				{
					if (exacted.Count() > 1)
					{
						// find the latest
						var maxes =
						nilnul.objs_._MaxesX.Maxes(
							exacted, e => nilnul.txt_.vered._VerX.Num(e.Item1), nilnul.num.Comparer2.Singleton
						);
						if (maxes.Count() == 1)
						{
							found = maxes.Single();
							goto found;
						}
						else
						{
							throw new InvalidOperationException(
								$"{sub} has plural latest prjs"
							);
						}
					}
					else //no exact match. now try circa ones
					{
						var circas = dirCandidates_inDnts.Where(
							dnt =>
							nilnul.obj_.deV._id.nom_.idiom.circa.eq_.core_.CaseInsentive.Singleton.Equals(
								dnt.segs.asSegs().Last().name
								,
								prjAsDir_NameWanna.Last()
							)
						);

						var maxes =
						nilnul.objs_._MaxesX.Maxes(
							circas, e => nilnul.txt_.vered._VerX.Num(e.Item1), nilnul.num.Comparer2.Singleton
						);
						if (maxes.Count() == 1)
						{
							found = maxes.Single();
							goto found;
						}
						else
						{
							if (maxes.Any())
							{
								throw new nilnul.objs_.started._single.PluralException(
									$"{sub} has plural latest prjs with circumstant name"
								);

							}
							throw new nilnul.objs.vow_._started.NoneException(
									$"{sub} has no latest prjs with circumstant name"

							);
						}


					}
				}


			}
			else
			{
				found = (dirCandidates_inDnts.Single());
			}
		found:

			return (
sub
,
found.Item1
			);

			

		}

		static public (nilnul.fs.address_.shield_.BaseDiv, string) SubDnt(
			nilnul.fs._address.doc_._exted.Main main
		)
		{
			return _SubDnt_ofMain(main.ToString());

		}
	

	}
}
