using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.prj
{
	/// <summary>
	/// given the info(full name) of a prj, find the (src, sln) for the prj.
	/// note in sln, prj may be indirectly contained. the "directory" between sln and prj is called "suburb" or "subsln", which will be found later.
	/// </summary>
	static public class _LocatorX
	{
		static public (nilnul.fs.address_.shield_.BaseDiv, string) _SuburbDnt_ofMain(
			string main
		) {

			var srcs = nilnul.dev.Srcs_addresses.OvCfg();

			var slns = nilnul.dev.src_.folder_.nonlinks_.disjoint._SlnsX._Shields_assumeDisjoint(srcs.toDisjointNonlinks());
			//get the sln -- the folder

			var rtSln = _SrcSln_ofMain(srcs, main);


			var prjName_as_slnSub9tgt = nilnul.dev.src.sln.prj.name._SlnSub9TgtX.SlnSub9Tgt(main);


			/// the name of the   sln file.
			var slnName = nilnul.dev.src.sln._NameX._Name_assumeSln(rtSln.child.denote.en).asSegs().Select(seg => seg.name);


			///remained of the prjName
			var subRemained = prjName_as_slnSub9tgt.Item1.Skip(
				slnName.Count()
			);


			// there might be subSln
			var directory = new List<string>();

			while (
				subRemained.Any()		// subsln
			)
			{
				var dir4sub = nilnul.fs.folder._DirsX.Captions(rtSln).Select(
					c =>

					nilnul.dev.src.sln.dir.name._ParsedX.Parsed(c)

				).OfType<nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs>(   // where is of the type
				).SingleOrDefault(
					s =>
nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.Eq>.Singleton.re(
						s.asSegs().Select(seg => seg.name)
						,
						subRemained

					)
				);

				if (dir4sub is null)
				{
					break;
				}

				directory.Add(dir4sub.ToString());
				subRemained = subRemained.Skip(
					dir4sub.asSegs().Count()
				);

			}

			// now find the prj

			var prjFolderParent = nilnul.fs.address_.shield_.BaseDiv.Ov_divOfDnts(
				rtSln,
				directory
			);

			/// prjNameRemained is split into part of sln and prjType
			///  prjDirName might be "sub._Lib(1"
			///
			var prjFoldeNameWanna = nilnul.objs.op_.unary_._AppendX.Append(subRemained
				,
				prjName_as_slnSub9tgt.Item2
			);

			var dirCandidates_inDnts = nilnul.fs.folder._DirsX.Captions(prjFolderParent).Select(
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
					nilnul.objs_.started._TorsoX.Torso(prjFoldeNameWanna)
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
					dnt => dnt.segs.asSegs().Last().name == prjFoldeNameWanna.Last()
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
								$"{prjFolderParent} has plural latest prjs"
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
								prjFoldeNameWanna.Last()
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
									$"{prjFolderParent} has plural latest prjs with circumstant name"
								);

							}
							throw new nilnul.objs.vow_._started.NoneException(
									$"{prjFolderParent} has no latest prjs with circumstant name"

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
prjFolderParent
,
found.Item1
			);

			

		}

		static public (nilnul.fs.address_.shield_.BaseDiv, string) SuburbDnt(
			nilnul.fs._address.doc_._exted.Main main
		)
		{
			return _SuburbDnt_ofMain(main.ToString());

		}
		static public nilnul.fs.address_.BaseDivision _SlnSub_ofMain(
			string main
		) {

			var srcs = nilnul.dev.Srcs_addresses.OvCfg();

			var slns = nilnul.dev.src_.folder_.nonlinks_.disjoint._SlnsX._Shields_assumeDisjoint(srcs.toDisjointNonlinks());
			//get the sln -- the folder

			var rtSln = _SrcSln_ofMain(srcs, main);

			var prjName_as_slnSub9tgt = nilnul.dev.src.sln.prj.name._SlnSub9TgtX.SlnSub9Tgt(main);

			/// the name of the   sln file.
			var slnName = nilnul.dev.src.sln._NameX._Name_assumeSln(rtSln.child.denote.en).asSegs().Select(seg => seg.name);


			///remained of the prjName
			var subRemained = prjName_as_slnSub9tgt.Item1.Skip(
				slnName.Count()
			);


			// there might be subSln
			var directory = new List<string>();

			while (
				subRemained.Any()		// subsln
			)
			{
				var dir4sub = nilnul.fs.folder._DirsX.Captions(rtSln).Select(
					c =>

					nilnul.dev.src.sln.dir.name._ParsedX.Parsed(c)

				).OfType<nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs>(   // where is of the type
				).SingleOrDefault(
					s =>
nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.Eq>.Singleton.re(
						s.asSegs().Select(seg => seg.name)
						,
						subRemained

					)
				);

				if (dir4sub is null)
				{
					break;
				}

				directory.Add(dir4sub.ToString());
				subRemained = subRemained.Skip(
					dir4sub.asSegs().Count()
				);

			}

			// now find the prj

			var prjFolderParent = nilnul.fs.address_.BaseDivision.Ov_divisionOfDnts(
				rtSln,
				directory
			);

			return prjFolderParent;
		}

		static public nilnul.fs.address_.shield_.BaseDir _SrcSln_ofMain(
			Srcs_addresses srcs,
			string main
		) {

			//var srcs = nilnul.dev.Srcs_addresses.OvCfg();

			var slns = nilnul.dev.src_.folder_.nonlinks_.disjoint._SlnsX._Shields_assumeDisjoint(srcs.toDisjointNonlinks());




			var prjName = main;
			var prjName_slnDenote = nilnul.dev.src.sln.prj.name._SlnSub9TgtX.SlnSub9Tgt(prjName);





			//get the sln -- the folder

			var rtSln = slns.Single(
				s =>
				nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.Eq>.Singleton.re(
					nilnul.dev.src.sln._NameX._Name_assumeSln(s.child.denote.en).asSegs().Select(seg => seg.name)
					,
					prjName_slnDenote.Item1

				)
			);
			return rtSln;
			

			

		}

	}
}
