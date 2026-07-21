namespace nilnul.dev.prj_
{
	/// <summary>
	/// language INtegrated Query; also a library, run on webserver alongside with other libs, to connect to db, thus mapping db to lib objects;
	/// this is separated from lib in that:
	///		: a new namespace to map db table to object, avoiding conflicting with the names in a mid tier lib;
	///		: can be replaced by another connection which connects to a different data src;
	/// </summary>
	/// alias:
	///		conn
	///		db
	internal class ILinq:IPrj
	{
	}




}
