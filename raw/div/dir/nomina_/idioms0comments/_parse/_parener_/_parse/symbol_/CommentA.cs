using System.Linq;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_
{
	public abstract class CommentA : nilnul.obj.Box<Content>, CommentI
	{
		public CommentA(Content content) : base(content)
		{

		}

		/// <summary>
		/// we can use, for example, "(Git)" or the ending "(git", to denote this is intended as git module.
		/// </summary>
		/// <returns></returns>
		public bool hasNotationCaseInsensitive(string notation)
		{
			if (boxed.txt is null)
			{
				if (
					boxed.commentTxtS.Any(
						ct =>
						ct.comment.hasNotationCaseInsensitive(notation)
					)
				)
				{
					return true;
				}
				var nonBlankEs = boxed.commentTxtS.Where(
					ct => !(string.IsNullOrWhiteSpace(ct.txt.ToString()))
				);
				if (nonBlankEs.Count() == 1)
				{
					if (
						nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
							nonBlankEs.First().txt.ToString()
							,
							notation
						)
					)
					{
						return true;
					}
					return false;
				}
				return false;

			}

			if (boxed.Where(x => x is CommentI).Cast<CommentI>().Any(c => c.hasNotationCaseInsensitive(notation)))
			{
				return true;
			}
			var txts = boxed.Where(x => x is Txt).Cast<Txt>().Where(
				t => !(string.IsNullOrWhiteSpace(t.ToString()))
			);
			if (txts.Count() == 1)
			{
				if (
						nilnul.txt.eq_.CaseInsensitive.Singleton.Equals(
							txts.First().ToString()
							,
							notation
						)
					)
				{
					return true;
				}
				return false;
			}
			return false;



		}

	}



}
