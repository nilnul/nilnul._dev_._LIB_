using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.bak_.vs.create
{
	static public class _NextX
	{
		static public void Create(nilnul.fs.git.Module module,  string repoName, nilnul.win.prog_.Git git=null) {

			var r = nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.Result(
						repoName
				);


			var remoteKey = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NextX.NameVer(module,new txt_._vered_.Name(nilnul.dev.srcs.bak_._retVoid.Settings1.Default.moduleRemoteKeysVs.Cast<string>().Last()), git);

			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				module.top
				,
				
				remoteKey.ToString()
				,

				nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._CreateX.GenUrl(repoName)
			);
			
		}

		public static void Create(Folder folder, string name)
		{
			Create( Module.FroAddress(folder.ToString()), name);
			//throw new NotImplementedException();
		}
	}
}
