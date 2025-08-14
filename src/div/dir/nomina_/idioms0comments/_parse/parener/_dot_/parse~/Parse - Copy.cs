using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_
{
	[Obsolete(nameof(_ParseX))]
	public class Parse
	{

		nilnul.obj.slider_.Enumer<_lex.WordI> input;

		Exception xpn;
		public _parse.symbol_.Start parsed;

		public Parse(Lex lex)
		{
			//this.lex = lex;
			input = new obj.slider_.Enumer<_lex.WordI>(lex);

		}



		public Parse(Content content) : this(new Lex(content))
		{


		}

		public Parse(string x) : this(new Lex(x))
		{

		}

		public string result
		{
			get
			{

				if (xpn == null)
				{
					return parsed.ToString();
				}
				else
				{
					return xpn.ToString();
				}
			}
		}


		public void parse()
		{

			try
			{
				parsed = _parse.symbol_.Start.Parse(input);

			}
			catch (Exception x)
			{
				xpn = x;

				//throw;
			}



		}


	}
}
