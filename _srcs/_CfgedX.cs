using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace nilnul.dev._srcs
{
	/// <summary>
	/// provider of srcs.
	/// joint addresses will be streamlined -- keep the parent only
	/// </summary>
	public static class _CfgedX
	{
		

		public static StringCollection TxtCollection => Properties.Settings.Default.srcs ?? new StringCollection();

		public static IEnumerable<string> Txts => nilnul.txts_.StrCollectionX.ToEnumable(TxtCollection);

		public static nilnul.fs.addresses_.disjoint_.EndMatters Disjoint() => 
			new nilnul.fs.addresses_.disjoint_.EndMatters(Txts)
		;

      

       // [Obsolete("",true)]
		static _CfgedX() {
			//Refresh();
		}





	}
}
