using nilnul.dev;
using nilnul.fs;
using nilnul.fs.folder.categorize_.git_.plainWorkRepo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink_.git_.work_.top.div_.nonlink_.git_.work_.top_.incomplete_.moduleUndone_
{
	/// <summary>
	/// </summary>
	static public class _PrimedX
	{
		/// <summary>
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location"></param>
		/// <param name="log"></param>
		/// <param name="err"></param>
		/// <remarks>
		/// </remarks>
		/// <returns>
		/// newly processed
		/// </returns>

		public static void _Exe(
			string folder,
			 CancellationToken cancel,
			nilnul.win.program_.Git git = null
		)
		{
			Trace.TraceInformation($@"baking {typeof(_PrimedX).FullName}:{folder}...");
			Trace.Indent();
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cancel.ThrowIfCancellationRequested();
				return;
			}
			try
			{
				foreach (var child in nilnul.fs.folder.dirs_.excludeVs_._NormalX.EnumerateAsAddresses(folder))
				{
					if (cancel.IsCancellationRequested)
					{
						Trace.TraceWarning($"cancelling {folder}");
						cancel.ThrowIfCancellationRequested();
						break;
					}

					if (nilnul.fs.git.module.dir.be_._WorkX.Be(child, git))
					{
						if (
							nilnul.fs.git.module.dir_.work.be_._TopX._Be(child, git)
						)
						{
							div_.nonlink_.git_.work_._TopX._Exe(
								child,
								cancel,
								git
						   );
						}
						else
						{
							sln_.nonlink.directory_.nonlink_.git_.work_._NontopX._Exe(child, /*log,*/ cancel, git);
						}
					}
				}

			}
			catch (Exception e)
			{
				Trace.TraceError($"exception when enumerating directories of gitModuleUndone {folder}:{e}");
				//throw;
			}

			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cancel.ThrowIfCancellationRequested();
				return;
			}

			try
			{
				_primed_._SyncThisX._Async(folder, cancel, git);
				_retVoid.SettingX.modulesNewlyBaked.Add(folder);
			}
			finally
			{
			}

			Trace.Unindent();
			Trace.TraceInformation($@"baked {typeof(_PrimedX).FullName}:{folder}");
		}
	}
}
