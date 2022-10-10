using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.deV._id._nom._idiom.casible_
{
	/// <summary>
	/// as casible's start and end char must be cacible, chinese char has no such subtlety.
	/// We here consider find the corresponding "upper", "lower" pair chinese chars. this set is a subset of all the chinese characters.
	/// To find the pair, we may consider:
	///		1) simplified as lower, traditional as upper.
	///			eg: 国 as lower, 國 as upper
	///		2) for financial used digit, secular use as lower, financial use as upper
	///			eg: 一 as lower, 壹 as upper
	///		3) variant(异体) with less strokes is taken as lower, the one with more strokes is taken as upper
	///			eg: 両 is lower, 两 is upper
	///			強强
	///			
	///		4） the seldom-use（罕见）, archaic (古体), etc,  is taken as upper.
	///		
	///			
	///			奔, 犇
	///			冰，氷
	///			草艸
	///			操𢮥
	///			册冊
	///			查査
	///			察［詧
	///			插［揷
	///			趁［趂
	///			乘［乗
	///			
	///			吃［喫
	///			仇［讐
	///			床［牀
	///			
	///			秌	秋
	///			和	咊
	///			
	///			够	夠
	///			
	///			
	///			
	///			(https://zh.m.wikisource.org/zh-hans/%E7%AC%AC%E4%B8%80%E6%89%B9%E5%BC%82%E4%BD%93%E5%AD%97%E6%95%B4%E7%90%86%E8%A1%A8
	///		5) enclosed one is upper. to make on char enclosed, we may use combined chars (use plural unicode point) or precombined char
	///		:
	///		eg:
	///		🈚
	///		   🈑
	///		手 🈐
	///		 文 ㉆
	///		 大 ㉩
	///		 ㊰
	///		 土 ㈯  #avoid use this as it may confuse with parenthesized
	///		🉆
	///		5.1) with an upper stoke combined is taken upper, when upper char is otherwise unavailable	
	///		
	///		6) where no ambiguity incurred, append a radical to a char to make a uppercase.
	///			米，咪
	///			采，採
	///			韭	韮
	///		7） vertial layout is upper, horizon layout is lower
	///			eg:
	///				啟	啓
	///				桃 𣑯
	///				略 畧
	///				讎 讐
	///				群	羣
	///				峰 as lower, 峯 as upper
	///		8) chinese form as lower, overseas to chinese (such a jp, korea) mailand is upper
	///			污汚
	///			姊姉
	///			咒呪
	///			冰	氷
	///			真		眞
	///			值		値
	///		9) 正体(often with a formal annotation)、俗体中: more stoked one is upper, often used one is upper.
	///			蛆 as lower, 䏣 as upper
	///			沙	砂
	///		 岡	崗
	///			升	昇
	///			稾	藁
	///			果	菓
	///			来 來
	///			蛇	虵
	///				花華
	///			嫂	㛐
	///			夜亱
	///			户戶
	///			(https://zh.wikipedia.org/wiki/%E5%BC%82%E4%BD%93%E5%AD%97
	///		10) in other ancient countires that use simipar HanChar forms, such as Tangut(西夏)， those char is not activesly used. they are taken as upper.
	///		but the rendering support is poor.
	///		eg:
	///		11) a radical is taken as the lower or upper form
	///		  心 as lower, ⺖ as upper
	///		  ⺷ as upper for 羊, which is a lower form
	///		  ⻠ as upper for
	///		  (https://www.key-shortcut.com/en/writing-systems/%E6%96%87%E5%AD%97-chinese-cjk/cjk-characters-1
	///		12) emoji   
	///		 
	/// </summary>
	/// <remarks>
	/// unlike the stableness among different unicode versions, the compildation of such pairs follows version semantics: break among major, compatible among minor versions
	/// proposition of alternative can be managed together as well.
	/// </remarks>
	public class Chinese
	{
		public const string Caplitalized = "Es";
	}
}
