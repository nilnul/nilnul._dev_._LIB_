using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj.co_
{
	/// <summary>
	/// for a realm, we first have a trivia base case as the project.
	/// Then we can extend it to an axiomatic case as a cap project.
	/// </summary>
	/// <remarks>
	/// eg:
	///		nilnul.geometry as the base case, and nilnul.geometry.dimensional as the furthermore dimensioned geometry.
	///	eg:
	///		nilnul.os as the common core of all os.
	///		nilnul.win as the specific os based on the above.
	///		,to summarize various os such as windows, linux, macOs, we need another project called, say, nilnul.os.combo, where we can use multiple os on one machine using the technology of:
	///			virtual machine
	///			,or, booting from one of multiple installation of os on the same machine
	/// </remarks>
	internal class Base9ext
	{
	}
}
