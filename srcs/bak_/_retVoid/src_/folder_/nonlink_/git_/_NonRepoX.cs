using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.src_.folder_.nonlink_.git_
{
	static public class _NonRepoX
	{

		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		static public void Exe(
			nilnul.fs.FolderI folder,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null)
		{



			Trace.TraceInformation($"baking src:{folder}");
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				return;
			}
			//Trace.TraceInformation($"{nameof(Cfg.doneContainers)}:{Cfg.doneContainers}");

			if (
					nilnul.dev.srcs.bak_._retVoid.SettingX.IsBaked
					(folder.ToString())
			)
			{
				Trace.TraceInformation($" {folder} already done ");
			}
			else
			{
				nonRepo_._IncompleteX__serial.Exe
					(
					 folder,
				 cancel,
				 git = null);
			}
		}

		static public void Exe(
			string folder,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder), cancel, git);
		}


	}

}
