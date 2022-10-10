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

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.directory_.nonlink_
{
	static public class _GitX
	{
		

			public static void Exe(
				nilnul.fs.address_.shields_.Disjoint srcs,
				nilnul.fs.address_.ShieldI _shield
				,
				CancellationToken cancel,
				win.prog_.Git git = null
			)
			{

				var shieldTxt = _shield.ToString();

				switch (
					nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(shieldTxt)
				)
				{
					case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

						 sln_.nonlink.directory_.nonlink_.git_._Plain0nontopX._Exe(shieldTxt, cancel, git);
						break;

					case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
						 sln_.nonlink.directory_.nonlink_.git_._WorkX._Exe(
							nilnul.fs.folder_.git_.Work.FroAddress(shieldTxt), cancel, git
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
