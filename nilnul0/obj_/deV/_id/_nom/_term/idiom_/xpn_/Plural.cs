using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom._idiom.casible_.nonmono_.xpn_
{
	/// <summary>
	/// in nonmono casible, the last concept, an <see cref="_casible.concept_.EntityI"/> can be made plural.
	/// to avoid confusion, we forbid the pluralization of the whole nonmono casible.
	/// To make the whole casible plural, let's resolve to <see cref=""/>
	/// </summary>

	[Serializable]
	public class PluralException : Exception
	{
		public PluralException() { }
		public PluralException(string message) : base(message) { }
		public PluralException(string message, Exception inner) : base(message, inner) { }
		protected PluralException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
