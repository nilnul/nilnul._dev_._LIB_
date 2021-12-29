using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.which_
{
	static public class _SupOfX
	{
		static public nilnul.fs.AddressI SrcNulable_ofEndMatters(nilnul.fs.AddressI address) {

			return nilnul.dev.Srcs_addresses.OvCfg().FirstOrDefault(
				s=>
				nilnul.fs.address.re_.sup_.EndMatters.Singleton.re(s,address)
			);


		}

		static public nilnul.fs.AddressI SrcNulable(nilnul.fs.address_.ShieldI address) {

			return nilnul.dev.Srcs_addresses.OvCfg().FirstOrDefault(
				s=>
				nilnul.fs.address.re_.sup_.EndMatters.Singleton.re(s,address)
			);

		}

		static public nilnul.fs.AddressI SrcNulable_ofAddressToShield(nilnul.fs.AddressI address) {

			return SrcNulable(
				nilnul.fs.address_.Shield.Ov(address)
			);
		}

		static public nilnul.fs.AddressI SrcNulable_ofAddressToShield(string address) {

			return SrcNulable_ofAddressToShield(
				nilnul.fs.AddressA.Parse(address)
			);
		}



	}
}
