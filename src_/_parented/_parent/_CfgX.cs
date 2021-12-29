using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_._parented._parent
{
	/// <summary>
	/// the parent of intended srcs. This can be ~/src_, and the srcs can then be:
	///		_my_, intended for personal
	///		_pub_, intended for every one
	///		_nilnul_, intended for nilnul framework proposed by nilnul
	///		_team1_, inteded for a team you named
	/// </summary>
	static public class _CfgX
	{
		static public string Address()
		{
			//first create the container of src
			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.srcsParent))
			{
				var trimmed = Properties.Settings.Default.srcsParent.Trim();
				if (
					nilnul.txt.be_.fs_.Address.Singleton.be(
						trimmed
					)
				)
				{
					return trimmed;
				}
			}

			var basement = my_._CfgX.Address();

			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.divisionInPersonal4srcsParent))
			{
				var trimmed = Properties.Settings.Default.divisionInPersonal4srcsParent.Trim();
				if (nilnul.fs._address.division._parse.Be.Singleton.be(trimmed))
				{
					return  nilnul.fs.address_.BaseDivision.Create_ofAddress(basement,
											trimmed
											 ).ToString();
				}

			}
			return 
				 nilnul.fs.address_.shield_.baseDiv_.divInDivision_._BaseInAddressX.Create(basement,
				  (string)Properties.Settings.Default.Properties[nameof(Properties.Settings.Default.divisionInPersonal4srcsParent)].DefaultValue
				 ).ToString()
			;
		}
		
	}
}
