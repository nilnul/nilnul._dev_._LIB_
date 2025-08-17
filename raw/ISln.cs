using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.raw
{
	/// <summary>
	/// a dir of subsrc(<see cref="src.subsrc"/>).
	///
	/// for a src_.file, no slns exist.
	/// for a src_.unoccupied, no slns exist.
	///
	/// generally, we should consider src_.folder, especially src_.folder_.nonlink
	/// </summary>
	/// <remarks>
	/// 
	/// sln is a git module.
	/// </remarks>
	public interface ISln:dev.ISln
	{

	}
}
