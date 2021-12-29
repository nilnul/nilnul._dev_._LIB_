using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink_.git_.work_.top.directory_.nonlink_.git_
{
	static public class _WorkX
	{
		public static void __Exe(string sln, /*Log1 log,*/ CancellationToken cancel, nilnul.win.program_.Git git = null)
		{
			if (
				nilnul.fs.folder_.git_.work.be_.Top.Singleton.be_ofAddress(sln, git)
				)
			{
				nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.directory_.nonlink_.git_.work_._TopX._Exe(sln, cancel, git);

			}
			else
			{
				_retVoid.sln_.nonlink.directory_.nonlink_.git_.work_._NontopX._Exe(sln, cancel, git);
			}
		}

		internal static void _Exe(Work work, CancellationToken cancel, win.program_.Git git)
		{
			__Exe(work.ToString(), cancel, git);
		}

		internal static void _Exe(Work1 work, CancellationToken cancel, win.program_.Git git)
		{
			__Exe(work.ToString(), cancel, git);
		}


	}
}