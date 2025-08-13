using nilnul.fs.address_.spear_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.sln.sub.synd.prj_._sql_.directory.include_
{
	/// <summary>
	/// include a directory as nonbuild, checking whether it's already included.
	/// to extend this, note to exclude "bin","obj", "packages" and other generated directories(mostly dirs.)
	/// </summary>
	///
	static public class _NonbuildX
	{




		static public bool Changed_prjOfNomina_directoryInDestination(string prjNomina, string directory)
		{
			return nilnul.dev.prj_._sql_.directory.include_._NonbuildX.Changed_directoryInDestination(
				src.sln.sub.synd.prj_._sql._LocateX.Spear_ofMain(prjNomina)
				,
				directory
			);
		}

	}
}
