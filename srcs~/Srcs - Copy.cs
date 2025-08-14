using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.folders_;

namespace nilnul.dev
{
	/// <summary>
	/// All your data should be put in one of the srcs; each src contains a collection of slns
	/// </summary>
	/// 
	[Obsolete("",true)]
	public interface SrcsI:
		
		IEnumerable<nilnul.fs.FolderI>


	{
		
	}
		[Obsolete("",true)]
public class Srcs:
		nilnul.obj.Box<nilnul.fs.folders_.Disjoint >
		,
		SrcsI
	{

		public Srcs(Disjoint val) : base(val)
		{

		}

		public Srcs(IEnumerable<string> folders):this(Disjoint.Of(folders) )
		{

		}
		public Srcs(params string[] folders):this(  Disjoint.Of(folders))
		{

		}

		public Srcs(StringCollection stringCollection):this(
			stringCollection.Cast<string>()
		)
		{

		}

		public nilnul.fs.folders_.Disjoint folders
		{
			get { return boxed; }
		}

		public IEnumerator<FolderI1> GetEnumerator()
		{
			foreach (var item in folders.ed.toArr())
			{
				yield return item;
			}
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}
}
