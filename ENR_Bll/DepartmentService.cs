
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
    public class DepartmentService
    {
        public DepartmentService() { }


        /// <summary>
        /// 添加部门信息
        /// </summary>
        /// <param name="info">部门对象</param>
        /// <returns>若成功返回true</returns>
        public bool AddDepartmentWithParameter(DepartmentInfo info)
        {
            List<DepartmentInfo> infos = new List<DepartmentInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "1";
            data.Search_type = "5";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }

        /// <summary>
        /// 修改部门信息
        /// </summary>
        /// <param name="info">部门对象</param>
        /// <returns>若成功返回true</returns>
        public bool UpdateDepartmentWithParameter(DepartmentInfo info)
        {
            List<DepartmentInfo> infos = new List<DepartmentInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "2";
            data.Search_type = "5";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }

        /// <summary>
        /// 根据参数查询部门信息
        /// </summary>
        /// <param name="info">部门信息对象</param>
        /// <returns>部门信息集合</returns>
        public List<DepartmentInfo> SelectDepartmentWithParameter(DepartmentInfo info)
        {
            List<DepartmentInfo> infos = new List<DepartmentInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "3";
            data.Search_type = "5";
            return getData(data);
        }

        /// <summary>
        /// 无参查询部门信息
        /// </summary>
        /// <returns>部门信息集合</returns>
        public List<DepartmentInfo> SelectDepartmentNoParameter()
        {
            project data = new project();
            data.Type = "4";
            data.Search_type = "5";
            return getData(data);
        }
        /// <summary>
        /// 获取部门信息
        /// </summary>
        /// <param name="data">参数对象</param>
        /// <returns>部门信息集合</returns>
        private static List<DepartmentInfo> getData(project data)
        {
            String JSON = DBTool.Send(JsonConvert.SerializeObject(data));
            project project = DBTool.JSONStringToObject(JSON);
            List<DepartmentInfo> objs = JsonConvert.DeserializeObject<List<DepartmentInfo>>(project.Field);
            return objs;
        }
    }
}
