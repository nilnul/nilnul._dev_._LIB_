using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs;
using nilnul.fs.address_.shield.sortie_;
using nilnul.fs.address_.shields_;

namespace nilnul.dev
{

	/// <summary>
	/// <see cref="nameof(Srcs_addresses)"/>
	/// </summary>
	public class Srcs3:
		_srcs_.ShieldsA
		,
		SrcsI3
	{

		public Srcs3(nilnul.fs.address_.shields_.Disjoint val) : base(val )
		{
		}

		public Srcs3(Lst list):this( new Disjoint(list) )
		{
		}

		static public Srcs3 FroAddresses(IEnumerable<string> folders) => new Srcs3( nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(folders))
		;
		static public Srcs3 FroAddresses(params string[] folders) => new Srcs3(nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(folders))
	;
		static public Srcs3 FroAddresses(StringCollection stringCollection) => new Srcs3(
			nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(stringCollection.Cast<string>())
		);


		 public IEnumerable<nilnul.fs.folder_.Normal> toNonlinks() {

			return this.ee.Select(x=> nilnul.fs.folder_.nonlink.coerce_._TgtX.Normal(x) );
		}


		 public IEnumerable<nilnul.fs.folder_.Normal> toDisjointNonlinks() {

			var links = toNonlinks();

			nilnul.fs.folders.be_.disjoint.VowOfSeq.Singleton.vow(links.Select(x=>x.en));

			return links;

		}

		static public StringCollection Cfged {
			get {
				return Properties.Settings.Default.srcs ?? new StringCollection();
			}
		}

		static public IEnumerable<string> CfgedAsTxts {
			get {
				return nilnul.txts_.StrCollectionX.ToEnumable(Cfged);
			}
		}
		

		

	}
}
