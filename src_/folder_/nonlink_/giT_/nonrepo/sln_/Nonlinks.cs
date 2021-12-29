using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.src_.folder_.nonlink_.giT_.nonRepo.sln_
{
	static public  class _NonlinksX
	{
	


		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="src"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
	 static public  IEnumerable<nilnul.fs.FolderI> _Folders_assumeSrc(
			nilnul.fs.FolderI src
		)
		{


			return

				nilnul.fs.folder.dirs_._NonlinkX.Folders(src).Where(
					nilnul.dev.src.dir.be_._SlnX._Be_assumeSrcDir
				);
				
			
			

		}

		static public IEnumerable<nilnul.fs.FolderI> _Folders_addressAssumeSrc(
			string folder
		)
		{
			return _Folders_assumeSrc(
				nilnul.fs.Folder.FroAddress(folder)
			);
		}
		

	}
}
