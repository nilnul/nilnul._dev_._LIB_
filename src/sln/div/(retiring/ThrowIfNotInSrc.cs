﻿using nilnul.fs;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.fs.address_.shields_;
using nilnul.dev;

namespace nilnul.dev.sln.div
{
	[Obsolete(nameof(nilnul.fs.folder.repoName_.ThrowIfNotInSrc))]
	public class RepoName
	{
		private SrcsI3 _srcs;

		public SrcsI3 srcs
		{
			get { return _srcs; }
			set { _srcs = value; }
		}

		public RepoName(SrcsI3 srcs)
		{
			_srcs = srcs;
		}

		public RepoName() : this(
			nilnul.dev.Properties.Settings.Default.srcs
		)
		{

		}

		public RepoName(StringCollection srcs1) : this(
			srcs1.Cast<string>().Select(x => nilnul.fs.address_.Shield.Parse(x))
		)
		{

		}

		public RepoName(IEnumerable<Shield> enumerable) : this(Srcs3.FroUnsured(enumerable))
		{

		}

		public RepoName(Disjoint disjoint1) : this(new Srcs3(disjoint1) as SrcsI3)
		{
		}

		/// <summary>
		/// get the src
		/// </summary>
		/// <param name="container"></param>
		/// <returns></returns>
		public nilnul.fs.address_.ShieldI getSrc(nilnul.fs.address_.ShieldI container)
		{
			return _srcs.shields.ee.FirstOrDefault(x => nilnul.fs.address_.shield.re_.Sup.Singleton.re(x, container));
		}

		public string getName(string shield)
		{
			return getName(nilnul.fs.address_.Shield.FroAddress(shield));
		}

		public string getName(FolderI folder1)
		{
			return getName(folder1.address.en);
		}

		public string getName(nilnul.fs.address_.ShieldI container)
		{

			var src = getSrc(container);


			IEnumerable<nilnul.fs._address.DirI> dirs;
			if (src == null)
			{
				//dirs = container.stem.div.dirs;

				throw new InvalidOperationException($@"{container} is not in any src");
			}
			else
			{
				dirs = nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
					src, container
				).dirs;
			}

			//var dirs = nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
			//		src, container
			//	).dirs.ToArray();
			//var parts = new List<string>();

			return string.Join(".",
				dirs.Select(
					d => nilnul.dev.sln.div.dir.segs._ParseX.Parse(
						d.denote.ToString()
					).name
				).Select(
					t => nilnul.txt.convert_.trim_.White.Singleton.op(t)
				).Where(
					trimed => !string.IsNullOrEmpty(trimed)
				)
			);

		}

		static public void SingletonReset()
		{
			nilnul.Singleton1<RepoName>.Reset();
		}

		static public RepoName Singleton
		{
			get
			{
				return nilnul.Singleton1<RepoName>.Instance;
			}
		}



	}
}
