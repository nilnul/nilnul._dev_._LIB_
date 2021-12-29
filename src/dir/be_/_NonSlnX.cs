using System.Linq;

namespace nilnul.dev.src.dir.be_
{
	public class _NonSlnX
	{

		public static bool __IsDenoteBlank(nilnul.fs.FolderI folder)
		{

			return nilnul.txt.be_.White.Singleton.be(
				nilnul.fs.folder._repoName.dir.name_.idioms0Comments._ParseX.Parse(
					folder.address.en.stem.div.dirs.Last().denote.ToString()
				).name
			);
		}

		public static bool Be(
				nilnul.fs.FolderI folder
			)
		{
			// from the name by convention 
			// or from a config file

			if (
				folder.address.en.stem.div.dirs.Last().denote.en.StartsWith(".")

				|| __IsDenoteBlank(folder)


			)
			{
				return true;

			}
			return false;






		}
	}
}
