namespace nilnul.dev
{
	/// <summary>
	/// if the address does not exist, it's included. (traced in the category of info: )
	/// if the addresses refers to a file, the file is included. (warning: : plz consider move the file into a folder and add that folder to srcs. Or, is the file a pac, namely a zip file that can be decopressed into a folder?)
	/// if the address is shield, and the refered is a file, an error is booked
	/// 
	/// if the address_.spear and address_.Shield is the same  when shrinked (c:\a is eq to c:\a\), the short one is kept. This is inline to the interpretation of address <see cref="nameof(nilnul.fs.address.meaning)"/>:
	///		c:\a refers to the tagged object. for file, the tag is the content. for folder, the tag is null.
	///		c:\a\ refers to the contained divisions. for file, the contained is empty; for folder the contained is the divisions.
	/// </summary>

	public interface SrcsI_addresses:
		
		_srcs_.AddressesI
		,
		ISrcs

	{

	}
}
