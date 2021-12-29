using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.gl.client_
{
	public class Cfged
	{

		static public System.Net.NetworkCredential Cached = Ensure();
		static public System.Net.NetworkCredential Ensure() {
			return 
nilnul.win.app_._CredManX.Ensure(Gl.DOMAIN);

		}

		static public nilnul.fs.git.svr_.gitlab.Client Client = new nilnul.fs.git.svr_.gitlab.Client(
			Cached.Password

		);


	}
}
