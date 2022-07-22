using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._compile_.parener._dot_._parse.symbol_.start
{
	public class Eq : IEqualityComparer<Start>
	{
		public bool Equals(Start x, Start y)
		{
			return x.ToString() == y.ToString();
			throw new NotImplementedException();
		}

		public bool Equals(Start x, string y)
		{
			return x.ToString() == y;
			throw new NotImplementedException();
		}


		public int GetHashCode(Start obj)
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
