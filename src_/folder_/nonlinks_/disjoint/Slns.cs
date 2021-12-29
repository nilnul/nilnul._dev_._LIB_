using nilnul.fs.folder_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.folder_.nonlinks_.disjoint
{
	static public class _SlnsX
	{
		static public IEnumerable<fs.address_.shield_.BaseDir> _Shields_assumeSrc(IEnumerable<nilnul.fs.FolderI> folders)
		{
			return folders.SelectMany(
				f=> nilnul.dev.src._SlnsX._Shields_assumeSrc(f)
			);
		}

		public static IEnumerable<fs.address_.shield_.BaseDir> _Shields_assumeDisjoint(IEnumerable<Normal> _nonlinks_disjoint)
		{
			return _nonlinks_disjoint.SelectMany(
				f=> nilnul.dev.src._SlnsX._Shields_assumeSrc(f.en)
			);

		}



		//public static object _Shields_assumeSrc(Srcs3 srcs)
		//{
		//	return _Shields_assumeSrc(
		//		srcs.
		//	);
		//}
	}
}
