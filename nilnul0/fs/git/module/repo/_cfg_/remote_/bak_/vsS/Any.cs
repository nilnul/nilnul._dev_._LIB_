﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vss
{
	/// <summary>
	/// aws:amazon web service-code commit
	/// </summary>
	static public class _AnyX
	{


		static public bool Be(nilnul.fs.folder_.git_.Top module, nilnul.win.prog_.Git git = null)
		{
			return _VsX.GetKeys().Any(
				x=> nilnul.fs.git.module.repo._cfg_.remote._ExistX.Be(
					module
					,
				
					x
					, git
				)
			);
		}

		static public bool Be(nilnul.fs.FolderI module, win.prog_.Git git = null)
		{
			return Be(
				new fs.folder_.git_.Top(module), git
			);
		}



	}
}
