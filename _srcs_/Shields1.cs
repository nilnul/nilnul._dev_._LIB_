using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.shields_;

namespace nilnul.dev._srcs_
{
	public interface ShieldsI1:BlankI
	{
		nilnul.fs.address_.shields_.Disjoint shields { get; }
	}

	public abstract class ShieldsA :
		nilnul.fs.address_.shields_.Disjoint,

		ShieldsI1
	{
		public ShieldsA()
		{

		}

		protected ShieldsA(Disjoint val):base(val.ee)
		{
		}

		public Disjoint shields => this;

	}
}
