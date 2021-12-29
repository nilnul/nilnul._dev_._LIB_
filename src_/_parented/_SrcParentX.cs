using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs_._cfged
{
	/// <summary>
	/// the parent of intended srcs. This can be ~/src_, and the srcs can then be:
	///		_my_, intended for personal
	///		_pub_, intended for every one
	///		_nilnul_, intended for nilnul framework proposed by nilnul
	///		_team1_, inteded for a team you named
	/// </summary>
	static public class _SrcParentX
	{
		static public nilnul.fs.FolderI folder;
		static public nilnul.fs.FolderI Create()
		{
			//first create the container of src
			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.srcsParent))
			{
				try
				{
					return nilnul.fs.folder.create._EnsureX._Folder_ofAddress(Properties.Settings.Default.srcsParent);
				}
				catch (Exception)
				{
				}
			}

			var basement = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal, Environment.SpecialFolderOption.Create);

			if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.src_destination))
			{
				try
				{
					return nilnul.fs.folder.create._EnsureX.Folder(
						 nilnul.fs.address_.shield_.baseDiv_.divInDivision_._BaseInAddressX.Create(basement,
						 Properties.Settings.Default.src_destination
						 )
					);
				}
				catch (Exception)
				{
				}

			}
			return nilnul.fs.folder.create._EnsureX.Folder(
				 nilnul.fs.address_.shield_.baseDiv_.divInDivision_._BaseInAddressX.Create(basement,
				  (string)Properties.Settings.Default.Properties[nameof(Properties.Settings.Default.src_destination)].DefaultValue
				 )
			);
		}
		static _SrcParentX() {
			folder = Create();
		}
	}
}
