using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;

namespace nilnul.dev
{
	/// <summary>
	/// All your data should be put in one of the srcs; each src contains a collection of slns
	/// </summary>
	/// 
	[Obsolete()]
	public interface SrcsI1:
		
		nilnul.fs.address_.ContainersI

	{

		
	}
	[Obsolete()]
	public class Srcs1:
		nilnul.fs.address_.containers_.Disjoint
		,
		SrcsI1
	{

		public Srcs1(nilnul.fs.address_.containers_.Disjoint val) : base(val )
		{
		}

		public Srcs1(IEnumerable<string> folders):this(Disjoint.Fro(folders) )
		{

		}
		public Srcs1(params string[] folders):this(  Disjoint.Fro(folders))
		{

		}

		public Srcs1(StringCollection stringCollection):this(
			stringCollection.Cast<string>()
		)
		{

		}

		

	}
}
