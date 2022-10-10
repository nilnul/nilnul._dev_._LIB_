using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dev_.src_
{
	public static class _IniX
	{

		/// <summary>
		/// in this very folder, ensure a file named, ".nilnulCfg" or any configed, to store the settings.
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="key"></param>
		/// <param name="val"></param>
		/// <param name="git"></param>

		static public void Set(nilnul.fs.FolderI folder, string key, string val, nilnul.win.prog_.Git git = null)
		{
			//if (
			//	nilnul.fs.address.be_.Folder.Singleton.be(
			//		new nilnul.fs.address_.BaseDst(folder.address.en, ".git")
			//	)

			//)
			{

				nilnul.fs.folder.git_._CfgX._Set(
					folder.ToString()
					, nilnul.dev.Properties.Settings.Default.folder_srcCfg_doc
					, key
					, val
					, git
				);

			}
		}
	}
}
