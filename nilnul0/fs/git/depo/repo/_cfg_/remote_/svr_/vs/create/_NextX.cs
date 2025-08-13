using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G = nilnul.win.program_.Git;

namespace nilnul.fs.git.module._cfg_.remote_.svr_.vs.create
{
	static public class _NextX
	{
		static public void Create(nilnul.fs.git.ModuleI module,  nilnul.fs.git.svr_.vs.repo.Name repoName, nilnul.win.program_.Git git=null) {

			var r = nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.Ret(
						repoName
			);



			var remoteKey = nilnul.fs.git.module._cfg_.remotes_.ids_.named._NextX.NameVer(
				module,
				new txt_._nameVer_.Name(
					_VsX.GetNewestKey()
				), 
				git
			);

			nilnul.fs.git.module._cfg_._remote._CreateX1.RetVoid(
				module.top
				,
				
				remoteKey.ToString()
				,

				nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.GenUrl(repoName)
			);
			
		}

		public static void Create(nilnul.fs.FolderI3 folder, string name, G git=null)
		{
			Create(
				Module3.FroAddress(folder.ToString()), 
				name
				,git
			);
			//throw new NotImplementedException();
		}
	}
}
