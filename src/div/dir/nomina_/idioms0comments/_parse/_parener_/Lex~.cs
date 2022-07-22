using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._parener_._lex;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_
{
	public class Lex1:IEnumerable<_lex.WordI>
	{
		nilnul.character_.cha.be_.ComplementOf notPunc = new character_.cha.be_.ComplementOf(
			'('
			,
			')'
		);

		#region input
		public nilnul.character_.cha.nulable.slider_.Txt readerStream;
		#endregion

		//public List<_lex.Symbol> tokens = new List<_lex.Symbol>();

		#region result		
		//public _lex.word.List words = new _lex.word.List();
		public string errorMsg = "";
		#endregion



		public string tokensToTxt()
		{
			return words.ToString();
		}


		public string parsedResult()
		{

			if (errorMsg == "")
			{
				return tokensToTxt();
			}
			else
			{
				return tokensToTxt() + "\r\n" + errorMsg;
			}

		}

		public void run(string s)
		{
			readerStream = new character_.cha.nulable.slider_.Txt(s);

			words = new _lex.word.List();
			errorMsg = "";

			parseTail_notRead();


		}



		public void readNext_intoCurrent()
		{
			//current = readerStream.current;
			readerStream.moveNext();
		}







		public void parseHeaded_reduceCurrentAsSymbol(_lex.WordI symbol)
		{

			words.Add(symbol);
			parseTail_notRead();

		}




		public void parseHeaded_ruleSeg()
		{

			var symbol = new _lex.word_.Txt();
			symbol._append(readerStream.current);    // { name = current1.ToString() };

			readerStream.moveNext();

			while (isSeg(readerStream.current))
			{
				symbol.append(readerStream.current.Value);
				readerStream.moveNext();
			}

			words.Add(symbol);

			parseHeaded_currentFilled();


		}




		public void parseHeaded_currentNotNul()
		{

			if (readerStream.current == '(')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.word_.LeftParen());


			}


			else if (readerStream.current == ')')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.word_.RightParen());

			}

			
			else
			{
				parseHeaded_ruleSeg();
			}
			return;


		}
		public void parseHeaded_currentFilled()
		{

			if (readerStream.current == null)
			{
				return;
			}
			else
			{
				parseHeaded_currentNotNul();

			}
		}

		public void parseTail_notRead()
		{
			readNext_intoCurrent();
			parseHeaded_currentFilled();
		}




		public bool isSeg(char? current)
		{
			return current != null && notPunc.be(readerStream.current.Value);
		}


		public bool isSeg()
		{
			return isSeg(readerStream.current);
		}


		public void error(string msg)
		{
			errorMsg = msg;
			return;
			throw new Exception(msg);

		}

		public IEnumerator<WordI> GetEnumerator()
		{
			return ((IEnumerable<WordI>)words).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<WordI>)words).GetEnumerator();
		}
	}
}
