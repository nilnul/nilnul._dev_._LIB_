using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.spear;

namespace nilnul.dev.src.prj_.cs_.lib
{
	/// <summary>
	/// <see cref="	nameof(_config.IPrjRef)"/>.
	/// if the prj is recently build using a different config, then the built in this config is not the newest.
	/// </summary>
	public class Compileds
	{
		private fs.address_.spear_.ParentDoc _prjFile;

		public fs.address_.spear_.ParentDoc prjFile
		{
			get { return _prjFile; }
			//set { _prjFile = value; }
		}

		private string _prjNomina;

		public string prjNomina
		{
			get { return _prjNomina; }
			set
			{
				_prjNomina = value;
				_prjFile = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(prjNomina);
			}
		}

		public Compileds(string prjNomina)
		{
			this.prjNomina = prjNomina;


		}
	
		public IEnumerable<string> files()
		{
			

			var bin = System.IO.Path.Combine(
				this.prjFile.parent.ToString()
				,
				"bin"
			);
			return System.IO.Directory.EnumerateDirectories(bin).Select(
				dFullname=>
				System.IO.Path.Combine(
					dFullname
					,
					$"{prjNomina}.dll"
				)
				
			).Where(
				f=>
				System.IO.File.Exists(f)
			);
		
		}
		public IEnumerable<AssemblyName> specs()
		{
			return files().Select(
				x=>
				AssemblyName.GetAssemblyName(x)
			);
		}
		public IEnumerable<AssemblyName> specsOrdered()
		{
			return specs().OrderBy(
				x=>x.Version
			);
		}






	}
}
