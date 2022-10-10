using nilnul.fs.address_.spear_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj_._sql_.directory.include_.nonbuild_
{
	/// <summary>
	/// include a directory as nonbuild.
	/// to extend this, note to exclude "bin","obj", "packages" and other generated directories(mostly dirs.)
	/// </summary>
	static public class _AssumeNotIncludedX
	{

		/// <summary>
		/// 
		/// </summary>
		/// <param name="directory">backslashed</param>
		/// <returns></returns>
		static public XElement _El4folder_directoryAssumeComplied(string directory)
		{
			return new XElement(
				"Folder",

				new XAttribute("Include", directory)


			);
		}


		static public XElement _El4folder(nilnul.fs._address.DirectoryI doc)
		{
			return _El4folder_directoryAssumeComplied(
				nilnul.fs._address._route.division_.div_.directory._construe_.phrase_.ByBackslashX.ByBackslash(doc)
			);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="document"></param>
		/// <returns></returns>
		static public XElement _El4document_assumeComplied(string document)
		{
			return new XElement(
				"None",

				new XAttribute("Include", document)

			);
		}

		static public XElement _El4document(nilnul.fs._address.Document doc)
		{
			return _El4document_assumeComplied(
				fs._address._route.division_.denotation._construe_.phrase_.ByBackslashX.ByBackslash(doc)
			);
		}


		

		static public IEnumerable<XElement> Els(
			nilnul.fs.address_.ShieldI prjContainer
			, nilnul.fs._address.DirectoryI directory
		)
		{
			var full = new nilnul.fs.address_.shield_.BaseDiv(prjContainer, directory);


			var docs = nilnul.fs.folder._DocsX.Docs(
				full

			);




			return new[]{
				_El4folder(
					
					directory
				)
			}.Concat(
				docs.Select(
					d =>
					_El4document(
						new fs._address.Document(directory, d)
					)
				)
			).Concat(
				nilnul.fs.folder._DirsX.Dirs(
						full
				)
				.SelectMany(
					dir
						=>
					Els(
								prjContainer
								,
								//nilnul.fs._address._route.division_.div_.di
								nilnul.fs._address.directory_._BasedDirX.Directory(
									directory
									,
									dir
								)
					)
				)
			);
		}


		static public XElement ItemGrp0Nul(
			
			nilnul.fs.address_.ShieldI prjContainer
			,
			nilnul.fs._address.DirectoryI directory
		)
		{
			var els = Els(prjContainer, directory);
			if (els.Any())
			{
				return new XElement(
					"ItemGroup"
					,
					els
				);


			}
			return null;


			
		}
		static public XElement ItemGrp0Nul(
			string prjContainer, nilnul.fs._address.DirectoryI directory)
		{
			return ItemGrp0Nul(
				nilnul.fs.address_.Shield.FroAddress(prjContainer)
				,
				directory
			);
		}

		static public XElement ItemGrp0Nul(
			string prjContainer, string directory)
		{
			return ItemGrp0Nul(
				(prjContainer)
				,
				nilnul.fs._address._route.division_.div_.directory.op_.of_._DestinationX.Old(directory)
			);
		}

		static public bool Of_prjAssumeSql(string prj, string directory)
		{
			var doc = XDocument.Load(prj);

			var el0nul = ItemGrp0Nul(
				prj,directory
			);

			var changed = el0nul is null;
			
			if (changed)
			{
			}
			else
			{
				var itemGrpLast = doc.XPathSelectElements(
					 @"/*/*[local-name()='ItemGroup']/*[local-name()='Build']"
				).LastOrDefault();
				if (itemGrpLast is null)
				{
					throw new NotImplementedException();
				}
				else
				{
					itemGrpLast.AddAfterSelf(el0nul);
				doc.Save(prj);

				}

			}
			return changed;
		}

		private static bool OfPrj(nilnul.fs.file_.ext_.deV_.Sqlproj parentDoc, string directory)
		{
			return Of_prjAssumeSql(parentDoc.ToString(), directory);
		}

		private static bool OfPrj(nilnul.fs.address_.SpearI parentDoc, string directory)
		{
			return OfPrj(new fs.file_.ext_.deV_.Sqlproj(parentDoc),directory);
		}


		static public bool prjOfNomina(string prjNomina, string directory)
		{
			return OfPrj(
				src.sln.sub.synd.prj_._sql._LocateX.Spear_ofMain(prjNomina),  directory
			);
		}

	}
}
