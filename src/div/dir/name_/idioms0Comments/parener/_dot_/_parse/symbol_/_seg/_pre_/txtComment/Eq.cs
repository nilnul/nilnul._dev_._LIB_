using nilnul.dev.sln.as_.dst.name._infixer.parener._dot_._parse.symbol_._seg._pre_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.as_.dst.name._infixer._compile_.parener._dot_._parse.symbol_._seg._pre_.txtComment
{
	public class Eq : IEqualityComparer<TxtComment>
	{
		public bool Equals(TxtComment x, TxtComment y)
		{
			return x.ToString() == y.ToString();
			throw new NotImplementedException();
		}

		public int GetHashCode(TxtComment obj)
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
