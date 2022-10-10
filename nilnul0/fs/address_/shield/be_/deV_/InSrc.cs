﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;

namespace nilnul.fs.address_.shield.be_.dev_
{
	/// <summary>
	/// </summary>
	static public class _InSrcX
	{
		public static bool Be(
			nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI _shield
			
		)
		{

			var parent = srcs.supOf(_shield);
			if (parent == null)
			{
				return false;
			}
			else
			{

				return nilnul.fs.address_.shield_.dev_.insideSrc.be_._InSrcX.Be(srcs,_shield);
			}
		}

		public static bool Be(
			nilnul.fs.address_.ShieldI _shield
			
		)
		{
			return  Be(
				 
					nilnul.dev.Properties.SettingsX.SrcsAsDisjoint	//.Default.srcs		 //.dev.srcs.bak_._retVoid.SettingX.srcs1
				,
				_shield
			);
		}

		public static bool Be(
			string _shield
			
		)
		{
			return  Be(
				nilnul.fs.address_.Shield.FroAddress(_shield)
				
			);
		}
	}
}

