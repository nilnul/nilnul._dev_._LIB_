using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.input_.txt
{
	/// <summary>
	/// change txt to symbol
	/// </summary>
	public class SplitByDot :
		nilnul.obj.Box<_parener_._parse.symbol_.Txt>
		,
		IEnumerable<_lex.WordI>
	{
		public SplitByDot(_parener_._parse.symbol_.Txt val) : base(val)
		{
			chaSlider = new character_.cha.nulable.slider_.Txt(
				this.boxed.ToString()
			);
		}

		nilnul.character_.cha.nulable.slider_.Txt chaSlider;

		public IEnumerator<WordI> GetEnumerator()
		{
			while (chaSlider.current != null)
			{
				switch (chaSlider.current)
				{
					case '.':
						yield return new word_.Dot();
						chaSlider.moveNext();

						break;
					
					default:
						yield return retrieve_Txt();
						break;
				}


			}


			//throw new NotImplementedException();
		}

		private WordI retrieve_Txt()
		{
			var r = new word_.Txt();
			while (chaSlider.current != null && chaSlider.current != '.')
			{
				r.append(chaSlider.current.Value);
				chaSlider.moveNext();

			}
			return r;
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
