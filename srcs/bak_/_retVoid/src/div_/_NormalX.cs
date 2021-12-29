using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.srcs.bak_._retVoid.src.div_
{
	/// <summary>
	/// the processed is:
	///		a folder
	///		nonlink: not a link itself; any of the ancestor is nonlink
	/// </summary>
	public static class _NonlinkX
	{

		public static void Exe(
			nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.folder_.Normal _div_inSrc
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{

			fs.address_.ShieldI shield = _div_inSrc.en.address.en;

			Trace.TraceInformation($"to process {nameof(Exe)}{_div_inSrc}");
			/// get the parent src
			/// 

			fs.address_.ShieldI parent = srcs.supOf(shield);

			uint distance = nilnul.fs.address_.shield.co_.sup._DistanceX1._ofSupSub(parent, shield);
			switch (distance)
			{
				case 0: //src
					nilnul.dev.srcs.bak_._retVoid.src_.folder_._NormalX.Exe(
					   _div_inSrc.ToString(), cancel, git);
					break;
				case 1: //sln
					nilnul.dev.srcs.bak_._retVoid.sln_._NonlinkX__serial._Exe(_div_inSrc.ToString(), cancel, git);
					break;

				default:    //inside sln
					_retVoid.sln_.nonlink.directory_._NonlinkX__serial.Exe(
						srcs, shield,
						cancel, git);
					break;
			}


		}

		public static void Exe(
	nilnul.fs.address_.shields_.Disjoint srcs,
	nilnul.fs.address_.ShieldI _shield
	,
	CancellationToken cancel,
	win.prog_.Git git = null
)
		{
			Exe(
						  srcs

						   ,
						  new nilnul.fs.folder_.Normal(
						   _shield
						   )
						   ,
						   cancel
						   , git
					   );

		}
		public static void Exe(
			//nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI _shield
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			Exe(
			   nilnul.dev.srcs.bak_._retVoid.SettingX.srcs1

			   ,
			   _shield
			   ,
			   cancel
			   , git
		   );
		}

	}
}
