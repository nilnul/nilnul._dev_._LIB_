using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ_.iface_.marker
{
		/*
	if this is renamed, when one lib begins to use a type from another lib which uses the name before the renaming, then, eg :
	System.TypeLoadException: 未能从程序集“nilnul._obj_._LIB_, Version=1.2.0.0, Culture=neutral, PublicKeyToken=085f320e4a727230”中加载类型“nilnul.obj.ICollection0`1”。
	在 nilnul.fs._address._dst.denote._parse.scan_._WordX._OfValidChas(String x)
   在 nilnul.fs._address._dst.denote._parse.Check.check(String obj) )错误:the caption error:System.TypeLoadException: 未能从程序集“nilnul._obj_._LIB_, Version=1.2.0.0, Culture=neutral, PublicKeyToken=085f320e4a727230”中加载类型“nilnul.obj.ICollection0`1”。
   在 nilnul.fs._address._dst.denote._parse.scan_._WordX._OfValidChas(String x)
   在 nilnul.fs._address._dst.denote._parse.Check.check(String obj)

	,where the "fs" lib references "txt" lib, which uses the old name that has been renamed in lib:obj
		;
		 Hence when the name of the marker interface is not stable, keep its access internal; and only when it's internal can it be freely renamed.
		If it's public, renaming can break code;
		 */
	/// <summary>
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	/// 
	class IRename
    {

    }
}
