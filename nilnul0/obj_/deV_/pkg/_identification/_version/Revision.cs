using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV_.pkg._identity._version
{
	public class Revision : nilnul.obj.Box1<nilnul.NumI1>
	{

		public Revision(NumI1 val) : base(val)
		{
		}

		public Revision(int v4):this(new nilnul.Num1(v4) )
		{

		}

		public nilnul.NumI1 num { get {
				return boxed;
			} }


		public BigInteger numAsBigint { get {
				return num.toBigint();
			} }

		public int numAsInt { get {
				return (int)numAsBigint;
			} }


		public override string ToString()
		{
			return $".{boxed}";
		}


	}
}
