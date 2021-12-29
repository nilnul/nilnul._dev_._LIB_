using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.notLink_.git_.nonRepo.div_.notLink_.git_.module
{

	static public class _PrimeX
	{
		static public void _Exe(string _folder_address, CancellationToken cancel, nilnul.win.program_.Git git = null)
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

			var ensured = nilnul.fs.git.module._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(_folder_address, name).ToArray();


			var ensuredDict = new Dictionary<string, nilnul._op.result_.explain_.RetTxt>()
			{
				{"vs", ensured[0] }
				,
				{"aw", ensured[1] }
				,
				{"gl", ensured[2] }
				,
				{"bb", ensured[3] }
				,

			}
				;


			var ensuredCount = ensured.Count();

			var ensuredIndividuals = ensured.Take(ensuredCount - 1);
			var ensuredIndividualFails = ensuredIndividuals.Where(x => x.isXpn());

			var ensuredFailedKeyVal = ensuredDict.Where(x => x.Value.isXpn());

			if (
				ensuredIndividualFails.Any()
			)
			{
				Trace.TraceError(
					$@"failed to create remotes:(
					{
						nilnul.txts.accumulate_.DuoLineBreak.Singleton.accumulate(
							ensuredFailedKeyVal.Select(x => $@"[{x.Key}:{x.Value}]")
						)
					}
					)
					"
				);
			}


			var ensuredLast = ensured.Last();
			if (ensuredLast.isXpn())
			{
				Trace.TraceError(
					$@"failed to create a remote to aggregate the svrs:({
						ensuredLast.ToString()

					})
					"
				);

			}


			Trace.TraceInformation(
				$@"created remotes successful: ({
				nilnul.txts.accumulate_.DuoLineBreak.Singleton.accumulate(
					ensuredDict.Where(x => x.Value.isRet()).Select(x => $@"[{x.Key}:{x.Value}]")

				)
				})
				"
			);
			//Trace.Unindent();
			Trace.TraceInformation("primed");



		}
	}
}
