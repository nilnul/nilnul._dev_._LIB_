using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom._idiom._casible.concept_._entity._radic.txt
{
	public class Be
		: nilnul.txt.BeI
	{
		public bool be(string obj)
		{
			return Regex.IsMatch(obj,@"\A[A-Za-z][A-Za-z0-9]*[A-Za-z]\z");

			//return Regex.IsMatch(obj,@"\A[A-Za-z][A-Za-z]*[A-Za-z]\z");
			//throw new NotImplementedException();
		}


		static public Be Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Be>.Instance;
			}
		}

	}
}
