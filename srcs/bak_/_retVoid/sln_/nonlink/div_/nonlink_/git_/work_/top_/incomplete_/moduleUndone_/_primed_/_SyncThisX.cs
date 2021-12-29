using nilnul.dev;
using nilnul.fs;
using nilnul.fs.folder.categorize_.git_.plainWorkRepo;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.div_.nonlink_.git_.work_.top_.incomplete_.moduleUndone_._primed_
{
	/// <summary>
	/// </summary>
	static public class _SyncThisX
	{

		public const int maxConcurrency= 8;
		public const int iniConcurrency = 4;
		static public SemaphoreSlim semaphore = new SemaphoreSlim(iniConcurrency);/*The initialCount parameter defines the number of concurrent requests to enter the semaphore that can be granted. However, it doesn't define the maximum number of requests that can be granted concurrently. A SemaphoreSlim object instantiated by calling this constructor doesn't throw a SemaphoreFullException exception if a call to the Release method increases the value of the CurrentCount property beyond initialCount. This occurs if there are more calls to Release methods than there are to Wait or WaitAsync methods. To set the maximum number of concurrent requests to enter the semaphore that can be granted, call the SemaphoreSlim(Int32, Int32) constructor.*/

		/// <summary>
		/// use stash
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static async void _Async(
			string _location
			,
			CancellationToken cancel
			, 
			nilnul.win.program_.Git git = null)
		{
			if (nilnul.dev.srcs.bak_._retVoid.SettingX.IsModuleBaked(_location))
			{
				Trace.TraceInformation($"{_location} already baked.");

			}

			var module = nilnul.fs.git.Module1.OfAddress(_location);

			Trace.TraceInformation($"begining processing {_location} as rootOfInnerModule");
			try
			{

				var name = nilnul.fs.folder.repoName_.ThrowIfNotInSrc.Singleton.getName_ofAddress(_location);

				//nilnul.txts.accumulate_.DuoLineBreak.Singleton.accumulate(
				//	nilnul.fs.git.module._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Txts(_location, name)
				//);

				var timestamp = nilnul.time.to.Txt.ToTxtFull();
				var bakBranch = nilnul.dev.srcs.bak_._retVoid.Settings1.Default.bakBranch + timestamp;


				/*
				 branch <branchname> [<stash>]
Creates and checks out a new branch named <branchname> starting from the commit at which the <stash> was originally created, applies the changes recorded in <stash> to the new working tree and index. If that succeeds, and <stash> is a reference of the form stash@{<revision>}, it then drops the <stash>. When no <stash> is given, applies the latest one.

This is useful if the branch on which you ran git stash push has changed enough that git stash apply fails due to conflicts. Since the stash entry is applied on top of the commit that was HEAD at the time git stash was run, it restores the originally stashed state with no conflicts.
				 */

				var _oldHead = fs.git.module.Head1.GetHeadContent(module, git);
				Trace.TraceInformation($"oldHead:{_oldHead}");

				Trace.TraceWarning($"switching to branch {bakBranch}  for { _location}");

				nilnul.win.program_.Git.RunCmd_retVoid(_location, $"checkout -b {bakBranch}", git);




				Trace.TraceWarning($"committing worksite for { _location}");

				nilnul.fs.git.module.staged.commit_._AllowEmptyX.Exe(_location, "commit workspace index for possibly restoring work site later");

				Trace.TraceWarning($"adding and committing all changes at { _location}");

				nilnul.fs.git.module.index.add_.all.commit_._AllowEmptyX.Exe(_location, "add and commit all for backup");



				///create temp branch to backoff
				///
				var tempBranch = nilnul.dev.srcs.bak_._retVoid.Settings1.Default.tmpBranch
					+
					timestamp;
				//nilnul.txt_._GuidX.Construct_noHyphen(Guid.NewGuid());

				Trace.TraceInformation($"creating temp branch:{tempBranch}");

				nilnul.win.program_.Git.RunCmd_retVoid(_location, $"checkout -b {tempBranch}", git);
				Trace.TraceInformation($"created temp branch{tempBranch}");

				Trace.TraceInformation($"backtracking head");

				//change the index
				nilnul.win.program_.Git.RunCmd_retVoid(_location, "reset HEAD~", git);
				Trace.TraceInformation($"backtracked");




				Trace.TraceInformation($"setting head to original");

				fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);
				Trace.TraceInformation($"setted head to original");
				Trace.TraceInformation($"removing tmp branch");

				nilnul.win.program_.Git.RunCmd_retVoid(_location, $"branch -D {tempBranch}", git);
				Trace.TraceInformation($"removed tmp branch");


				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled after adding/committing all at { _location}");
					cancel.ThrowIfCancellationRequested();
					//Settings.Default.doneAt = _location;
					return;
				}
				#region pushup the bakBranch.



				var remotes = nilnul.fs.git.module._cfg_.remotes_.bak_.awGlVs._VwX.LatestOrDefault(
					_location
				);  //.Where(x => x.StartsWith(DataFoldersGit.AutoRemotPrefix_NoUnderscore));


				if (remotes.Count() == 0)
				{
					// cannot decide the remote repo name. 
					//err log and return.

					Trace.TraceError(
						$"no remote with auto sync set found at {_location}"

					);
					return;
				}


				var latestRemotes = remotes.Where(x => x != null);// 
				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled before pushing bak branch for {_location}");
					cancel.ThrowIfCancellationRequested();
					return;
				}

				Trace.TraceInformation($"pushing {bakBranch} for { _location}");

				try
				{
					var results = new ConcurrentQueue<KeyValuePair<txt_.NameVer, int>>();
					

					foreach (var remote in latestRemotes)
					{
						
						await semaphore.WaitAsync();
						results.Enqueue(
							new KeyValuePair<txt_.NameVer, int>(
								remote
								,
								await  nilnul.fs.git.module.repo.push_.remote.branch_.titled._TaskX.Exe(
									module.ToString()
									, remote.ToString()
									, bakBranch
									, git
								)
							)
						);
						semaphore.Release();

					}


					var resultsErr = results.Where(x => x.Value != 0);
					var resultsSuccess = results.Where(x=>x.Value==0);

					if (resultsErr.Any())
					{
						Trace.TraceError(
							$@"exceptions when pushing at {module} of branch_ {bakBranch}:(
								{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
									resultsErr.Select(r => $@"{r.Key}:{r.Value}")
								)}
							)"
						);
					}
					if (resultsSuccess.Any())
					{
						Trace.TraceInformation(
							$@"success in pushing at {module} of branch_ {bakBranch}:(
								{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
									resultsSuccess.Select(r => $@"{r.Key}:{r.Value}")
								)}
							)"
						);
					}


				}
				catch (Exception e)
				{
					Trace.TraceError($"when pushing {bakBranch} for {_location} as workroot inside sln by sync with remote: " + e.Message);

					//throw;
				}



				if (cancel.IsCancellationRequested)
				{

					Trace.TraceWarning($"user cancelled before pushing all branches at {_location}");
					cancel.ThrowIfCancellationRequested();
					return;
				}
				//then push all branches


				Trace.TraceInformation($"pusing all branches for { _location}");



				try
				{
					var pushAllResults = new ConcurrentQueue<KeyValuePair<txt_.NameVer, int>>();

					foreach (var remote in latestRemotes)
					{
						await semaphore.WaitAsync();

						pushAllResults.Enqueue(
							new KeyValuePair<txt_.NameVer, int>(
								remote
								,
								await nilnul.fs.git.module.repo.push_.remote.branches_.all.exitCode_.titled._TaskX.Exe(
									module.ToString()
									, remote.ToString()
									
									, git
								)
							)
						);
						semaphore.Release();

					}


					var resultsErr = pushAllResults.Where(x => x.Value != 0);
					var resultsSuccess = pushAllResults.Where(x => x.Value == 0);

					if (resultsErr.Any())
					{
						Trace.TraceError(
							$@"exceptions when pushing all at {module} :(
								{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
									resultsErr.Select(r => $@"{r.Key}:{r.Value}")
								)}
							)"
						);
					}
					if (resultsSuccess.Any())
					{
						Trace.TraceInformation(
							$@"success in pushing at {module} of branch_ {bakBranch}:(
								{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
									resultsSuccess.Select(r => $@"{r.Key}:{r.Value}")
								)}
							)"
						);
					}

					


				}
				catch (Exception e)
				{
					Trace.TraceError($"when pushing all branches for {_location} as workroot inside sln by sync with remote: " + e.Message);

				}



				#endregion
			}
			catch (Exception e)
			{
				Trace.TraceError($"when processing {_location} as workroot inside sln by sync with remote: " + e.Message);
				nilnul.dev.srcs.bak_._retVoid.SettingX.modulesNewlyBaked.Add(_location);

				//throw;
			}
		}

		//public static void _SyncThis(FolderI1 folder, CancellationToken cancel, nilnul.win.program_.Git git = null)
		//{
		//	_SyncThis(folder.ToString(), cancel, git);
		//	//throw new NotImplementedException();
		//}

		//[Obsolete()]
		//public static void _SyncThis(FolderI1 folder, nilnul.win.program_.Git git = null)
		//{
		//	var src = new CancellationTokenSource();

		//	_SyncThis(folder.ToString(), src.Token, git);
		//	//throw new NotImplementedException();
		//}

		//[Obsolete()]

		//public static void _SyncThis(string folder, nilnul.win.program_.Git git = null)
		//{

		//	_SyncThis(new nilnul.fs.Folder1(folder), git);
		//	//throw new NotImplementedException();
		//}



	}
}
