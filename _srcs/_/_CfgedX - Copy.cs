using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace nilnul.dev.srcs_
{
	/// <summary>
	/// provider of srcs.
	/// joint addresses will be streamlined -- keep the parent only
	/// </summary>
	///
	[Obsolete(nameof(nilnul.dev._srcs._CfgedX))]
	public static class _CfgedX
	{


		public static StringCollection TxtCollection => Properties.Settings.Default.srcs ?? new StringCollection();

		public static IEnumerable<string> Txts => nilnul.txts_.StrCollectionX.ToEnumable(TxtCollection);

		public static Srcs3 GetSrcs() => new Srcs3(
			nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(Txts)
		);

        [Obsolete("",true)]
		public static Srcs3 Srcs ;

        [Obsolete("",true)]
		static public void Refresh() {
			_CfgedX.Srcs = GetSrcs();
		}

       // [Obsolete("",true)]
		static _CfgedX() {
			//Refresh();
		}





	}
}
