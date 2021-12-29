using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_
{
	/// <summary>
	/// one of the srsc is the primary src. by default, the first of srcs is considered primary.
	/// </summary>
	interface IPrimary
	{
	}

	static public class Primary
	{
		static public nilnul.fs.AddressI Address_ofCfg() {
			return Srcs_addresses.OvCfg().addresses.First();
		}
	}
}
