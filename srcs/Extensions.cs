using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address;
namespace nilnul.dev.srcs
{
	static public class _ExtensionsX
	{
		/// <summary>
		/// get folders 
		/// </summary>
		/// <param name="srcs"></param>
		/// <returns>
		/// the memeber might be link. destiny nondisjoint
		/// </returns>
		static public IEnumerable<nilnul.fs.FolderI> Folders(nilnul.dev.SrcsI_addresses srcs) {
			var folders= srcs.addresses.Select(
				a=> (a,nilnul.fs.address._CategorizeX.Category(a))
			).Where(
				c=> c.Item2 switch {
				  nilnul.fs.address._categorize.Category.Unoccupied => false
				  ,
				  nilnul.fs.address._categorize.Category.SpearOccupiedByFolder => true
				  ,
				  nilnul.fs.address._categorize.Category.ShieldOccupiedByFolder => true
				  ,
				  nilnul.fs.address._categorize.Category.ShieldOccupiedByFile => throw new Exception()
				  ,
					  _=> false
				}
				
			).Select(
				c1=> new nilnul.fs.Folder(c1.a)
			);

			nilnul.fs.folders.be_.destinyDisjoint.Vow.Singleton.vow(
				folders
			);

			return folders;
		}


	}
}
