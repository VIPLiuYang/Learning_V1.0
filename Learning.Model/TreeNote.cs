/**  版本信息模板在安装目录下，可自行修改。
* TreeNote.cs
*
* 功 能： N/A
* 类 名： TreeNote
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/10/17 20:31:19   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Learning.Model
{
	/// <summary>
	/// TreeNote:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TreeNote
	{
		public TreeNote()
		{}
		#region Model
		private int _treenodeid;
		private string _notename;
		private int? _fathernoteid=0;
		private string _url="#";
		private string _imgurl;
		private string _status= "1";
		private int? _webid;
		private string _code;
		private int? _torder=1;
		private decimal? _price=0M;
		/// <summary>
		/// 
		/// </summary>
		public int TreeNodeId
		{
			set{ _treenodeid=value;}
			get{return _treenodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NoteName
		{
			set{ _notename=value;}
			get{return _notename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FatherNoteId
		{
			set{ _fathernoteid=value;}
			get{return _fathernoteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImgUrl
		{
			set{ _imgurl=value;}
			get{return _imgurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? WebId
		{
			set{ _webid=value;}
			get{return _webid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TOrder
		{
			set{ _torder=value;}
			get{return _torder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? price
		{
			set{ _price=value;}
			get{return _price;}
		}
		#endregion Model

	}
}

