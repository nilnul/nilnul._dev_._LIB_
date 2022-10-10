using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg.identity
{




	static public  class _VersionX
	{





		

		static public readonly Regex Regex0 = new Regex(

			nilnul.obj_.deV_.pkg._identity._VersionX.Regex0.ToString()+@"\z"
			
			,
				RegexOptions.CultureInvariant | RegexOptions.Compiled | RegexOptions.ExplicitCapture |RegexOptions.IgnorePatternWhitespace
			,
				TimeSpan.FromSeconds(0.5)
		);

		


		static public nilnul.obj_.deV_.pkg._identity.VersionA OfIdenty(string s) {

			var m = Regex0.Match(s);
			if (m.Success)
			{
				return nilnul.obj_.deV_.pkg._identity._VersionX.Parse(m.Value);
			}

			/// the above shall always succeed, as we allow empty string.
			return null;

			
		
			
			
		}


		


	}


	
}
