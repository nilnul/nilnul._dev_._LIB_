using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom._idiom._casible.concept_._entity._radic.txt.be_.upper_
{
	public class HasDigit
		: nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return Regex.IsMatch(obj,@"\A[A-Z][A-Z]*[A-Z]\z");
		}


		static public HasDigit Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<HasDigit>.Instance;
			}
		}

	}
}
