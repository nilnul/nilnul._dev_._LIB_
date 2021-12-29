using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.bak_._retVoid.src_.folder_.nonlink_.git_.nonRepo_.incomplete.dir_
{
	static public class _NonlinkX__serial
	{

		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		static public void Exe(
			nilnul.fs.FolderI folder,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			// from the name by convention 
			// or from a config file

			if (
				folder.address.en.stem.div.dirs.Last().denote.en.StartsWith(".")

				|| IsSlnNameBlank(folder)


				
			)
			{
				Trace.TraceInformation(
					$" the src.dir:{folder.ToString()} 's name starts with dot (meanig it's a concealed folder) or is blank (it's notation folder for comment purpose only)."
				);


			}
			else
			{
				_retVoid.sln_._NonlinkX__serial._Exe(folder, cancel, git);

			}

			
			

		}


		static public bool IsSlnNameBlank(nilnul.fs.FolderI folder) {

			return nilnul.txt.be_.White.Singleton.be(
				nilnul.fs.folder._repoName.dir.name_.idioms0Comments._ParseX.Parse(
					folder.address.en.stem.div.dirs.Last().denote.ToString()
				).name
			);
		}

		static public void Exe(
			string folder,
			CancellationToken cancel,
			nilnul.win.prog_.Git git = null
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder),cancel,git);
		}


	}

}
