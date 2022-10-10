using Amazon.CodeCommit;
using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.aw_.ohio.client_.cfged.repo
{
	//extern alias git;
	static public class _CreateX
	{
		static public CreateRepositoryResponse Ret(nilnul.fs.git.svr.repo.Name name, string note=null)
		{
			return Cfged.Ensured.CreateRepository(new CreateRepositoryRequest() { RepositoryName=name ,RepositoryDescription=note });
		}

		static public CreateRepositoryResponse Ret(string name, string note=null)
		{
			return Ret(new svr.repo.Name(name),note);
		}


		static public string RetTxt(string name, string note=null)
		{
			
			return nilnul.fs.git.svr_.aws.acc.repo._create._ResponseX.Phrase( 
				Ret(name,note)
			);
		}



	}
}
