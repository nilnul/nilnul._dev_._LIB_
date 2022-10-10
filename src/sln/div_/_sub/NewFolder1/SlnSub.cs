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
	static public class _SlnSubX
	{
		[Obsolete()]
		static public nilnul.fs.address_.shield_.BaseDiv _SlnSub_ofMain(
			string main
		) {

			var srcs = nilnul.dev.Srcs_addresses.OvCfg();

			var slns = nilnul.dev.src_.folder_.nonlinks_.disjoint._SlnsX._Shields_assumeDisjoint(srcs.toDisjointNonlinks());
			//get the sln -- the folder

			var rtSln = _locator._SrcSlnX._SrcSln_ofMain(srcs, main);

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

			return prjFolderParent;
		}

	

	}
}
