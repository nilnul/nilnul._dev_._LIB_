using nilnul.dev;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln.div_.git_.plain0nontop_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _IntentX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		static public void Exe( 
			string folderAddress, 
			CancellationToken cancel, 
			nilnul.win.program_.Git git=null
		)
		{
			if (nilnul.dev.srcs.bak_._retVoid.SettingX.IsBaked(folderAddress))
			{
				Trace.TraceInformation($"{folderAddress} already baked");
				return;
			}

			else
			{
				undone_._IntentX.Exe(folderAddress,cancel,git);
			}
		}
	}
}