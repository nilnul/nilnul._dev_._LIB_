using nilnul.fs.address_.shields_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.shields_
{
	/// <summary>
	/// for an individual shield.
	/// </summary>
	public static class _DisjointX
	{


		public static void _Bak(
			IEnumerable<string> _shieldsDisjoint
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			string shieldsTxt = nilnul.fs.address.str._PhraseX.Phrase(_shieldsDisjoint);
			Trace.TraceWarning($"begin {shieldsTxt}...");
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelled {shieldsTxt}...");

				return;
			}

			//Trace.Indent();
		
			try
			{
				foreach (string src in _shieldsDisjoint)
				{
					cancel.ThrowIfCancellationRequested();
					nilnul.dev.srcs.bak_._retVoid._ShieldX.Exe(src, cancel, git);
				}
			}
			finally
			{
				//Trace.Unindent();

			}

			//throw new NotImplementedException();
		}

		public static void _ShuffleAndBak(
			IEnumerable<string> _shieldsDisjoint
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			_Bak(
				/*nilnul.obj.str.op_.unary_._ShuffleX.Op*/
				(_shieldsDisjoint)
				,
				cancel
				,
				git
			);

		}



		/// <summary>
		/// 
		/// </summary>
		/// <param name="srcs"></param>
		/// <param name="_shields"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>baked(not canceled) directories</returns>
		public static void _Bak(
			nilnul.dev.Srcs3 srcs
			,
			IEnumerable<string> _shields
			,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{

			_Bak(srcs as SrcsI3, _shields, cancel, git);
		}

		public static void _Bak(
			SrcsI3 srcs,
			IEnumerable<string> _shieldsDisjoint
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			_Bak(_shieldsDisjoint, cancel, git);

		}

		public static void _Bak(SrcsI3 srcs, Disjoint disjoint, CancellationToken cancel, win.prog_.Git git)
		{
			_Bak(srcs, disjoint.ee.Select(x => x.ToString()), cancel, git);

			//throw new NotImplementedException();
		}


		public static void _Bak(Disjoint disjoint, CancellationToken cancel, win.prog_.Git git)
		{
			_Bak(disjoint.ee.Select(x => x.ToString()), cancel, git);

			//throw new NotImplementedException();
		}


	}
}
