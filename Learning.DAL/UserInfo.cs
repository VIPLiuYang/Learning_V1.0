/**  版本信息模板在安装目录下，可自行修改。
* UserInfo.cs
*
* 功 能： N/A
* 类 名： UserInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2018/10/17 20:31:20   N/A    初版
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
	/// 数据访问类:UserInfo
	/// </summary>
	public partial class UserInfo
	{
		public UserInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserId", "UserInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from UserInfo");
			strSql.Append(" where UserId=@UserId");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)
			};
			parameters[0].Value = UserId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool strExists(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from UserInfo");
            if (!string.IsNullOrEmpty(strWhere))
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Exists(strSql.ToString());
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Learning.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserInfo(");
			strSql.Append("WorkerID,UserName,Pwd,Status,SID,Name,Phone,QQ,Email,DepartId,Address,HeadImg,Money,Permission,idcard,iszonghe,inssj,udsj)");
			strSql.Append(" values (");
			strSql.Append("@WorkerID,@UserName,@Pwd,@Status,@SID,@Name,@Phone,@QQ,@Email,@DepartId,@Address,@HeadImg,@Money,@Permission,@idcard,@iszonghe,@inssj,@udsj)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkerID", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@Pwd", SqlDbType.VarChar,50),
					new SqlParameter("@Status", SqlDbType.TinyInt,1),
					new SqlParameter("@SID", SqlDbType.VarChar,1024),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@QQ", SqlDbType.VarChar,50),
					new SqlParameter("@Email", SqlDbType.VarChar,500),
					new SqlParameter("@DepartId", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@HeadImg", SqlDbType.NVarChar,500),
					new SqlParameter("@Money", SqlDbType.VarChar,50),
					new SqlParameter("@Permission", SqlDbType.Int,4),
					new SqlParameter("@idcard", SqlDbType.VarChar,50),
					new SqlParameter("@iszonghe", SqlDbType.TinyInt,1),
					new SqlParameter("@inssj", SqlDbType.DateTime),
					new SqlParameter("@udsj", SqlDbType.DateTime)};
			parameters[0].Value = model.WorkerID;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.Pwd;
			parameters[3].Value = model.Status;
			parameters[4].Value = model.SID;
			parameters[5].Value = model.Name;
			parameters[6].Value = model.Phone;
			parameters[7].Value = model.QQ;
			parameters[8].Value = model.Email;
			parameters[9].Value = model.DepartId;
			parameters[10].Value = model.Address;
			parameters[11].Value = model.HeadImg;
			parameters[12].Value = model.Money;
			parameters[13].Value = model.Permission;
			parameters[14].Value = model.idcard;
			parameters[15].Value = model.iszonghe;
			parameters[16].Value = model.inssj;
			parameters[17].Value = model.udsj;

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
		public bool Update(Learning.Model.UserInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserInfo set ");
			strSql.Append("WorkerID=@WorkerID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Pwd=@Pwd,");
			strSql.Append("Status=@Status,");
			strSql.Append("SID=@SID,");
			strSql.Append("Name=@Name,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("Email=@Email,");
			strSql.Append("DepartId=@DepartId,");
			strSql.Append("Address=@Address,");
			strSql.Append("HeadImg=@HeadImg,");
			strSql.Append("Money=@Money,");
			strSql.Append("Permission=@Permission,");
			strSql.Append("idcard=@idcard,");
			strSql.Append("iszonghe=@iszonghe,");
			strSql.Append("inssj=@inssj,");
			strSql.Append("udsj=@udsj");
			strSql.Append(" where UserId=@UserId");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkerID", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@Pwd", SqlDbType.VarChar,50),
					new SqlParameter("@Status", SqlDbType.TinyInt,1),
					new SqlParameter("@SID", SqlDbType.VarChar,1024),
					new SqlParameter("@Name", SqlDbType.VarChar,50),
					new SqlParameter("@Phone", SqlDbType.VarChar,50),
					new SqlParameter("@QQ", SqlDbType.VarChar,50),
					new SqlParameter("@Email", SqlDbType.VarChar,500),
					new SqlParameter("@DepartId", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,500),
					new SqlParameter("@HeadImg", SqlDbType.NVarChar,500),
					new SqlParameter("@Money", SqlDbType.VarChar,50),
					new SqlParameter("@Permission", SqlDbType.Int,4),
					new SqlParameter("@idcard", SqlDbType.VarChar,50),
					new SqlParameter("@iszonghe", SqlDbType.TinyInt,1),
					new SqlParameter("@inssj", SqlDbType.DateTime),
					new SqlParameter("@udsj", SqlDbType.DateTime),
					new SqlParameter("@UserId", SqlDbType.Int,4)};
			parameters[0].Value = model.WorkerID;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.Pwd;
			parameters[3].Value = model.Status;
			parameters[4].Value = model.SID;
			parameters[5].Value = model.Name;
			parameters[6].Value = model.Phone;
			parameters[7].Value = model.QQ;
			parameters[8].Value = model.Email;
			parameters[9].Value = model.DepartId;
			parameters[10].Value = model.Address;
			parameters[11].Value = model.HeadImg;
			parameters[12].Value = model.Money;
			parameters[13].Value = model.Permission;
			parameters[14].Value = model.idcard;
			parameters[15].Value = model.iszonghe;
			parameters[16].Value = model.inssj;
			parameters[17].Value = model.udsj;
			parameters[18].Value = model.UserId;

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
		public bool Delete(int UserId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where UserId=@UserId");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)
			};
			parameters[0].Value = UserId;

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
		public bool DeleteList(string UserIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserInfo ");
			strSql.Append(" where UserId in ("+UserIdlist + ")  ");
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
		public Learning.Model.UserInfo GetModel(int UserId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserId,WorkerID,UserName,Pwd,Status,SID,Name,Phone,QQ,Email,DepartId,Address,HeadImg,Money,Permission,idcard,iszonghe,inssj,udsj from UserInfo ");
			strSql.Append(" where UserId=@UserId");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)
			};
			parameters[0].Value = UserId;

			Learning.Model.UserInfo model=new Learning.Model.UserInfo();
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
		public Learning.Model.UserInfo DataRowToModel(DataRow row)
		{
			Learning.Model.UserInfo model=new Learning.Model.UserInfo();
			if (row != null)
			{
				if(row["UserId"]!=null && row["UserId"].ToString()!="")
				{
					model.UserId=int.Parse(row["UserId"].ToString());
				}
				if(row["WorkerID"]!=null)
				{
					model.WorkerID=row["WorkerID"].ToString();
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Pwd"]!=null)
				{
					model.Pwd=row["Pwd"].ToString();
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					model.Status=int.Parse(row["Status"].ToString());
				}
				if(row["SID"]!=null)
				{
					model.SID=row["SID"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["QQ"]!=null)
				{
					model.QQ=row["QQ"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["DepartId"]!=null)
				{
					model.DepartId=row["DepartId"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["HeadImg"]!=null)
				{
					model.HeadImg=row["HeadImg"].ToString();
				}
				if(row["Money"]!=null)
				{
					model.Money=row["Money"].ToString();
				}
				if(row["Permission"]!=null && row["Permission"].ToString()!="")
				{
					model.Permission=int.Parse(row["Permission"].ToString());
				}
				if(row["idcard"]!=null)
				{
					model.idcard=row["idcard"].ToString();
				}
				if(row["iszonghe"]!=null && row["iszonghe"].ToString()!="")
				{
					model.iszonghe=int.Parse(row["iszonghe"].ToString());
				}
				if(row["inssj"]!=null && row["inssj"].ToString()!="")
				{
					model.inssj=DateTime.Parse(row["inssj"].ToString());
				}
				if(row["udsj"]!=null && row["udsj"].ToString()!="")
				{
					model.udsj=DateTime.Parse(row["udsj"].ToString());
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
			strSql.Append("select UserId,WorkerID,UserName,Pwd,Status,SID,Name,Phone,QQ,Email,DepartId,Address,HeadImg,Money,Permission,idcard,iszonghe,inssj,udsj ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append(" UserId,WorkerID,UserName,Pwd,Status,SID,Name,Phone,QQ,Email,DepartId,Address,HeadImg,Money,Permission,idcard,iszonghe,inssj,udsj ");
			strSql.Append(" FROM UserInfo ");
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
			strSql.Append("select count(1) FROM UserInfo ");
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
				strSql.Append("order by T.UserId desc");
			}
			strSql.Append(")AS Row, T.*  from UserInfo T ");
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
			parameters[0].Value = "UserInfo";
			parameters[1].Value = "UserId";
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

