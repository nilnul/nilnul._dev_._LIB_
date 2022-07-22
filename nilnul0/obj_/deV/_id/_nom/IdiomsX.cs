using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom
{
	/// <summary>
	/// idioms is not nom; but can be used to denote namespace.
	/// idioms can also be concatenated by "connectors" such as "0"
	/// AbcDef0Gh
	///		note the difference with AbcDef0gh, where Def0gh is a whole while in AbcDef0Gh, AbcDef and Gh are two wholes connected by "0"
	/// </summary>
	static public class IdiomsX
	{
		static public string JoinByDot(params string[] phrases) {
			return string.Join(".",phrases);
		}


	}
}
