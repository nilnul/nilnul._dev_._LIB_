using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_
{
	public class Txt :
		nilnul.obj.Box<StringBuilder>
		,

		WordI
		,
		TxtOrCommentI
	{

		public Txt(StringBuilder sb):base(sb)
		{

		}

		public Txt():this(new StringBuilder())
		{

		}
		public Txt(string val) : this(new StringBuilder(val))
		{
		}

		public void append(char c) {
			boxed.Append(c);
		}


	}
}
