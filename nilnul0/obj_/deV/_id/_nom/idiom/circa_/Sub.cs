using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom.idiom.circa_
{
	/// <summary>
	/// if a type is both sub and ext, it's prefered to use sub.
	/// eg:
	///		idiom.circa_.Sub is not a subtype of idiom; so it's placed as an extension of idiom as idiom.Circa. But "sub" is also subtype of "circa"
	///	
	/// </summary>
	/// <remarks>
	/// sub makes browsing subtypes easy, as we know that all sub_.TypeS are subtype of "Sub"
	/// </remarks>
	interface ISub
	{
	}
}
