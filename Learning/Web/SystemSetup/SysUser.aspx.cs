using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning.Web.SystemSetup
{
    public partial class SysUser : System.Web.UI.Page
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {
            Com.DataPack.DataRsp<string> rsp = new Com.DataPack.DataRsp<string>();
            if (Com.Session.UserId == null)
            {
                rsp.code = "expire";
                rsp.msg = "页面已经过期，请重新登录";
            }
        }


        [WebMethod]
        public static Com.DataPack.DataRsp<string> page(string PageIndex, string PageSize, string uname, string ustat)
        {
            Com.DataPack.DataRsp<string> rsp = new Com.DataPack.DataRsp<string>();
            try
            {
                BLL.UserInfo user_bll = new BLL.UserInfo();
                Com.DataPack.PageModelResp pages = new Com.DataPack.PageModelResp();
                pages.PageIndex = int.Parse(PageIndex);
                pages.PageSize = int.Parse(PageSize);
                int rowc = 0; int pc = 0;
                string cols = "UserId,WorkerID,UserName,Status,Name,Phone,QQ,Email,DepartId,Address,HeadImg,inssj,udsj";
                DataTable userdt = user_bll.GetListCols(cols, "1=1", "UserId", "", pages.PageIndex, pages.PageSize, ref rowc, ref pc).Tables[0];
                pages.PageCount = pc;
                pages.RowCount = rowc;
                if (userdt.Rows.Count > 0)
                {
                    pages.list = userdt;
                }
                rsp.data = Newtonsoft.Json.JsonConvert.SerializeObject(pages).Replace("\n\r", ""); 
            }
            catch (Exception ex)
            { 
                throw;
            }
            return rsp;
        }
    }
}