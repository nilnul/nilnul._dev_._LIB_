using nilnul.fs.folder;
using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_
{
	/// <summary>
	/// 
	/// </summary>
	public static class _IntentX__serial
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public static void Exe(
			string folderAddress,
			CancellationToken cancellationToken,
			nilnul.win.prog_.Git git = null
		)
		{

			try
			{
				if (nilnul.fs.folder.be_.HasDocument.Singleton.Be_ofAddress(folderAddress))
				{
					if (nilnul.fs.folder.be_.git_.Plain0Nontop.Singleton.be_ofAddress(folderAddress))
					{

						intent_.git_._Plain0NontopX__serial.Exe(folderAddress, cancellationToken, git);

					}
					else
					{
						intent_.git_._TopX__serial.Exe(folderAddress, cancellationToken, git);
					}

				}
				else
				{
					Trace.TraceWarning($"intendGit:{folderAddress} is empty");
				}

			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} :" + e.Message
				);
				throw;
				return;
			}
		}
	}
}