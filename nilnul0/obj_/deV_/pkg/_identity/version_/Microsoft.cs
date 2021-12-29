using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.pac.name_._vered.ver_
{
	/*
	  Per msdn:
	  
	  The input parameter must have the following format:

major.minor[.build[.revision]]

where major, minor, build, and revision are the string representations of the version number's four components: major version number, minor version number, build number, and revision number, respectively. Optional components are shown in square brackets ([ and ]). The components must appear in the specified order and must be separated by periods.
	 * */

	/// <summary>
	/// 
	/// </summary>
	class Microsoft
	{
		/// <summary>
		/// A difference in build number represents a recompilation of the same source. Different build numbers might be used when the processor, platform, or compiler changes.
		/// </summary>
		int build;

		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		///MajorRevision
		///Gets the high 16 bits of the revision number.
		///MinorRevision
		///Gets the low 16 bits of the revision number.
		///
		/// Standard version:
		/// major.minor.build.revision = 2.4.1128.2
		/// Interim version:
		/// major.minor.build.majRev/minRev = 2.4.1128.100/2
		/// </remarks>
		int revision;
	}
}
