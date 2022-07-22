using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_.comment_
{




	public class Begun : CommentA
	{
		public Begun(Content content) : base(content)
		{
		}

		static public Begun Create(IEnumerable<SymbolI> symbols)
		{
			nilnul.obj.vow_.True.Singleton.vow(symbols.Last() is symbol_.RightParen);

			return new Begun(
				new Content(
				symbols.Take(symbols.Count()-1).Cast<TxtOrCommentI>()
			)
			);

		}

		public override string ToString()
		{
			return $"{boxed})";
		}



	}







}
