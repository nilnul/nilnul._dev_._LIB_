using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._identy._nomina._local.design_
{
	/// <summary>
	/// <see cref="infoGrow"/>, the seg as an extension wrapps all previous information.
	/// eg:
	///		<see cref="System.Xml.Linq.XElement"/>, which is not only an element, but also has a reference to the whole document where this element is in, such that we can insert an element before this element;
	/// </summary>
	/// <remarks>
	/// <seealso cref="nilnul.txt_.vered_._id._nom.term.extersed_.ITrivia "/> as a previouse seg, is to be extended;
	/// to extend by a new obj, not obtrusively change the original one, we need locate each specific part of the original obj, by a certain referencing mechanism such as: file/line/col(char of line),char, or catalog/book/chapt/section,page/paragraph, group, quote("q" is used rather than "p" to avoid ambiguity with 'p' for page), segment, cluster, chunk, hunk, clump,/
	/// </remarks>
	/// <see cref="nilnul.obj_.deV_.typ._identy._nomina.seg.design_.IInfoGrow"/>
	/// <see cref="nilnul._obj.typ._id.IInfoGrow"/>
	/// <see cref="nilnul.dev.src.prj_.lib.schema._typ.IInfoGrow"/>
	/// <see cref="nilnul.obj_.deV._nomina.design_.infoPath.IInfoGrow"/>
	internal class IInfoGrow
	{
	}
}
