using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo._create
{
	public class Result
	{
		private string _msg;

		public string msg
		{
			get { return _msg; }
			set { _msg = value; }
		}

		private Exception _xpn;

		public Exception xpn
		{
			get { return _xpn; }
			set { _xpn = value; }
		}

		public Result(string msg, Exception xpn)
		{
			_msg = msg;
			_xpn = xpn;
		}

	}
}
