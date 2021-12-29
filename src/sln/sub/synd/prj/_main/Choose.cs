using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.sub.synd.prj._main
{
	/// <summary>
	/// choose the project file according to id(nom and version)
	/// </summary>
	static public class _LocateNulableX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="prjContainer">container of the prjMeta</param>
		/// <param name="prjIdentity">the prj Main, as Identity, as segments </param>
		/// <param name="ext">the ext of the meta</param>
		/// <returns></returns>
		static public (fs._address.doc_._exted.Main, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) ChooseMain(
			nilnul.fs.FolderI prjContainer,
			string[] prjIdentity,
			string ext
		)
		{

			var extComparer = new nilnul.fs._address.doc.be_.Ext(ext);
			/// prjNameRemained is split into part of sln and prjType
			///  prjDirName might be "sub._Lib(1"
			var docCandidateEs_inDnts = nilnul.fs.folder._DocsX.Docs(prjContainer).Where(
				 extComparer.be
			).Select(
				t => nilnul.fs._address.doc_.exted._MainX.Main(t)
			)
			.Select(
				m => (
					main: m
					,
					segs: nilnul.obj_.deV.identy.noted._ParsedX.NotedNulable(m.ToString())
				)
			).Where(
				t => !(t.Item2 is null)
			).Where(
				t => t.Item2 is nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs // if it's all comments, disregard.
			).Select(
				t => (
					main: t.Item1,
					segs: t.Item2 as nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs
				)

			)   /// torso are the same
			.Where(
				segs => nilnul.txts.eq_.CaseInsensitive.Singleton.eq(
					nilnul.objs_.started._TorsoX.Torso(segs.Item2.asSegs())
					,
					nilnul.objs_.started._TorsoX.Torso(prjIdentity)
				)
			)
			.Where(
				t => sln.prj._name._tgt.primitive.alias._SortieX.Sortie_ofCirca(
					prjIdentity.Last()
				).Contains(
					t.segs.asSegs().Last().name
					,
					nilnul.obj_.deV._id.nom_.idiom.circa.eq_.core_.CaseInsentive.Singleton

				)

			)
			// found the prefix that are the same
			;

			return nilnul.objs_._MaxesX.Maxes(
				docCandidateEs_inDnts
				,
				new nilnul.obj.comp_.OvComps<
					(
						fs._address.doc_._exted.Main
						,
						fs.folder._repoName.dir.name_.idioms0Comments_.Segs
					)
				>(
					new nilnul.obj.comp_.ByTag<
						(fs._address.doc_._exted.Main
						,
						fs.folder._repoName.dir.name_.idioms0Comments_.Segs)
						,
						int
					>(
						t => t.Item2.asSegs().Last().name == prjIdentity.Last() ? 1 : 0
						,
						Comparer<int>.Default
					)
					,
					new nilnul.obj.comp_.ByTag<
						(
							fs._address.doc_._exted.Main
							,
							fs.folder._repoName.dir.name_.idioms0Comments_.Segs
						)
						,
						nilnul.NumI
					>(
						e => nilnul.txt_.vered._VerX.Num(e.Item1), nilnul.num.Comparer2.Singleton
					)


				)
			).SingleOrDefault();//.Item1.ToString();





		}

		static public (fs._address.doc_._exted.Main, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) ChooseMain(nilnul.fs.address_.ShieldI folder, string[] prjIdentity, string ext)
		{
			return ChooseMain(
				new nilnul.fs.Folder(folder), prjIdentity, ext
			);
		}
		public static (fs._address.doc_._exted.Main, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) ChooseMain(nilnul.fs.address_.ShieldI prjFolderParent, string prjNomina, string ext)
		{
			return ChooseMain(
				new nilnul.fs.Folder(prjFolderParent)
				,
				prjNomina.Split('.')
				, ext
			);
		}



		public static nilnul.fs.address_.spear_.ParentDoc SpearNulable_ofDoc(string main, string ext)
		{
			return SpearNulable_ofDoc(
				main
				,
				new fs._address.doc_._exted.Ext(ext)
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="prjName">
		/// with ext
		/// </param>
		/// <returns>
		/// null if not found
		/// </returns>
		public static nilnul.fs.address_.spear_.ParentDoc SpearNulable_ofDoc(string main, nilnul.fs._address.doc_._exted.Ext ext)
		{
			main = dev.src.sln._nomina.Updates.Defaulted.rewritePrj(main);

			var prjAsShield = nilnul.dev.src.sln.sub.dir_._synd._ChooseX.ShieldNulable_ovBase(
				main
			);
			if (prjAsShield is null)
			{
				return null;
			}

			var prjMainFound = ChooseMain(
				prjAsShield
				,
				main
				,
				ext
			);
			if (prjMainFound.Item1 is null)
			{
				return null;
			}

			var prjFile = new nilnul.fs.address_.spear_.ParentDoc(

			prjAsShield,
			prjMainFound.Item1 + ext
		);

			return prjFile;
		}

		public static nilnul.fs.address_.spear_.ParentDoc Spear_ofDoc(string main, nilnul.fs._address.doc_._exted.Ext ext, Srcs_addresses srcs)
		{

			var prjAsShield = nilnul.dev.src.sln.sub.dir_._synd._ChooseX.ShieldNulable_ovBase(
				main
				,srcs
			);
			if (prjAsShield is null)
			{
				return null;
			}

			var prjMainFound = ChooseMain(
				prjAsShield
				,
				main
				,
				ext
			);
			if (prjMainFound.Item1 is null)
			{
				return null;
			}

			var prjFile = new nilnul.fs.address_.spear_.ParentDoc(

			prjAsShield,
			prjMainFound.Item1 + ext
		);

			return prjFile;
		}

		public static nilnul.fs.address_.spear_.ParentDoc Spear_ofDoc(string prjName)
		{

			var exted = nilnul.fs._address.doc_.MainExt.Parse(prjName);

			var prjAsShield = nilnul.dev.src.sln.sub.dir_._synd._ChooseX.ShieldNulable_ovBase(
				exted.main
			);
			if (prjAsShield is null)
			{
				return null;
			}

			var prjMainFound = ChooseMain(
	prjAsShield
	,
	exted.main
	,
	exted.ext.ToString()
);
			if (prjMainFound.Item1 is null)
			{
				return null;
			}

			var prjFile = new nilnul.fs.address_.spear_.ParentDoc(

			prjAsShield,
			prjMainFound.Item1 + exted.ext.ToString()
		);

			return prjFile;
		}

		public static fs.address_.spear_.ParentDoc Spear_ofDoc(string main, string ext, Srcs_addresses svrRepoS)
		{
			return Spear_ofDoc(
				main
				,
				new fs._address.doc_._exted.Ext(ext)
				, svrRepoS
			);

		}

	}
}
