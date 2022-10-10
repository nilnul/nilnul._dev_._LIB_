using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_
{
	/// <summary>
	/// the io of lex
	/// </summary>
	/// 
	[Obsolete(nameof(_infixer._compile_._parener_._lex.Result))]
	public class Lex
	{
		static public nilnul.character_.cha.be_.ComplementOf NotPunc = new character_.cha.be_.ComplementOf(
			'('
			,
			')'
		);

		#region input
		public nilnul.character_.cha.nulable.slider_.Txt readerStream;
		#endregion

		//public List<_lex.Symbol> tokens = new List<_lex.Symbol>();

		#region result		
		public _lex.word.List words;//= new _lex.word.List();
		public string errorMsg = "";
		#endregion

		public string input()
		{
			return words.ToString();
		}

		public string result()
		{
			if (errorMsg == "")
			{
				return input();
			}
			else
			{
				return input() + "\r\n" + errorMsg;
			}
		}

		public  Lex(string s)
		{
			readerStream = new character_.cha.nulable.slider_.Txt(s);
			words = new _lex.word.List();
			errorMsg = "";
		}
		
		public void _retrieveTxt()
		{
			var symbol = new _lex.word_.Represent();
			symbol._append(readerStream.current);    // { name = current1.ToString() };
			readerStream.moveNext();

			while (_isTxt(readerStream.current))
			{
				symbol.append(readerStream.current.Value);
				readerStream.moveNext();
			}
			words.Add(symbol);
		}
		
		public void parse()
		{

			switch (readerStream.current)
			{
				case null:
					break;
				case '(':
					words.Add(new _lex.word_.LeftParen());
					readerStream.moveNext();
					parse();

					break;
				case ')':
					words.Add(new _lex.word_.RightParen());
					readerStream.moveNext();
					parse();
					break;
				default:
					_retrieveTxt();
					parse();
					break;
			}

			
				
			
		}

		public bool _isTxt(char? current)
		{
			return current != null && NotPunc.be(current.Value);
		}

		public bool _isTxt()
		{
			return _isTxt(readerStream.current);
		}
	}
}
