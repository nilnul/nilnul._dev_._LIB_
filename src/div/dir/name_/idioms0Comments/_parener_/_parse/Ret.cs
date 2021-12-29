using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse
{
	
	/// <summary>
	/// the parsed. this is the "Start" symbol
	/// </summary>
	public interface RetI :SymbolI{

	}
	/// <summary>
	/// 
	/// </summary>
	public class Ret
	{
		Txt txt;    //nullable
		symbol_._content_.CommentTxtS commentTxtS = new symbol_._content_.CommentTxtS();  //emptible

		public override string ToString()
		{
			return $"{txt}{commentTxtS}";
		}
	}
}
