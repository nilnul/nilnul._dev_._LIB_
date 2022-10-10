using nilnul.fs;
using nilnul.fs.address_;
using NuGet.Packaging.Core;
using NuGet.Versioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj._build.target.ensure_
{
	static public class _FourDotEightX
	{
		static public bool _Updated_assumePrj(string file)
		{

			return  _EnsureX.Updated_fileAssumePrj(file, _target._ValX.FourDotEight);

		}

		public static bool Updated_assumePrj(SpearI en)
		{
			return _Updated_assumePrj(en.ToString());
		}

		static public bool Updated_assumePrjNomina(string prjIdentity)
		{
			return Updated_assumePrj(

nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(
				prjIdentity
			)
			);
		}


		public static bool Updated_assumePrj(FileI ee)
		{
			return Updated_assumePrj(ee.file.en);

		}

		static public bool Updated(nilnul.dev.IPrj file)
		{
			return _Updated_assumePrj(file.ToString());
		}




	}
}
