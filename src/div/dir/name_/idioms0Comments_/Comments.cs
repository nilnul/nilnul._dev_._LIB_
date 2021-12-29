using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C =nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment;

namespace nilnul.fs.folder._repoName.dir.name_.idioms0Comments_
{
	/// <summary>
	/// </summary>
	public class Comments : Idioms0CommentsI
	{

		private List<dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment> _tail;
		public List<C> tail {
			get { return _tail; }
		}

		public Comments( List< C> tail)
		{
			

			this._tail = tail;
		}
		public Comments(C seg) : this( new List<C>() { seg})
		{

		}
		public Comments() : this(new List<C>())
		{

		}

		public  string name
		{
			get
			{
				return "";
			}
		}





		public override string ToString()
		{
			return $@"{
				nilnul.obj.str_.enumable.phrase_.join_.Empty.Singleton.phrase(
					_tail.Select(
						x => x.ToString()
					)
				)
			}";
		}

		static public Comments Parse(IEnumerable<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI> slider) => Parse(
new nilnul.obj.slider_.Enumer<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI>(slider)
);

		static public Comments Parse(nilnul.obj.slider_.Enumer<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI> slider)
		{

			List<C> tail=new List<C>();
			switch (slider.current)
			{
				case dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Dot dot:
					throw new nilnul.exception_.ParseException("cannot be started with dot");

					//reduce stak to 
					break;
				case null:
					return new Comments();
					//throw new Exception("no segs found");
					break;
				case dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment txtOrComment:

					var list = new List<dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment>();
					list.Add(txtOrComment);

					slider.moveNext();

					while (slider.current is dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment)
					{
						list.Add(slider.current as dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment);
						slider.moveNext();
					}

					nilnul.obj.vow_.True.Singleton.vow(slider.current == null, new nilnul.exception_.ParseException("expecting end of words"));

					return new Comments(list);

					break;
				case dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Txt txtOrComment:
					throw new nilnul.exception_.ParseException($"unexpected txt{txtOrComment}");

				default:
					throw new UnexpectedReachException();
					//retrieve seg

					break;
			}

			return new Comments( tail);



		}

	}
}
