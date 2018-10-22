using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning
{
    public partial class Nav : System.Web.UI.Page
    {
        public string treestr = "";
        public int dataid = 1;
        Learning.BLL.TreeNote Treenote_bll = new BLL.TreeNote();

        #region 初始化页面 
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (Com.Session.UserName == null)
            {
                Response.Redirect("Login.aspx");
                Response.End();
            }
            else
            { 
                DataTable menuDt = Treenote_bll.GetList("treeNodeId in (" + string.Join(",", GetTreeNotes()) + ") order by TOrder").Tables[0];
                DataRow[] drs = menuDt.Select("FatherNoteId=0");
                //父节点生成
                foreach (DataRow dr in drs)
                {
                    if (string.IsNullOrEmpty(dr["Url"].ToString()))
                    {
                        sb.Append("<li class=\"nav-li\">");
                        sb.Append("<a href=\"javascript:; \" class=\"ue-clear\"><i class=\"nav-ivon\"></i><span class=\"nav-text\">" + dr["NoteName"].ToString() + "</span></a>");
                        sb.Append("<ul class=\"subnav\">");
                        int menuId1 = int.Parse(dr["TreeNodeId"].ToString());
                        TreeViewChildAdd(menuId1, sb, menuDt);
                        sb.Append("</ul>");
                        sb.Append("</li>");
                    }
                } 
            }
            treestr = sb.ToString();
        }
        #endregion

        #region 功能树下级节点 
        public void TreeViewChildAdd(int menuId, StringBuilder sb, DataTable menuDt)
        {
            //得到该节点下的所有子节点
            DataRow[] drs = menuDt.Select("FatherNoteId=" + menuId.ToString()); 
            foreach (DataRow dr in drs)
            {
                //有下级节点的
                if (string.IsNullOrEmpty(dr["Url"].ToString()))
                {
                    sb.Append("<li class=\"subnav-li\" href=" + dr["Url"].ToString() + " data-id="+ dataid + ">");
                    sb.Append("<a href=\"javascript:; \" class=\"ue-clear\">");
                    sb.Append("<i class=\"subnav-icon\"></i>");
                    sb.Append("<span class=\"subnav-text\">" + dr["NoteName"].ToString() + "</span>");
                    sb.Append("</a>");
                    sb.Append("</li>");
                }
                else
                {
                    sb.Append("<li class=\"subnav-li\" href=" + dr["Url"].ToString() + " data-id=" + dataid + ">");
                    sb.Append("<a href=\"javascript:; \" class=\"ue-clear\">");
                    sb.Append("<i class=\"subnav-icon\"></i>");
                    sb.Append("<span class=\"subnav-text\">" + dr["NoteName"].ToString() + "</span>");
                    sb.Append("</a>");
                    sb.Append("</li>");
                }
                dataid++;
            }  
        }
        #endregion

        #region 根据人员信息加载可加载的功能树
        private List<int> GetTreeNotes()
        {
            DataTable dt = Treenote_bll.GetTree("userName='" + Com.Session.UserName + "' AND treeNote.status='1' AND  WebId='110'").Tables[0];
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