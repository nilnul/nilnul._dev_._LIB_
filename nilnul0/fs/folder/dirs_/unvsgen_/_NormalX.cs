using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dirs_.excludeVs_
{
	/// <summary>
	/// </summary>
	/// 
	//[Obsolete("",true)]
	static public class _NormalX
	{

		

		static public IEnumerable<DirectoryInfo> EnumerateAsAddresses(DirectoryInfo parent)
		{

			return _ExcludeVsX.EnumerateAsAddresses(parent).Where(x=>nilnul.fs.folder.be_._NormalX.Be(x));
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
