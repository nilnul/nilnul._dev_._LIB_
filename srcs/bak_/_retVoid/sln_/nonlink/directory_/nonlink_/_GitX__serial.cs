using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.directory_.nonlink_
{
	public static class _GitX__serial
	{


		public static void Exe(
			nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{

			string shieldTxt = _shield.ToString();

			switch (
				nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(shieldTxt)
			)
			{
				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:

					sln_.nonlink.directory_.nonlink_.git_._Plain0nontopX_serial._Exe(shieldTxt, cancel, git);
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					sln_.nonlink.directory_.nonlink_.git_._WorkX__serial._Exe(
					   nilnul.fs.folder_.git_.Work.FroAddress(shieldTxt), cancel, git
				   );
					break;

				case nilnul.fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					return;
					break;

				default:
					Trace.TraceError($"sln {shieldTxt}:unknown git.folder.Category");
					return;

					//throw new UnexpectedReachException("unknown git.folder.Category");


			}


			//nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(_shield.ToString());

		}

		public static void Void(
			nilnul.fs.address_.ShieldI _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			Exe(nilnul.dev.srcs_._CfgedX.GetSrcs(), _shield, cancel, git);
		}

		public static void Void_ofAddress(
			string _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			Void(
				nilnul.fs.address_.shield_._AddressX1.Create(_shield)
				,
				cancel
				,
				git
			);
		}




	}
}
