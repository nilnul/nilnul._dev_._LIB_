using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_.comment_
{




	public class Parened : CommentA
	{

		public Parened(Content content) : base(content)
		{
		}

		static public Parened Create(IEnumerable<SymbolI> symbols)
		{
			nilnul.obj.vow_.True.Singleton.vow(symbols.First() is symbol_.LeftParen);
			nilnul.obj.vow_.True.Singleton.vow(symbols.Last() is symbol_.RightParen);


			return new Parened(
				new Content(
				symbols.Skip(1).Take(symbols.Count()-2).Cast<TxtOrCommentI>()
			)
			);

		}

		public override string ToString()
		{
			return $"({boxed})";
		}



	}







}
