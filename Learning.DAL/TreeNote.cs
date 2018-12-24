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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Learning.Common;

namespace Learning.DAL
{
	/// <summary>
	/// 数据访问类:TreeNote
	/// </summary>
	public partial class TreeNote
	{
		public TreeNote()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TreeNodeId", "TreeNote"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int TreeNodeId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TreeNote");
			strSql.Append(" where TreeNodeId=@TreeNodeId");
			SqlParameter[] parameters = {
					new SqlParameter("@TreeNodeId", SqlDbType.Int,4)
			};
			parameters[0].Value = TreeNodeId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Learning.Model.TreeNote model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TreeNote(");
			strSql.Append("NoteName,FatherNoteId,Url,ImgUrl,Status,WebId,Code,TOrder,price)");
			strSql.Append(" values (");
			strSql.Append("@NoteName,@FatherNoteId,@Url,@ImgUrl,@Status,@WebId,@Code,@TOrder,@price)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NoteName", SqlDbType.VarChar,50),
					new SqlParameter("@FatherNoteId", SqlDbType.Int,4),
					new SqlParameter("@Url", SqlDbType.VarChar,500),
					new SqlParameter("@ImgUrl", SqlDbType.VarChar,50),
					new SqlParameter("@Status", SqlDbType.VarChar,50),
					new SqlParameter("@WebId", SqlDbType.Int,4),
					new SqlParameter("@Code", SqlDbType.NVarChar,50),
					new SqlParameter("@TOrder", SqlDbType.Int,4),
					new SqlParameter("@price", SqlDbType.Money,8)};
			parameters[0].Value = model.NoteName;
			parameters[1].Value = model.FatherNoteId;
			parameters[2].Value = model.Url;
			parameters[3].Value = model.ImgUrl;
			parameters[4].Value = model.Status;
			parameters[5].Value = model.WebId;
			parameters[6].Value = model.Code;
			parameters[7].Value = model.TOrder;
			parameters[8].Value = model.price;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Learning.Model.TreeNote model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TreeNote set ");
			strSql.Append("NoteName=@NoteName,");
			strSql.Append("FatherNoteId=@FatherNoteId,");
			strSql.Append("Url=@Url,");
			strSql.Append("ImgUrl=@ImgUrl,");
			strSql.Append("Status=@Status,");
			strSql.Append("WebId=@WebId,");
			strSql.Append("Code=@Code,");
			strSql.Append("TOrder=@TOrder,");
			strSql.Append("price=@price");
			strSql.Append(" where TreeNodeId=@TreeNodeId");
			SqlParameter[] parameters = {
					new SqlParameter("@NoteName", SqlDbType.VarChar,50),
					new SqlParameter("@FatherNoteId", SqlDbType.Int,4),
					new SqlParameter("@Url", SqlDbType.VarChar,500),
					new SqlParameter("@ImgUrl", SqlDbType.VarChar,50),
					new SqlParameter("@Status", SqlDbType.VarChar,50),
					new SqlParameter("@WebId", SqlDbType.Int,4),
					new SqlParameter("@Code", SqlDbType.NVarChar,50),
					new SqlParameter("@TOrder", SqlDbType.Int,4),
					new SqlParameter("@price", SqlDbType.Money,8),
					new SqlParameter("@TreeNodeId", SqlDbType.Int,4)};
			parameters[0].Value = model.NoteName;
			parameters[1].Value = model.FatherNoteId;
			parameters[2].Value = model.Url;
			parameters[3].Value = model.ImgUrl;
			parameters[4].Value = model.Status;
			parameters[5].Value = model.WebId;
			parameters[6].Value = model.Code;
			parameters[7].Value = model.TOrder;
			parameters[8].Value = model.price;
			parameters[9].Value = model.TreeNodeId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int TreeNodeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TreeNote ");
			strSql.Append(" where TreeNodeId=@TreeNodeId");
			SqlParameter[] parameters = {
					new SqlParameter("@TreeNodeId", SqlDbType.Int,4)
			};
			parameters[0].Value = TreeNodeId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string TreeNodeIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TreeNote ");
			strSql.Append(" where TreeNodeId in ("+TreeNodeIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Learning.Model.TreeNote GetModel(int TreeNodeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TreeNodeId,NoteName,FatherNoteId,Url,ImgUrl,Status,WebId,Code,TOrder,price from TreeNote ");
			strSql.Append(" where TreeNodeId=@TreeNodeId");
			SqlParameter[] parameters = {
					new SqlParameter("@TreeNodeId", SqlDbType.Int,4)
			};
			parameters[0].Value = TreeNodeId;

			Learning.Model.TreeNote model=new Learning.Model.TreeNote();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Learning.Model.TreeNote DataRowToModel(DataRow row)
		{
			Learning.Model.TreeNote model=new Learning.Model.TreeNote();
			if (row != null)
			{
				if(row["TreeNodeId"]!=null && row["TreeNodeId"].ToString()!="")
				{
					model.TreeNodeId=int.Parse(row["TreeNodeId"].ToString());
				}
				if(row["NoteName"]!=null)
				{
					model.NoteName=row["NoteName"].ToString();
				}
				if(row["FatherNoteId"]!=null && row["FatherNoteId"].ToString()!="")
				{
					model.FatherNoteId=int.Parse(row["FatherNoteId"].ToString());
				}
				if(row["Url"]!=null)
				{
					model.Url=row["Url"].ToString();
				}
				if(row["ImgUrl"]!=null)
				{
					model.ImgUrl=row["ImgUrl"].ToString();
				}
				if(row["Status"]!=null)
				{
					model.Status=row["Status"].ToString();
				}
				if(row["WebId"]!=null && row["WebId"].ToString()!="")
				{
					model.WebId=int.Parse(row["WebId"].ToString());
				}
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["TOrder"]!=null && row["TOrder"].ToString()!="")
				{
					model.TOrder=int.Parse(row["TOrder"].ToString());
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
			}
			return model;
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
            string procname = "XiaoZhengGe";
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + cols);
            strSql.Append(" FROM SchInfo  ");
            //strSql.Append(" left join SchInfo as b on a.SchId=b.SchId	 ");
            //strSql.Append(" left join SchDepartInfo as c on c.Pid=a.DepartId	 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            if (ordercols.Trim() != "")
                strSql.Append(" order by " + ordercols + " " + orderby);
            //  @sqlstr nvarchar(4000), --查询字符串
            //  @currentpage int, --第N页
            //  @pagesize int, --每页行数
            //  @pagecount int output ,
            //  @rowcount int output 
            SqlParameter[] parameters = {
                    new SqlParameter("@sqlstr", SqlDbType.NVarChar, 4000),
                    new SqlParameter("@currentpage", SqlDbType.Int),
                    new SqlParameter("@pagesize", SqlDbType.Int),
                    new SqlParameter("@pagecount", SqlDbType.Int),
                    new SqlParameter("@rowcount", SqlDbType.Int),
                    };
            parameters[0].Value = strSql.ToString();
            parameters[1].Value = PageIndex;
            parameters[2].Value = PageSize;
            parameters[3].Direction = ParameterDirection.Output;
            parameters[4].Direction = ParameterDirection.Output;
            string table1 = "WFListV";
            DataSet myds1 = DbHelperSQL.RunProcedure(procname, parameters, table1);
            DataTable dt = new DataTable();
            dt = myds1.Tables["WFListV1"].Copy();
            DataSet myds = new DataSet();
            myds.Tables.Add(dt);

            PageCount = (int)parameters[3].Value;
            RowCount = (int)parameters[4].Value;
            return myds;
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TreeNodeId,NoteName,FatherNoteId,Url,ImgUrl,Status,WebId,Code,TOrder,price ");
			strSql.Append(" FROM TreeNote ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetTree(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append(" SELECT DISTINCT treeNote.treeNodeId,treeNote.fatherNoteId,TOrder from userInfo  left join  roleuser on userInfo.userId=roleUser.userId LEFT JOIN  ");
            strSql.Append(" rolemodel on roleUser.roleID=roleModel.roleId  LEFT JOIN treeNote on roleModel.treeNodeId=treeNote.treeNodeId   "); 
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}


         



		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" TreeNodeId,NoteName,FatherNoteId,Url,ImgUrl,Status,WebId,Code,TOrder,price ");
			strSql.Append(" FROM TreeNote ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TreeNote ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.TreeNodeId desc");
			}
			strSql.Append(")AS Row, T.*  from TreeNote T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "TreeNote";
			parameters[1].Value = "TreeNodeId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

