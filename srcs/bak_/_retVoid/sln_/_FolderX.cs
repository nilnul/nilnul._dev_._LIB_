using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete(nameof(sln_._NonlinkX))]
	static public class _FolderX
	{
		public static void _Exe(string sln, /*Log1 log,*/ CancellationToken cancel, nilnul.win.program_.Git git = null)
		{
			if (nilnul.fs.folder.be_._NormalX.Be(sln))
			{
				folder_._NormalX._Exe(sln,cancel,git);

			}
			else
			{
				Trace.TraceError($"folder {sln} is not normal");
			}

		}
	}
}