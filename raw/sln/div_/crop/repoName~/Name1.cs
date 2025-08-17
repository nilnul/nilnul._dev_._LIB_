using nilnul.fs;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.address_.shields_;

namespace nilnul.dev.sln.div_.git_.top
{
	[Obsolete(nameof(nilnul.fs.folder.RepoName))]
	public class Name1
	{
		private SrcsI3 _srcs;

		public SrcsI3 srcs
		{
			get { return _srcs; }
			set { _srcs = value; }
		}

		public Name1(SrcsI3 srcs)
		{
			_srcs = srcs;
		}

		public Name1():this(
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.srcs
		)
		{

		}

		public Name1(StringCollection srcs1):this(
			srcs1.Cast<string>().Select(x=> nilnul.fs.address_.Shield.Parse(x))
		)
		{

		}

		public Name1(IEnumerable<Shield> enumerable):this(  Srcs3.FroUnsured(enumerable))
		{

		}

		public Name1(Disjoint disjoint1):this(new Srcs3(disjoint1) as SrcsI3)
		{
		}

		/// <summary>
		/// get the src
		/// </summary>
		/// <param name="container"></param>
		/// <returns></returns>
		public nilnul.fs.address_.ShieldI getSrc(nilnul.fs.address_.ShieldI container) {
			return _srcs.shields.en.FirstOrDefault(x => nilnul.fs.address_.shield.re_.Sup.Singleton.re(x,container) );
		}

		public string getName(string shield) {
			return getName(nilnul.fs.address_.Shield.FroAddress(shield));
		}

		public string getName(FolderI folder1)
		{
			return getName(folder1.container.ToString());
		}

		public string getName(nilnul.fs.address_.ShieldI container) {

			var src = getSrc(container);

			if (src==null)
			{
				throw new Exception("container is not in any src");
			}

			//var dirs = nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
			//		src, container
			//	).dirs.ToArray();
			//var parts = new List<string>();

			return string.Join(".",
				nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
					src, container
				).dirs.Select(
					d => nilnul.dev.sln.div.dir.segs._ParseX.Parse(
						d.name.ToString()
					).name
				).Select(
					t=> nilnul.txt.convert_.trim_.White.Singleton.op(t)
				).Where(
					trimed=> !string.IsNullOrEmpty(trimed)
				)
			);

		}

		static public Name1 Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Name1>.Instance;
			}
		}

	}
}
