
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
    public class LimitService
    {

        public LimitService() { }

        /// <summary>
        /// 根据参数查询权限信息
        /// </summary>
        /// <param name="info">权限信息对象</param>
        /// <returns>权限信息集合</returns>
        public List<LimitInfo> SelectWithParameter(LimitInfo info)
        {
            project data = new project();
            data.Type = "1";
            data.Search_type = "6";
            return getData(data);
        }

        /// <summary>
        /// 无参查询权限信息
        /// </summary>
        /// <returns>权限信息集合</returns>
        public List<LimitInfo> SelectNoParameter()
        {
            project data = new project();
            data.Type = "2";
            data.Search_type = "6";
            return getData(data);
        }

        /// <summary>
        /// 获取权限信息
        /// </summary>
        /// <param name="data">参数对象</param>
        /// <returns>权限信息集合</returns>
        private static List<LimitInfo> getData(project data)
        {
            String JSON = DBTool.Send(JsonConvert.SerializeObject(data));
            project project = DBTool.JSONStringToObject(JSON);
            List<LimitInfo> objs = JsonConvert.DeserializeObject<List<LimitInfo>>(project.Field);
            return objs;
        }

    }
}
