using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg;
using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg._post_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._compile_.parener._dot_._parse.symbol_._seg.post
{
	public class Eq : IEqualityComparer<Post>
	{
		public bool Equals(Post x, Post y)
		{
			return nilnul.obj.str_.enumable.Eq<CommentTxt, nilnul.dev.sln.as_.dst.name._infixer._compile_.parener._dot_._parse.symbol_._seg._post_.commentTxt.Eq>.Singleton.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(Post obj)
		{
			return 0;
			throw new NotImplementedException();
		}

		static public Eq Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Eq>.Instance;
			}
		}

	}
}
