using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln_.personal_.fs_
{
	/// <summary>
	/// a net disk, cloud storage, which with the help of client software, can sync between client and server, thus can sync many clients with svr. When files are deleted on one device, all (device/client)s as well as svr will remove those files.
	/// This is different from distributive fs such as git in that git stores forked branches that contains a history of different versions of each file.
	/// This has its place being useful in that, for inboxes where screenSnaps/incomingStackedFiles are stored waiting for triage to various versioned projects. When the file is moved to a repo, the file shall be deleted, not create new version upon old commited vesion as done in versionedRepo, so the inbox shall be a synced cloud, not git or any other versioned repo.
	/// </summary>
	interface ISync
	{
	}
}
