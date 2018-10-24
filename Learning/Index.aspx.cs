using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;

namespace Learning
{
    public partial class Index : System.Web.UI.Page
    {
        public static string uname;
        Learning.BLL.TreeNote Treenote_bll = new BLL.TreeNote();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Com.Session.UserName == null)
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
            else
            {
                uname = Com.Session.Name.ToString();
            }
        }






    }
}