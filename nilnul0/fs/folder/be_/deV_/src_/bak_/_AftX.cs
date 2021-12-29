using System;

namespace nilnul.fs.folder.be_.deV_.src_.bak_
{
	/// <summary>
	/// after (not until) the given date to bak. baking will not be carried out lt() this date.
	/// </summary>
	///
	[Obsolete("see nilnul.dev.bak")]

	public class _AftX0
	{
		public static bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null)
		{
			win.prog._run.Result r = nilnul.win.prog_.git_.cfg.read_._ResultX.Result
				   (new address_.spear_.ParentDoc(s.address.en, ".nilnulCfg"),
				   "bak.aft", git);
			if (r.beErr)
			{
				return true;
			}

			DateTimeOffset benchmark;// = new DateTime();
			bool parsed = DateTimeOffset.TryParse(r.msg.Trim(), out benchmark);
			if (parsed)
			{
				return DateTimeOffset.UtcNow>= benchmark;
			}
			else
			{
				return true;
			}
		}

		public static bool Be(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null)
		{
			return Be(new nilnul.fs.Folder(s), git);
		}

		public static bool Be_ofAddress(string s, nilnul.win.prog_.Git git = null)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s), git);
		}
	}
}
