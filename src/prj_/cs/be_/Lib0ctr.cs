using nilnul.fs.address_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.be_
{
	/// <summary>
	/// lib 0 ctr
	/// </summary>
	public class Lib0ctr
		:
		nilnul.obj_.singular.Heir<Lib0ctr>,

		BeI
	{

		static public sln.prj._name._tgt.primitive.Aliases txts {
			get {
				return nilnul.dev.src.sln.prj._name._tgt.primitive.alias._SortieX.LIB0CTR_asAlias;
			}
		}
				

		static public bool Be_ofTarget(string target) {

			return nilnul.dev.src.sln.prj._name._tgt.primitive.alias._SortieX.LIB0CTR_asAlias.contain(target);
		}


		static public bool Be_ofIdenty(IEnumerable<string> identity) {
			var target = identity.Last();



			return Be_ofTarget(target);
		}

		static public bool Be_ofIdenty(string identity) {
			return Be_ofIdenty(identity.Split('.'));
		}

		static public bool Be_ofMain(string mainOfDoc) {

			var parsed = nilnul.obj_.deV.identy.noted._ParsedX.NotedNulable(mainOfDoc);

			if (parsed is null)
			{
				return false;
			}
			if (
				parsed is nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs segs 
			)
			{
				return Be_ofTarget(
					nilnul.txt_.vered._KeyX._Txt(

						nilnul.obj_.deV._id.nom_.idiom.circa._CoreX.Core(
							nilnul.txt_.vered._KeyX._Txt(

								segs.tip.name //.ToString()
							)
						)
					)
				);
			}
			else//  it's all comments, disregard.
			{
				return false;
			}
			
		}

	

		static public bool _Be_assumeCsPrj(nilnul.fs.FolderI _csPrj) {
			/// the name?
			///
			var name = nilnul.fs.folder._repoName.dir.name_.idioms0Comments._ParseX.Parse(
				 nilnul.fs.address_.shield_.BaseDir._Ov(
				_csPrj.address.en
				).child.denote
			).name;

//				 nilnul.obj_.Dev. _id._nom.idiom._CircasX.Txts("lib").Concat(
//nilnul.obj_.Dev. _id._nom.idiom._CircasX.Txts("dll")
//					).Concat(
//nilnul.obj_.Dev. _id._nom.idiom._CircasX.Txts("win_ctr")
//					)
			;

			if (nilnul.dev.src.sln.prj._name._tgt.primitive.alias._SortieX.LIB0CTR_asAlias.contain(name))
			{
				return true;
			}
			return false;

			/// has Dir"TestResults/" ?
		}

		public bool _Be_assumeCsPrj(ShieldI parent)
		{
			return _Be_assumeCsPrj(new nilnul.fs.Folder(parent));
		}

		public bool be(Cs obj)
		{

			var basedDoc = new nilnul.fs.address_.spear_.ParentDoc(obj.ee.file.en);
			return _Be_assumeCsPrj(basedDoc.parent);

		}

	}
}
