using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_
{
	/// segment content into segs. This is a builder, or io

	static public class _ParseX
	{
		static public _parse.symbol_.Start Parse(nilnul.obj.slider_.Enumer<_lex.WordI> input)
		{


			return _parse.symbol_.Start.Parse(input);
		}
		static public _parse.symbol_.Start Parse(Lex lex)
		{
			return Parse(new obj.slider_.Enumer<_lex.WordI>(lex));
		}

		static public _parse.symbol_.Start Parse(Content content)
		{
			return Parse(new Lex(content));
		}

		static public _parse.symbol_.Start Parse(string x)
		{
			return Parse(new Lex(x));
		}


	}
}