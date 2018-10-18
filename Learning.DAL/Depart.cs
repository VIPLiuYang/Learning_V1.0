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
using System.Text;
using System.Data.SqlClient;
using Learning.Common;

namespace Learning.DAL
{
	/// <summary>
	/// 数据访问类:Depart
	/// </summary>
	public partial class Depart
	{
		public Depart()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("DepartId", "Depart"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int DepartId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Depart");
			strSql.Append(" where DepartId=@DepartId");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartId", SqlDbType.Int,4)
			};
			parameters[0].Value = DepartId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Learning.Model.Depart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Depart(");
			strSql.Append("DepartName,Manager,FatherId,DOrder,address,tel,type,state,deptcode,sort,z-index)");
			strSql.Append(" values (");
			strSql.Append("@DepartName,@Manager,@FatherId,@DOrder,@address,@tel,@type,@state,@deptcode,@sort,@z-index)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartName", SqlDbType.VarChar,50),
					new SqlParameter("@Manager", SqlDbType.VarChar,50),
					new SqlParameter("@FatherId", SqlDbType.Int,4),
					new SqlParameter("@DOrder", SqlDbType.Int,4),
					new SqlParameter("@address", SqlDbType.VarChar,50),
					new SqlParameter("@tel", SqlDbType.NVarChar,20),
					new SqlParameter("@type", SqlDbType.TinyInt,1),
					new SqlParameter("@state", SqlDbType.TinyInt,1),
					new SqlParameter("@deptcode", SqlDbType.NVarChar,200),
					new SqlParameter("@sort", SqlDbType.Int,4),
					new SqlParameter("@z-index", SqlDbType.Int,4)};
			parameters[0].Value = model.DepartName;
			parameters[1].Value = model.Manager;
			parameters[2].Value = model.FatherId;
			parameters[3].Value = model.DOrder;
			parameters[4].Value = model.address;
			parameters[5].Value = model.tel;
			parameters[6].Value = model.type;
			parameters[7].Value = model.state;
			parameters[8].Value = model.deptcode;
			parameters[9].Value = model.sort; 

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
		public bool Update(Learning.Model.Depart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Depart set ");
			strSql.Append("DepartName=@DepartName,");
			strSql.Append("Manager=@Manager,");
			strSql.Append("FatherId=@FatherId,");
			strSql.Append("DOrder=@DOrder,");
			strSql.Append("address=@address,");
			strSql.Append("tel=@tel,");
			strSql.Append("type=@type,");
			strSql.Append("state=@state,");
			strSql.Append("deptcode=@deptcode,");
			strSql.Append("sort=@sort,");
			strSql.Append("z-index=@z-index");
			strSql.Append(" where DepartId=@DepartId");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartName", SqlDbType.VarChar,50),
					new SqlParameter("@Manager", SqlDbType.VarChar,50),
					new SqlParameter("@FatherId", SqlDbType.Int,4),
					new SqlParameter("@DOrder", SqlDbType.Int,4),
					new SqlParameter("@address", SqlDbType.VarChar,50),
					new SqlParameter("@tel", SqlDbType.NVarChar,20),
					new SqlParameter("@type", SqlDbType.TinyInt,1),
					new SqlParameter("@state", SqlDbType.TinyInt,1),
					new SqlParameter("@deptcode", SqlDbType.NVarChar,200),
					new SqlParameter("@sort", SqlDbType.Int,4),
					new SqlParameter("@z-index", SqlDbType.Int,4),
					new SqlParameter("@DepartId", SqlDbType.Int,4)};
			parameters[0].Value = model.DepartName;
			parameters[1].Value = model.Manager;
			parameters[2].Value = model.FatherId;
			parameters[3].Value = model.DOrder;
			parameters[4].Value = model.address;
			parameters[5].Value = model.tel;
			parameters[6].Value = model.type;
			parameters[7].Value = model.state;
			parameters[8].Value = model.deptcode;
			parameters[9].Value = model.sort; 
			parameters[10].Value = model.DepartId;

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
		public bool Delete(int DepartId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Depart ");
			strSql.Append(" where DepartId=@DepartId");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartId", SqlDbType.Int,4)
			};
			parameters[0].Value = DepartId;

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
		public bool DeleteList(string DepartIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Depart ");
			strSql.Append(" where DepartId in ("+DepartIdlist + ")  ");
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
		public Learning.Model.Depart GetModel(int DepartId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 DepartId,DepartName,Manager,FatherId,DOrder,address,tel,type,state,deptcode,sort,z-index from Depart ");
			strSql.Append(" where DepartId=@DepartId");
			SqlParameter[] parameters = {
					new SqlParameter("@DepartId", SqlDbType.Int,4)
			};
			parameters[0].Value = DepartId;

			Learning.Model.Depart model=new Learning.Model.Depart();
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
		public Learning.Model.Depart DataRowToModel(DataRow row)
		{
			Learning.Model.Depart model=new Learning.Model.Depart();
			if (row != null)
			{
				if(row["DepartId"]!=null && row["DepartId"].ToString()!="")
				{
					model.DepartId=int.Parse(row["DepartId"].ToString());
				}
				if(row["DepartName"]!=null)
				{
					model.DepartName=row["DepartName"].ToString();
				}
				if(row["Manager"]!=null)
				{
					model.Manager=row["Manager"].ToString();
				}
				if(row["FatherId"]!=null && row["FatherId"].ToString()!="")
				{
					model.FatherId=int.Parse(row["FatherId"].ToString());
				}
				if(row["DOrder"]!=null && row["DOrder"].ToString()!="")
				{
					model.DOrder=int.Parse(row["DOrder"].ToString());
				}
				if(row["address"]!=null)
				{
					model.address=row["address"].ToString();
				}
				if(row["tel"]!=null)
				{
					model.tel=row["tel"].ToString();
				}
				if(row["type"]!=null && row["type"].ToString()!="")
				{
					model.type=int.Parse(row["type"].ToString());
				}
				if(row["state"]!=null && row["state"].ToString()!="")
				{
					model.state=int.Parse(row["state"].ToString());
				}
				if(row["deptcode"]!=null)
				{
					model.deptcode=row["deptcode"].ToString();
				}
				if(row["sort"]!=null && row["sort"].ToString()!="")
				{
					model.sort=int.Parse(row["sort"].ToString());
				}
				 
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select DepartId,DepartName,Manager,FatherId,DOrder,address,tel,type,state,deptcode,sort,z-index ");
			strSql.Append(" FROM Depart ");
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
			strSql.Append(" DepartId,DepartName,Manager,FatherId,DOrder,address,tel,type,state,deptcode,sort,z-index ");
			strSql.Append(" FROM Depart ");
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
			strSql.Append("select count(1) FROM Depart ");
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
				strSql.Append("order by T.DepartId desc");
			}
			strSql.Append(")AS Row, T.*  from Depart T ");
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
			parameters[0].Value = "Depart";
			parameters[1].Value = "DepartId";
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

