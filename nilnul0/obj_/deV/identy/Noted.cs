using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.identy
{
	/// <summary>
	/// eg:
	///		ab(c).de
	///		ab(c.d).ef
	///		ab)cd.ef
	///		ab.cd.(ef.gh
	///			where "(ef.gh" is the comment
	///				here "(" takes precedence prior to "."
	/// </summary>
	interface Noted
	{
	}
}
