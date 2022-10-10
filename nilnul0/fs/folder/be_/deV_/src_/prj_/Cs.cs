using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.deV_.src_.prj_
{
	/// <summary>
	/// </summary>
	public class Cs : nilnul.fs.folder.BeI
	{
		public bool be(FolderI obj)
		{
			return  nilnul.fs.folder._DocsX.Docs(obj).Any(doc=> nilnul.fs._address.doc.be_.deV_.src_.prj_.Cs.Singleton.be(doc)) ;

			//throw new NotImplementedException();
		}

		public bool be(DirectoryInfo obj)
		{
			return be(new nilnul.fs.Folder(obj));
			//return be(nilnul.fs.folder.of_.DirInfo.Singleton.of(obj));
		}

		public bool be(BaseDiv p)
		{
			return be(new nilnul.fs.Folder(p));

			//throw new NotImplementedException();
		}

		public bool be(Folder obj)
		{
			return be((FolderI)obj);
		}

		public bool be_ofAddress(string address)
		{
			return be(nilnul.fs.Folder.FroAddress(address));
		}

		


		static public Cs Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Cs>.Instance;
			}
		}

	}
}
