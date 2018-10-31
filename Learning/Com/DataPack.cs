using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Learning.Com
{
    public class DataPack
    {
        /// <summary>
        /// Resp包
        /// </summary>
        [Serializable]
        public class DataRsp<T>
        {
            /// <summary>
            /// 返回状态码
            /// </summary>
            public string code = "0000";//返回代码
            /// <summary>
            /// 返回说明
            /// </summary>
            public string msg = "正常";//返回代码提示
            /// <summary>
            /// 返回数据包
            /// </summary>
            public T data;//数据包
        }

        //分页获取包
        [Serializable]
        public class PageModelResp
        {
            /// <summary>
            /// 分页索引页-第几页
            /// </summary>
            public int PageIndex { get; set; }
            /// <summary>
            /// 总记录数
            /// </summary>
            public int RowCount { get; set; }
            /// <summary>
            /// 总页数
            /// </summary>
            public int PageCount { get; set; }
            /// <summary>
            /// 分页大小-以多少条分页
            /// </summary>
            public int PageSize { get; set; }
            public DataTable list;
        }
    }
}