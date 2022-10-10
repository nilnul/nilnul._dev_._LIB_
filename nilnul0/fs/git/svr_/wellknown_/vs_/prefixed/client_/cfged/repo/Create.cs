//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.svr_.wellknown_.vs.client_.cfged.repo
{
	//extern alias git;
	static public class _CreateX
	{

		static public string Ret(string prj)
		{
			return Ret( 
				nilnul.fs.git.svr_.vs.repo.Name.ByEncode(prj)
			);
		}
		static public string Ret(nilnul.fs.git.svr_.vs.repo.Name prj)
		{
			return new nilnul.fs.git.svr_.vs.client.prjs.add_.ByWebClient_basicUser1(Cfged.Client).ret(
					prj
			);
		}
		



		static public JObject Jobj(string prj)
		{
			return JObject.Parse(Ret(prj));
		}

		static public string Result(string prj)
		{
			 return Result(nilnul.fs.git.svr_.vs.repo.Name.ByEncode(prj)).ToString();
		}

		static public _op.result_.Explain<string> Result(nilnul.fs.git.svr_.vs.repo.Name prj)
		{
			 return new nilnul.fs.git.svr_.vs.client.prjs.add_.ByWebClient_basicUser1(Cfged.Client).result(
					prj
			);
		}


		static public string GenUrl(string repo)
		{
			return $"https://{Cfged.Prefix}.visualstudio.com/DefaultCollection/_git/{repo}";
		}
	}
}