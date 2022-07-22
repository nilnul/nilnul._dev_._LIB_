using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.div.dir.segs
{
	[Obsolete()]
	static public class _ParseX
	{
		static public Segs Parse(as_.dst.name._infixer.parener._dot_.Lex lex)
		{
			return Parse(new obj.slider_.Enumer<as_.dst.name._infixer.parener._dot_._lex.WordI>(lex));
		}

		static public Segs Parse(as_.dst.name._infixer._parener_._parse.symbol_.Content content)
		{
			return Parse(new Lex(content));
		}

		static public Segs Parse(string x)
		{
			return Parse(new Lex(x));
		}


		static public Segs Parse(nilnul.obj.slider_.Enumer<as_.dst.name._infixer.parener._dot_._lex.WordI> input)
		{


			return Segs.Parse(input);
		}
	}
}
