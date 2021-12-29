using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.spear;

namespace nilnul.dev.src.prj_.cs.build_.config_
{
	/// <summary>
	/// <see cref="	nameof(_config.IPrjRef)"/>.
	/// if the prj is recently build using a different config, then the built in this config is not the newest.
	/// </summary>
	public class Max
	{
		private fs.address_.spear_.ParentDoc _prjFile;

		public fs.address_.spear_.ParentDoc prjFile
		{
			get { return _prjFile; }
			//set { _prjFile = value; }
		}

		private string _prjNomina;

		public string prjNomina
		{
			get { return _prjNomina; }
			set
			{
				_prjNomina = value;
				_prjFile = nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(prjNomina);
			}
		}

		public Max(string prjNomina)
		{
			this.prjNomina = prjNomina;


		}
		private Max() {

		}

		static public Max Of(fs.address_.spear_.ParentDoc file) {
			return new Max()
			{
				_prjFile = file

				,
				_prjNomina = nilnul.fs._address._route.division_._div._dir.dnt_.exted._StubX._Stub(file.doc.ToString())

			};
		}
		static public Max OfFile(string file) {
			return Of( fs.address_.spear_.ParentDoc.Parse(file));
		}

		public string configMax()
		{
			return nilnul.objs._MaxOrDefaultX.Max(
			configs4push
			,
			c => versionNulable(
				prjNomina
				, c
			),
			nilnul.txt_._versioned.version_.ms.nulable.comp_.NulMin.Singleton
			);
		}

		public bool isMax(string config)
		{
			return nilnul.txt.nulable.eq_.NulUneq.Singleton.Equals(
				configMax()
				, config
			);
		}

		 public win.prog._run.Result nulIfAlreadyNew_ensureMax( string config)
		{
			if (!isMax(config))
			{
				//rebuild to push as the newest
				var r=build_._ForceX.ThrowXpn(prjFile, config); // nuget update is not 

				return r;
			}
			return null;

			


		}

		public System.Version versionNulable(string prjNomina, string config)
		{
			var prjFile = this.prjFile;// nilnul.dev.src.sln.sub.synd.prj_.cs._meta._LocateX.SpearNulable_ofMain(prjNomina);

			var builtDll = System.IO.Path.Combine(
				prjFile.parent.ToString()
				,
				"bin"
				,
				config,
				$"{prjNomina}.dll"
			);
			if (
				nilnul.fs.address_.spear.be_.File.Singleton.Be_ofAddress(builtDll)
			)
			{
				var assemblyMeta = AssemblyName.GetAssemblyName(builtDll);
				return assemblyMeta.Version;

			}
			return null;
		}
		//search other config with pushing enabled.

		static string[] configs4push = new[] { "Release", "Symbols4Debug", "Symbols","Symbol" };




	}
}
