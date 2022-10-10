using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.folder_.normal.div_.git_.top_.undone_._moduleUndone
{
	[Obsolete("",true)]
	static public class _PrimeX
	{
		static public void Prime(string folderAddress, nilnul.win.prog_.Git git = null)
		{
			Trace.TraceInformation($@"priming the {typeof(_PrimeX).FullName}: {folderAddress}");
			Trace.Indent();

			var container = nilnul.fs.address_.Shield.Parse(
				folderAddress
			);
			var folder = new nilnul.fs.Folder(container);

			string name = "";
			try
			{
				name = nilnul.fs.folder.RepoName.Singleton.getName(folderAddress);
			}
			catch (Exception e)
			{
				//Trace.Unindent();
				Trace.TraceError($"when parsing {folderAddress} for a repoName:{e}");
				return;
				//throw;
			}

			Trace.TraceInformation(
				$"{folder} is ensuring the dotnet ignore"
			);
			nilnul.fs.git.module._ignore_.div_.top.doc.patch_.dotnet._EnsureX.Exe(folderAddress);


			Trace.TraceInformation(
				$"{folder} is ensuring the vsAwGlBb remotes"
			);

			var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(folderAddress, name).ToArray();

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
