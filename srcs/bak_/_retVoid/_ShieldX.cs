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
	static public class _ShieldX
	{
		public static void Exe(
			nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			Trace.TraceInformation($"to process {_shield}");
			/// get the parent src

			var parent = srcs.supOf(_shield);
			if (parent == null)
			{
				Trace.TraceInformation($"{_shield} in not in srcs:{srcs}");
				//return ;
			}
			else
			{
				shield_._InSrcX.Exe(srcs, _shield, cancel, git);

			}
		}

		public static void Exe(
			nilnul.fs.address_.ShieldI _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			 Exe(
				 nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(
					nilnul.dev.srcs.bak_._retVoid.Settings1.Default.srcs.Cast<string>()
				),
				_shield,
				cancel,
				git
			);
		}

		public static void Exe(
			string _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			 Exe(
				nilnul.fs.address_.Shield.FroAddress(_shield)
				,
				cancel,
				git
			);
		}
	}
}

