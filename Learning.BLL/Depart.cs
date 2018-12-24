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
using System.Data;
using System.Collections.Generic;
using Learning.Common;
using Learning.Model;
namespace Learning.BLL
{
	/// <summary>
	/// Depart
	/// </summary>
	public partial class Depart
	{
		private readonly Learning.DAL.Depart dal=new Learning.DAL.Depart();
		public Depart()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DepartId)
		{
			return dal.Exists(DepartId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Learning.Model.Depart model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Learning.Model.Depart model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int DepartId)
		{
			
			return dal.Delete(DepartId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string DepartIdlist )
		{
			return dal.DeleteList(DepartIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Learning.Model.Depart GetModel(int DepartId)
		{
			
			return dal.GetModel(DepartId);
		}

        /// <summary>
        /// 数据分页
        /// </summary>
        /// <param name="cols">所查询的列</param>
        /// <param name="strWhere">所查询的条件</param>
        /// <param name="ordercols">排序列</param>
        /// <param name="orderby">降序或升序</param>
        /// <param name="PageIndex">当前页数</param>
        /// <param name="PageSize">每页条数</param>
        /// <param name="RowCount">记录总数</param>
        /// <param name="PageCount">总页数</param>
        /// <returns></returns>
        public DataSet GetListCols(string cols, string strWhere, string ordercols, string orderby, int PageIndex, int PageSize, ref int RowCount, ref int PageCount)
        {
            return dal.GetListCols(cols, strWhere, ordercols, orderby, PageIndex, PageSize, ref RowCount, ref PageCount);
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Learning.Model.Depart> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Learning.Model.Depart> DataTableToList(DataTable dt)
		{
			List<Learning.Model.Depart> modelList = new List<Learning.Model.Depart>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Learning.Model.Depart model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

