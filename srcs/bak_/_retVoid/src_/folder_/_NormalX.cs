using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.src_.folder_
{
	public static class _NormalX
	{
		public static void Exe(
			nilnul.fs.FolderI folder,
			CancellationToken cancel,
				nilnul.win.prog_.Git git = null)
		{


			nonlink_._GitX.Exe(folder, cancel, git);
		}


		public static void Exe(
			string folder,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder), cancel, git);
		}

		///// <summary>
		///// return newly 
		///// </summary>
		///// <param name="folder"></param>
		///// <param name="cancel"></param>
		///// <param name="git"></param>
		///// <returns>newly baked</returns>
		//public static void Exe(
		//	nilnul.fs.FolderI folder,
		//	CancellationToken cancel,
		//	nilnul.win.prog_.Git git = null)
		//{

		//	Exe(folder.ToString(),cancel,git);
			

			
		//}

	}

}
