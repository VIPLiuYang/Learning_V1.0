/**  版本信息模板在安装目录下，可自行修改。
* Depart.cs
*
* 功 能： N/A
* 类 名： Depart
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/10/17 20:31:18   N/A    初版
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
	/// Depart:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Depart
	{
		public Depart()
		{}
		#region Model
		private int _departid;
		private string _departname;
		private string _manager;
		private int? _fatherid;
		private int? _dorder;
		private string _address;
		private string _tel;
		private int? _type;
		private int? _state=1;
		private string _deptcode;
		private int? _sort; 
		/// <summary>
		/// 
		/// </summary>
		public int DepartId
		{
			set{ _departid=value;}
			get{return _departid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DepartName
		{
			set{ _departname=value;}
			get{return _departname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Manager
		{
			set{ _manager=value;}
			get{return _manager;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FatherId
		{
			set{ _fatherid=value;}
			get{return _fatherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DOrder
		{
			set{ _dorder=value;}
			get{return _dorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 是否有效：0-无效；1-有效
		/// </summary>
		public int? state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string deptcode
		{
			set{ _deptcode=value;}
			get{return _deptcode;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int? sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
	 
		#endregion Model

	}
}

