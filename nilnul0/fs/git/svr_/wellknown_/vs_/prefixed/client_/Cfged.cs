using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.vs.client_
{
	public class Cfged
	{
		public static string Prefix => nilnul.dev.srcs.bak_._retVoid.Settings1.Default.vsPrefix;


		static public nilnul.fs.git.svr_.vs.Client Client => new nilnul.fs.git.svr_.vs.Client(
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.vsPrefix
			,
			

			nilnul.win.app_._CredManX.Ensure(
				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.vsPrefix + ".visualstudio.com"
				//,
				//nilnul.dev.srcs.bak_._retVoid._CfgX.ParentForm
			)
		);

		static public nilnul.fs.git.svr_.vs.Client Gen() => new nilnul.fs.git.svr_.vs.Client(
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.vsPrefix
			,
			

			nilnul.win.app_._CredManX.Ensure(
				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.vsPrefix + ".visualstudio.com"
				//,
				//nilnul.dev.srcs.bak_._retVoid._CfgX.ParentForm
			)
		);	




		static public void SetCredential(string token) {

		}
	}
}
