using nilnul.fs._address;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.dir.be_.deV_
{
	/// <summary>
	/// </summary>
	static public class _VsGeneratedX
	{

		static public string[] slnGenerated = new[] { ".vs", "packages" };

		static public string[] prjGenerated = new[] {
			".vs", "packages", "bin", "obj"

			,
			"TestResults"	///only in "test projects" 


		};


		public static bool Be(FolderI parent, DirI dir)
		{
			var dirDenote = dir.denote;

			if (nilnul.fs.folder.be_.vs_.Sln.Singleton.be(parent))
			{
				if (slnGenerated.Contains(dir.denote, nilnul.txt.eq_.CaseInsensitive.Singleton))
				{
					return true;
				}

				
			}
			if (nilnul.fs.folder.be_.vs_.Prj.Singleton.be(parent))
			{
				if (
					prjGenerated.Contains(
						dirDenote,
						nilnul.txt.eq_.CaseInsensitive.Singleton
					)
				)
				{
					return true;
				}
			}

			return false;
		}

		static public bool Be(DirectoryInfo parent, nilnul.fs._address.DirI dir)
		{
			var dirDenote = dir.denote;

			if (nilnul.fs.folder.be_.vs_.Sln.Singleton.be(parent))
			{
				if (slnGenerated.Contains(dir.denote, nilnul.txt.eq_.CaseInsensitive.Singleton))
				{
					return true;
				}

				
			}
			if (nilnul.fs.folder.be_.vs_.Prj.Singleton.be(parent))
			{
				if (
					prjGenerated.Contains(
						dirDenote,
						nilnul.txt.eq_.CaseInsensitive.Singleton
					)
				)
				{
					return true;
				}
			}

			return false;
		}

		static public bool Be_ofAddresses(string parent, nilnul.fs._address.DirI dir)
		{
			return Be(new DirectoryInfo(parent),dir);
		}

	}
	public class VsGenerated :
		nilnul.fs.folder.Boxed
		,

		nilnul.fs._address.dir.BeI
	{
		public VsGenerated(FolderI val) : base(val)
		{

		}



		public bool be(DirI obj)
		{
			return _VsGeneratedX.Be(boxed,obj);
			
		}
	}

	public class VsGenerated_caching :
		nilnul.fs.folder.Boxed
		,

		nilnul.fs._address.dir.BeI
	{
		private bool _beSln;

		public bool beSln
		{
			get { return _beSln; }
			//set { _beSln = value; }
		}

		private bool _bePrj;

		public bool bePrj
		{
			get { return _bePrj; }
			//set { _bePrj = value; }
		}


		public VsGenerated_caching(FolderI val) : base(val)
		{
			_beSln = nilnul.fs.folder.be_.vs_.Sln.Singleton.be(val);
			_bePrj = nilnul.fs.folder.be_.vs_.Prj.Singleton.be(val);
		}



		public bool be(DirI dir)
		{
			var dirDenote = dir.denote;

			if (_beSln)
			{
				if (_VsGeneratedX.slnGenerated.Contains(
					dirDenote,
					nilnul.txt.eq_.CaseInsensitive.Singleton)
				)
				{
					return true;
				}


			}
			if (_bePrj)
			{
				if (
					_VsGeneratedX.prjGenerated.Contains(
						dirDenote,
						nilnul.txt.eq_.CaseInsensitive.Singleton
					)
				)
				{
					return true;
				}
			}

			return false;
		}
	}

}
