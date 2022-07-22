using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.div.dir.nomina_.idioms0comments
{
	static public class _ParseX
	{
		static public Idioms0commentsI Parse(nilnul.obj.slider_.Enumer<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI> input)
		{


			return Idioms0commentsA.Parse(input);
		}
		static public Idioms0commentsI Parse(dev.sln.as_.dst.name._infixer.parener._dot_.Lex lex)
		{
			return Parse(new obj.slider_.Enumer<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI>(lex));
		}

		static public Idioms0commentsI Parse(dev.sln.as_.dst.name._infixer._parener_._parse.symbol_.Content content)
		{
			return Parse(new Lex(content));
		}

		static public Idioms0commentsI Parse(string x)
		{
			return Parse(new Lex(x));
		}


	}
}
