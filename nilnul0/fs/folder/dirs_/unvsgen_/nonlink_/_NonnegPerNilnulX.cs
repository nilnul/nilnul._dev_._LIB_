using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dirs_.excludeVs_.nonlink_
{
	/// <summary>
	/// </summary>
	static public class _NonNegByNilNulX
	{

		

		static public IEnumerable<DirectoryInfo> EnumerateAsAddresses(DirectoryInfo parent)
		{

			var cfgFile = new nilnul.fs.address_.spear_.ParentDoc(parent, ".nilnulIgnore");

			string[] lines;

			if (nilnul.fs.address_.spear.be_.File.Singleton.be(cfgFile)
			)
			{
				//read the settings

				lines = System.IO.File.ReadAllLines(
					cfgFile.ToString()
				).Select(x => x.Trim()).ToArray();
			}
			else
			{
				lines = new string[0];
			}


			

			return _NormalX.EnumerateAsAddresses(parent).Where(
				x=> nilnul.obj.str.be_._NoneX.None(
					lines,
					l => x.Name == l
				//(l => Regex.IsMatch(d.denote.en,l))
				)
			);
		}

		static public IEnumerable<string> EnumerateAsAddresses(string parent)
		{
			return EnumerateAsAddresses(new DirectoryInfo(parent)).Select(x => x.FullName);
		}

		public static IEnumerable<FolderI> Folders(FolderI nonlinkPlain)
		{
			return EnumerateAsAddresses( nilnul.fs.folder.to_.Info.Singleton.to(nonlinkPlain)).Select(x=> new nilnul.fs.Folder(x));
		}

		public static IEnumerable<string> Addresses(FolderI nonlinkPlain)
		{
			return EnumerateAsAddresses(nonlinkPlain.ToString());
			//throw new NotImplementedException();
		}


	}
}
