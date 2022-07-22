using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.div.dir.nomina_.idioms0comments_.segs_.xpn_
{
	

	[Serializable]
	public class SegsEmptyException : Exception
	{
		public SegsEmptyException() { }
		public SegsEmptyException(string message) : base(message) { }
		public SegsEmptyException(string message, Exception inner) : base(message, inner) { }
		protected SegsEmptyException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
}
