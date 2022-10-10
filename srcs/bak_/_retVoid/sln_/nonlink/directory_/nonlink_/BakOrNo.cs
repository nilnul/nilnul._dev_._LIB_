using nilnul.dev;
using nilnul.fs.address_;
using nilnul.fs.address_.shields_;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.sln_.nonlink.directory_.nonlink_
{
	/// <summary>
	/// 
	/// </summary>
	static public class _BakOrNoX__serial
	{


		internal static void Exe(Disjoint srcs, ShieldI shield, CancellationToken cancel, win.prog_.Git git)
		{

			cancel.ThrowIfCancellationRequested();
			if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX0.Be(shield,git) )
			{
				Trace.TraceInformation(
					$"{shield} is neglected"
				);
			}
			else
			{
				_GitX__serial.Exe(srcs,shield,cancel,git);
			}


		}


		public static void Exe(Srcs3 srcs, string folderAddress, CancellationToken cancellationToken, win.prog_.Git git)
		{
			Exe(
				srcs
				, 
				nilnul.fs.address_.shield_._AddressX1.Create(folderAddress)
				,
				cancellationToken
				, 
				git
			);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		static public void Exe( 
			string folderAddress, 
			CancellationToken cancellationToken, 
			nilnul.win.prog_.Git git=null
		) {
			Exe(
				nilnul.dev.srcs_._CfgedX.GetSrcs()
				,folderAddress
				,
				cancellationToken,git
			);
				
		}
	}
}