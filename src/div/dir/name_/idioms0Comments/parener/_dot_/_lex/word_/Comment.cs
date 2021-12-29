using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_
{
	public class Comment :
		nilnul.obj.Box<_infixer._parener_._parse.symbol_.CommentI>
		,
		WordI
		,
		TxtOrCommentI
	{
		public Comment(CommentI val) : base(val)
		{
		}

	}
}
