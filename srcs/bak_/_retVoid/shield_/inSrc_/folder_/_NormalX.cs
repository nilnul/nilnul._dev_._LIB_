using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.dev.srcs.bak_._retVoid.shield_.inSrc_.folder_
{
	/// <summary>
	/// </summary>
	static public class _NormalX
	{

		public static void Exe(
			nilnul.fs.address_.shields_.Disjoint1 srcs,
			nilnul.fs.address_.ShieldI1 _shield
			,
			CancellationToken cancel, 
			win.program_.Git git = null
		)
		{
			Trace.TraceInformation($"to process {nameof(Exe)}{_shield}");
			/// get the parent src
			/// 

			var parent = srcs.supOf(_shield);

			var distance = nilnul.fs.address_.shield.duo_.sup._DistanceX1._ofSupSub(parent, _shield);
			switch (distance)
			{
				case 0: //src
					 nilnul.dev.srcs.bak_._retVoid.src_.folder_._NormalX.Exe(
						_shield.ToString(), cancel,git);
					break;
				case 1: //sln
					 nilnul.dev.srcs.bak_._retVoid.sln_._NonlinkX._Exe(_shield.ToString(),cancel,git);
					break;
				
				default:    //inside sln
					_retVoid.sln_.nonlink.directory_._NonlinkX.Exe(
						srcs,_shield,
						cancel,git);
					break;
			}


		}
		public static void Exe(
			//nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI1 _shield
			,
			CancellationToken cancel,
			win.program_.Git git = null
		)
		{
			 Exe(
				nilnul.dev.srcs.bak_._retVoid.SettingX.srcs1
				
				,
				_shield
				,
				cancel
				,git
			);
		}
		
	}
}
