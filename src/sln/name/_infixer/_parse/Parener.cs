using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._lex;
using nilnul.dev.sln.as_.dst.name._infixer._lex.word_;
using nilnul.dev.sln.as_.dst.name._infixer._parse._parener._ret;
using nilnul.dev.sln.as_.dst.name._infixer._parse._parener._ret.nub_._seg_.ele_;

namespace nilnul.dev.sln.as_.dst.name._infixer._parse
{
	/// <summary>
	/// considering the priority(precedence and associativity) of ops and build a tree
	/// </summary>
	/// todo:
	public class Parener
	{

		_lex.word.Slider words;

		_parse._parener.Ret ret = new _parse._parener.Ret();

		public void run()
		{

			switch (words.current)
			{
				case null:
					return;

					break;
				case _lex.word_.TxtI txt:
					ret.Add(
						parse_seg()
					);
					switch (words.current)
					{
						case _lex.word_.Dot dot:
							ret.Add(new _parse._parener._ret.nub_.Dot());
							words.moveNext();
							ret.AddRange(parse_segs());



							break;
						case _lex.word_.LeftParen leftParent:
							throw new UnexpectedReachException();
							break;
						case _lex.word_.RightParen rightParen:
							run_rightParen();
							break;
						case _lex.word_.TxtI txt1:
							throw new UnexpectedReachException();
							break;
						default:
							throw new UnexpectedTypeException();

							break;
					}
					;
					break;
				default:

					break;
			}



		}

		private void run_rightParen()
		{
			ret.Add(new _parener._ret.nub_.RightParen());

			run();

			//throw new NotImplementedException();
		}

		private List<NubI> parse_segs()
		{

			var r = new List<NubI>();
			switch (words.current)
			{
				case null:
					return r;
					break;
				case _lex.word_.Dot dot:
					throw new UnexpectedReachException("two dots");
					break;
				case _lex.word_.LeftParen leftParen:
					r.Add(parse_seg());
					switch (words.current)
					{
						case null:
							return r;
							break;
						case _lex.word_.Dot dot:
							r.AddRange(parse_segs());
							break;
						case _lex.word_.LeftParen leftParen1:
							throw new UnexpectedReachException();
							break;
						case _lex.word_.RightParen rightParen1:
							r.Add(new _parse._parener._ret.nub_.RightParen());
							words.moveNext();
							r.AddRange(parse_segs());
							break;
						case _lex.word_.TxtI txt1:
							throw new UnexpectedReachException();
							break;
						default:
							throw new UnexpectedReachException();

							break;
					}
					break;
				case _lex.word_.RightParen rightParen:
					r.Add(new _parse._parener._ret.nub_.RightParen());
					words.moveNext();
					r.AddRange(parse_segs());
					break;
				case _lex.word_.Txt txt2:
					r.Add(parse_seg());
					switch (words.current)
					{
						case null:
							//return r;
							break;
						case _lex.word_.Dot dot:
							r.Add(new _parse._parener._ret.nub_.Dot());
							words.moveNext();

							r.AddRange(parse_segs());

							break;
						case _lex.word_.LeftParen leftParen1:
							throw new UnexpectedReachException();
							break;
						case _lex.word_.RightParen rightParen1:
							r.Add(new _parse._parener._ret.nub_.RightParen());
							words.moveNext();
							r.AddRange(parse_segs());
							break;
						case _lex.word_.TxtI txt1:
							throw new UnexpectedReachException();
							break;
						default:
							throw new UnexpectedReachException();

							break;
					}
					break;

					break;
				default:

					break;
			}
			return r;
			//throw new NotImplementedException();
		}

