using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.divs_.notDotLed_.deV_
{
	/// <summary>
	/// </summary>
	static public class _ExcludeVsX
	{

		

		static public IEnumerable<DivI> Divs(nilnul.fs.FolderI parent)
		{

			yield return new Div();

			foreach (var item in directories_.notDotLed_.deV_.NoVsGenerated.Directories(parent))
			{
				yield return item;
			}

		}

		static public IEnumerable<DivI> Divs(nilnul.fs.Folder parent)
		{
			return Divs(
				(nilnul.fs.FolderI)(parent)
			);
		}
		static public IEnumerable<DivI> Divs(DirectoryInfo parent)
		{
			return Divs(
				new nilnul.fs.Folder(parent)
			);
		}

		static public IEnumerable<DivI> Divs_ofAddress(string parent)
		{
			return Divs(
				nilnul.fs.Folder.FroAddress(parent)
			);
		}
	}
}
