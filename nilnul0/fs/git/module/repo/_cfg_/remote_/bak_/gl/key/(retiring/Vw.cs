﻿using nilnul.txt_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.gl.key
{
	static public class _VwX
	{

		static public NameVer Latest(nilnul.fs.git.Module module, nilnul.win.prog_.Git git=null) {
			foreach (var item in _GlX.GetKeys().Reverse())
			{
				var remotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq(module).Select(x => nilnul.txt_.NameVer.Parse(x)).Where(
								y =>
									 y.name.en == item

				);
				var lastest = nilnul.txt_.nameVer.SetX.GetLatestOrDefault(remotes);
				if (lastest != null)
				{
					return lastest;
				}

			}
			return null;






		}
	}
}
