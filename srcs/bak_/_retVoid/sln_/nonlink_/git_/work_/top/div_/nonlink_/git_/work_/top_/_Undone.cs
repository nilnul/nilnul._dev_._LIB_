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

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink_.git_.work_.top.div_.nonlink_.git_.work_.top_
{
	/// <summary>
	/// </summary>
	static public class _UndoneX
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
			Trace.TraceInformation($"in {typeof(_UndoneX).FullName} {nameof(_Exe)}  for {folder} ");

			//Trace.TraceInformation($@"baking {typeof(_UndoneX).FullName}:{folder}...");
			Trace.Indent();

			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cancel.ThrowIfCancellationRequested();
				return;
			}


			if (nilnul.dev.srcs.bak_._retVoid.SettingX.IsModuleBaked(folder))
			{

				undone_._ModuleDoneX._Exe(folder, cancel);
			}
			else
			{
				nilnul.dev.srcs.bak_._retVoid.sln_.folder_.normal.div_.normal_.git_.top_.undone_._ModuleUndoneX._Exe(folder, cancel);
			}
			nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(folder);

			Trace.Unindent();

			Trace.TraceInformation($@"baking {typeof(_UndoneX).FullName}:{folder}...done");


			//if (nilnul.dev.srcs.bak_._retVoid.SettingX.IsModuleBaked(folder))
			//{

			//	primed_._ModuleDoneX._Exe(folder,cancel);
			//}
			//else
			//{
			//	primed_._ModuleUndoneX._Exe(folder,cancel);
			//}


		}
	}
}
