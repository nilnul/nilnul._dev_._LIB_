using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlBbVs_.last
{
	//extern alias git;
	static public class _CreateX
	{
		static public void Void(nilnul.fs.git.ModuleI _gitTop, nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git=null
		)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				,
				_AwGlBbVsX.GetLastAsName()
				,
				url
				,
				git
			);
		}

		static public void Void(
			nilnul.fs.git.ModuleI _gitTop, string url
			,
			nilnul.win.prog_.Git git=null
		)
		{
			Void(_gitTop, nilnul.web.url._ParseX3.Parse(url),git);
		}

		static public void Void(
			nilnul.fs.git.Module _gitTop
			, 
			nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git=null
		)
		{
			Void(_gitTop as nilnul.fs.git.ModuleI, url,git);
		}
		static public void Void(
			nilnul.fs.folder_.git_.Top _gitTop
			, 
			nilnul.web.UrlI3 url
			,
			nilnul.win.prog_.Git git=null
		)
		{
			Void(
				new nilnul.fs.git.Module(
					_gitTop
				)
				, url,git);
		}

		static public void Void(
			nilnul.fs.folder_.git_.Top _gitTop
			, 
			string url
			,
			nilnul.win.prog_.Git git=null
		)
		{
			Void(_gitTop, nilnul.web.url._ParseX3.Parse(url),git);
		}
	}
}
