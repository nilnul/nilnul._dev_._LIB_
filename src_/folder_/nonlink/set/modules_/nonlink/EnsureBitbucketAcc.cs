using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.nonlink.set.modules_.nonlink
{
	static public class _EnsureBitbucketAccX
	{
		static public void Void(nilnul.fs.folder_.nonlink.Set nonlinks, 
			 nilnul.win.prog_.Git git = null)
		{


			var modules = nilnul.dev.src_.nonlink.set.modules_._NonlinkX.Seq_disregardRepo(nonlinks);

			nilnul.fs.git.modules.each._cfg_.remotes.EnsureBitbucketAcc.Void(modules, "wangyoutian", git); ;
			

		}


		static public void Void(nilnul.win.prog_.Git git = null)
		{

			var nonlinks = nilnul.fs.folder_.nonlink.Set.FroAddresses(
				nilnul.dev.Properties.Settings.Default.srcs
			);
			Void(nonlinks, git);


		}

	}
}

