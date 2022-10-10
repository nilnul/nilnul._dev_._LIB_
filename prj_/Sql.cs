using nilnul.fs;
using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_
{
	public class Sql : nilnul.fs.file_.ext_.deV_.Sqlproj
	{
		 public const string EXT = nilnul.fs.file_.ext_.deV_.Sqlproj.EXT;

		public Sql(FileI val) : base(val)
		{
		}

		public Sql(string spear):base(spear )
		{
		}

		public Sql(SpearI prjAsSpear):base(prjAsSpear)
		{
		}

		

		public nilnul.fs.address_.ShieldI container {
			get {
				return nilnul.fs.address_.spear._ContainerX.Shield(this.ee.file.en);
			}
		}

		static public string _Address_ofContainerAddress(string address) {

			return 
				System.IO.Directory.EnumerateFiles(address, "*.sqlproj").Single()
			;
		}
		static public string Address_ofContainer(nilnul.fs.address_.ShieldI address) {

			return 
				_Address_ofContainerAddress(address.ToString())
			;
		}

	}
	
}
