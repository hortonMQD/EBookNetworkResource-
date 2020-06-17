using ENR_Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ENR_Bll
{
    public class AuditService
    {
        public AuditService() {  }

        /// <summary>
        /// 提交审核意见
        /// </summary>
        /// <param name="info">审核意见对象</param>
        /// <returns>若成功返回true，反之返回false</returns>
        public bool Update(AuditOpinionInfo info)
        {
            List<AuditOpinionInfo> infos = new List<AuditOpinionInfo>();
            infos.Add(info);
            project data = new project();
            data.Field = JsonConvert.SerializeObject(infos);
            data.Type = "1";
            data.Search_type = "4";

            String JSON = JsonConvert.SerializeObject(data);
            data = DBTool.JSONStringToObject(DBTool.Send(JSON));
            return DBTool.isTrue(data.Field);
        }

        
    }
}
