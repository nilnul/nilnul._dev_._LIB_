using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.plain0nontop_
{
	public static class _NonIntentX
	{
		internal static void _Exe(string _location__nonrootWork, /*srcs._bak.Io log,*/ CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			//try
			//{
				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled before {_location__nonrootWork}");
					return;

				}
				//Trace.TraceInformation($"beginning {_location__nonrootWork}...");
				Trace.Indent();

				try
				{
					foreach (string child in nilnul.fs.folder.dirs_.excludeVs_.nonlink_._NonNegByNilNulX.EnumerateAsAddresses(
						_location__nonrootWork))
					{
						if (nilnul.fs.folder_.git_.work.be_._TopX._Be(child))
						{
							nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.directory_.nonlink_.git_.work_._TopX._Exe(child, cancel, git);
						}
						else
						{
							directory_.nonlink_.git_.work_._NontopX._Exe(child, cancel, git);
						}

					}
				}
				finally
				{
					Trace.Unindent();

				}
			//}
			//catch (Exception e)
			//{
			//	Trace.TraceError($"exception in baking NonIntent:{_location__nonrootWork}: {e} ");
			//}


		}


	}
}
