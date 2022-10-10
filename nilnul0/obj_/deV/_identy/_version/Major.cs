using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV.identy._versioned._version
{
	/*
	
	 */
	/// <summary>
	/// 
	/// </summary>
	/// 
	public interface IMajor
	{
	}
}

/*
 in nilnul,
	5.7 to 5.8 with some increment changes.
	when we remove 5.7 from 5.8, and still make 5.8 work, but disregard whether 5.7 works or not, we get a version "5.(8-7)". we rename this version as 6.
	new project shall use v6, and old project can still use 5.8.
	when we develop v6, obsoleted code is marked as "Not in Pac" or "Obsolte(true)". In other words, v6 still takes in old src code in src; but when compiled, old code is removed.
	by so doing, v5 can still merge the update in v6, resulting in growing minor vers, as in "5.9", "5.129", etc. And we need not to provide the hassle of "upgrading and importing"

the old 5.* will grow more and more cumbersome. but that's users choice.
new user can use leaned v6
 */