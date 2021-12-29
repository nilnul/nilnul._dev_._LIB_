using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs._bak
{
	[Obsolete("",false)]
	static public class SettingX
	{

		static public ConcurrentBag<string> modulesNewlyBaked = new ConcurrentBag<string>();

		//static public ConcurrentBag<string> shieldsNewlyBaked = new ConcurrentBag<string>();


		static public IEnumerable<string> shieldsBaked
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsBaked ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}

		static public IEnumerable<string> modulesBaked
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsBaked ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}


		static public IEnumerable<string> shields2bak
		{
			get
			{
				return (nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shields2bak ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
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
					Settings1.Default.srcs ?? new System.Collections.Specialized.StringCollection()
					).Cast<string>()
				);
			}
		}



		static public bool IsBaked(string shieldAddress)
		{
			return nilnul.fs.address_.shields._CoverX.Cover_inAddress(
					shieldsBaked
					,
					(shieldAddress)
			);
		}

		static public bool IsModuleBaked(string shieldAddress)
		{
			return nilnul.fs.address_.shields._CoverX.Cover_inAddress(
					modulesBaked
					,
					(shieldAddress)
			);
		}


		static public void _SaveNewlyBaked(IEnumerable<string> newlyBaked)
		{
			var merged = shieldsBaked.Concat(newlyBaked);

			var newDoneFolders = nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(merged);

			if (
				nilnul.fs.address_.shield.set.Eq.Singleton.eq_ofAddresses(
					shields2bak
					,
					newDoneFolders.ee.Select(
						s => s.ToString()
					)
				)
			)
			{
				newDoneFolders = new nilnul.fs.address_.shields_.Disjoint();
				nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesBaked = new StringCollection();

			}

			var stringconn = new StringCollection();

			stringconn.AddRange(newDoneFolders.ee.Select(container => container.ToString()).ToArray());

			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.shieldsBaked = stringconn;

		}

		static public void Save(IEnumerable<string> newlyBaked)
		{
			_SaveNewlyBakedModule();
			_SaveNewlyBaked(newlyBaked);
			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();

		}

		static public void _SaveNewlyBakedModule()
		{
			var merged = modulesBaked.Concat(modulesNewlyBaked);
			var newDoneModules = nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(merged);

			var stringconn = new StringCollection();
			stringconn.AddRange(newDoneModules.ee.Select(container => container.ToString()).ToArray());

			nilnul.dev.srcs.bak_._retVoid.Settings1.Default.modulesBaked = stringconn;

			//nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();

		}




	}
}
