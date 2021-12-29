using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid
{
	//[Obsolete()]
	/// <summary>
	/// must be a shield. it might be nonexistent, in other words, not a folder. 
	/// if the address is a file, it shall not be considered a src.
	/// </summary>
	static public class _SrcX
	{

		

		internal static void Exe(string v, CancellationToken cancel, win.prog_.Git git)
		{
			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be_ofAddress(v))
			{
				src_._FolderX.Exe(nilnul.fs.Folder.FroAddress(v), cancel, git);
			}
			else
			{
				Trace.TraceError($"{v} not exist.");

			}
		}
	}

}
