using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identy._nomina.noms.be_
{
	/// <summary>
	/// a nom is supposed to be not same in case insensitiveness as any antecedent ones.
	/// if there is such repetitiveness, we need to find alias to euphemism.
	/// </summary>
	/// <remarks>
	/// this is needed when we want to promote some nom to a earlier place.
	/// eg:
	///		usr.chron.slates would mean slates for a given chron. And if we intend to mean: chrons.every.slates, then we can nominate it as "usr.slates" where slates mean "chron.slate.str"
	/// </remarks>
	/// alias:
	///		anaphora 
	///			,such as:  do in "I like it and so do they".
	/// 
	internal class IDistinct8CaseInsensitive
    {
    }
}
