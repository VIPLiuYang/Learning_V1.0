using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Learning
{
    public partial class Index : System.Web.UI.Page
    {
        Learning.BLL.TreeNote tree = new BLL.TreeNote();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region 根据人员信息加载可加载的功能树
        private List<int> GetTreeNotes()
        {
            DataTable dt = tree.GetTree("userName='" + Com.Session.UserName + "' AND treeNote.status='1' AND  WebId='110'").Tables[0];
            List<int> treeids = dt.AsEnumerable().Select(rx => rx.Field<int>("treeNodeId")).ToList();
            foreach (DataRow r in dt.Rows)
            {
                if (!treeids.Contains(Convert.ToInt32(r["fatherNoteId"])))
                    treeids.Add(Convert.ToInt32(r["fatherNoteId"]));
            }
            return treeids; 
        }
        #endregion
    }
}