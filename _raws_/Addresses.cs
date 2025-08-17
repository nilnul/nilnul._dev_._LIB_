using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.shields_;

namespace nilnul.dev._raws_
{

	public abstract class AddressesA :
		nilnul.fs.addresses_.disjoint_.EndMatters
		,

		AddressesI
	{
		public AddressesA()
		{

		}

		protected AddressesA(nilnul.fs.addresses_.disjoint_.EndMatters  val):base(
			val
		)
		{
		}

		public nilnul.fs.addresses_.disjoint_.EndMatters addresses => this;

	}
}
