using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg._pre_
{
	public class TxtComment
	{
		private  nilnul.obj.Opt1< _lex.word_.Txt> _txt;

		public nilnul.obj.Opt1<_lex.word_.Txt> txt
		{
			get { return _txt; }
			set { _txt = value; }
		}

		private _lex.word_.Comment _comment;
			
		public _lex.word_.Comment comment
		{
			get { return _comment; }
			set { _comment = value; }
		}
		public TxtComment(nilnul.obj.Opt1< _lex.word_.Txt> txt, _lex.word_.Comment comment)
		{
			_txt = txt;
			_comment = comment;

		}
		public TxtComment( _lex.word_.Txt txt,_lex.word_.Comment comment)
			: this( new nilnul.obj.Opt1<_lex.word_.Txt>(txt),comment)
		{


		}

		public TxtComment(_lex.word_.Comment comment)
			: this( new nilnul.obj.Opt1<_lex.word_.Txt>(), comment)
		{


		}
		public IEnumerable<TxtOrCommentI> enumerate() {
			if ( nilnul.obj.opt.be_.One1<_lex.word_.Txt>.Singleton.be(txt))
			{
				yield return (
					(txt as nilnul.obj.Opt1<_lex.word_.Txt>).val
					as 
					nilnul.obj.opt_.One<_lex.word_.Txt>
				).val;
			}
			yield return comment;
		}


		public override string ToString()
		{
			return $"{_txt}{_comment}";
		}

	}
}
