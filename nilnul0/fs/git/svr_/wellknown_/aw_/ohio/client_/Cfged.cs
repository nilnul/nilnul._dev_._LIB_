using Amazon.CodeCommit;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//shangwu 10:57. z168 信仰

	//济南 -0531-12306



namespace nilnul.fs.git.svr_.wellknown_.aw_.ohio.client_
{
	/// <summary>
	/// with admin full access; as a result can create repo by calling Aws Sdk
	/// </summary>
	public class Cfged
	{
		static public AmazonCodeCommitClient Ensured = Ensure();

		static public AmazonCodeCommitClient Ensure()
		{
			var saved = nilnul.win.app_._CredManX.Ensure(
				Ohio.domain
			);
			if (saved == null)
			{
				throw new exception_.UnexpectedException("after ensure the credential shall not be null.");
				return null;
			}
			return new AmazonCodeCommitClient(
				 new BasicAWSCredentials(
					 saved.UserName
					 ,
					 saved.Password
					)
				,
				 Amazon.RegionEndpoint.USEast2
			);
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
