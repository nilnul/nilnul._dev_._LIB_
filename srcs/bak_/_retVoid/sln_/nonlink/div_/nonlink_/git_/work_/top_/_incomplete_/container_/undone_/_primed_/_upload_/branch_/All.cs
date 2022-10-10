using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_._incomplete_.container_.undone_._primed_._upload_.branch_
{
	/// <summary>
	/// </summary>
	public static class _AllX
	{
		/// <summary>
		/// use stash
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static bool _NoErr(
			string _location
			,
			CancellationToken cancel
			,
			nilnul.win.prog_.Git git = null)
		{

			bool noError = true;

			fs.git.Module module = nilnul.fs.git.Module.FroAddress(_location);

			Trace.TraceInformation($"syncing {_location} ...");
			try
			{


				IEnumerable<txt_.NameVer> remotes = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.awGlVs._VwX.LatestOrDefault(
					_location
				);  //.Where(x => x.StartsWith(DataFoldersGit.AutoRemotPrefix_NoUnderscore));


				if (remotes.Count() == 0)
				{

					Trace.TraceError(
						$"no remote with auto sync set found at {_location}"

					);

					return false;
				}


				IEnumerable<txt_.NameVer> latestRemotes = remotes.Where(x => x != null);// 


				//then push all branches
				Trace.TraceInformation($"pusing all branches for { _location}");

				try
				{
					Dictionary<txt_.NameVer, int> pushAllResults = new Dictionary<txt_.NameVer, int>();

					foreach (txt_.NameVer remote in latestRemotes)
					{
						cancel.ThrowIfCancellationRequested();
						pushAllResults.Add(

							remote
							,

							nilnul.fs.git.module.repo.push_.remote.branches_.all.exitCode_._UiTitledX.Exe(
							module.ToString()
							, remote.ToString()

							, git
						)

						);

					}


					IEnumerable<KeyValuePair<txt_.NameVer, int>> resultsErr = pushAllResults.Where(x => x.Value != 0);
					IEnumerable<KeyValuePair<txt_.NameVer, int>> resultsSuccess = pushAllResults.Where(x => x.Value == 0);

					if (resultsErr.Any())
					{
						Trace.TraceError(
							$@"exceptions when pushing all at {module} :(
								{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
									resultsErr.Select(r => $@"{r.Key}:{r.Value}:{ nilnul.fs.git.repo._push.ExitCodeX.Explain(r.Value)}")
								)}
							)"
						);
						noError = false;
					}
					if (resultsSuccess.Any())
					{
						Trace.TraceInformation(
							$@"success in pushing at {module} of all branches:(
								{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
									resultsSuccess.Select(r => $@"{r.Key}:{r.Value}")
								)}
							)"
						);
					}




				}
				catch (OperationCanceledException ex)
				{
					throw;
				}
				catch (Exception e)
				{
					noError = false;
					Trace.TraceError($"when pushing all branches for {_location} as workroot inside sln by sync with remote: " + e.Message);

				}




			}
			catch (OperationCanceledException ex)
			{
				throw;
			}

			catch (Exception e)
			{
				noError = false;
				Trace.TraceError($"when processing {_location} as workroot inside sln by sync with remote: " + e.Message);

				//throw;
			}

			return noError;


		}

		public static bool _NoErr(fs.FolderI _module, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			return _NoErr(_module.ToString(), cancel, git);
			//throw new NotImplementedException();
		}




	}
}
