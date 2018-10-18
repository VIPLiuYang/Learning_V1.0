using Learning.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Learning
{
    /// <summary>
    /// Login1 的摘要说明
    /// </summary>
    public class Login1 : IHttpHandler,IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string action = context.Request["action"];
            if (action=="login")
            {
                try
                {
                    string name = context.Request["name"];
                    string pwd = context.Request["pwd"];
                    DataTable dt = DbHelperSQL.Query(" select * from  userinfo where username='"+name+"'").Tables[0];
                    string json = "[]";
                    if (dt.Rows.Count>0)
                    {
                        Com.Session.UserId = dt.Rows[0]["UserId"].ToString();
                        Com.Session.UserName = dt.Rows[0]["UserName"].ToString() ;
                        Com.Session.Name = dt.Rows[0]["Nmae"].ToString();
                        Com.Session.DepartId = dt.Rows[0]["DepartId"].ToString();
                        Com.Session.Permission = dt.Rows[0]["Permission"].ToString();
                        Com.Session.SID = dt.Rows[0]["SID"].ToString();
                        Com.Session.HeadImg = dt.Rows[0]["HeadImg"].ToString();
                        json = "{\"total\":\"" + dt.Rows.Count + "\",\"rows\"'a'}";



                        context.Response.Write(json);
                    }



                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}