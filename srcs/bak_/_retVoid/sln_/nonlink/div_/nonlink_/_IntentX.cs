using nilnul.dev;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_
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
			nilnul.win.prog_.Git git=null
		) {

			try
			{
				if (nilnul.fs.folder.be_.git_.Plain0Nontop.Singleton.be_ofAddress(folderAddress))
				{
					intent_.git_._Plain0NontopX.Exe(folderAddress,cancellationToken,git);

				}
				else
				{
					intent_.git_._TopX.Exe(folderAddress,cancellationToken,git);
				}
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