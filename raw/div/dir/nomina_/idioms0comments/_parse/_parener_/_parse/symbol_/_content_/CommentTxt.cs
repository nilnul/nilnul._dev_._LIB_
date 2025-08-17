using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_._content_
{
	/// <summary>
	/// comment, followed by txtNuable
	/// </summary>
	public class CommentTxt
	{
		//required
		public CommentI comment;

		/// <summary>
		/// nulable
		/// </summary>
		public Txt txt; //nullable

		public CommentTxt(CommentI comment, Txt txt)
		{
			this.comment = comment;
			this.txt = txt;
		}

		public CommentTxt(CommentI comment):this(comment,null)
		{

		}

		public override string ToString()
		{
			return $"{comment}{txt}";
		}
	}
}
