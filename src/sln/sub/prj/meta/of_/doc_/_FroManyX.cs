using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.sub.prj.meta.of_.doc_
{
	/// <summary>
	/// choose the project file according to identy(nomina and version)
	/// </summary>
	/// <seealso cref="nilnul.dev.src.sln.sub.synd._prj._LocateX"/>
	static public class _FroManyX
	{



		public static IEnumerable<nilnul.fs.address_.spear_.ParentDoc> Spears_ofDoc(
			string main, nilnul.fs._address.doc_._exted.Ext ext, Srcs_addresses srcs)
		{

main = dev.src.sln._nomina.Updates.Defaulted.rewritePrj(main);

			var prjAsShieldS = nilnul.dev.src.sln.sub.dir_._prj.choose_._ManyX.Shields_assumeNomina(
				main,srcs
			);
			foreach (var prjAsShield in prjAsShieldS)
			{
				if (prjAsShield is null)
				{
					continue;
				}

				var prjMainFound = nilnul.dev.src.sln.sub.synd.prj._main._LocateNulableX.ChooseMain(
					prjAsShield
					,
					main
					,
					ext
				);
				if (prjMainFound.Item1 is null)
				{
					continue;
				}

				var prjFile = new nilnul.fs.address_.spear_.ParentDoc(
					prjAsShield,
					prjMainFound.Item1 + ext
				);

				yield return prjFile;
			}

			
		}

		public static IEnumerable<fs.address_.spear_.ParentDoc> Spears_ofDoc(string main, string ext, Srcs_addresses svrRepoS)
		{
			return Spears_ofDoc(
				main
				,
				new fs._address.doc_._exted.Ext(ext)
				, svrRepoS
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
		public static IEnumerable< nilnul.fs.address_.spear_.ParentDoc> Spears_ofDoc(string main, nilnul.fs._address.doc_._exted.Ext ext)
		{
			return Spears_ofDoc(
				main,ext,  Srcs_addresses.OvCfg()
			);
		}

		public static IEnumerable< nilnul.fs.address_.spear_.ParentDoc> Spears_ofDoc(string main, nilnul.fs._address.doc_._exted.ExtI ext)
		{
			return Spears_ofDoc(
				main
				,
				 
				ext is nilnul.fs._address.doc_._exted.Ext a?a: new fs._address.doc_._exted.Ext(ext.ToString())
				,
				Srcs_addresses.OvCfg()
			);
		}

		public static IEnumerable<fs.address_.spear_.ParentDoc> Spears_ofDoc(string main, string ext)
		{
			return Spears_ofDoc(
				main
				,
				new fs._address.doc_._exted.Ext(ext)
			);
		}

		public static IEnumerable<fs.address_.spear_.ParentDoc> Spears_ofDoc(string prjName)
		{

			var exted = nilnul.fs._address.doc_.MainExt.Parse(prjName);

			return Spears_ofDoc(
				exted.main
				,
				exted.ext
			);
		}


	}
}
