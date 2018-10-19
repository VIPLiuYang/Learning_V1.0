 
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Learning.Com
{
    public class Public
    {
        /// <summary>
        /// 数字转中文
        /// </summary>
        /// <param name="number">eg: 22</param>
        /// <returns></returns>
        public static string NumberToChinese(int number)
        {
            string res = string.Empty;
            string str = number.ToString();
            string schar = str.Substring(0, 1);
            switch (schar)
            {
                case "1":
                    res = "一";
                    break;
                case "2":
                    res = "二";
                    break;
                case "3":
                    res = "三";
                    break;
                case "4":
                    res = "四";
                    break;
                case "5":
                    res = "五";
                    break;
                case "6":
                    res = "六";
                    break;
                case "7":
                    res = "七";
                    break;
                case "8":
                    res = "八";
                    break;
                case "9":
                    res = "九";
                    break;
                default:
                    res = "零";
                    break;
            }
            if (str.Length > 1)
            {
                switch (str.Length)
                {
                    case 2:
                    case 6:
                        res += "十";
                        break;
                    case 3:
                    case 7:
                        res += "百";
                        break;
                    case 4:
                        res += "千";
                        break;
                    case 5:
                        res += "万";
                        break;
                    default:
                        res += "";
                        break;
                }
                res += NumberToChinese(int.Parse(str.Substring(1, str.Length - 1)));
            }
            return res;
        }
        public static bool PerClassExist(string schid,string percode)
        {
            bool bl = false;

            return bl;
        }
        public static bool IsNum(string str)
        {
            Regex reg = new Regex("^[0-9]+$");
            Match ma = reg.Match(str);
            return ma.Success;
        }
     
      
        /// <summary>
        /// DataRow转换为DataTable
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="strWhere">筛选的条件</param>
        /// <returns></returns>
        public static DataTable DataRowToDataTable(DataTable dt, string strWhere)
        {
            if (dt.Rows.Count <= 0) return dt;        //当数据为空时返回
            DataTable dtNew = dt.Clone();         //复制数据源的表结构
            DataRow[] dr = dt.Select(strWhere);  //strWhere条件筛选出需要的数据！
            for (int i = 0; i < dr.Length; i++)
            {
                dtNew.Rows.Add(dr[i].ItemArray);  // 将DataRow添加到DataTable中
            }
            return dtNew;
        }



 

 
       
        //分页获取包
        [Serializable]
        public class GradeInfo
        {
            public DataTable gradelist;
            public DataTable gradebosslist;
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
            public bool isadd { get; set; }
            public bool isedit { get; set; }
            public bool isdel { get; set; }
            public bool islook { get; set; }

            public DataTable list;
        }
      
      
       

        //SQL注入过滤
        public static string SqlEncStr(string inputString)
        {
            //要替换的敏感字
            string SqlStr = @"and|or|exec|execute|insert|select|delete|update|alter|create|drop|count|\*|chr|char|asc|mid|substring|master|truncate|declare|xp_cmdshell|restore|backup|net +user|net +localgroup +administrators";
            try
            {
                if ((inputString != null) && (inputString != String.Empty))
                {
                    string str_Regex = @"\b(" + SqlStr + @")\b";

                    Regex Regex = new Regex(str_Regex, RegexOptions.IgnoreCase);
                    //string s = Regex.Match(inputString).Value; 
                    MatchCollection matches = Regex.Matches(inputString);
                    for (int i = 0; i < matches.Count; i++)
                        inputString = inputString.Replace(matches[i].Value, "[" + matches[i].Value + "]");

                }
            }
            catch
            {
                return "";
            }
            return inputString;

        }
        public static string getKey(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString();
        }
        //写日志
        public static void WriteLog(string type, string className, string content)
        {
            string path = HttpContext.Current.Request.PhysicalApplicationPath + "logs";
            if (!Directory.Exists(path))//如果日志目录不存在就创建
            {
                Directory.CreateDirectory(path);
            }

            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");//获取当前系统时间
            string filename = path + "/" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";//用日期对日志文件命名

            //向日志文件写入内容
            string write_content = time + " " + type + " " + className + ": \r\n" + content;
            FileStream fs = null;
            try
            {
                //if (SourceAddress.ToString() == "60.28.196.5" || DestinationAddress.ToString() == "60.28.196.5")
                //{
                fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Write);
                //(Filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                byte[] filebyte = Encoding.Default.GetBytes(write_content + "\r\n_______________________________________\r\n\r\n");
                fs.Write(filebyte, 0, filebyte.Length);
                fs.Flush();
                //}
            }
            catch
            {

            }
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
        
        public static string StrToMD5(string str)
        {
            str = str + getKey("SecretKey");
            byte[] data = Encoding.UTF8.GetBytes(str);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] OutBytes = md5.ComputeHash(data);
            string OutString = "";
            for (int i = 0; i < OutBytes.Length; i++)
            {
                OutString += OutBytes[i].ToString("x2");
            }
            // return OutString.ToUpper();
            return OutString.ToLower();
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Encrypt(string Text)
        {
            return Encrypt(Text, getKey("SecretKey"));
        }
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Encrypt(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray;
            inputByteArray = Encoding.UTF8.GetBytes(Text);
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            return ret.ToString();
        }


        #region ========解密========


        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Decrypt(string Text)
        {
            return Decrypt(Text, getKey("SecretKey"));
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Decrypt(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = Text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.UTF8.GetString(ms.ToArray());
        }

        #endregion
        
    }
}