namespace nilnul.obj_.deV
{
	/// <summary>
	/// a str of words. We can have 0 word, thus the txt can be empty.
	/// </summary>
	/// dot led name is not word, as splitting that we will get an empty str at the begining whileas word cannot be empty.
	/// dotAppend name is a word neither, and parsing it into words throw exception. But:
	///		)) we seldom bother at it. And windows explorer automatically remove the trailing dot if you input the name.
	///		)) in fs, we take abc. as a normal filename with ext as "."
	///
	/// alias:
	///		words
	///		caption
	///		name
	///			not a single word, but a str of words.
	///			confusion with folder name when used in <see cref="dev.src.sln.div._RepoNameX"/>
	class IWords
	{

	}

}