		private _parse._parener._ret.nub_.Seg parse_seg()
		{
			var r = new _parse._parener._ret.nub_.Seg();

			switch (words.current)
			{
				case null:
					throw new UnexpectedReachException();
				case _lex.word_.LeftParen leftParen:
					r.Add(parse_comment());

					switch (words.current)
					{
						case null:
							//r.vowContainTxt();
							//return r;
							break;
						case _lex.word_.Dot dot:

							//r.vowContainTxt();
							//return r;
							break;
						case _lex.word_.LeftParen leftParen1:
							r.AddRange(parse_seg());
							break;
						case _lex.word_.RightParen rightParen:
							//r.vowContainTxt();
							//return r;
							break;
						case _lex.word_.TxtI txt:
							r.AddRange(parse_seg());
							break;
						default:
							throw new UnexpectedTypeException();
							break;
					}
					break;
				case _lex.word_.TxtI txt:
					r.Add(txt);
					words.moveNext();
					switch (words.current)
					{
						case null:
						case _lex.word_.Dot dot:
							//return r;
							break;
						case _lex.word_.LeftParen leftParen:
							r.AddRange(parse_seg());
							//return r;
							break;
						case _lex.word_.RightParen rightParen1:
							//return r;
							break;
						case _lex.word_.TxtI txt1:
							throw new UnexpectedReachException();
						default:
							throw new UnexpectedTypeException();
							break;
					}
					break;
				default:
					throw new UnexpectedTypeException();
					break;
			}
			r.vowContainTxt();
			return r;
		}

		private _parse._parener._ret.nub_._seg_.ele_.CommentI parse_comment()
		{
			var r = new _parse._parener._ret.nub_._seg_.ele_.Comment();

			switch (words.current)
			{
				case _lex.word_.LeftParen leftParen:

					words.moveNext();

					switch (words.current)
					{
						case _lex.word_.LeftParen leftParen1
						:
							r.tail = parse_commentTail();
							break;
						case _lex.word_.Dot dot:
						case _lex.word_.Txt txt:
							r.leadingDweltTxtNulable = parseCommentTxt();
							break;
						case _lex.word_.RightParen rightParen:
							r.rightBorderNulable = rightParen;
							return r;
						case null:
							break;
						default:
							throw new UnexpectedReachException();
							break;
					}


					break;
				default:
					throw new UnexpectedReachException();

					break;
			}
			return r;
		}

		private List<Tuple<_parse._parener._ret.nub_._seg_.ele_.CommentI, string>> parse_commentTail()
		{
			var r = new List<Tuple<_parse._parener._ret.nub_._seg_.ele_.CommentI, string>>();

			Tuple<_parse._parener._ret.nub_._seg_.ele_.CommentI, string> currentTuple;
			_parse._parener._ret.nub_._seg_.ele_.CommentI currentTupleComment;

			StringBuilder currentTupleTxt = new StringBuilder();
			string currentTupleTxt1;

			switch (words.current)
			{
				case _lex.word_.LeftParen leftParen:
					currentTupleComment = parse_comment();

					break;
				default:
					throw new UnexpectedReachException();
					break;
			}
			words.moveNext();

			switch (words.current)
			{
				case _lex.word_.LeftParen leftParen:
					currentTuple = new Tuple<CommentI, string>(currentTupleComment, null);
					r.AddRange(parse_commentTail());

					break;

				case _lex.word_.RightParen rightParen:  //border
					break;

				case null:  //border
					break;
				case _lex.word_.Dot dot:
				case _lex.word_.Txt txt:
					currentTupleTxt1 = parseCommentTxt().ToString();
					currentTuple = new Tuple<CommentI, string>(currentTupleComment, currentTupleTxt.ToString());

					r.Add(currentTuple);
					switch (words.current)
					{
						case _lex.word_.LeftParen leftParen2:
							r.AddRange(parse_commentTail());
							break;
						default:
							break;
					}

					break;
				default:

					break;
			}
			return r;


			//throw new NotImplementedException();
		}



		private _parse._parener._ret.nub_._seg_.ele_._comment_.content_.Txt parseCommentTxt()
		{

			var txtBuilder = new StringBuilder();
			while (
						_infixer._lex.word.nulable.be_.commentBorder._AntoX.Be(words.current)
					)
			{
				txtBuilder.Append(words.current);

				words.moveNext();

			}

			return new _parse._parener._ret.nub_._seg_.ele_._comment_.content_.Txt(txtBuilder.ToString());

		}
	}
}

