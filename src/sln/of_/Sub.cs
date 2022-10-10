using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.of_
{
	/// <summary>
	/// given the info(full name, or identity) of a sln, find the (src, sln) for the sln
	/// </summary>
	static public class _SubX
	{
		static public nilnul.fs.address_.shield_.BaseDir _Sln(
			string identity
		)
		{
			return _Sln(
				identity.Split('.')
			);
		}
		static public nilnul.fs.address_.shield_.BaseDir _Sln(
			string[] identity
		)
		{
			return _Sln(
				 nilnul.dev.Srcs_addresses.OvCfg()
				 ,
				 identity
			 );

		}
		static public nilnul.fs.address_.shield_.BaseDir _Sln(
			Srcs_addresses srcs,
			string sub
		)
		{
			return _Sln(
				srcs
				,
				sub.Split(nilnul.obj_.deV._identity._sur._SepX.Character)
			);
		}
		/// <summary>
		/// assert that sln resides in only one src.
		/// </summary>
		/// <param name="srcs"></param>
		/// <param name="main"></param>
		/// <returns></returns>
		static public nilnul.fs.address_.shield_.BaseDir _Sln(
			Srcs_addresses srcs,
			string[] sub
		) {

			//var srcs = nilnul.dev.Srcs_addresses.OvCfg();

			var slns = nilnul.dev.src_.folder_.nonlinks_.disjoint._SlnsX._Shields_assumeDisjoint(srcs.toDisjointNonlinks());




			//get the sln -- the folder

			var rtSln = slns.Single(
				s =>
				nilnul.objs.re_.init_.EqDefault<string, nilnul.txt.Eq>.Singleton.re(
					nilnul.dev.src.sln._NameX._Name_assumeSln(s.child.denote.en).asSegs().Select(seg => seg.name)
					,
					sub

				)
			);
			return rtSln;


		}

	}
}
