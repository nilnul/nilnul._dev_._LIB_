using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex;
using nilnul.obj.slider_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._start_
{
	public class Tail:List<Tuple<Dot, Seg>> 
	{
		public Tail(IEnumerable<Tuple<Dot, Seg>> collection) : base(collection)
		{
		}

		static public Tail Parse(Enumer<WordI> slider) {
			var r = Retrieve(slider);

			nilnul.obj_.nothing.Vow.Singleton.vow(slider.current,new Exception("something is leftover after Tail is parsed"));
			return r;

			//return nilnul.obj_.nothing.vow._EnX.En(slider.current,);
			

		}
		internal static Tail Retrieve(Enumer<WordI> slider) {
			return new Tail( Retrieve2List(slider));
		}

		internal static List<Tuple<Dot, Seg>> Retrieve2List(Enumer<WordI> slider)
		{
			var r = new List<Tuple<Dot, Seg>>();
			switch (slider.current)
			{
				case null:
					break;
				case _lex.word_.Dot dot:
					var dot1 = dot;
					slider.moveNext();


					var tuple = new Tuple<Dot, Seg>( 
						new _parse.symbol_.Dot( dot1), 
						Seg.Retrieve(slider)
					);

					r.Add(tuple);


					r.AddRange(Retrieve2List(slider));

					break;
				default:

					break;
			}
			return r;
			//throw new NotImplementedException();
		}


	}
}
