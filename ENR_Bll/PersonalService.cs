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
    public class PersonalService
    {

        public PersonalService() { }

        /// <summary>
        /// 管理用户登录方法
        /// </summary>
        /// <param name="info">管理用户对象</param>
        /// <returns>若成功返回true</returns>
        public bool login(PersonalInfo info)
        {
            List<PersonalInfo> infos = new List<PersonalInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "1";
            data.Search_type = "2";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
            
        }
        /// <summary>
        /// 添加管理用户方法
        /// </summary>
        /// <param name="info">管理用户对象</param>
        /// <returns>若成功返回true</returns>
        public bool Add(PersonalInfo info)
        {
            List<PersonalInfo> infos = new List<PersonalInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "2";
            data.Search_type = "2";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }


        /// <summary>
        /// 根据参数查询管理用户信息
        /// </summary>
        /// <param name="info">管理用户信息对象</param>
        /// <returns>管理用户信息集合</returns>
        public List<PersonalInfo> SelectWithParameter(PersonalInfo info)
        {
            List<PersonalInfo> infos = new List<PersonalInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "3";
            data.Search_type = "2";
            return getData(data);
        }
        /// <summary>
        /// 无参查询管理用户信息
        /// </summary>
        /// <param name="info">管理用户信息对象</param>
        /// <returns>管理用户信息集合</returns>
        public List<PersonalInfo> SelectPersonalNoParameter()
        {
            project data = new project();
            data.Type = "4";
            data.Search_type = "2";
            return getData(data);
        }

        /// <summary>
        /// 修改管理用户信息
        /// </summary>
        /// <param name="info">管理用户对象</param>
        /// <returns>若成功返回true</returns>
        public bool Update(PersonalInfo info)
        {
            List<PersonalInfo> infos = new List<PersonalInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "5";
            data.Search_type = "2";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }
        /// <summary>
        /// 获取管理用户信息
        /// </summary>
        /// <param name="data">参数对象</param>
        /// <returns>管理用户信息集合</returns>
        private static List<PersonalInfo> getData(project data)
        {
            String JSON = DBTool.Send(JsonConvert.SerializeObject(data));
            project project = DBTool.JSONStringToObject(JSON);
            List<PersonalInfo> objs = JsonConvert.DeserializeObject<List<PersonalInfo>>(project.Field);
            return objs;
        }
    }
}
