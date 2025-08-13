using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev._sln.prj._procure
{
	internal enum Li_
	{
		/// <summary>
		/// develop the project by oneself
		/// </summary>
		Dev
			,
		/// <summary>
		/// embed the source code of other project, which is often portable, and not too complex to embed into our project
		/// </summary>
		Embed
			,
		/// <summary>
		/// introduce an open source project, which is usually free, but requires us to have a good understanding of it. Also we may take the burden of maintaining it.
		/// </summary>
		/// <remarks>
		/// together with <see cref="Embed"/>, this helps amplify the usage of available current knowledge, and avoid repetition of development cost. This is good to prosper the advancement of scitec and speed up the research&development for the whole society.
		/// In other words, don't reinvent the wheel. If there is one, use it rather than make it.
		/// </remarks>
		Raw
			,
		/// <summary>
		/// by the src and|or compiled code. Often this is cheaper than developing it by oneself.
		/// </summary>
		/// <remarks>
		/// this helps activate and facilitate and proper the commerce and economy
		/// </remarks>
		Purchase
	}
}
