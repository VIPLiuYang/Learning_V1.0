using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Learning.Com
{
    public class Session
    {
        //系统编辑状态
        public static string appeditstat
        {
            get
            {
                string result = null;//  "liuyang"; //
                if (HttpContext.Current.Session["appeditstat"] != null && HttpContext.Current.Session["appeditstat"].ToString() != "")
                    result = HttpContext.Current.Session["appeditstat"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["appeditstat"] = value;
            }
        }
        //用户账号
        public static string UserName
        {
            get
            {
                string result = null;//  "liuyang"; //
                if (HttpContext.Current.Session["UserName"] != null && HttpContext.Current.Session["UserName"].ToString() != "")
                    result = HttpContext.Current.Session["UserName"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["UserName"] = value;
            }
        }
        //用户ID
        public static string UserId
        {
            get
            {
                string result = null;//  "liuyang"; //
                if (HttpContext.Current.Session["UserId"] != null && HttpContext.Current.Session["UserId"].ToString() != "")
                    result = HttpContext.Current.Session["UserId"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["UserId"] = value;
            }
        }
        //用户密码
        public static string Pwd
        {
            get
            {
                string result = null;//  "liuyang"; //
                if (HttpContext.Current.Session["Pwd"] != null && HttpContext.Current.Session["Pwd"].ToString() != "")
                    result = HttpContext.Current.Session["Pwd"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["Pwd"] = value;
            }
        }
        //用户属于项目
        public static string WorkerId
        {
            get
            {
                string result = null;//  "liuyang"; //
                if (HttpContext.Current.Session["WorkerId"] != null && HttpContext.Current.Session["WorkerId"].ToString() != "")
                    result = HttpContext.Current.Session["WorkerId"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["WorkerId"] = value;
            }
        }
        // 
        public static string Status
        {
            get
            {
                string result = null;//  "liuyang"; //
                if (HttpContext.Current.Session["Status"] != null && HttpContext.Current.Session["Status"].ToString() != "")
                    result = HttpContext.Current.Session["Status"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["Status"] = value;
            }
        }
        public static string Name
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["Name"] != null && HttpContext.Current.Session["Name"].ToString() != "")
                    result = HttpContext.Current.Session["Name"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["Name"] = value;
            }
        }
        public static string SID
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["SID"] != null && HttpContext.Current.Session["SID"].ToString() != "")
                    result = HttpContext.Current.Session["SID"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["SID"] = value;
            }
        }
        // 
        public static string Phone
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["Phone"] != null && HttpContext.Current.Session["Phone"].ToString() != "")
                    result = HttpContext.Current.Session["Phone"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["Phone"] = value;
            }
        }
        // 
        public static string QQ
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["QQ"] != null && HttpContext.Current.Session["QQ"].ToString() != "")
                    result = HttpContext.Current.Session["QQ"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["QQ"] = value;
            }
        }
        // 
        public static string Email
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["Email"] != null && HttpContext.Current.Session["Email"].ToString() != "")
                    result = HttpContext.Current.Session["Email"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["Email"] = value;
            }
        }
        // 
        public static string DepartId
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["DepartId"] != null && HttpContext.Current.Session["DepartId"].ToString() != "")
                    result = HttpContext.Current.Session["DepartId"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["DepartId"] = value;
            }
        }
        // 
        public static string Adddress
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["Adddress"] != null && HttpContext.Current.Session["Adddress"].ToString() != "")
                    result = HttpContext.Current.Session["Adddress"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["Adddress"] = value;
            }
        }

        // 
        public static string HeadImg
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["HeadImg"] != null && HttpContext.Current.Session["HeadImg"].ToString() != "")
                    result = HttpContext.Current.Session["HeadImg"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["HeadImg"] = value;
            }
        }
        // 
        public static string Permission
        {
            get
            {
                string result = null;
                if (HttpContext.Current.Session["Permission"] != null && HttpContext.Current.Session["Permission"].ToString() != "")
                    result = HttpContext.Current.Session["Permission"].ToString();
                return result;
            }
            set
            {
                HttpContext.Current.Session["Permission"] = value;
            }
        }
        
    }
}