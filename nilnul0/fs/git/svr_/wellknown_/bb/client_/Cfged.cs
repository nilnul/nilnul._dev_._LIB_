using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.bb.client_
{

	/// <summary>
	/// this one works in create prj
	/// </summary>
	public class Cfged : nilnul.fs.git.svr_.bitBucket.Client
	{



		static public System.Net.NetworkCredential Credential =  nilnul.win.app_._CredManX.Ensure(Bb.DOMAIN);


		public Cfged(

		) : base(Credential)
		{
		}

		

		static public Cfged Singleton
		{
			get
			{
				return nilnul.Singleton1<Cfged>.Instance;
			}
		}






	}
}
