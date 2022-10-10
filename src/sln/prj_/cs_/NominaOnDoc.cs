using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.spear;

namespace nilnul.dev.src.sln.prj_.cs_
{
	/// <summary>
	/// </summary>
	public class NominaOnDoc
	{
		private fs.address_.spear_.ParentDoc _prjFile;

		public fs.address_.spear_.ParentDoc prjFile
		{
			get { return _prjFile; }
			set {
				_prjFile = value;

				_prjNomina = src.prj.asDoc.main._NominaX.NominaAsTxt(value);
			}
		}

		private string _prjNomina;

		public string prjNomina
		{
			get { return _prjNomina; }
			//set
			//{
			//	_prjNomina = value;
			//	_prjFile = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(prjNomina);
			//}
		}



		public NominaOnDoc(fs.address_.spear_.ParentDoc prjNomina)
		{
			this.prjFile = prjNomina;
		}


		public NominaOnDoc(string prjNomina):this(  fs.address_.spear_.ParentDoc.Parse(prjNomina) )
		{
			
		}

	



	}
}
