﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.folder_.normal.div_.normal_.git_.top_.undone_._moduleUndone_
{
	[Obsolete("",true)]
	static public class _PrimeX
	{
		static public void _Exe(string _folder_address,CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			Trace.TraceInformation($@"priming the {typeof(_PrimeX).FullName}: {_folder_address}");
			//Trace.Indent();

			var container = nilnul.fs.address_.Shield.Parse(
				_folder_address
			);
			var folder = new nilnul.fs.Folder(container);

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

			//var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(_folder_address, name).ToArray();

			//var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(_folder_address, name).ToArray();

			var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.awGlVs.ensure._UpsertOmegaX.Msg(_folder_address, name,git);

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
