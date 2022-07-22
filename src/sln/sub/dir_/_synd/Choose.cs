using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.sub.dir_._synd
{
	/// <summary>
	/// choose the project container, which is a folder
	/// </summary>
	/// obsoleting <see cref="nilnul.dev.srcs.prj._locator._SubDirX"/>
	static public class _ChooseX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sub">
		/// sub the folder
		/// </param>
		/// <param name="prjIdentityRemained"> split prj main by dot into array. initial segs have been matached by sub; this is the remained.
		/// with "git" comment, priority is high
		/// </param>
		/// <param name="ext">
		/// ext of prjFile
		/// </param>
		/// <returns></returns>
		static public (string, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) DntNulable(
			nilnul.fs.FolderI sub
			,
			//string[]
			IEnumerable<string> prjIdentityRemained

		)
		{

			//var docCandidateEs_inDnts = 
			// found the prefix that are the same
			//;

			return nilnul.objs_._MaxesX.Maxes(
				nilnul.fs.folder._DirsX.Captions(sub)
				.Select(
					dnt => (
						dnt: dnt
						,
						segs: nilnul.obj_.deV.identy.noted._ParsedX.NotedNulable(dnt.ToString())
					)
				).Where(
					t => !(t.Item2 is null)
				).Where(
					t => t.Item2 is nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs // if it's all comments, disregard.
				).Select(
					t => (
						dnt: t.Item1,
						segs: t.Item2 as nilnul.fs.folder._repoName.dir.name_.idioms0Comments_.Segs
					)

				)   /// torso are the same
				.Where(
					segs => nilnul.txts.eq_.CaseInsensitive.Singleton.eq(
						nilnul.objs_.started._TorsoX.Torso(segs.Item2.asSegs())
						,
						nilnul.objs_.started._TorsoX.Torso(prjIdentityRemained)
					)
				)
				.Where(
					t => sln.prj._name._tgt.primitive.alias._SortieX.Sortie_ofCirca(
						prjIdentityRemained.Last()
					).Contains(
						t.segs.asSegs().Last().name.ToString()
						,
					nilnul.obj_.deV._id.nom_.idiom.circa.eq_.core_.CaseInsentive.Singleton
					) // get all the candidates.
				)
				,
				new nilnul.obj.comp_.OvComps<
					(
						string
						,
						fs.folder._repoName.dir.name_.idioms0Comments_.Segs
					)
				>(
					new nilnul.obj.comp_.ByTag<
						(string
						,
						fs.folder._repoName.dir.name_.idioms0Comments_.Segs)
						,
						int
					>(
						t => t.Item2.asSegs().Last().name == prjIdentityRemained.Last() ? 1 : 0
						,
						Comparer<int>.Default
					)
					,
					new nilnul.obj.comp_.ByTag<
						(
							string
							,
							fs.folder._repoName.dir.name_.idioms0Comments_.Segs
						)
						,
						nilnul.NumI
					>(
						e => nilnul.txt_.vered._VerX.Num(e.Item1), nilnul.num.Comparer2.Singleton
					)
					,
					new nilnul.obj.comp_.ByTag<
						(
							string
							,
							fs.folder._repoName.dir.name_.idioms0Comments_.Segs
						)
						,
						int
					>(
						e => e.Item2.asSegs().Any(s => s.hasNotationCaseInsensitive("git")) ? 1 : 0, Comparer<int>.Default
					)


				)
			).SingleOrDefault();//.Item1.ToString();





		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sub"></param>
		/// <param name="prjIdentityRemained"></param>
		/// <returns> the dnt, and the parsed segs</returns>
		static public (string, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) DntNulable(
			nilnul.fs.FolderI sub
			,
			string prjIdentityRemained

		)
		{
			return DntNulable(sub, prjIdentityRemained.Split('.'));
		}



		/// <summary>
		/// container of prjFolder
		/// </summary>
		/// <param name="prjFolderParent"></param>
		/// <param name="prjName"></param>
		/// <returns></returns>
		public static (string, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) DntNulable(
			nilnul.fs.address_.ShieldI prjFolderParent,
			IEnumerable<string> prjName
			)
		{
			return DntNulable(
				new nilnul.fs.Folder(prjFolderParent)
				,
				prjName

			);
		}

		public static (string, fs.folder._repoName.dir.name_.idioms0Comments_.Segs) DntNulable(
			nilnul.fs.address_.ShieldI prjFolderParent,
			string prjName
			)
		{
			return DntNulable(
				new nilnul.fs.Folder(prjFolderParent)
				,
				prjName.Split('.')

			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="prjMain">
		///		the tgt of prj is kept in the base(main) of the doc name, not just in ext
		/// </param>
		/// <returns></returns>
		public static nilnul.fs.address_.shield_.BaseDir ShieldNulable_ovBase(
			string prjMain
			)
		{
			var sub = nilnul.dev.src.sln._sub._NulableOvPrjX._Sub_ofMain(
				prjMain,
				out IEnumerable<string> subRemained
				,
				out string target
			);
			if (sub is null)
			{
				return null;
			}

			var dnt = nilnul.dev.src.sln.sub.dir_._synd._ChooseX.DntNulable(
				sub
				,
				nilnul.objs.op_.unary_._AppendX.Append(
					subRemained
					,
					target
				)
			);
			if (dnt == (default,default))
			{
				return null;
			}

			var prjAsShield = nilnul.fs.address_.shield_.BaseDir.Create_dirOfDenote(
					sub,
					dnt.Item1
				);
			return prjAsShield;
		}

		public  static nilnul.fs.address_.shield_.BaseDir ShieldNulable_ovBase(string main, Srcs_addresses srcs)
		{

			var sub = nilnul.dev.src.sln.div_._sub._OvPrjX._Sub_ofMain(
				main,
				srcs,
				out IEnumerable<string> subRemained
				,
				out string target
			);

			var dnt = nilnul.dev.src.sln.sub.dir_._synd._ChooseX.DntNulable(
				sub
				,
				nilnul.objs.op_.unary_._AppendX.Append(
					subRemained
					,
					target
				)
			);
			if (dnt == (default,default))
			{
				return null;
			}

			var prjAsShield = nilnul.fs.address_.shield_.BaseDir.Create_dirOfDenote(
					sub,
					dnt.Item1
				);
			return prjAsShield;


		}
	}
}
