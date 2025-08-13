namespace nilnul.dev.prj_.sql.directory.toe_
{
	/// <summary>
	/// a cumulative <see cref="IDes"/> from a table at the last seg of a namespace, to anywhere  upstream of the namespace or any upstream inlet of a confluenting stream.
	/// eg:
	///		a.b.c.d.Carte_ can cumulatively <see cref="IDes"/> upto _b.A; here we regard both a and _b.A as the sup of b.
	/// </summary>
	/// alias:
	///		carte
	///			in memory of DesCarte
	///		rollupward
	///		joi
	///			which would conflict with <see cref="binary_.join_"/>
	///
	interface ICarte {

	}

}
