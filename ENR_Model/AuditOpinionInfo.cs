using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENR_Model
{
    public class AuditOpinionInfo
    {
        private String id;      //自动编码
        private String isPass;  //是否审核通过
        private String opinion; //审核意见
        private String createTime;  //创建时间
        private String auditor;     //审核人（外键：管理用户自动编码）

        public AuditOpinionInfo()
        {
            id = IDUtils.GetGuid16String();
        }

        public string Id { get => id; set => id = value; }
        public string IsPass { get => isPass; set => isPass = value; }
        public string Opinion { get => opinion; set => opinion = value; }
        public string CreateTime { get => createTime; set => createTime = value; }
        public string Auditor { get => auditor; set => auditor = value; }
    }
}
