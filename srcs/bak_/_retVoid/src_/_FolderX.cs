using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.src_
{
	//[Obsolete()]
	static public class _FolderX
	{

		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="src"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		static public void Exe(
			nilnul.fs.FolderI src,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null)
		{

			if (nilnul.fs.folder.be_._NormalX.Be(src.ToString()))
			{
				folder_._NormalX.Exe(src, cancel, git);
				return;
			}
			else
			{
				Trace.TraceError($"{src} is not a normal folder; it is a reparse point.");

			}
			return;


		



		}


		public static void Exe(string v, CancellationToken cancel, win.prog_.Git git)
		{
			if (nilnul.fs.folder.be_._NormalX.Be(v))
			{
				folder_._NormalX.Exe(nilnul.fs.Folder.FroAddress(v), cancel, git);
				return;
			}
			else
			{
			Trace.TraceError($"{v} is not a normal folder; it is a reparse point.");

			}
			return ;
		}
	}

}
