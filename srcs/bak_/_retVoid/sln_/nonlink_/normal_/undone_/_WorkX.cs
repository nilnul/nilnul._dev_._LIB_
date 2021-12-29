using nilnul.dev;
using nilnul.fs.folder_.git_;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_
{
	[Obsolete(
		//nameof( nilnul.dev.srcs.bak_._retVoid.sln_.nonlink_.undone_._WorkX)
		)]
	static public class _WorkX
	{
		public static void __Exe(string sln, /*Log1 log,*/ CancellationToken cancel, nilnul.win.program_.Git git = null) {

		
			if (
				nilnul.fs.folder_.git_.work.be_.Top.Singleton.be_ofAddress(sln, git)
				)
			{
				 sln_.work_._TopX._Exe(sln,cancel,git);
			}
			else
			{
				 sln_.work_._NonTopX._Exe(sln,cancel,git);
			}

			
		}

		internal static void _Exe(Work work, CancellationToken cancel, win.program_.Git git)
		{
			 __Exe(work.ToString(),cancel,git);
		}


	}
}
