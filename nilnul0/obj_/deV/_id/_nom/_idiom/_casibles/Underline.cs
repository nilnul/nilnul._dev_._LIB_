using nilnul.obj_.deV._id._nom._idiom._casible.concept_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom._idiom._casibles
{
	/// <summary>
	/// underline is used between, not around, casibles.
	/// used when term (casbiles) is in UPPER_CASE
	/// </summary>
	public class Underline
		:
		nilnul.obj.Box<char>
		,

		JuncI
	{
		public Underline() : base('_')
		{
		}
	}
}
