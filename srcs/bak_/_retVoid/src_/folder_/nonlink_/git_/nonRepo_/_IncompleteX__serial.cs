using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.src_.folder_.nonlink_.git_.nonRepo_
{
	public static class _IncompleteX__serial
	{

		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		public static void Exe(
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



			//Trace.Indent(); //cached by thread


			foreach (fs.FolderI dir in

				nilnul.obj.str.op_.unary_._ShuffleX.Op(
					nilnul.fs.folder.dirs_._NonlinkX.Folders(folder)
				)
				
			)
			{
				if (cancel.IsCancellationRequested)
				{
					//Trace.Unindent();
					cancel.ThrowIfCancellationRequested();
				}
				incomplete.dir_._NonlinkX__serial.Exe(dir, cancel, git);
			}
			//Trace.Unindent();

			nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(folder.address.ToString());

		}

		public static void Exe(
			string folder,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder), cancel, git);
		}
		//public static void Exe(
		//	nilnul.fs.FolderI folder,
		//	CancellationToken cancel,
		//	nilnul.win.prog_.Git git = null)
		//{

		//	Exe(folder.ToString(),cancel,git);
		//}

	}
}
