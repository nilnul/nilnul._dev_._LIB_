using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._compile_.parener._dot_._parse.symbol_.seg
{
	public class Eq : IEqualityComparer<Seg>
	{
		public bool Equals(Seg x, Seg y)
		{

			return x.pre.Equals(y.pre) &&
				x.txt.ToString() == y.txt.ToString()
				&&
				nilnul.dev.sln.as_.dst.name._infixer._compile_.parener._dot_._parse.symbol_._seg.post.Eq.Singleton.Equals(x.post, y.post);

			throw new NotImplementedException();
		}

		public int GetHashCode(Seg obj)
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
