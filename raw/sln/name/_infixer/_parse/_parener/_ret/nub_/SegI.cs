using nilnul.dev.sln.as_.dst.name._infixer._lex;
using nilnul.dev.sln.as_.dst.name._infixer._lex.word_;
using nilnul.lang.eg.logic._walk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parse._parener._ret.nub_
{

	/// <summary>
	/// txt with comment in
	/// </summary>
	public interface SegI : NubI
	{



	}

	/// <summary>
	/// seg can be empty such as in ".." or in ".()."
	/// </summary>

	public class Seg : List<_seg_.EleI>, SegI
	{
		//list of comment or txt
		internal void Add(_lex.word_.TxtI txt)
		{
			base.Add(new _seg_.ele_.Txt(txt));

			//throw new NotImplementedException();
		}

		internal void Add(WordI current)
		{
			switch (current)
			{
				case _lex.word_.TxtI txt:
					Add(txt);
					break;
				default:
			throw new UnexpectedTypeException();

					break;
			}
		}

		public bool containTxt() {
			return this.Any(x=> x is _seg_.ele_.Txt);
		}

		public void vowContainTxt() {
			 nilnul.obj.vow_.True.Singleton.vow(containTxt());
		}

		public override string ToString()
		{
			return string.Join("",this);
		}
	}



}
