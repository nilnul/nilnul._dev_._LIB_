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

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.nonintent_.git_
{
	static public class _Plain0NontopX
	{
		public static void _Void(
			string _location__nonrootWork
			, /*srcs._bak.Io log,*/ CancellationToken cancel
			, nilnul.win.prog_.Git git = null
		)
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
				try
				{

					foreach (var child in nilnul.fs.folder.dirs_.excludeVs_.nonlink_._NonNegByNilNulX.EnumerateAsAddresses(
						_location__nonrootWork))
					{
						if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(child))
						{
							nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.directory_.nonlink_.git_.work_._TopX._Exe(child, cancel, git);
						}
						else
						{
							sln_.nonlink.directory_.nonlink_.git_._Plain0nontopX._Exe(child, cancel, git);
						}

					}
				}
				finally
				{
					Trace.Unindent();

				}
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception in baking NonIntent:{_location__nonrootWork}: {e} ");
			}


		}


	}
}
