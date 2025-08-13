using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identification.versionary._parse
{
	internal class _RegexX
	{
		//[RegexGen]
		public Regex GetRegex()
		{
			return new Regex(
@"^
(?<major>0|[1-9]\d*)
\.
(?<minor>0|[1-9]\d*)
\.
(?<patch>0|[1-9]\d*)

(?:
	-
	(?<prerelease>(?:
			0
			|
			[1-9]\d*
			|
			\d*[a-zA-Z-][0-9a-zA-Z-]*
		)
		(?:
			\.(?:
				0|
				[1-9]\d*|
				\d*[a-zA-Z-][0-9a-zA-Z-]*
			)
		)*
	)
)?

(?:
	\+
	(?<buildmetadata>
		[0-9a-zA-Z-]+
		(?:\.[0-9a-zA-Z-]+)*
	)
)?
$"


				 //,				RegexOptions.Singleline
				 //,				RegexOptions
				 , RegexOptions.IgnorePatternWhitespace
			);
		}
	}
}
