using nilnul.obj_.deV._id._nom.idiom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identy
{
	/// <summary>
	/// zero or more terms
	/// </summary>
	/// <remarks>
	/// alias:
	///		sur
	///		namespace
	///		schema
	///		linege
	///		descent
	///		context
	///		surrounding
	///	nomenclature:
	///		mnemonics
	///			sur, schema: begin with the same letter.
	///			sur, is the initial part of surname
	///			sur, is predecessor to "name" in "surname"
	/// </remarks>
	public class Sur : nilnul.obj.Box1<_id._nom.idiom.Sentineled>
	{
		public Sur(Sentineled val) : base(val)
		{
		}
		public override string ToString()
		{
			return string.Join("", this);
		}
	}
}
