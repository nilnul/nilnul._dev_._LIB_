using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src_.nonlink.set.modules_.nonlink
{
	static public class _DelCred0KeyX
	{


		static public void Void(nilnul.win.prog_.Git git = null)
		{

			var nonlinks = nilnul.fs.folder_.nonlink.Set.FroAddresses(
				nilnul.dev.Properties.Settings.Default.srcs
			);
			Void(nonlinks, git);


		}
		static public void Void(nilnul.fs.folder_.nonlink.Set nonlinks, nilnul.win.prog_.Git git = null)
		{


			var modules = nilnul.dev.src_.nonlink.set.modules_._NonlinkX.Seq_disregardRepo(nonlinks);

			modules.ForEach(
				module =>
				{
					var remotes = nilnul.fs.git.module.repo._cfg_.remotes._VwX.Seq(module);

					remotes.ForEach(
						remote =>
						{
							var urls = nilnul.fs.git.module.repo._cfg_.remote.urls_._ValidX.Urls(module, remote);
							urls.ForEach(
								url =>
								{
									if (
										nilnul.web._url._origin._authority._socket._host.domain.Eq.Singleton.eq(

											//url.origin.authority.socket.host.domain
											nilnul.web.url._DomainX.Domain(url)
											,
											nilnul.fs.git.svr_.BitBucket.DOMAIN
										)

									)
									{
										nilnul.fs.git.module.repo._cfg_.remote.url.change_._DelKeyX.Void(module, remote, url, git);

									}
									else
									{
										nilnul.fs.git.module.repo._cfg_.remote.url.change_._DelCredentialX.Void(module, remote, url, git);

									}
								}
							);

						}
					);
				}
			);

		}

	}
}

