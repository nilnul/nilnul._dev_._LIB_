using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs._build.ref_
{
	/// <summary>
	/// even some pacs installed, and added to the references, but when build, the resulted dll only references some of them. Some dll in the reference list is not included in the built dll's references.
	/// This may result some pecularities:
	///		you have some obsolete packages in both "packages.config" and prj's references, but your compiled dll is still the newest in the sense that the dll's reference(not the prj src's reference) are all the newest.
	/// </summary>
	interface IUnused
	{
	}
}
