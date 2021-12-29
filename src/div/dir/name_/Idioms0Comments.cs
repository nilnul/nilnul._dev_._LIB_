using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder._repoName.dir.name_
{
	/// <summary>
	/// dot sepearted Seg. (emptible txt with comments interleft).
	/// This can be empty.
	/// </summary>
	public abstract class Idioms0CommentsA : SymbolI
	{



		static public Idioms0CommentsI Parse(nilnul.obj.slider_.Enumer<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI> slider)
		{

			
			switch (slider.current)
			{
				case dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Dot dot:

					throw new nilnul.obj_.xpn_.ParseException("cannot be started with dot");

					//reduce stak to 
					break;
				case null:
					return new idioms0Comments_.Comments();
					
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

					//stops at next dot "."

					//
					if (list.Any(x => x is dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Txt))
					{
						return new idioms0Comments_.Segs(
							Seg.Parse(list)
							,
							dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._start_.Tail.Parse(slider) //parse the followed
						);

					}
					else
					//if the begining is not txt, it must be comment. if it is comment, then no dot shall be followed, and the whole must be comment
					{
						nilnul.obj.vow_.True.Singleton.vow( slider.current ==null, new nilnul.exception_.ParseException("expecting end aft comments"));
						return new idioms0Comments_.Comments(
							list.Cast<dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment>().ToList()
						);
						//nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex.word_.Comment;
					}


					break;
				default:
					throw new UnexpectedReachException();
					//retrieve seg

					break;
			}

			//return new Idioms0CommentsA(seg, tail);



		}

		static public Idioms0CommentsI Parse(
			IEnumerable<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI> slider
		) => Parse(
			new nilnul.obj.slider_.Enumer<dev.sln.as_.dst.name._infixer.parener._dot_._lex.WordI>(slider)
		);
	}
}
