using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_
{
	/// <summary>
	/// dot sepearted 
	/// </summary>
	public class Start : SymbolI
	{
		private Seg _seg;

		public Seg seg
		{
			get { return _seg; }
			set { _seg = value; }
		}

		private List<Tuple<Dot, Seg>> _tail;

		public Start(Seg seg, List<Tuple<Dot, Seg>> tail)
		{
			this.seg = seg;
			this.tail = tail;
		}
		public Start(Seg seg):this(seg,new List<Tuple<Dot, Seg>>())
		{
			
		}


		public Seg tip {
			get {
				if (_tail.Any())
				{
					return _tail.Last().Item2;
				}
				return _seg;
			}
		}

		public IEnumerable<_compile_.parener._dot_._parse.symbol_.SegOrDotI> words
		{
			get {
				yield return _seg;

				foreach (var item in _tail)
				{
					yield return item.Item1;
					yield return item.Item2;

				}
			}

		}

		public Start normalize() {

			if (_tail.Any())
			{
				var newTail = _tail.ToList();
				newTail[newTail.Count - 1] = new Tuple<Dot, Seg>(
					new Dot() ,
					newTail[newTail.Count - 1].Item2.normalize()
				);

				return new Start(
					this._seg,
					newTail
				);
			}
			return new Start(this._seg.normalize(), new List<Tuple<Dot, Seg>>());

		}


		public List<Tuple<Dot, Seg>> tail
		{
			get { return _tail; }
			set { _tail = value; }
		}



		public override string ToString()
		{
			return $@"{_seg}{
				nilnul.obj.str_.enumable.phrase_.join_.Empty.Singleton.phrase(
					_tail.Select(
						x => nilnul.obj.couple.phrase_.join_.Empty<Dot, Seg>.Singleton.phrase(x)
					)
				)
			}";
		}

		static public Start Parse(IEnumerable<_lex.WordI> slider)
		{
			return Parse(
				new nilnul.obj.slider_.Enumer<_lex.WordI>(slider)
			);
		}

		static public Start Parse(nilnul.obj.slider_.Enumer<_lex.WordI> slider)
		{

			Seg seg;
			List<Tuple<Dot, Seg>> tail;
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

					var list = new List<_lex.word_.TxtOrCommentI>();
					list.Add(txtOrComment);

					slider.moveNext();
					while (slider.current is _lex.word_.TxtOrCommentI)
					{
						list.Add(slider.current as _lex.word_.TxtOrCommentI);
						slider.moveNext();
					}

					seg = Seg.Parse(list);
					tail = _start_.Tail.Parse(slider);

					break;
				default:
					throw new UnexpectedReachException();
					//retrieve seg

					break;
			}

			return new Start(seg, tail);



		}

	}
}
