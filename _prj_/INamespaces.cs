using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._prj_
{
	/// <summary>
	/// in prj, artefacts are stored/structured by namespaces following the directory hierarchy.
	/// when two responsibilities/jobs are in one prj, the namespaces of those two might intertwined together, sometimes bringing about confusion/commotion.
	/// In that case, we better spin out a separate prj which takes on only one responsibility, but accommodates many namespaces beyond the default namespaces; and the artefacts of various namespaces in the prj form a relatively closure/<see cref="nilnul.dev.ISys"/>. And in the end, the prj becomes a capsulation of different namespaces working together for a same/shared/common mission.
	/// </summary>
	internal class INamespaces
	{
	}
}
