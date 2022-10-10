using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg._post_
{
	public class CommentTxt
	{
		private _lex.word_.Comment _comment;
			
		public _lex.word_.Comment comment
		{
			get { return _comment; }
			set { _comment = value; }
		}

		private  nilnul.obj.Opt1< _lex.word_.Txt> _txt;

		public nilnul.obj.Opt1<_lex.word_.Txt> txt
		{
			get { return _txt; }
			set { _txt = value; }
		}

		public CommentTxt(_lex.word_.Comment comment, nilnul.obj.Opt1<_lex.word_.Txt> txt)
		{
			_comment = comment;
			_txt = txt;

		}

		public CommentTxt(_lex.word_.Comment comment)
			:this(comment, new nilnul.obj.Opt1<_lex.word_.Txt>())
		{
			

		}

		public CommentTxt(_lex.word_.Comment comment, _lex.word_.Txt txt)
			:this(comment, new nilnul.obj.Opt1<_lex.word_.Txt>(txt))
		{
			

		}

		public IEnumerable<TxtOrCommentI> enumerate()
		{
			yield return comment;
			if (nilnul.obj.opt.be_.One1<_lex.word_.Txt>.Singleton.be(txt))
			{
				yield return (
					(txt as nilnul.obj.Opt1<_lex.word_.Txt>).val
					as
					nilnul.obj.opt_.One<_lex.word_.Txt>
				).val;
			}
		}


		public override string ToString()
		{
			return $"{_comment}{_txt}";
		}

	}
}
