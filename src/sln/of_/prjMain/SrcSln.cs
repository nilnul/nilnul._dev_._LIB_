using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.prj._locator
{
	/// <summary>
	/// given the info(full name) of a prj, find the (src, sln) for the prj.
	/// note in sln, prj may be indirectly contained. the "directory" between sln and prj is called "suburb" or "subsln", which will be found later.
	/// </summary>
	static public class _SrcSlnX
	{


		/// <summary>
		/// assert that sln resides in only one src.
		/// </summary>
		/// <param name="srcs"></param>
		/// <param name="main"></param>
		/// <returns></returns>
		static public nilnul.fs.address_.shield_.BaseDir _SrcSln_ofMain(
			Srcs_addresses srcs,
			string main
		) {

			//var srcs = nilnul.dev.Srcs_addresses.OvCfg();

			var slns = nilnul.dev.src_.folder_.nonlinks_.disjoint._SlnsX._Shields_assumeDisjoint(srcs.toDisjointNonlinks());




			var prjName_slnDenote = nilnul.dev.src.sln.prj.name._SlnSub9TgtX.SlnSub9Tgt(main);





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
