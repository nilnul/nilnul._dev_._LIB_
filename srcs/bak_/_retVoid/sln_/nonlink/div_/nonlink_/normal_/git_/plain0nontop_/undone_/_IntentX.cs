using nilnul.dev;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln.div_.git_.plain0nontop_.undone_
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
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		static public void Exe( 
			string folderAddress, 
			CancellationToken cancellationToken, 
			nilnul.win.program_.Git git=null
		) {
			try
			{
				_intent._IniX.Setup(folderAddress,git);
				sln.div_.git_.top_._UndoneX._Exe(folderAddress,cancellationToken, git);
			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} :" +e.Message
				);
				return ;
			}
		}
	}
}