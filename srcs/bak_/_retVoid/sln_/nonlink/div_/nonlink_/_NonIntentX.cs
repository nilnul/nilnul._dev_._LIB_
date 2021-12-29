using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_
{
	/// <summary>
	/// 
	/// </summary>
	public static class _NonintentX
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
				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folderAddress))
				{
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
						nonintent_.git_._Plain0NontopX._Void(folderAddress,
						 cancellationToken,
						 git
						 );
						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
						nonintent_.git_._Plain0NontopX._Void(folderAddress,
						 cancellationToken,
						 git
						 );
						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:

						return;
						break;
					default:
						break;
				}
				
			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} :" + e.Message
				);
				return;
			}
		}
	}
}