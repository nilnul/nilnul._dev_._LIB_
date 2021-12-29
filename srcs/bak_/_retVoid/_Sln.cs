using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid
{
	/// <summary>
	/// a dir of src, and the dir must be:
	///		not a git repo
	///		not other special - purposed folder such as git repo
	///		not the folder included in the "ignore" file in src folder.
	/// </summary>
	static public class _SlnX
	{
		public static void _Exe(string sln, /*Log1 log,*/ CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			if (nilnul.fs.folder.be_._NormalX.Be_ofAddress(sln))
			{
				sln_._NonlinkX._Exe(sln,cancel,git);
			}
			else
			{
				Trace.TraceError($"{sln} is not a nonlink folder. it's a linked folder.");
			}

		}
	}
}