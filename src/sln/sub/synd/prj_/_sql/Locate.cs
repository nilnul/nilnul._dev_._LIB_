using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.sub.synd.prj_._sql
{
	/// <summary>
	/// choose the project file according to id(nom and version)
	/// </summary>
	static public class _LocateX
	{
		static public (fs._address.doc_._exted.Main, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) Main(nilnul.fs.FolderI folder, string[] prjIdentity)
		{

			return src.sln.sub.prj.meta_._ChoosePrjX.ChooseMain(
				folder, prjIdentity,

				nilnul.dev.prj_.Sql.EXT
			);



		}
		static public (fs._address.doc_._exted.Main, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) Main(
			nilnul.fs.address_.ShieldI folder
			,
			string[] prjIdentity
		)
		{
			return Main(
				new nilnul.fs.Folder(folder), prjIdentity
			);
		}




		public static (fs._address.doc_._exted.Main, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) Main(
			nilnul.fs.address_.ShieldI prjFolderParent
			,
			string main)
		{

			return src.sln.sub.prj.meta_._ChoosePrjX.ChooseMain(
				prjFolderParent, main,

				nilnul.dev.prj_.Sql.EXT
			);


		}
		public static nilnul.fs.address_.spear_.ParentDoc Spear_ofMain(string main)
		{
			return src.sln.sub.prj.meta_._ChoosePrjX.SpearNulable_ofDoc(
				main
				,
				nilnul.dev.prj_.Sql.EXT
			);
		}

		public static nilnul.fs.address_.spear_.ParentDoc Spear_ofMain(string main,
			Srcs_addresses svrRepoS)
		{
			return src.sln.sub.prj.meta_._ChoosePrjX.Spear_ofDoc(
				main
				,
				nilnul.dev.prj_.Sql.EXT
				,
			  svrRepoS
			);
		}



	}
}
