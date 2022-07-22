using nilnul.dev.sln.as_.dst.name._infixer._lex;
using nilnul.dev.sln.as_.dst.name._infixer._lex.word_;
using nilnul.lang.eg.logic._walk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_.lex._parser.nub_
{
	public interface StartI {

	}

	/// <summary>
	/// the start symbol
	/// </summary>
	public class Start 
	{
		List<TxtOrCommentI> content;

		public override string ToString()
		{
			return string.Join("",content);
		}
	}



}
