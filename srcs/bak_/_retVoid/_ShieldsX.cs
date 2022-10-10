using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.dev.srcs.bak_._retVoid
{
	/// <summary>
	/// </summary>
	static public class _ShieldsX
	{
		public static void Exe(
			SrcsI3 srcs,
			IEnumerable<string> _shieldsDisjoint
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			 nilnul.dev.srcs.bak_._retVoid.shields_._DisjointX._Bak(
				srcs, 
				nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(_shieldsDisjoint)
				,
				cancel,
				git);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="srcs"></param>
		/// <param name="_shields"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>baked(not canceled) directories</returns>
		static public void _Exe(
			nilnul.dev.Srcs3 srcs
			,
			IEnumerable<string> _shields
			,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			 Exe(srcs as SrcsI3, _shields, cancel, git);
		}

		public static void Exe(
			IEnumerable<string> _shields
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			 nilnul.dev.srcs.bak_._retVoid.shields_._DisjointX._Bak(
				nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(_shields)
				,
				cancel,
				git);
		}



	}
}
