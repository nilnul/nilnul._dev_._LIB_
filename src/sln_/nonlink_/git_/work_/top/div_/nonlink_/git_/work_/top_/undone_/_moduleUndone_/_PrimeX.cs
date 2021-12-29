using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink_.git_.work_.top.div_.nonlink_.git_.work_.top_.incomplete_._moduleUndone_
{
	[Obsolete("",true)]
	static public class _PrimeX
	{
		static public void _Exe(string _folder_address,CancellationToken cancel, nilnul.win.program_.Git git = null)
		{
			Trace.TraceInformation($@"priming the {typeof(_PrimeX).FullName}: {_folder_address}");
			//Trace.Indent();

			var container = nilnul.fs.address_.Container1.Parse(
				_folder_address
			);
			var folder = new nilnul.fs.Folder1(container);

			string name = "";
			try
			{
				name = nilnul.fs.folder.repoName_.ThrowIfNotInSrc.Singleton.getName_ofAddress(_folder_address);
			}
			catch (Exception e)
			{
				//Trace.Unindent();
				Trace.TraceError($"when parsing {_folder_address} for a repoName:{e}");
				return;
				//throw;
			}

			Trace.TraceInformation(
				$"{folder} is ensuring the dotnet ignore"
			);
			nilnul.fs.git.module._ignore_.div_.top.doc.patch_.dotnet._EnsureX.Exe(_folder_address);


			Trace.TraceInformation(
				$"{folder} is ensuring the vsAwGlBb remotes"
			);

			//var ensured = nilnul.fs.git.module._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(_folder_address, name).ToArray();

			//var ensured = nilnul.fs.git.module._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(_folder_address, name).ToArray();

			var ensured = nilnul.fs.git.module._cfg_.remotes_.bak_.awGlVs.ensure._UpsertOmegaX.Msg(_folder_address, name,git);





			Trace.TraceInformation(
				$@"created remotes : ({
					ensured
				})
				"
			);
			//Trace.Unindent();
			Trace.TraceInformation("primed");



		}
	}
}
