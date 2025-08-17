using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._lex.word_
{


	public interface TxtI :  WordI
	{

		

	}
	public class Txt : TxtI
	{


		public StringBuilder builder = new StringBuilder();


	


		public void append(char x)
		{
			builder.Append(x);
		}

		public void _append(char? _notNull)
		{
			append(_notNull.Value);
		}

		public override string ToString()
		{
			return builder.ToString();
		}

	}











}
