using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj._this
{
	/// <summary>
	/// embed is a 3rd party library, which generally is mainted as a separate project and added as a reference; but for some 3rd party library, the count of files is small to the effect of a single file, and the source is not regarded as stable enough to be free of maintainance, hence the library is embedded here for easier maintainance including some revision|adaption.
	/// the library shall be regarded as an exclave; its copyright belongs to the original author; the copyright notice is kept untouched.
	/// If the maintainance is significant and some code need big change, the library would be taken out to become an independent library.
	/// </summary>
	/// <remarks>
	/// the embed is generally placed under a folder named after the author.
	/// </remarks>
	internal class IEmbed
	{
	}
}
