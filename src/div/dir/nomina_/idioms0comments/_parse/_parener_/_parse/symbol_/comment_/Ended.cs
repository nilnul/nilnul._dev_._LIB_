using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_.comment_
{




	public class Ended : CommentA
	{

		public Ended(Content content) : base(content)
		{
		}

		

		static public Ended Create(List<SymbolI> symbols) {
			nilnul.obj.vow_.True.Singleton.vow( symbols.First() is symbol_.LeftParen);

			return new Ended(
				new Content( 
				symbols.Skip(1).Cast<TxtOrCommentI>()
			)
			);

		}

		static public Ended Create(IEnumerable<SymbolI> symbols) {
			nilnul.obj.vow_.True.Singleton.vow( symbols.First() is symbol_.LeftParen);

			return new Ended(
				new Content( 
				symbols.Skip(1).Cast<TxtOrCommentI>()
			)
			);

		}



		public override string ToString()
		{
			return $"({boxed}";
		}



	}







}
