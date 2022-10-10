using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.folder_.normal.div_.normal_.git_
{
	[Obsolete(
		//nameof(sln_.nonlink.div_.nonlink_.git_.work_._TopX)
		)]
	static public class _TopX
	{
		static public void _Exe(
			string folder,
			CancellationToken cancel,
			nilnul.win.program_.Git git = null
		)
		{
			Trace.TraceInformation(
				$"{typeof(_TopX).FullName} baking: {folder}"
			);
			Trace.Indent();

			if (nilnul.dev.srcs.bak_._retVoid.SettingX.IsBaked(folder))
			{
				Trace.TraceInformation(
					$"{folder} is already baked."
				);
				return;
			}
			else
			{
				sln.div_.git_.top_._UndoneX._Exe(folder, cancel, git);

			}

			//try
			//{

			//}
			//catch (Exception e)
			//{
			//	Trace.TraceError($"when processing {folder}:{e.Message}");
			//	return;
			//}
			Trace.Unindent();
			Trace.TraceInformation(
				$"baked sln.div_.git_.top: {folder}"
			);



		}
	}
}
