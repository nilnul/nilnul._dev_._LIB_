using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs._tgt
{
	/// <summary>
	/// </summary>
	static public class _CfgX
	{
		static public string Address()
		{
			//first create the container of src
			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.tgt_address))
			{
				var trimmed = Properties.Settings.Default.tgt_address.Trim();
				if (
					nilnul.txt.be_.fs_.Address.Singleton.be(
						trimmed
					)
				)
				{
					return trimmed;
				}
			}

			var basement = nilnul.dev.my_._CfgX.Address();

			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.tgt_division_in_my))
			{
				var trimmed = Properties.Settings.Default.tgt_division_in_my.Trim();
				if (nilnul.fs._address.division._parse.Be.Singleton.be(trimmed))
				{
					return  nilnul.fs.address_.BaseDivision.Create_ofAddress(basement,
											trimmed
											 ).ToString();
				}

			}
			return 
				 nilnul.fs.address_.shield_.baseDiv_.divInDivision_._BaseInAddressX.Create(basement,
				  (string)Properties.Settings.Default.Properties[nameof(Properties.Settings.Default.tgt_division_in_my)].DefaultValue
				 ).ToString()
			;
		}
		
	}
}
