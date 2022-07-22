using nilnul.dev.sln.as_.dst.name._infixer._parener_._lex.word_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_
{

	public class Txt :nilnul.obj.Box<string>, TxtOrCommentI
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="content">nulable</param>
		public Txt(string content):base(content)
		{

		}

		public Txt(_lex.word_.Represent txt):this(txt.ToString())
		{
		}
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		///
		[return: ReturnNull]
		public override string ToString()
		{
			return boxed;
		}

	}



}
