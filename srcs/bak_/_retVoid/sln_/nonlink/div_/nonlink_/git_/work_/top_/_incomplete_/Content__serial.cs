#define BAK_SERIAL0
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

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_._incomplete_
{
	/// <summary>
	/// </summary>
	static public class _ContentX__serial
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
			nilnul.win.prog_.Git git = null
		)
		{
			Trace.TraceInformation($@"baking {typeof(_ContentX__serial).FullName}:{folder}...");
			
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cancel.ThrowIfCancellationRequested();
				return;// false;
			}
			Trace.Indent();
			try
			{

				foreach (var child in nilnul.fs.folder.dirs_.excludeVs_.nonlink_._NonNegByNilNulX.EnumerateAsAddresses(folder))
				{

					if (cancel.IsCancellationRequested)
					{
						Trace.TraceWarning($"cancelling {folder}");
						cancel.ThrowIfCancellationRequested();
						return;
						break;
					}

					if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX0.Be_ofAddress(child,git) )
					{
						Trace.TraceWarning( $"{child} is neglected");
						continue;
					}

					if (nilnul.fs.git.module.dir.be_._WorkX._Be_ofAddress(child, git))
					{
						if (
							nilnul.fs.git.module.dir_.work.be_._TopX._Be(child, git)
						)
						{
							div_.nonlink_.git_.work_._TopX__serial._Exe(
								child,
								cancel,
								git
						   );
						}
						else
						{
							sln_.nonlink.directory_.nonlink_.git_.work_._NontopX__serial._Exe(child, /*log,*/ cancel, git);
						}
					}
				}
				Trace.TraceInformation($@"baked {typeof(_ContentX__serial).FullName}:{folder}");

			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception when enumerating directories of gitModuleUndone {folder}:{e}");
				throw;
			}
			finally
			{
				Trace.Unindent();

			}


		}
	}
}
