using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.dev.srcs.bak_._retVoid.shield_
{
	/// <summary>
	/// for an individual shield
	/// </summary>
	static public class _InSrcX
	{

		public static void Exe(
			nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{

			Trace.TraceInformation($"to process :{_shield}");
			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be_ofAddress(_shield.ToString()))
			{

				 shield_.inSrc_._FolderX.Exe(srcs, _shield, cancel, git);
			}
			else
			{
				Trace.TraceError($"{_shield} is not a folder (it is file or notexist)");
			}
		}

		public static void Exe(
			//nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			 Exe(
				 nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(
					nilnul.dev.srcs.bak_._retVoid.Settings1.Default.srcs.Cast<string>()
				)
				,
				_shield
				,
				cancel
				, git
			);
		}

	}
}
