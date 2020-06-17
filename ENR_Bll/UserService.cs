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
    public class UserService
    {
        public UserService() { }


        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="info">用户对象</param>
        /// <returns>若成功返回true</returns>
        public bool login(UserInfo info)
        {
            List<UserInfo> infos = new List<UserInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "1";
            data.Search_type = "3";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }
        /// <summary>
        /// 添加用户信息
        /// </summary>
        /// <param name="info">用户对象</param>
        /// <returns>若成功返回true</returns>
        public bool Add(UserInfo info)
        {
            List<UserInfo> infos = new List<UserInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "2";
            data.Search_type = "3";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }

        /// <summary>
        /// 依据参数查询用户信息
        /// </summary>
        /// <param name="info">用户对象</param>
        /// <returns>用户信息集合</returns>
        public List<UserInfo> SelectWithParamter(UserInfo info)
        {
            List<UserInfo> infos = new List<UserInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "3";
            data.Search_type = "3";
            return getData(data);
        }

        public List<UserInfo> SelectNoParamter()
        {
            project data = new project();
            data.Type = "4";
            data.Search_type = "3";
            return getData(data);
        }

        /// <summary>
        /// 修改用户个人信息
        /// </summary>
        /// <param name="info">用户对象</param>
        /// <returns>若成功返回true</returns>
        public bool Update(UserInfo info)
        {
            List<UserInfo> infos = new List<UserInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "5";
            data.Search_type = "3";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }


        /// <summary>
        /// 修改用户密码
        /// </summary>
        /// <param name="info">用户对象</param>
        /// <returns>若成功返回true</returns>
        public bool UpdatePwd(UserInfo info)
        {
            List<UserInfo> infos = new List<UserInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "6";
            data.Search_type = "3";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="data">参数对象</param>
        /// <returns>用户信息集合</returns>
        private static List<UserInfo> getData(project data)
        {
            String JSON = DBTool.Send(JsonConvert.SerializeObject(data));
            project project = DBTool.JSONStringToObject(JSON);
            List<UserInfo> objs = JsonConvert.DeserializeObject<List<UserInfo>>(project.Field);
            return objs;
        }
    }
}
