using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg
{
	public class Pre : List<_pre_.TxtComment>, IEquatable<Pre>
	{
		public override string ToString()
		{
			return string.Join("", this);
		}
		public Pre()
		{
		}

		public IEnumerable<_lex.word_.Txt> txts {
			get {
				return this.Where(
					x => nilnul.obj.opt.be_.One1<_lex.word_.Txt>.Singleton.be(x.txt) 
				).Select(
					y=>(
						(
							y.txt as nilnul.obj.Opt1<_lex.word_.Txt>
						).val as nilnul.obj.opt_.One<_lex.word_.Txt>
					).val
				);
			}
		}


		public IEnumerable<_lex.word_.Comment> comments {
			get {
				return this.Select(
					x => x.comment 
				);
			}
		}


		public IEnumerable<_lex.word_.TxtOrCommentI> txtOrComments { get {

				foreach (var item in this)
				{
					foreach (var item2 in item.enumerate())
					{
						yield return item2;
					}
				}
		} }

		public Pre(IEnumerable<_pre_.TxtComment> collection) : base(collection)
		{
		}

		public Pre(List<Comment> list):this( list.Select(x=>new _pre_.TxtComment(x)))
		{

		}

		static public Pre Parse(IEnumerator<_lex.word_.TxtOrCommentI> words)
		{
			return new Pre(
				Parse2List(
					new nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI>(words)
				)
			);


		}
		static public List<_pre_.TxtComment> Parse2List(nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> slider)
		{
			//lookahead

			var builder = new List<_pre_.TxtComment>();


			switch (slider.Current)
			{
				case _lex.word_.Comment comment:

					builder.Add( new _pre_.TxtComment(comment) );
					slider.moveNext();

					builder.AddRange( Parse2List(slider));

					break;
				case _lex.word_.Txt txt:

					slider.moveNext();
					builder.AddRange(Parse2List(txt, slider));

					break;
				case null:

					break;

				default:
					throw new UnexpectedTypeException();
					break;
			}
			return builder;

		}


		static public List<_pre_.TxtComment> Parse2List(_lex.word_.Txt head, nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> slider)
		{
			//lookahead
			var builder = new List<_pre_.TxtComment>();

			switch (slider.Current)
			{

				case _lex.word_.Comment comment:
					builder.Add(new _pre_.TxtComment(head, comment));
					slider.moveNext();
					builder.AddRange(Parse2List(slider));

					break;
				case _lex.word_.Txt txt:
					throw new Exception("no two successive txt");

					break;
				case null:
					throw new Exception("only txt, not comment follows in the pre");

					break;
				default:
					throw new UnexpectedTypeException();
					break;

			}
			return builder;
		}

		public bool Equals(Pre other)
		{
			return nilnul.obj.str_.enumable.Eq<_pre_.TxtComment, nilnul.dev.sln.as_.dst.name._infixer._compile_.parener._dot_._parse.symbol_._seg._pre_.txtComment.Eq>.Singleton.Equals(this,other);

			//throw new NotImplementedException();
		}
		
	}
}
