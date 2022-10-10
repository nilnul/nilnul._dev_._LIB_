using nilnul.dev.prj_.cs;
using nilnul.fs.address_.spear_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.dev.src.prj_.cs._meta_.snk
{
	/// <summary>
	/// only changes the meta. untouch the *.snk file 
	/// </summary>
	static public class _EnsureX
	{
		public static void _OfModify(Modify prjModified)
		{
			//var changed = false;
			var xml = prjModified.xdoc;

			#region signedAssembly element

			var xpath = "/*/*[local-name()='PropertyGroup']/*[local-name()='SignAssembly']";

			var el1 = xml.XPathSelectElements(xpath).SingleOrDefault();
			if (el1 is null)
			{
				el1 = new XElement(
					//xml.Root.GetDefaultNamespace()+
					"PropertyGroup"
					,
					new XElement(
						"SignAssembly"
						,
						true
					)
				);

				var xpath4itemGroup = "/*/*[local-name()='ItemGroup']";
				var itemGrpEle = xml.XPathSelectElements(xpath4itemGroup).FirstOrDefault();

				if (itemGrpEle is null)
				{

					var xpath4BuildCfg = "/*/*[local-name()='PropertyGroup'][@Condition]";
					var conditioned = xml.XPathSelectElements(xpath4BuildCfg).LastOrDefault();
					if (conditioned is null)
					{

						//first property
						var firstPropGrp = xml.XPathSelectElements("/*/*[local-name()='PropertyGroup']").FirstOrDefault();
						if (firstPropGrp is null)
						{
							xml.Root.AddFirst(el1);
							prjModified.touch();

						}
						else
						{
							firstPropGrp.AddBeforeSelf(el1);
							prjModified.touch();
						}
					}
					else
					{
						conditioned.AddAfterSelf(el1);
						prjModified.touch();
					}

				}
				else
				{
					itemGrpEle.AddBeforeSelf(el1);
					prjModified.touch();
				}


				//var attr = el1.Attribute("xmlns");
				//if (attr is null)
				//{
				//}
				//else
				//{
				//	if (string.IsNullOrWhiteSpace(attr.Value))
				//	{
				//		attr.Remove();
				//	}
				//}

				#region notwork
				//var attrs =
				//el1.Attributes().Where(a => a.IsNamespaceDeclaration);
				// <- empty
				//attrs.Remove();

				#endregion
				if (!(el1.Parent is null))
				{

					foreach (var item in el1.DescendantsAndSelf())
					{
						//item.Name = XNamespace.None+ item.Name.LocalName; //not work


						item.Name = item.Parent.GetDefaultNamespace() + item.Name.LocalName;
					}

				}

				prjModified.touch();
				//el1.Name = el1.Parent.GetDefaultNamespace() + el1.Name.LocalName;


			}
			else
			{
				if (

					!nilnul.txt.nulable.eq_.Trim.Singleton.Equals(el1.Value, "true")



					)
				{
					el1.Value = nilnul.bit.phrase_._LowerX.True;
					prjModified.touch();

				}
			}
			#endregion

			#region file

			var xpath4snkFile = "/*/*[local-name()='PropertyGroup']/*[local-name()='AssemblyOriginatorKeyFile']";

			var el4snkFile = xml.XPathSelectElements(xpath4snkFile).SingleOrDefault();

			el1 = el4snkFile;
			if (el4snkFile is null)
			{
				var intendedEl4snk = new XElement(
						xml.Root.GetDefaultNamespace() +
						"PropertyGroup"
						,
						new XElement(
xml.Root.GetDefaultNamespace() +
							"AssemblyOriginatorKeyFile"
							,
							dev.src.synd_.cs.doc_._SnkX.TMP_DOC
						)
					);
				el4snkFile = intendedEl4snk;
				var xpath4itemGroup = "/*/*[local-name()='ItemGroup']";
				var itemGrpEle = xml.XPathSelectElements(xpath4itemGroup).FirstOrDefault();

				if (itemGrpEle is null)
				{

					var xpath4BuildCfg = "/*/*[local-name()='PropertyGroup'][@Condition]";
					var conditioned = xml.XPathSelectElements(xpath4BuildCfg).LastOrDefault();

					if (conditioned is null)
					{

						//first property
						var firstPropGrp = xml.XPathSelectElements("/*/*[local-name()='PropertyGroup']").FirstOrDefault();
						if (firstPropGrp is null)
						{

							xml.Root.AddFirst(el1);

						}
						else
						{
							firstPropGrp.AddBeforeSelf(el1);
						}
						prjModified.touch();
					}
					else
					{
						conditioned.AddAfterSelf(el1);
						prjModified.touch();


					}

				}
				else
				{
					itemGrpEle.AddBeforeSelf(el4snkFile);
					prjModified.touch();
				}
				el4snkFile.Name = el4snkFile.Parent.GetDefaultNamespace() + el4snkFile.Name.LocalName;

			}
			else
			{
				var trimmed = el4snkFile.Value?.Trim();
				if (string.IsNullOrWhiteSpace(trimmed))
				{
					el4snkFile.Value = dev.src.synd_.cs.doc_._SnkX.TMP_DOC;
					prjModified.touch();
				}
				else
				{
					if (trimmed != dev.src.synd_.cs.doc_._SnkX.TMP_DOC)
					{
						Trace.TraceWarning($".snk file is not the t.snk for project:{prjModified.prjAddress}");

					}

				}
			}

			#endregion


		}



		static public bool _Changed_assumeCsproj(
			string prjFile
			,
			XDocument xml
		)
		{
			var t = Modify._AssumeValid(prjFile, xml);
			_OfModify(
				t
			);
			return t.changed;


		}


		static public void _Vod(
			string prjFile
		)
		{
			//var trace = new TraceSource();
			var xml = XDocument.Load(prjFile);

			var changed = _Changed_assumeCsproj(prjFile, xml);


			if (changed)
			{
				xml.Save(prjFile);
			}
		}


		public static bool _Changed_assumeCsproj(string prjFile, out XDocument xdoc)
		{
			xdoc = XDocument.Load(prjFile);
			return _Changed_assumeCsproj(prjFile.ToString(), xdoc);

		}
		public static bool _Changed_assumeCsproj(ParentDoc prjFile, XDocument xdoc)
		{
			return _Changed_assumeCsproj(prjFile.ToString(), xdoc);

		}
		public static bool _Changed_assumeCsproj(ParentDoc prjFile, out XDocument xdoc)
		{
			return _Changed_assumeCsproj(prjFile.ToString(), out xdoc);

		}


		public static void Vod(ParentDoc prjFile)
		{
			_Vod(prjFile.ToString());
		}
	}
}
