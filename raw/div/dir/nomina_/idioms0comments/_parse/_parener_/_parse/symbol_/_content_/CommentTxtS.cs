using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_._content_
{
	public class CommentTxtS : List<CommentTxt>
	{

		public void append(
			symbol_.CommentI leading,
			nilnul.obj.slider.construct_.seq_._appendNul.Ret<TxtOrCommentI> enumerator
		)
		{
			switch (enumerator.current)
			{
				case symbol_.CommentI comment:
					this.Add(new CommentTxt(leading));
					enumerator.moveNext();
					append(comment, enumerator);
					break;
				case symbol_.Txt currentTxt:
					this.Add(new CommentTxt(leading, currentTxt));
					enumerator.moveNext();
					append(enumerator);
					break;
				case null:
					this.Add(new CommentTxt(leading));

					break;
				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		/// <summary>
		/// must be comment -leaded
		/// </summary>
		/// <param name="enumerator"></param>
		public void append(nilnul.obj.slider.construct_.seq_._appendNul.Ret<TxtOrCommentI> enumerator)
		{

			switch (enumerator.Current)
			{
				case symbol_.CommentI comment:
					enumerator.moveNext();
					append(comment, enumerator);
					break;
				case null:

					break;

				default:
					throw new UnexpectedTypeException();
					break;
			}


		}


		public void append(IEnumerable<TxtOrCommentI> enumerable)
		{
			append(
				new nilnul.obj.slider.construct_.seq_._appendNul.Ret<TxtOrCommentI>(
					enumerable
				)
			);
		}

		static public CommentTxtS Create(IEnumerable<TxtOrCommentI> enumerable)
		{
			var r = new CommentTxtS();
			r.append(enumerable);
			return r;
		}

		public override string ToString()
		{
			return string.Join("", this);
		}

		public IEnumerable<TxtOrCommentI> enumerate()
		{
			foreach (var item in this)
			{
				yield return item.comment;
				if (item.txt != null)
				{
					yield return item.txt;
				}
			}
		}
	}
}
