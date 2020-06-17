using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENR_Model
{
    public class DepartmentInfo
    {
        private String id;          //自动编号
        private String name;        //名称
        private String leaderName;  //主管名称
        private String leader;      //主管编号
        private String createTime;  //创建时间
        private String isTrue;      //是否启用
        private String isAdmin;     //是否为行政部门

        public DepartmentInfo()
        {
            id = IDUtils.GetGuid16String();
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Leader { get => leader; set => leader = value; }
        public string CreateTime { get => createTime; set => createTime = value; }
        public string IsTrue { get => isTrue; set => isTrue = value; }
        public string LeaderName { get => leaderName; set => leaderName = value; }
        public string IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}
