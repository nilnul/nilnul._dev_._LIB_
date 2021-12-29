using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_
{
	/// <summary>
	/// change words to symbols
	/// </summary>
	/// todo:
	/// 
	[Obsolete()]
	public class Parser
	{
		/// <summary>
		/// input
		/// </summary>
		_lex.word.Slider words;


		/// <summary>
		/// output
		/// </summary>
		//Stack<_parse.SymbolI> stack = new Stack<_parse.SymbolI>();

		nilnul.obj.slider_.Stuck<_parse.SymbolI> stuck = new obj.slider_.Stuck<_parse.SymbolI>();

		public _parse.symbol_.Content content{ get {
				return (_parse.symbol_.Content)stuck.current  ;
			}
		}



		public _parse.symbol_.comment_.Ended reduce2commentEnded(List<_parse.SymbolI> symbols)
		{
			return _parse.symbol_.comment_.Ended.Create(symbols);
		}

		public _parse.symbol_.comment_.Ended reduce2commentEnded(IEnumerable<_parse.SymbolI> symbols)
		{
			return _parse.symbol_.comment_.Ended.Create(symbols);
		}


		public _parse.symbol_.Content reduce2content(IEnumerable<_parse.SymbolI> symbols)
		{
			return new _parse.symbol_.Content(symbols.Cast<_parse.symbol_.TxtOrCommentI>());
		}



		public _parse.symbol_.comment_.Parened reduce2commentParened(IEnumerable<_parse.SymbolI> symbols)
		{
			return _parse.symbol_.comment_.Parened.Create(symbols);
		}



		public _parse.symbol_.comment_.Begun reduce2commentBegun(IEnumerable<_parse.SymbolI> symbols)
		{
			return _parse.symbol_.comment_.Begun.Create(symbols);
		}

		/// <summary>
		/// 
		/// </summary>
		public void parse(string s)
		{
			var l1 = new Lex(s);
			l1.parse();
			words = new _lex.word.Slider( l1.words);
			while (true)
			{
				switch (words.current)
				{
					case null:

						var popped12 = stuck.TakeWhile(x => !(x is _lex.word_.LeftParen) && !(x == null));

						switch (stuck.current)
						{
							case null:
								stuck.push(reduce2content(popped12));
								return ;
								break;
							default:
								var l = popped12.ToList();
								l.Add(stuck.current);
								stuck.moveNext();
								stuck.push(reduce2commentEnded(popped12));

								break;
						}

						break;
					case _lex.word_.RightParen rightParen:

						var popped123 = stuck.TakeWhile(x => !(x is _lex.word_.LeftParen) && !(x == null));

						switch (stuck.current)
						{
							case null:
								var reduced = reduce2commentBegun(popped123);

								stuck.push(
									reduced
								);

								break;
							
							default:
								var l = popped123.ToList();
								l.Add(stuck.pop());
								stuck.push(reduce2commentParened(l));
								break;
						}
					
						;
						break;
					case _lex.word_.Txt txt:
						stuck.push(new _parse.symbol_.Txt( txt));

						break;

					case _lex.word_.LeftParen leftParen:
						stuck.push(new _parse.symbol_.LeftParen( ));

						break;
					default:


						throw new UnexpectedTypeException();
						break;
				}
				words.moveNext();

			}



		}

		


	}
}

