using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_.start
{
	public class Parse
	{
		Lex lex;

		Stack<_parse.SymbolI> stack;
		IEnumerator<_lex.WordI> enumerator;

		nilnul.obj.slider_.Enumer<_lex.WordI> slider;

		public Parse()
		{
			enumerator = lex.GetEnumerator();

		}

		public void parse()
		{


			switch (slider.current)
			{
				case _lex.word_.Dot dot:
					throw new Exception("cannot be started with dot");

					//reduce stak to 
					break;
				case null:
					throw new Exception("no segs found");
					break;
				case _lex.word_.TxtOrCommentI txtOrComment:

					break;
				default:
					//retrieve seg

					break;
			}



		}

		public symbol_.Seg retrieve_seg()
		{

			while (enumerator.MoveNext())
			{
				switch (enumerator.Current)
				{
					case _lex.word_.Dot dot:

						//reduce stak to 
						break;
					default:
						break;
				}


			}
		}

	}
}
