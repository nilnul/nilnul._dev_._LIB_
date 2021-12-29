using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.directory_.nonlink_.git_.plain0nontop_
{
	public static class _NonIntentX
	{
		internal static void _Exe(string _location__nonrootWork, /*srcs._bak.Io log,*/ CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			try
			{
				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled before {_location__nonrootWork}");
					cancel.ThrowIfCancellationRequested();
					return;

				}
				//Trace.TraceInformation($"beginning {_location__nonrootWork}...");
				Trace.Indent();
				try
				{
					foreach (string child in nilnul.fs.folder.dirs_.excludeVs_.nonlink_._NonNegByNilNulX.EnumerateAsAddresses(
										_location__nonrootWork))
					{
						cancel.ThrowIfCancellationRequested();
						if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(child))
						{
							nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.directory_.nonlink_.git_.work_._TopX._Exe(child, cancel, git);
						}
						else
						{
							git_._Plain0nontopX._Exe(child, cancel, git);
						}

					}
				}

				finally
				{
					Trace.Unindent();

				}

			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception in baking NonIntent:{_location__nonrootWork}: {e} ");
			}


		}


	}
}
