using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.sub.dir_.synd_.tgts_
{
	/// <summary>
	/// choose the project dir according to <see cref="nameof(src.sln.prj._name._tgt.Primitive_)"/>
	/// </summary>
	static public class _CsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sub">
		/// sub the folder
		/// </param>
		/// <param name="tgts">
		/// such as
		///		LIB
		///		TEST
		///		WEB
		///		WEB.DEMO
		/// </param>
		/// <returns></returns>
		static public Dictionary<string, (string, fs.folder._repoName.dir.name_.idioms0Comments_.Segs)> Dnts(
			nilnul.fs.FolderI sub

		)
		{
			var r= new Dictionary<string, (string, fs.folder._repoName.dir.name_.idioms0Comments_.Segs)>() {
				
			};

			dev.src.prj._name.Tgts.CsEs.Each(
				cs=>
				{
					var d = sln.sub.dir_._synd._ChooseX.DntNulable(sub, cs);
					if (d ==(default,default))
					{

					}
					else
					{
						r.Add(
							cs,
							d
						);
					}
				}
			);

			return r;





		}

		/// <summary>
		/// container of prjFolder
		/// </summary>
		/// <param name="prjFolderParent"></param>
		/// <param name="prjName"></param>
		/// <returns></returns>
		public static Dictionary<string, (string, fs.folder._repoName.dir.name_.idioms0Comments_.Segs)> Dnts(
			nilnul.fs.address_.ShieldI prjFolderParent
		)
		{
			return Dnts(
				new nilnul.fs.Folder(prjFolderParent)
				

			);
		}

	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="subAddress">
		///		the tgt of prj is kept in the base(main) of the doc name, not just in ext
		/// </param>
		/// <returns></returns>
		public static Dictionary<string, (string, fs.folder._repoName.dir.name_.idioms0Comments_.Segs)> Dnts_subOfAddress(
			string subAddress
			)
		{


			return Dnts(
				nilnul.fs.Folder.FroAddress(subAddress)
			);
		}



	}
}
