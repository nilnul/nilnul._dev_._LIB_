using nilnul.obj_.deV._identy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.type
{
	/// <summary>
	/// at least one term
	/// str of termVeredS, dot separated.
	/// Note version is not a notion of Name, but Term.
	/// </summary>
	/// <remarks>
	/// as path is separated by "/", name is seperated by "."
	/// </remarks>
	public class Identity : obj_.deV._identy_.LocalNameI, obj_.deV._identy_.NamespaceI
	{
		private ILocal _local;
		public ILocal local => _local;



		private Sur _sur;
		public Sur sur => _sur;
		public Identity(ILocal local, Sur sur)
		{
			_local = local;
			_sur = sur;
		}

		public override string ToString()
		{
			return $"{_sur}{_local}";
		}
	}
}
