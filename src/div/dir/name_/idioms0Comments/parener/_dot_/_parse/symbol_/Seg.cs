using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg;
using nilnul.obj.slider_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_
{
	/// <summary>
	/// such as (comment)abc(comment)(comment)abc
	/// </summary>

	public class Seg: _compile_.parener._dot_._parse.symbol_.SegOrDotI
	{
		private _seg.Pre _pre;
		public _seg.Pre pre
		{
			get { return _pre; }
			set { _pre = value; }
		}


		private _lex.word_.Txt _txt;
		public _lex.word_.Txt txt
		{
			get { return _txt; }
			set { _txt = value; }
		}


		private _seg.Post _post;
		public Seg(Pre pre, _lex.word_.Txt txt, Post post)
		{
			this._pre = pre;
			this.txt = txt;
			this.post = post;
		}

		public IEnumerable<_lex.word_.Txt> txts
		{
			get
			{
				foreach (var item in _pre.txts)
				{
					yield return item;
				}
				yield return _txt;
				foreach (var item in _post.txts)
				{
					yield return item;
				}
			}
		}

		public bool hasNotationCaseInsensitive(string notation) {
			return comments.Any(x=>x.toOriginal().hasNotationCaseInsensitive(notation));
		}

		public IEnumerable<nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment> comments
		{
			get
			{
				foreach (var item in _pre.comments)
				{
					yield return item;
				}

				foreach (var item in _post.comments)
				{
					yield return item;
				}
			}
		}

		public bool isNormalized()
		{
			return txts.First().ToString().StartsWith("_") || txts.Last().ToString().EndsWith("_");
		}

		public IEnumerable<TxtOrCommentI> txtOrCommentS
		{
			get
			{
				foreach (var item in this.pre.txtOrComments)
				{
					yield return item;

				}
				yield return txt;
				foreach (var item in this.post.txtOrComments)
				{
					yield return item;
				}

			}
		}

		public string name
		{
			get
			{
				return Regex.Replace( string.Join("", txts),"\\W","");
			}
		}

		public Seg foremostTxt()
		{
			return Parse(this.txtOrCommentS);
		}

		public Seg normalize()
		{
			if (isNormalized())
			{
				return this;
			}

			var txtOrCommentS = this.txtOrCommentS.ToList();
			var begin = txtOrCommentS.FindIndex(x => x is _lex.word_.Txt);

			var end = txtOrCommentS.FindLastIndex(x => x is _lex.word_.Txt);

			txtOrCommentS[begin] = new _lex.word_.Txt("_" + txtOrCommentS[begin].ToString());
			txtOrCommentS[end] = new _lex.word_.Txt(txtOrCommentS[end].ToString() + "_");

			return Parse(txtOrCommentS);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="slider"></param>
		/// <returns></returns>


		internal static Seg Retrieve(Enumer<WordI> slider)
		{
			switch (slider.current)
			{
				case _lex.word_.TxtOrCommentI txtOrComment:

					var l = new List<_lex.word_.TxtOrCommentI>();
					l.Add(txtOrComment);
					slider.moveNext();
					while (slider.current is _lex.word_.TxtOrCommentI)
					{
						l.Add(slider.current as _lex.word_.TxtOrCommentI);
						slider.moveNext();

					}
					return Parse(l);
					break;
				default:
					throw new Exception("no segs can be retrieved");
					//throw new Exception();
					break;
			}
			//throw new NotImplementedException();
		}



		public _seg.Post post
		{
			get { return _post; }
			set { _post = value; }
		}
		public override string ToString()
		{
			return $"{_pre}{_txt}{_post}";
		}
		/// <summary>
		/// no dot
		/// </summary>
		/// <param name="words"></param>
		/// <returns></returns>
		static public Seg Parse(IEnumerator<_lex.word_.TxtOrCommentI> words)
		{

			return Parse(new nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI>(words));
		}

		static public Seg Parse(nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> slider)
		{


			var r = Retrieve(slider);
			nilnul.obj.vow_.True.Vow(slider.current == null, new nilnul.exception_.ParseException("unexpected leftover after parsing Seg "));
			return r;

		}

		/// <summary>
		/// get as far as 
		/// </summary>
		/// <param name="slider"></param>
		/// <returns></returns>
		static public Seg Retrieve(nilnul.obj.slider_.Enumer<_lex.word_.TxtOrCommentI> slider)
		{
			_seg.Pre pre;
			_lex.word_.Txt txt;

			_seg.Post post;

			switch (slider.Current)
			{
				case _lex.word_.Txt txt1:
					pre = new Pre();
					txt = txt1;
					slider.moveNext();
					post = _seg.Post.Retrieve(slider);
					//return new Seg(pre, txt, post);
					break;
				case _lex.word_.Comment comment:
					var list = new List<_lex.word_.Comment>();
					list.Add(comment);
					slider.moveNext();
					while (slider.current is _lex.word_.Comment)
					{
						list.Add(slider.current as _lex.word_.Comment);
					}
					pre = new _seg.Pre(list);

					Seg tail;
					try
					{
						tail = Parse(slider);

					}
					catch (Exception e)
					{
						var ex = new Exception($"parsed: {pre} for Seg. no txt found ", e);


						throw ex;
					}


					pre = new _seg.Pre(pre.Concat(tail.pre));
					txt = tail.txt;
					post = tail.post;
					break;
				case null:

					throw new Exception("no txt found");

				default:
					throw new UnexpectedTypeException();
					break;

			}
			return new Seg(pre, txt, post);

		}

		internal static Seg Parse(IEnumerable<TxtOrCommentI> list)
		{
			return Parse(list.GetEnumerator());
			//throw new NotImplementedException();
		}
	}
}
