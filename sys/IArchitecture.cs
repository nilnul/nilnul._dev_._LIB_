namespace nilnul.dev.sln
{
	/// <summary>
	/// how subsystems are structured (statically) together to coordinate|collaborate (dynamically);
	/// eg:
	///		monolithic
	///		manifold homogenously
	///		client|server topology
	///		distributive (peer to peer) networked, which can be more loosely coupled than client|server topology, and more robust to failure of one node, but more complex to coordinate and secure.
	/// </summary>
	public interface IArchitecture { }

}
