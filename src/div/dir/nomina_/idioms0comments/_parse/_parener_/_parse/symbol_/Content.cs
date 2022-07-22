using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_
{
	public interface ContentI
	{

	}

	/// <summary>
	/// the start symbol
	/// </summary>
	public class Content
		:
		SymbolI
		,
		IEnumerable<TxtOrCommentI>


	{

		/// <summary>
		/// nullable
		/// </summary>
		public Txt txt;   

		private _content_.CommentTxtS _commentTxtS;

		public _content_.CommentTxtS commentTxtS
		{
			get { return _commentTxtS; }
			//set { _commentTxtS = value; }
		}

	
		public Content(string txt, _content_.CommentTxtS commentTxtS)
		{
			this.txt = new Txt(txt);
			this._commentTxtS = commentTxtS;
		}

		public Content(string txt) : this(txt, new _content_.CommentTxtS())
		{

		}

		public Content() : this((string)null)
		{

		}


		public Content(IEnumerable<TxtOrCommentI> enumerable)
		{


			if (enumerable.Any())
			{
				if (enumerable.First() is symbol_.Txt)
				{
					txt = enumerable.First() as symbol_.Txt;
					_commentTxtS = _content_.CommentTxtS.Create(
						enumerable.Skip(1)
					);
				}
				else if (enumerable.First() is symbol_.CommentI)
				{
					_commentTxtS = _content_.CommentTxtS.Create(
						enumerable
					);
				}
				else
				{
					throw new UnexpectedTypeException();
				}
			}
			else
			{
				_commentTxtS = new _content_.CommentTxtS();

			}


		}

		static public Content CreateFroTxt(string txt)
		{
			return new Content(txt);
		}

		public override string ToString()
		{
			return $"{txt}{commentTxtS}";
		}

		public IEnumerator<TxtOrCommentI> GetEnumerator()
		{
			if (txt != null)
			{
				yield return txt;
			}
			foreach (var item in commentTxtS.enumerate())
			{
				yield return item;
			}

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}



}
