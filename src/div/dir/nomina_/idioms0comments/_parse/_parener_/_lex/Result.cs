using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._parener_._lex;
using nilnul.dev.sln.as_.dst.name._infixer._parener_;

namespace nilnul.dev.sln.as_.dst.name._infixer._compile_._parener_._lex
{
	/// <summary>
	/// the io of lex
	/// </summary>
	public class Result : IEnumerable<WordI>
	{
		static public nilnul.character_.cha.be_.ComplementOf NotPunc = new character_.cha.be_.ComplementOf(
			'('
			,
			')'
		);

		#region input
		public nilnul.character_.cha.nulable.slider_.Txt readerStream;
		#endregion


		public Result(string s)
		{
			readerStream = new character_.cha.nulable.slider_.Txt(s);
			//words = new _lex.word.List();
			//errorMsg = "";
		}

		public WordI _retrieveTxt()
		{
			var symbol = new _infixer._parener_._lex.word_.Represent();
			symbol._append(readerStream.current);    // { name = current1.ToString() };
			readerStream.moveNext();

			while (_isTxt(readerStream.current))
			{
				symbol.append(readerStream.current.Value);
				readerStream.moveNext();
			}
			return symbol;
		}


		

		public bool _isTxt(char? current)
		{
			return current != null && NotPunc.be(current.Value);
		}

		public bool _isTxt()
		{
			return _isTxt(readerStream.current);
		}

		public IEnumerator<WordI> GetEnumerator()
		{
			while (readerStream.current != null)
			{
				switch (readerStream.current)
				{
					//case null:
					//	break;
					case '(':
						yield return new _infixer._parener_._lex.word_.LeftParen();
						readerStream.moveNext();
						//parse();

						break;
					case ')':
						yield return (new _infixer._parener_._lex.word_.RightParen());
						readerStream.moveNext();
						//parse();
						break;
					default:
						yield return _retrieveTxt();
						//parse();
						break;
				}

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
