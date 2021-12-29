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

namespace nilnul.dev.srcs.bak_._retVoid.sln.div_.git_.top_.undone_
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete()]
	static public class _ModuleDoneX
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
			string _slnDiv_git_top,
			/*srcs._bak.Io log,*/ CancellationToken cancel,
			nilnul.win.program_.Git git = null
		)
		{
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {_slnDiv_git_top}");
				//cancel.ThrowIfCancellationRequested();
				return;
			}



			foreach (var child in nilnul.fs.folder.dirs_.excludeVs_._NormalX.EnumerateAsAddresses(_slnDiv_git_top))
			{
				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelling {_slnDiv_git_top}");
					//cancel.ThrowIfCancellationRequested();
					return;
				}

				if (nilnul.fs.git.module.dir.be_._WorkX.Be(child, git))
				{
					if (
						nilnul.fs.git.module.dir_.work.be_._TopX._Be(child, git)
					)
					{
						div_.git_._TopX._Exe(
							child,
							cancel,
							git
					   );
					}
					else
					{

						sln.div_.git_.work_._NonTopX._Exe(child, /*log,*/ cancel, git);
					}
				}

			}
			_retVoid.SettingX.shieldsNewlyBaked.Add(_slnDiv_git_top);

		}
	}
}
