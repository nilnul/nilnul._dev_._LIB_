using nilnul.fs.address_.spear_;
using nilnul.obj.seq;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.prj_.cs.doc_.snk.put_
{
	/// <summary>
	/// if the doc is not occupied, create symlink to the given file.
	/// if the doc is occupied by a dir, do nothing.
	/// if the doc is a file, log an error.
	/// </summary>
	static public class _SymX
	{
		static public bool _Created_prjOfFolderAddress(
			string prj
			,
			string sharedInsallation
		)
		{


			return _Created_prjAssumeCs(
				nilnul.fs.Folder.FroAddress(prj)
				, sharedInsallation
			);


		}
		static public bool _Created_prjIdentityAssumeCs(
			string identity
			,
			string sharedInsallation
		)
		{


			return _Created_prjMetaAssumeCs(
				nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(identity)


				,
				sharedInsallation);

		}
		public static bool _Created_prjMetaAssumeCs(string parentDoc, string sharedInsallation)
		{
			return _Created_prjMetaAssumeCs(ParentDoc.Parse(parentDoc),sharedInsallation);
		}
		public static bool _Created_prjMetaAssumeCs(ParentDoc parentDoc, string sharedInsallation)
		{

			return _Created_prjAssumeCs(parentDoc.parent, sharedInsallation);
		}
		static public bool _Created_prjAssumeCs(
	nilnul.fs.address_.ShieldI prj
	,
	string sharedInsallation
)
		{


			return _Created_prjAssumeCs(
				new nilnul.fs.Folder(prj),
				sharedInsallation);

		}



		static public bool _Created_prjAssumeCs(
			nilnul.fs.FolderI prj
			,
			string sharedInsallation
		)
		{
			var snks = synd_.cs.doc_._SnksX.Captions(prj);

			if (snks.None())
			{
				src.synd_.cs.doc_.snk_.unoccupied.create_._SymX._Vod_prjAssumeCs(
					prj, sharedInsallation
				);
				return true;
			}
			if (
				!snks.Contains(
					dev.src.synd_.cs.doc_._SnkX.TMP_DOC
					,
					nilnul.txt.eq_.CaseInsensitive.Singleton
				)
			)
			{
				src.synd_.cs.doc_.snk_.unoccupied.create_._SymX._Vod_prjAssumeCs(
					prj, sharedInsallation
				);
				return true;

				//Trace.TraceError(
				//	$"{prj} has no {_SnkX.TMP_DOC}"
				//);
			}

			return false;


		}


	}
}
