using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.intent_.git_
{
	/// <summary>
	/// 
	/// </summary>
	public static class _Plain0NontopX
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
				cancellationToken.ThrowIfCancellationRequested();

				_intent._EnsureIniX.Setup(folderAddress, git);

				cancellationToken.ThrowIfCancellationRequested();

				sln_.nonlink.div_.nonlink_.git_.work_.top_.incomplete_._ModuleUndoneX._Exe(folderAddress, cancellationToken, git);


			}
			catch (OperationCanceledException ex)
			{
				throw;
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