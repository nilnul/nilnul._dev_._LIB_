using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.src_.folder_.nonlink_.giT_.nonrepos.sln_
{
	static public  class _NonlinksX
	{
	


		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="srcs_folderNonlinkNonrepEs"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
	 static public  IEnumerable<nilnul.fs.FolderI> _Folders_assumeSrcFolderNonlinkNonrepoEs(
		IEnumerable<
			nilnul.fs.FolderI> srcs_folderNonlinkNonrepEs
		)
		{


			return			srcs_folderNonlinkNonrepEs.SelectMany(
				s=>
nilnul.dev.src_.folder_.nonlink_.giT_.nonRepo.sln_._NonlinksX._Folders_assumeSrc(s)
			)
				;
				
			
			

		}

		static public IEnumerable<nilnul.fs.FolderI> _Folders_addressAssumeSrc(
			IEnumerable<string> folder
		)
		{
			return _Folders_assumeSrcFolderNonlinkNonrepoEs(
				folder.Select(
					f=>
					nilnul.fs.Folder.FroAddress(f)
				)
			);
		}
		

	}
}
