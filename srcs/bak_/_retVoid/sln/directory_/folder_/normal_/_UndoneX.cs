using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.dev.srcs.bak_._retVoid.sln.directory_.folder_.normal_
{
	static public class _UndoneX
	{
		

			public static void Exe(
				nilnul.fs.address_.shields_.Disjoint1 srcs,
				nilnul.fs.address_.ShieldI1 _shield
				,
				CancellationToken cancel,
				win.program_.Git git = null
			)
			{

				var shieldTxt = _shield.ToString();

				switch (
					nilnul.fs.folder.categorize_.git_.PlainWorkRepo1.Category_ofAddress(shieldTxt)
				)
				{
					case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

						 sln.div_.git_._Plain0nontopX._Exe(shieldTxt, cancel, git);
						break;

					case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
						 sln.div_.git_._WorkX._Exe(
							nilnul.fs.folder_.git_.Work1.FroAddress(shieldTxt), cancel, git
						);
						break;

					case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
						return ;
						break;

					default:
						Trace.TraceError($"sln {shieldTxt}:unknown git.folder.Category");
						return;

						//throw new UnexpectedReachException("unknown git.folder.Category");


				}


			nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(_shield.ToString());

		}
		}
	}
