using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.fs.address_.shields_;
using nilnul.win.program_;

namespace nilnul.dev.srcs.bak_._retVoid.shields_.disjoint
{
	/// <summary>
	/// for an individual shield.
	/// </summary>
	static public class _ShuffleX
	{


		

		public static void _Bak(
			IEnumerable<string> _shieldsDisjoint
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			_DisjointX._Bak(
				nilnul.obj.str.op_.unary_._ShuffleX.Op(_shieldsDisjoint)
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
		static public void _Bak(
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

		public static void  _Bak(SrcsI3 srcs, Disjoint disjoint, CancellationToken cancel, win.prog_.Git git)
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
