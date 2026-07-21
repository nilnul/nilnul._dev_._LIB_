using nilnul.dev.prj_.cs;
using nilnul.fs.address;
using nilnul.fs.address_.spear_;
using nilnul.fs.address_.spear_.based_;
using nilnul.obj.seq;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.raw.prj_.cs.doc_.snk.put_
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
				nilnul.dev.raw.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(identity)


				,
				sharedInsallation);

		}
		public static bool _Created_prjMetaAssumeCs(string parentDoc, string sharedInsallation)
		{
			return _Created_prjMetaAssumeCs(ParentDoc.Parse(parentDoc), sharedInsallation);
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
				raw.synd_.cs.doc_.snk_.unoccupied.create_._SymX._Vod_prjAssumeCs(
					prj, sharedInsallation
				);
				return true;
			}
			if (
				!snks.Contains(
					dev.raw.synd_.cs.doc_._SnkX.TMP_DOC
					,
					nilnul.txt.eq_.CaseInsensitive.Singleton
				)
			)
			{
				raw.synd_.cs.doc_.snk_.unoccupied.create_._SymX._Vod_prjAssumeCs(
					prj, sharedInsallation
				);
				return true;

				//Trace.TraceError(
				//	$"{prj} has no {_SnkX.TMP_DOC}"
				//);
			}

			var fullPath = System.IO.Path.Combine(prj.ToString(), dev.raw.synd_.cs.doc_._SnkX.TMP_DOC);
			// if it's symlink
			if (
				 nilnul.fs.folder.doc.be_._SymlinkX.Be_ofAddress(fullPath)
			)
			{
				var tgt = nilnul.fs.location_.link_.sym._TgtX._Address0nul_0location(fullPath);

				if (tgt is null)
				{
					Trace.TraceWarning(
						$"{fullPath} is a symlink, but the target is null. This is unexpected."
					);

					///nilnul.fs.location.drop_._RecyclableX.Del(fullPath);
					///
					nilnul.fs.file.drop_._RecyclableX.Vod(fullPath);

					raw.synd_.cs.doc_.snk_.unoccupied.create_._SymX._Vod_prjAssumeCs(
						prj, sharedInsallation
					);

					return true;

				}

				if (
					nilnul.fs.address.be_.Location1.Singleton.Be(tgt.ToString())
				)
				{
					return false; //not created.
				}


				Trace.TraceError(
					$"{fullPath} is a symlink pointing to a valid location, but the target {tgt} is not {sharedInsallation}. This is unexpected."
				);
				return false;

			}


			///hard value, we cannot change that as that might be what the user puts;
			return false;


		}

		public static void _Created_prjAssumeCs(Child1 prjFile)
		{

			_Created_prjMetaAssumeCs(
				prjFile.ToString()
				,
				nilnul.dev.raw.synd_.cs.doc_.snk_.unoccupied.create_._SymX.Address_underPrimarySrc()
			);

		}
		public static void _Create(Modify prjModified)
		{
			_Created_prjAssumeCs(prjModified.prj);
		}

		public static void _Created_prjMetaAssumeCs(ParentDoc prjFile)
		{
			_Created_prjMetaAssumeCs(
				prjFile
				,
				nilnul.dev.raw.synd_.cs.doc_.snk_.unoccupied.create_._SymX.Address_underPrimarySrc()
			);
			//throw new NotImplementedException();
		}
	}
}
