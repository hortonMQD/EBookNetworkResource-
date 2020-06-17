
using ENR_Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ENR_Bll
{
    public class BookService
    {

        public BookService() { }

        /// <summary>
        /// 添加图书信息
        /// </summary>
        /// <param name="info">图书对象</param>
        /// <returns>若成功返回true</returns>
        public bool Add(BookInfo info)
        {
            List<BookInfo> infos = new List<BookInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "1";
            data.Search_type = "1";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }

        /// <summary>
        /// 对图书信息进行修改
        /// </summary>
        /// <param name="info">图书对象</param>
        /// <returns>若成功返回true</returns>
        public bool Updata(BookInfo info)
        {
            List<BookInfo> infos = new List<BookInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "2";
            data.Search_type = "1";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }

        /// <summary>
        /// 删除图书信息
        /// </summary>
        /// <param name="info">图书对象</param>
        /// <returns>若成功返回true</returns>
        public bool Delete(BookInfo info)
        {
            List<BookInfo> infos = new List<BookInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "3";
            data.Search_type = "1";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }

        /// <summary>
        /// 修改图书下载次数
        /// </summary>
        /// <param name="info">图书对象</param>
        /// <returns>若成功返回true</returns>
        public bool UpdataDownload(BookInfo info)
        {
            List<BookInfo> infos = new List<BookInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "4";
            data.Search_type = "1";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }

        /// <summary>
        /// 根据参数查询图书信息
        /// </summary>
        /// <param name="info">图书对象</param>
        /// <returns>图书信息集合</returns>
        public List<BookInfo> SelectBookWithParameter(BookInfo info)
        {
            List<BookInfo> infos = new List<BookInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "5";
            data.Search_type = "1";
            return getData(data);
        }

        /// <summary>
        /// 根据参数查询最新图书信息
        /// </summary>
        /// <param name="info">图书对象</param>
        /// <returns>图书信息集合</returns>
        public List<BookInfo> SelectNewBookWithParameter(BookInfo info)
        {
            List<BookInfo> infos = new List<BookInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "6";
            data.Search_type = "1";
            return getData(data);
        }
        /// <summary>
        /// 根据参数查询热门图书信息
        /// </summary>
        /// <param name="info">图书对象</param>
        /// <returns>图书信息集合</returns>
        public List<BookInfo> SelectFireBookWithParameter(BookInfo info)
        {
            List<BookInfo> infos = new List<BookInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "7";
            data.Search_type = "1";
            return getData(data);
        }
        /// <summary>
        /// 获取图书信息
        /// </summary>
        /// <param name="data">参数对象</param>
        /// <returns>图书信息集合</returns>
        private static List<BookInfo> getData(project data)
        {
            String JSON = DBTool.Send(JsonConvert.SerializeObject(data));

            project project = DBTool.JSONStringToObject(JSON);
            List<BookInfo> objs = JsonConvert.DeserializeObject<List<BookInfo>>(project.Field);
            return objs;
        }

    }
}
