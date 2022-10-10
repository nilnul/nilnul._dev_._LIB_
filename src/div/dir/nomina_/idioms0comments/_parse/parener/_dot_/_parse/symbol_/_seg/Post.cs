using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg._post_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg
{
	public class Post : List<_post_.CommentTxt>
	{
		public override string ToString()
		{
			return string.Join("", this);
		}

		public Post()
		{

		}

		public IEnumerable<_lex.word_.Txt> txts
		{
			get
			{
				return this.Where(
					x => nilnul.obj.opt.be_.One1<_lex.word_.Txt>.Singleton.be(x.txt)
				).Select(
					y => (
						(
							y.txt as nilnul.obj.Opt1<_lex.word_.Txt>).val as nilnul.obj.opt_.One<_lex.word_.Txt>
					).val
				);
			}
		}

		public Post(IEnumerable<CommentTxt> collection) : base(collection)
		{
		}

		static public Post Parse(IEnumerator<_lex.word_.TxtOrCommentI> words)
		{
			return
				Parse(
					new nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI>(words)
				)
			;


		}



		static public Post Parse(nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> words)
		{

			var r = Retrieve(words);

			if (words.current!=null)
			{
				throw new Exception();
			}
			return r;


		}

		static public Post Retrieve(nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> words)
		{
			return new Post(
				Retrieve2List(
					words
				)
			);


		}
		public IEnumerable<_lex.word_.Comment> comments
		{
			get
			{
				return this.Select(
					x => x.comment
				);
			}
		}
		public IEnumerable<_lex.word_.TxtOrCommentI> txtOrComments
		{
			get
			{

				foreach (var item in this)
				{
					foreach (var item2 in item.enumerate())
					{
						yield return item2;
					}
				}
			}
		}


		static public List<_post_.CommentTxt> Parse2List(nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> slider)
		{
			
			var r = Retrieve2List( slider);
			if (slider.current != null)
			{
				throw new Exception();
			}
			return r;

		}

		static public List<_post_.CommentTxt> Retrieve2List(nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> slider)
		{
			//lookahead
			var builder = new List<_post_.CommentTxt>();


			switch (slider.Current)
			{
				case _lex.word_.Comment comment:
					slider.moveNext();
					builder.AddRange(Retrieve2List(comment, slider));

					break;
				case _lex.word_.Txt txt:
					//slider.moveNext();
					break;
				case null:
					//slider.moveNext();

					break;

				default:
					//slider.moveNext();
					break;
			}
			return builder;

		}


		static public List<_post_.CommentTxt> Parse2List(_lex.word_.Comment head, nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> slider)
		{
			var r = Retrieve2List( head,  slider);
			if (slider.current!=null)
			{
				throw new Exception();
			}
			return r;
		}

		static public List<_post_.CommentTxt> Retrieve2List(_lex.word_.Comment head, nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> slider)
		{
			//lookahead
			var builder = new List<_post_.CommentTxt>();

			switch (slider.Current)
			{

				case _lex.word_.Comment comment:
					builder.Add(new _post_.CommentTxt(head));
					slider.moveNext();
					builder.AddRange(Retrieve2List(comment, slider));

					break;
				case _lex.word_.Txt txt:
					builder.Add(new _post_.CommentTxt(head, txt));
					slider.moveNext();
					builder.AddRange(Retrieve2List(slider));

					break;
				case null:
					builder.Add(new _post_.CommentTxt(head));
					//slider.moveNext();
					break;
				default:
					throw new UnexpectedTypeException();
					//slider.moveNext();
					break;

			}
			//slider.moveNext();
			return builder;
		}

	}
}
