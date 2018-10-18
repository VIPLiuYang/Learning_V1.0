/**  版本信息模板在安装目录下，可自行修改。
* UserInfo.cs
*
* 功 能： N/A
* 类 名： UserInfo
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
	/// UserInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserInfo
	{
		public UserInfo()
		{}
		#region Model
		private int _userid;
		private string _workerid;
		private string _username;
		private string _pwd="edc5af8367eb9bd8";
		private int? _status=1;
		private string _sid;
		private string _name;
		private string _phone;
		private string _qq;
		private string _email;
		private string _departid;
		private string _address;
		private string _headimg;
		private string _money;
		private int? _permission=1024;
		private string _idcard;
		private int? _iszonghe=0;
		private DateTime? _inssj;
		private DateTime? _udsj;
		/// <summary>
		/// 
		/// </summary>
		public int UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkerID
		{
			set{ _workerid=value;}
			get{return _workerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SID
		{
			set{ _sid=value;}
			get{return _sid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepartId
		{
			set{ _departid=value;}
			get{return _departid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HeadImg
		{
			set{ _headimg=value;}
			get{return _headimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Permission
		{
			set{ _permission=value;}
			get{return _permission;}
		}
		/// <summary>
		/// 身份证
		/// </summary>
		public string idcard
		{
			set{ _idcard=value;}
			get{return _idcard;}
		}
		/// <summary>
		/// 是否是综合管理员：0-否；1-是；
		/// </summary>
		public int? iszonghe
		{
			set{ _iszonghe=value;}
			get{return _iszonghe;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? inssj
		{
			set{ _inssj=value;}
			get{return _inssj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? udsj
		{
			set{ _udsj=value;}
			get{return _udsj;}
		}
		#endregion Model

	}
}

