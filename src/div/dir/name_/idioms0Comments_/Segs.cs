using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder._repoName.dir.name_.idioms0Comments_
{
	/// <summary>
	/// dot sepearted ( Seg(emptible txt with comments interleft) ).
	/// This cannot be empty(in other words, it's headed).
	/// </summary>
	public class Segs : Idioms0CommentsI
	{
		private Seg _seg;   //nullable

		public Seg seg
		{
			get { return _seg; }
			set { _seg = value; }
		}

		private List<Tuple<Dot, Seg>> _tail;

		public Segs(Seg seg, List<Tuple<Dot, Seg>> tail)
		{
			if (seg == null)
			{
				nilnul.obj.vow_.True.Vow(nilnul.objs.be_._NoneX.None(tail), "when seg is null, tail must be empty");
			}

			this.seg = seg;
			this.tail = tail;
		}
		public Segs(Seg seg) : this(seg, new List<Tuple<Dot, Seg>>())
		{

		}
		public Segs() : this(null as Seg)
		{

		}

		public IEnumerable<Seg> asSegs() {
			if (_seg==null)
			{
				yield break;
			}

			yield return _seg;
			foreach (var item in _tail)
			{
				yield return item.Item2;
			}
		}

		public  string name
		{
			get
			{
				return $@"{string.Join(".",
						asSegs().Select(x=>x.name)
					)
				}";
			}
		}

		public Seg tip
		{
			get
			{
				if (_tail.Any())
				{
					return _tail.Last().Item2;
				}
				return _seg;
			}
		}

		public IEnumerable<dev.sln.as_.dst.name._infixer._compile_.parener._dot_._parse.symbol_.SegOrDotI> words
		{
			get
			{
				if (_seg==null)
				{
					yield break;

				}
				yield return _seg;

				foreach (var item in _tail)
				{
					yield return item.Item1;
					yield return item.Item2;

				}
			}

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

		static public Segs Parse(IEnumerable<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI> slider) => Parse(
new nilnul.obj.slider_.Enumer<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI>(slider)
);

		static public Segs Parse(nilnul.obj.slider_.Enumer<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI> slider)
		{

			Seg seg;
			List<Tuple<Dot, Seg>> tail;//=new List<Tuple<Dot, Seg>>();
			switch (slider.current)
			{
				case dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Dot dot:
					throw new Exception("cannot be started with dot");

					//reduce stak to 
					break;
				case null:
					seg = null;
					tail = new List<Tuple<Dot, Seg>>();
					//throw new Exception("no segs found");
					break;
				case dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.TxtOrCommentI txtOrComment:

					var list = new List<dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.TxtOrCommentI>();
					list.Add(txtOrComment);

					slider.moveNext();
					while (slider.current is dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.TxtOrCommentI)
					{
						list.Add(slider.current as dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.TxtOrCommentI);
						slider.moveNext();
					}

					seg = Seg.Parse(list);
					tail = dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._start_.Tail.Parse(slider);

					break;
				default:
					throw new UnexpectedReachException();
					//retrieve seg

					break;
			}

			return new Segs(seg, tail);



		}

	}
}
