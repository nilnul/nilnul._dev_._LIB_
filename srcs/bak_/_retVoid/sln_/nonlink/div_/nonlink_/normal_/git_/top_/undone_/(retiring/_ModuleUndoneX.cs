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
	static public class _ModuleUndoneX
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
			/*srcs._bak.Io log,*/ CancellationToken cancel,
			nilnul.win.program_.Git git = null
		)
		{
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cancel.ThrowIfCancellationRequested();
				return;
			}
			sln_.folder_.normal.div_.git_.top_.undone_._moduleUndone._PrimeX.Prime(folder, git);


			moduleUndone_._PrimedX._Exe(folder, cancel, git);



		}
	}
}
