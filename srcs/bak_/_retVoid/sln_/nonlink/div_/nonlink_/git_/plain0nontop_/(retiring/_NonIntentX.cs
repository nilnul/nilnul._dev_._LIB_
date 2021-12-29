using nilnul.dev;
using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln.div_.git_.plain0nontop_.undone_
{
	static public class _NonIntentX
	{
		internal static void _Exe(string _location__nonrootWork, /*srcs._bak.Io log,*/ CancellationToken cancel, nilnul.win.program_.Git git = null)
		{
			try
			{
				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled before {_location__nonrootWork}");
					return;

				}
				//Trace.TraceInformation($"beginning {_location__nonrootWork}...");
				Trace.Indent();

				foreach (var child in nilnul.fs.folder.dirs_.excludeVs_._NormalX.EnumerateAsAddresses(
					_location__nonrootWork))
				{
					if (nilnul.fs.folder_.git_.work.be_._TopX._Be(child))
					{
						nilnul.dev.srcs.bak_._retVoid.sln_.nonlink..folder_.normal.div_.normal_.git_._TopX._Exe(child, cancel, git);
					}
					else
					{
						work_._NonTopX._Exe(child, cancel, git);
					}

				}
				Trace.Unindent();
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception in baking NonIntent:{_location__nonrootWork}: {e} ");
			}


		}


	}
}
