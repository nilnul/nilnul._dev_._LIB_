using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs_._cfged.srcParent
{
	static public class _SrcX
	{
		static public nilnul.fs.FolderI Create(string s)
		{
			var basement = _SrcParentX.folder;

			if (!string.IsNullOrWhiteSpace(s))
			{
				try
				{
					return
						 nilnul.fs.folder.directory.create._EnsureX.Folder_directoryInDestination(basement,
						 s
					 )
					;
				}
				catch (Exception)
				{
				}

			}
			return null;
			;
		}

		static public void CreateAndAdd(IEnumerable<string> x) {

			var list = new nilnul.fs.address_.shield.sortie_.Lst();

			var created = x.Select(x1=> Create(x1)).Where(y=>y!=null);
			list.AddRange( _CfgedX.GetSrcs().shields.ee);
			list.AddRange(created.Select(x1=>x1.address.en));
			var txtCollection = new StringCollection();
			txtCollection.AddRange(list.Select(x1=>x1.ToString()).ToArray());
			nilnul.dev.Properties.Settings.Default.srcs =   txtCollection;
		}

		static public void CreateAndAdd() {
			CreateAndAdd(
				Properties.Settings.Default.srcDirS.Cast<string>()
			);
		}
	}
}
