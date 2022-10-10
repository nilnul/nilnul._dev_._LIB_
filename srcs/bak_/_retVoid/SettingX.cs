using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.shield;

namespace nilnul.dev.srcs.bak_._retVoid
{
	static public class SettingX
	{

		static public ConcurrentBag<string> modulesNewlyBaked = new ConcurrentBag<string>();

		static public ConcurrentBag<string> shieldsNewlyBaked = new ConcurrentBag<string>();

		static public ConcurrentBag<string> slnsNewlyBaked = new ConcurrentBag<string>();
		static public string module2bak
		{
			get
			{
				return nilnul.dev.srcs.bak_._retVoid.Settings1.Default.module2bak??"";

			}
		}


		[Obsolete("nilnul._dev_._bak_._LIB_")]
		static public IEnumerable<string> shieldsBaked
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsBaked ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}
		static public IEnumerable<string> shieldsNotBaked
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsNotBaked?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}

		static public IEnumerable<string> modulesBaked
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesBaked?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}

		static public IEnumerable<string> ModulesNotBakedInside
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesNotBakedInside?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}


		static public IEnumerable<string> slnsBaked
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.slnsBaked?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}


		static public IEnumerable<string> shields2bak
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shields2bak ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}

		static public IEnumerable<string> shields2bakOf(StringCollection sc)
		{
			
				return (sc ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			
		}

		[Obsolete()]
		static public nilnul.fs.address_.shields_.Disjoint srcs
		{
			get
			{
				return fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(
					(
					Settings1.Default.srcs ?? new System.Collections.Specialized.StringCollection()
					).Cast<string>()
				);
			}
		}

		static public nilnul.fs.address_.shields_.Disjoint srcs1
		{
			get
			{
				return fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(
					(
						Settings1.Default.srcs 
						?? 
						new System.Collections.Specialized.StringCollection()
					).Cast<string>()
				);
			}
		}


		/// <summary>
		/// is shield baked?
		/// </summary>
		/// <param name="shieldAddress"></param>
		/// <returns></returns>
		static public bool IsBaked(string shieldAddress)
		{
			//return nilnul.fs.address_.shields._CoverX1.Cover_inAddress(
			//		shieldsBaked
			//		,
			//		(shieldAddress)
			//);

			return nilnul.fs.address_.shield.collection.op_.binary_.Dif.Singleton.ret(
				 nilnul.fs.address_.shield.collection_.cover.aggregate_._union.Ret.OfAddresses(shieldsBaked)
				,
				 nilnul.fs.address_.shield.collection_.cover.aggregate_._union.Ret.OfAddresses(shieldsNotBaked)

			).contain_ofAddress(shieldAddress);
		}



		static public bool IsModuleBaked(string shieldAddress)
		{
			//return nilnul.fs.address_.shield.set._HasX.Bit_ofAddresses(
			//		modulesBaked
			//		,
			//		(shieldAddress)
			//);

			return nilnul.fs.address_.shield.collection.op_.binary_.Dif.Singleton.op(
				 nilnul.fs.address_.shield.collection_.Set.OvAddresses( modulesBaked)
				,
				nilnul.fs.address_.shield.collection_.Cover.OfAddresses(
					ModulesNotBakedInside
				)
			).Contain_ofAddress( 
				shieldAddress
			);
		}



		[Obsolete(""+ nameof(IsBaked))]
		static public bool IsSlnBaked(string shieldAddress)
		{
			return nilnul.fs.address_.shields._CoverX.Cover_inAddress(
					slnsBaked
					,
					(shieldAddress)
			);
		}


		static public void _SaveNewlyBaked()
		{
			var absorbed = nilnul.fs.address_.shields_.Disjoint._Absorb_addresses(shieldsBaked, shieldsNewlyBaked);

			//var newlyBaked = shieldsNewlyBaked;

			//var merged = shieldsBaked.Concat(newlyBaked);

			//var newDoneFolders = nilnul.fs.address_.shields_.Disjoint.Fro(merged);

			if (
				nilnul.fs.address_.shield.set.Eq.Singleton.eq_ofAddresses(
					shields2bak
					,
					absorbed.Select(
						s => s.ToString()
					)
				)
			)
			{
				//newDoneFolders = new nilnul.fs.address_.shields_.Disjoint();
				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesBaked = new StringCollection();
				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsBaked= new StringCollection();

			}

			//var stringconn = new StringCollection();

			//stringconn.AddRange(newDoneFolders.en.Select(container => container.ToString()).ToArray());
			else
			{
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsBaked = nilnul.txts_.StrCollectionX.FroEnumable( absorbed.Select(x=>x.ToString()));

			}


		}
		static public void _SaveNewlyBakedModule()
		{
			var absorbed = new nilnul.fs.address_.shield.Set(
				modulesBaked.Concat( modulesNewlyBaked).Select(x=>nilnul.fs.address_.shield_._AddressX1.Create(x))
			);

			//var merged = modulesBaked.Concat(modulesNewlyBaked);
			//var newDoneModules = nilnul.fs.address_.shields_.Disjoint.Fro(merged);

			//var modulesBakedNow = new StringCollection();
			//modulesBakedNow.AddRange(newDoneModules.en.Select(container => container.ToString()).ToArray());

			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesBaked = nilnul.txts_.StrCollectionX.FroEnumable( absorbed.Select(x=>x.ToString()) );

			//nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();

		}

		static public void Save()
		{
			_SaveNewlyBakedModule();
			//_SaveNewlyBakedSlns();
			_SaveNewlyBaked();
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();

		}


		//static public void _SaveNewlyBakedSlns()
		//{
		//	var merged = slnsBaked.Concat(slnsNewlyBaked);
		//	var newDoneModules = nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(merged);

		//	var stringconn = new StringCollection();
		//	stringconn.AddRange(newDoneModules.en.Select(container => container.ToString()).ToArray());

		//	nilnul.dev.srcs.bak_._retVoid.Settings1.Default.slnsBaked= stringconn;

		//	//nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();

		//}


	}
}
