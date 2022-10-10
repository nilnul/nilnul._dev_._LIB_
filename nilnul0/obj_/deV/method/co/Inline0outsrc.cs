using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.method.co
{
	/// <summary>
	/// for src,
	///		the method shall be outsrced in order for:
	///			1) the exectution path would be converged; and same problem would appear at the same path; this helps testing and debugging- when we fix the site for a problem, we don't left other places accomodating the same problem
	///			a caller tested is like a test for the callee.
	///			2) we don't load the same code twice into the memory of computer, saving space, and loading time. Computer might cache the logic, in this case, we also save the time once it's cached once.
	///	we can leave the inlining job to the compiler.
	/// </summary>
	class Inline0outsrc
	{
	}
}
