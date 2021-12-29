#define BAK_SERIAL0
using nilnul.dev;
using nilnul.fs;
using nilnul.fs.folder.categorize_.git_.plainWorkRepo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_._incomplete_.container_.undone
{
	/// <summary>
	/// </summary>
	static public class _TaskX
	{
		/// <summary>
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location"></param>
		/// <param name="log"></param>
		/// <param name="err"></param>
		/// <remarks>
		/// </remarks>
		/// <returns>
		/// newly processed
		/// </returns>
		public static Task _Task(
			string folder,
			 CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			return Task.Factory.StartNew(
				() =>
				{
					_UndoneX._Exe(folder, cancel, git);
				}
				,
				cancel
				,
				TaskCreationOptions.AttachedToParent
				,
				TaskScheduler.Current //TaskScheduler
			);
		}
	}
}
