using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.documents_
{
	static public class _NoRepoUnLinkX
	{
		static public IEnumerable<string> Addresses(string sln) {

			return nilnul.fs.folder.documents_._NoRepoUnLinkX._Addresses(sln);


		}

		static public IEnumerable<FileInfo> FileInfoS_ofAddress(string sln) {

			return Addresses(sln).Select(x=>new System.IO.FileInfo(x));


		}


	}
}
