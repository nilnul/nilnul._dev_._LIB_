using nilnul.fs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.sln.div_.git_.top
{
	
	[Obsolete()]
	public class Name
	{
		private SrcsI1 _srcs;

		public SrcsI1 srcs
		{
			get { return _srcs; }
			set { _srcs = value; }
		}

		public Name(SrcsI1 srcs)
		{
			_srcs = srcs;
		}

		/// <summary>
		/// get the src
		/// </summary>
		/// <param name="container"></param>
		/// <returns></returns>
		public nilnul.fs.address_.ContainerI1 getSrc(nilnul.fs.address_.ContainerI1 container) {
			return _srcs.FirstOrDefault(x => nilnul.fs.address_.container.re_.Sup.Singleton.re(x,container) );
		}

		public string getName(string shield) {
			return getName(nilnul.fs.address_.Container1.FroAddress(shield));
		}

		public string getName(FolderI folder1)
		{
			return getName(folder1.container);
		}

		public string getName(nilnul.fs.address_.ContainerI1 container) {

			//get the src

			var src = getSrc(container);

			if (src==null)
			{
				throw new Exception("container is not in any src");
			}

			//get the route

			//var route = nilnul.fs.address_.container.duo_.sup._DifX._Dif_ofSupSub(src, container);

			//from div to name
			return string.Join(".",
				nilnul.fs.address_.container.duo_.sup._DifX._Dif_ofSupSub(
					src, container
				).dirs.Select(
					d => nilnul.txt.op_._DeParenX._ByLevel(d.dst.ToString())
				).Select(
					t=> nilnul.txt.convert_.trim_.White.Singleton.op(t)
				).Where(
					trimed=> !string.IsNullOrEmpty(trimed)
				)
			);

		}

	}
}
