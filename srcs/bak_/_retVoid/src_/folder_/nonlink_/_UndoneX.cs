using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.src_.folder_.nonlink_
{
	public static class _UndoneX
	{

		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		public static void Exe(
			nilnul.fs.FolderI3 folder,
			CancellationToken cancel,
			nilnul.win.program_.Git git = null)
		{

			Trace.TraceInformation($"baking src:{folder}");
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				return;
				//cancel.ThrowIfCancellationRequested();
			}



			Trace.Indent(); //cached by thread


			foreach (fs.FolderI3 dir in nilnul.fs.folder.dirs_._NonlinkX.Folders(folder))
			{
				_retVoid.src_.folder_.nonlink.dir_._NonlinkX.Exe(dir, cancel, git);
			}
			Trace.Unindent();

			nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(folder.address.ToString());

		}

		public static void Exe(
			string folder,
			CancellationToken cancel,
			nilnul.win.program_.Git git = null
		)
		{
			Exe(nilnul.fs.Folder2.FroAddress(folder), cancel, git);
		}
		public static void Exe(
			nilnul.fs.FolderI1 folder,
			CancellationToken cancel,
			nilnul.win.program_.Git git = null)
		{

			Exe(folder.ToString(),cancel,git);
		}

	}
}
