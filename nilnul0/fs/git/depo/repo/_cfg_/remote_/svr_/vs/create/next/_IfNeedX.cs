using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module._cfg_.remote_.svr_.wellknowns_.create.next
{
	static public class _IfNeedX
	{
		static public void Create(nilnul.fs.git.ModuleI module,  nilnul.fs.git.svr_.vs.repo.Name repoName, nilnul.win.program_.Git git=null) {
			var url = nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.GenUrl(repoName);



			var r = nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.Result(
						repoName
				);


			var remoteKey = nilnul.fs.git.module._cfg_.remotes_.ids_.named._NextX.NameVer(module,new txt_._nameVer_.Name(nilnul.dev.srcs.bak_._retVoid.Settings1.Default.moduleRemoteKeysVs.Cast<string>().Last()), git);

			nilnul.fs.git.module._cfg_._remote._CreateX1.RetVoid(
				module.top
				,
				
				remoteKey.ToString()
				,

				nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.GenUrl(repoName)
			);
			
		}

		public static void Create(nilnul.fs.FolderI3 folder, string name)
		{
			Create( Module3.FroAddress(folder.ToString()), name);
			//throw new NotImplementedException();
		}
	}
}
