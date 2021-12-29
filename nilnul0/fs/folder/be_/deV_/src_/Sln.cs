using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.vs_
{
	/// <summary>
	/// contains a .sln
	/// </summary>
	public class Sln : nilnul.fs.folder.BeI
	{


		public bool be(FolderI obj)
		{
			return nilnul.fs.folder._DocsX.Docs(obj).Any(doc => nilnul.fs._address.doc.be_.vs_.Sln.Singleton.be(doc))
				;
		//	throw new NotImplementedException();
		}
		public bool be(DirectoryInfo obj) {
			return be(new nilnul.fs.Folder(obj));
			//return be(nilnul.fs.folder.of_.DirInfo.Singleton.of(obj));
		}
		public bool be(Folder obj)
		{
			return be((FolderI)obj);
		}

		public bool be_ofAddress(string address) {
			return be( nilnul.fs.Folder.FroAddress(address));
		}

		//public bool be(FolderI obj)
		//{
		//	return  be_ofAddress(obj.ToString()) ;

		//	//throw new NotImplementedException();
		//}

		static public Sln Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Sln>.Instance;
			}
		}

	}
}
