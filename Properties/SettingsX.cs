using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.Properties
{
	static public class SettingsX
	{
		static public IEnumerable<string> Srcs
		{
			get
			{
				return (nilnul.dev.Properties.Settings.Default.srcs ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}


		static public nilnul.fs.address_.shields_.Disjoint SrcsAsDisjoint
		{
			get
			{
				return fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(
					Srcs
				);

			}
		}

		static public string NugetPacsSrc_division {
			get {
				return Settings.Default.nugetPacsSrc_division ?? Settings.Default.Properties[nameof(Settings.nugetPacsSrc_division)].ToString();
			}

		}
		static public string NugetPacsSrcAddress {
			get {
				return System.IO.Path.Combine(nilnul.fs.address_.shield_.my_._DossiersX.Address(), NugetPacsSrc_division);
			}
		}

		static public nilnul.fs.address_.Shield NugetPacsSrcShield {
			get {
				return nilnul.fs.address_.Shield.FroAddress(NugetPacsSrcAddress);
			}
		}



	}
}
