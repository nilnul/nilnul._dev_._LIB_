using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.dev.sln.as_.dst.name._infixer._parener_._parse.symbol_;

namespace nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._lex
{
	/// <summary>
	/// eg:
	///		"."
	///		,
	///		txt
	///		,
	///		comment
	/// </summary>
	public interface WordI
	{
	}

	public class Seg
		:
		nilnul.obj.Box<_parener_._parse.symbol_.Content>
		,
		WordI
	{
		public Seg(Content val) : base(val)
		{
		}

		static public Seg Create(string txt) {
			return new Seg(
				new Content(txt)
			);
		}

	}


}
