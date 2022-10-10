using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.dev.srcs.bak_._retVoid.shield_.inSrc_
{
	/// <summary>
	/// for an individual shield
	/// </summary>
	static public class _FolderX
	{

		public static void Exe(
			nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			src._DivX.Exe(srcs,_shield,cancel,git);
			//if (nilnul.fs.folder.be_._NormalX.Be(_shield.ToString()))
			//{
			//	folder_._NormalX.Exe(srcs, _shield, cancel, git);
			//	//return;
			//}
			//else
			//{
			//	Trace.TraceInformation($"not a normal folder; maybe symlink or reparse: {_shield}");
			//}
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
				nilnul.dev.srcs.bak_._retVoid.SettingX.srcs1

				,
				_shield
				,
				cancel
				, git
			);
		}

	}
}
