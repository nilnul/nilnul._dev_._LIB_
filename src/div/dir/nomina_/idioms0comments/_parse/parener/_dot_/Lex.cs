using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_
{
	/// <summary>
	/// transform txt content into dot txt, comment
	/// </summary>
	public class Lex : IEnumerable<_lex.WordI>
	{

		_parener_._parse.symbol_.Content content;

		public Lex(_parener_._parse.symbol_.Content content)
		{
			this.content = content;
		}

		public Lex(string x)
		{
			this.content =  _parener_._ParseX.Parse(x);
			
		}

		public IEnumerator<_lex.WordI> GetEnumerator()
		{
			var enumerator = content.GetEnumerator();
			while (enumerator.MoveNext())
			{
				switch (enumerator.Current)
				{
					case _parener_._parse.symbol_.Txt txt:
						foreach (var item in new _lex.input_.txt.SplitByDot(txt))
						{
							yield return item;
						}
						break;
					case _parener_._parse.symbol_.CommentI comment:
						yield return new _lex.word_.Comment(comment);
						break;
					default:
						throw new UnexpectedTypeException();
						break;
				}

			}
			

		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
