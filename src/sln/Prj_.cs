using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln
{

	public class Prj_
	{
		/*
		 for each external library, create a project for adapting.

		 */
		/*
		 by domain, or namespace, under which a set of types are created to map a lower layer which is also corresponded to a namespace.
		For example,
			for linq, we need to create a prj seperate from LIB, as in LINQ, many classed are created by tools to map db, and the name is nearly one to one with classes we created in LIB. to avoid name conflicts, we need to create a seperate prj.
			for cfg, which is an adapting project for Runtime Environment such as CLR or OS_.Win, we need not to create a separate project, as the settings class are not that much to recreate to map those in LIB.
		 */

	}
}
