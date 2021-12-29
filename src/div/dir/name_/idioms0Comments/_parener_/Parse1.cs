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
	static public class _ParseX
	{





		static public _parse.symbol_.comment_.Ended Reduce2commentEnded(List<_parse.SymbolI> symbols)
		{
			return _parse.symbol_.comment_.Ended.Create(symbols);
		}

		static public _parse.symbol_.comment_.Ended reduce2commentEnded(IEnumerable<_parse.SymbolI> symbols)
		{
			return _parse.symbol_.comment_.Ended.Create(symbols);
		}


		static public _parse.symbol_.Content reduce2content(IEnumerable<_parse.SymbolI> symbols)
		{
			return new _parse.symbol_.Content(symbols.Cast<_parse.symbol_.TxtOrCommentI>());
		}



		static public _parse.symbol_.comment_.Parened reduce2commentParened(IEnumerable<_parse.SymbolI> symbols)
		{
			return _parse.symbol_.comment_.Parened.Create(symbols);
		}



		static public _parse.symbol_.comment_.Begun reduce2commentBegun(IEnumerable<_parse.SymbolI> symbols)
		{
			return _parse.symbol_.comment_.Begun.Create(symbols);
		}
		static public _parse.symbol_.Content Parse(_infixer._compile_._parener_._lex.Result lexResult)
		{
			return Parse(
				new _infixer._parener_._lex.word.Slider(lexResult)
			);

		}

		static public _parse.symbol_.Content Parse(_infixer._parener_._lex.word.Slider words)
		{

			nilnul.obj.slider_.Stuck<_parse.SymbolI> stuck = new obj.slider_.Stuck<_parse.SymbolI>();

			while (true)
			{
				switch (words.current)
				{
					case null:

						var popped12 = stuck.popWhile(
							x => !(x is _parse.symbol_.LeftParen) && !(x is null)
						);



						switch (stuck.current)
						{
							case null:
								popped12.Reverse();

								stuck.push(reduce2content(popped12));
								if (stuck.current == null)
								{
									return new _parse.symbol_.Content();

								}

								return (_parse.symbol_.Content)stuck.current;
								break;
							default:
								popped12.Add(stuck.pop());
								popped12.Reverse();
								stuck.push(Reduce2commentEnded(popped12));

								break;
						}

						break;
					case _lex.word_.RightParen rightParen:
						stuck.push(new _parse.symbol_.RightParen());

						var popped4RightParen = stuck.pop(1).Concat(
							stuck.popWhile(
								x =>
									!(x is _parse.symbol_.LeftParen)
									&&
									!(x == null)
							)
						).ToList();

						switch (stuck.current)
						{
							case null:
								popped4RightParen.Reverse();
								var reduced = reduce2commentBegun(popped4RightParen);

								stuck.push(
									reduced
								);

								break;

							default:

								popped4RightParen.Add(stuck.pop());
								popped4RightParen.Reverse();
								stuck.push(reduce2commentParened(popped4RightParen));
								break;
						}

						;
						break;
					case _lex.word_.Represent txt:
						stuck.push(new _parse.symbol_.Txt(txt));

						break;

					case _lex.word_.LeftParen leftParen:
						stuck.push(new _parse.symbol_.LeftParen());

						break;
					default:


						throw new UnexpectedTypeException();
						break;
				}
				words.moveNext();

			}


		}

		/// <summary>
		/// 
		/// </summary>
		static public _parse.symbol_.Content Parse(string s)
		{
			return Parse(new _compile_._parener_._lex.Result(s));




		}




	}
}

