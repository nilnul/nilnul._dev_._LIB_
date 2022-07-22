using nilnul.fs.address_.spear_;
using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.prj_._sql_.directory.include_
{
	/// <summary>
	/// include a directory as nonbuild, checking whether it's already included.
	/// to extend this, note to exclude "bin","obj", "packages" and other generated directories(mostly dirs.)
	/// </summary>
	///
	static public class _NonbuildX
	{





		static public IEnumerable<XElement> Els_directoryAssumeFolder(
			nilnul.fs.address_.ShieldI prjContainer
			,
			XDocument xdoc
			,
			IEnumerable<XElement> folders
			,
			IEnumerable<XElement> builds
			,
			IEnumerable<XElement> nones
			,
			IEnumerable<XElement> build0noneS
			,
			nilnul.fs._address.DirectoryI directory

		)
		{


			if (

				folders.Any(
					e =>
					nilnul.txt0nul.eq_.fs_.backslashed_.EnsureEndDeck.Singleton.Equals(
					e.Attribute("Include").Value
					,
					
					directory.ToString()
				)
				)
			)
			{

			}
			else
			{
				yield return division._IncludeX._El4folder(

					directory
				);
			}

			var full = new nilnul.fs.address_.shield_.BaseDiv(prjContainer, directory);

			var docs = nilnul.fs.folder._DocsX.Docs(
				full

			);


			foreach (var item in docs)
			{
				var document = new fs._address.Document(directory, item);
				if (
					build0noneS.Any(
						e => nilnul.txt0nul.eq_.fs_.backslashed_.EnsureEndDeck.Singleton.Equals(
							e.Attribute("Include").Value
							,
							document.ToString()
						)
					)
				)
				{

				}
				else
				{
					yield return _sql_.division._IncludeX._El4document(
						document
					);
				}
			}
			foreach (
				var dir in nilnul.fs.folder._DirsX.Dirs(
						full
				)
			)
			{
				foreach (
					var item in Els_directoryAssumeFolder(
						prjContainer
						,
						xdoc
						,
						folders
						,
						builds
						, nones
						,
						build0noneS
						,
						//nilnul.fs._address._route.division_.div_.di
						nilnul.fs._address.directory_._BasedDirX.Directory(
							directory
							,
							dir
						)
					)
				)
				{
					yield return item;
				}


			}



		}

		static public IEnumerable<XElement> Els_directoryAssumeFolder(
			nilnul.fs.address_.ShieldI prjContainer
			,
			XDocument xdoc
			,
			nilnul.fs._address.DirectoryI directory
		)
		{



			var folderElS = xdoc.XPathSelectElements(
					 @"/*/*[local-name()='ItemGroup']/*[local-name()='Folder']"
				);

			var buildElS = xdoc.XPathSelectElements(
					 @"/*/*[local-name()='ItemGroup']/*[local-name()='Build']"
				);

			var noneElS = xdoc.XPathSelectElements(
					 @"/*/*[local-name()='ItemGroup']/*[local-name()='None']"
			);


			return Els_directoryAssumeFolder(
				prjContainer
				,
				xdoc,
				folderElS
				,
				buildElS
				,
				noneElS
				,
				buildElS.Concat(noneElS)
				,
				directory
			);

		}



		static public IEnumerable<XElement> Els0nul(
			nilnul.fs.address_.ShieldI prjContainer
			,
			XDocument xdoc
			,
			nilnul.fs._address.DirectoryI directory
		)
		{
			var full = new nilnul.fs.address_.shield_.BaseDiv(prjContainer, directory);

			if (nilnul.fs.address_.shield.be_.Folder.Singleton.be(full))
			{
				return Els_directoryAssumeFolder(prjContainer, xdoc, directory);
			}
			else
			{
				return null;
			}

		}



		static public XElement ItemGrp0Nul_directoryAssumeFolder(
			XDocument xdoc
			,
			nilnul.fs.address_.ShieldI prjContainer
			,
			nilnul.fs._address.DirectoryI directory
		)
		{

			var els = Els_directoryAssumeFolder(prjContainer, xdoc, directory);
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
			XDocument xdoc
			,
			nilnul.fs.address_.ShieldI prjContainer
			,
			nilnul.fs._address.DirectoryI directory
		)
		{

			var els = Els0nul(prjContainer, xdoc, directory);
			if (els is null)
			{
				return null;
			}
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

		static public XElement ItemGrp0Nul_syndAssumeAddress(
			XDocument xdoc,
			string prjContainer,
			nilnul.fs._address.DirectoryI directory
			)
		{
			return ItemGrp0Nul(
				xdoc
				,
				nilnul.fs.address_.Shield.FroAddress(prjContainer)
				,
				directory
			);
		}

		static public XElement ItemGrp0Nul_directoryAssumeDestination(
			XDocument xdoc
			,
			string prjContainer
			,
			string directory
		)
		{
			return ItemGrp0Nul_syndAssumeAddress(
				xdoc,
				(prjContainer)
				,
				nilnul.fs._address._route.division_.div_.directory.op_.of_._DestinationX.Old(directory)
			);
		}

		static public bool _Changed_prjAssumeSql_directoryAssumeDestination(string prj, string directory)
		{
			var doc = XDocument.Load(prj);

			var el0nul = ItemGrp0Nul_directoryAssumeDestination(
				doc
				,
				nilnul.fs.address_.spear._ContainerX.TxtUptoLastSep(prj)
				,
				directory
			);

			var unchanged = el0nul is null;

			if (unchanged)
			{
			}
			else
			{
				var itemGrpLast = doc.XPathSelectElements(
					 @"/*/*[local-name()='ItemGroup']"
				).LastOrDefault();
				if (itemGrpLast is null)
				{
					throw new NotImplementedException($"{prj} has no ItemGroup, which is unimplemented at this time");
				}
				else
				{
					itemGrpLast.AddAfterSelf(el0nul);

					nilnul.xml.el.enclosed._RemoveEmptyNsX.RemoveEmptyNs(el0nul);
					doc.Save(prj);
				}

			}
			return !unchanged;
		}

		public static bool Changed_directoryAssumeDestination(nilnul.fs.file_.ext_.deV_.Sqlproj parentDoc, string directory)
		{
			return _Changed_prjAssumeSql_directoryAssumeDestination(parentDoc.ToString(), directory);
		}

		public static bool Changed_directoryInDestination(nilnul.fs.address_.SpearI parentDoc, string directory)
		{
			return Changed_directoryAssumeDestination(new fs.file_.ext_.deV_.Sqlproj(parentDoc), directory);
		}


		static public bool Changed_prjOfNomina_directoryInDestination(string prjNomina, string directory)
		{
			return Changed_directoryInDestination(
				src.sln.sub.synd.prj_._sql._LocateX.Spear_ofMain(prjNomina)
				,
				directory
			);
		}

	}
}
