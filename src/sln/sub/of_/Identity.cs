using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.sub.of_
{
	/// <summary>
	/// given the identity of a sub (including sln), find the location of the sub. the tail of the sub may not be used up, hence as a lead in the prj dir name
	/// </summary>
	static public class _IdentityX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="identityOfSub">
		///	the identity of sub
		/// </param>
		/// <param name="subRemained0">
		/// eg:  for "nilnul.fs._git_.dd.ab.cd._LIB_",
		///		where "nilnul.fs._git_" is sln
		///		"dd" is sub
		///		"ab.cd._LIB_" is prjAsDnt, where "ab.cd" is subRemained, and the prjFolder will be "ab.cd._LIB_"
		/// </param>
		/// <returns></returns>
		static public nilnul.fs.address_.shield_.BaseDiv _Sub_ofIdentity(
			string identityOfSub
			,
			out IEnumerable<string> subRemained0
		) {

			var srcs = nilnul.dev.Srcs_addresses.OvCfg();

			var slns = nilnul.dev.src_.folder_.nonlinks_.disjoint._SlnsX._Shields_assumeDisjoint(srcs.toDisjointNonlinks());

			//get the sln -- the folder
			var rtSln1 = dev.src.sln.of_._SubX._Sln(srcs, identityOfSub);

			var subAsSegs = identityOfSub.Split(nilnul.obj_.deV._identity._sur._SepX.Character);


			/// the name of the  sln file.
			var slnName = nilnul.dev.src.sln._NameX._Name_assumeSln(rtSln1.child.denote.en).asSegs().Select(seg => seg.name);

			///remained of the prjName
			var  subRemained = subAsSegs.Skip(
				slnName.Count()
			);


			// there might be subSln
			var directory = new List<string>();

			while (
				subRemained.Any()		// subsln
			)
			{
				var dir4sub = nilnul.fs.folder._DirsX.Captions(rtSln1).Select(
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
				rtSln1,
				directory
			);
			subRemained0 = subRemained;

			return prjFolderParent;
		}

	

	}
}
