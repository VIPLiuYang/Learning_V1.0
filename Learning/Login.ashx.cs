using Learning.Common;
using Learning.Model;
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
    public class Login1 : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string action = context.Request["Action"];
            if (action == "null")
            {
                context.Response.Write(PublicProperty.PublicKey);
            }
            else if (action == "Login")//登录
            {
                string str = "";
                //解密 RSA
                RSACryptoService rsa = new RSACryptoService(PublicProperty.PrivateKey, PublicProperty.PublicKey);
                try
                {

                    string LgName = context.Request["UserName"];
                    string Pwd = context.Request["PassWord"];
                    string Code = context.Request["TxtCode"];
                    string txtcode = rsa.Decrypt(Code);
                    if (recode(txtcode, context))
                    {
                        string uname = Com.Public.SqlEncStr(rsa.Decrypt(LgName));
                        if (!string.IsNullOrEmpty(uname))
                        {
                            string pwd = Com.Public.SqlEncStr(rsa.Decrypt(Pwd));
                            Com.Session.Pwd = pwd;
                            string pwdmd5 = Com.Public.StrToMD5(pwd);
                            //查询所登录的用户名和密码是否一致。如果一致，则返回true；否则，返回false。 
                            Learning.BLL.UserInfo userbll = new BLL.UserInfo();
                            bool result = userbll.strExists("UserName='" + uname + "' and Pwd='" + pwdmd5 + "' and Status=1 and WorkerID='" + Com.Public.getKey("WorkerID") + "'");
                            if (result == true)
                            {
                                //用户登录处理
                                DataTable dt = userbll.GetList("UserName='" + uname + "' and Status=1 and WorkerID='" + Com.Public.getKey("WorkerID") + "' ").Tables[0];
                                Com.Session.UserId = dt.Rows[0]["UserId"].ToString();
                                Com.Session.UserName = dt.Rows[0]["UserName"].ToString();
                                Com.Session.WorkerId = dt.Rows[0]["WorkerId"].ToString();
                                Com.Session.Name = dt.Rows[0]["Name"].ToString();
                                Com.Session.DepartId = dt.Rows[0]["DepartId"].ToString();
                                str = "001";
                            }
                            else
                            {
                                str = "002";//账号或密码错误,或者被停用，请联系管理员
                            }
                        }
                        else
                        {
                            str = "003";//用户名不能为空
                        }
                    }
                    else
                    {
                        str = "004";//验证码错误
                    }
                }
                catch (Exception ex)
                {
                    str = ex.Message;
                }
                context.Response.Write(str);
            }
            else if (action == "out")//退出
            {
                /*PublicMethod.Clear();*/ 
                context.Session.Clear();
                context.Session.Abandon();
                context.Response.Clear();
                //清除cookies
                // Com.CookieHelper.ClearCookie("uname");
                context.Response.Write("out");
            }

        }
        protected bool recode(string txtcode, HttpContext context)
        {
            string text = txtcode;//获得用户输入的验证码
            string chkcode = context.Request.Cookies["validateCookie"].Values["ChkCode"].ToString();//获得系统生成的验证码
            bool bok = false;
            if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(chkcode))
            {
                if (!chkcode.Equals(chkcode.ToUpper()))//如果系统生成的不为大写则转换成大写形式
                    chkcode.ToUpper();
                if (text.ToUpper().Trim().Equals(chkcode.Trim())) //将输入的验证码转换成大写并与系统生成的比较
                    bok = true;
            }
            else if (string.IsNullOrEmpty(text))
            {

            }
            return bok;
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