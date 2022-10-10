using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.div.be_
{
	static public class _BaseX
	{


		public static bool Be(
		nilnul.fs.address_.shields_.Disjoint srcs,
		nilnul.fs.address_.ShieldI _shield
		,
		win.prog_.Git git = null
	)
		{
			

			var parent = srcs.supOf(_shield);

			var distance = nilnul.fs.address_.shield.co_.sup._DistanceX1._ofSupSub(parent, _shield);
			switch (distance)
			{
				////case 0: //src
				////	nilnul.dev.srcs.bak_._retVoid.src_.folder_._NormalX.Exe(
				////	   _shield.ToString(), cancel, git);
				////	break;
				case 1: //sln
					return true;
					break;

				default:    //inside sln
					return false;
					break;
			}


		}


		public static bool Be(
			nilnul.fs.address_.ShieldI _shield
			,
			win.prog_.Git git = null
		)
		{
			return  Be(
				nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(
				   nilnul.dev.Properties.Settings.Default.srcs.Cast<string>()
			   ),
			   _shield,
			   git
		   );
		}

		public static bool Be_ofAddress(
			string _shield
			,
			win.prog_.Git git = null
		)
		{
			return  Be(
				nilnul.fs.address_.shield_._AddressX1.Create(_shield)
			   ,
			   git
		   );
		}



	}
}
