using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln._sub
{
	/// <summary>
	/// solution means sln and sub (not having the prj dir)
	/// </summary>
	static public class _NulableOvPrjX
	{

		public static nilnul.fs.address_.shield_.BaseDiv _Sub_ofMain(string main, Srcs_addresses srcs, out IEnumerable<string> subRemained0, out string target)
		{

			var slns = nilnul.dev.src_.folder_.nonlinks_.disjoint._SlnsX._Shields_assumeDisjoint(srcs.toDisjointNonlinks());
			//get the sln -- the folder

			var rtSln = dev.src.sln.of_.prj_.nomina_._RetNulableX._SrcSln_ofMain(srcs, main);
			if (rtSln is null)
			{
				subRemained0 = null;
				target = null;
				return null;
			}

			var prjName_as_slnSub9tgt = nilnul.dev.src.sln.prj.name._SlnSub9TgtX.SlnSub9Tgt(main);

			/// the name of the   sln file.
			var slnName = nilnul.dev.src.sln._NameX._Name_assumeSln(rtSln.child.denote.en).asSegs().Select(seg => seg.name);

			target = prjName_as_slnSub9tgt.Item2;
			///remained of the prjName
			var  subRemained = prjName_as_slnSub9tgt.Item1.Skip(
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

					nilnul.dev.src.sln.dir.name._ParsedX.NulableParsed(c)

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
			subRemained0 = subRemained;

			return prjFolderParent;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="main"> main of Prj</param>
		/// <param name="subRemained0">
		/// eg:  for "nilnul.fs._git_.dd.ab.cd._LIB_",
		///		where "nilnul.fs._git_" is sln
		///		"dd" is sub
		///		"ab.cd._LIB_" is prjAsDnt, where "ab.cd" is subRemained
		/// </param>
		/// <returns></returns>
		static public nilnul.fs.address_.shield_.BaseDiv _Sub_ofMain(
			string main
			,
			out IEnumerable<string> subRemained0
			,
			out string target
		) {


			return _Sub_ofMain(
				main
				,
				nilnul.dev.Srcs_addresses.OvCfg()
				,
				out subRemained0
				,
				out target
			);
		}
	}
}
