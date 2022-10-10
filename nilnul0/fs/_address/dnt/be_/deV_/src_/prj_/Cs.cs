using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address.doc.be_.deV_.src_.prj_
{
	/// <summary>
	/// c-sharp project.
	/// </summary>
	public class Cs :

		nilnul.fs._address.doc.BeI

	{

		static public string[] exts = new string[] {".csproj" };

		public bool be(DocI obj)
		{
			return exts.Contains(nilnul.fs._address.doc_.exted._ExtX.Ext(obj).ToString().ToLower());

		}
		

		public bool be(Doc obj)
		{
			return be((DocI)obj);
		}

		public bool be(string x)
		{
			return be(new nilnul.fs._address.Doc(x) );
		}
		//public bool be(DocI obj)
		//{
		//	return   be(obj.ToString());
		//}

		//public bool be(DocI obj)
		//{
		//	return  be(obj.ToString());

		//}

		//public bool be(Doc obj)
		//{
		//	return be((DocI)obj);
		//}

		static public Cs Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cs>.Instance;
			}
		}


	}
}
