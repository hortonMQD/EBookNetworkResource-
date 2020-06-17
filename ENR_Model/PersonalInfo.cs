using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENR_Model
{
    public class PersonalInfo
    {
        private String id;                  //自动编号
        private String pId;                 //用户名
        private String name;                //名称
        private String pwd;                 //密码
        private String oldPwd;              //未修改前密码
        private String department;          //所属部门编号
        private String departmentName;      //所属部门名称
        private String limit;               //权限编号
        private String limitName;           //权限名称
        private String telephone;           //联系电话
        private String createTime;          //创建时间
        private String isDimission;         //是否离职
        private String dimissionTime;       //离职时间

        public PersonalInfo()
        {
            id = IDUtils.GetGuid16String();
        }

        public string Id { get => id; set => id = value; }
        public string PId { get => pId; set => pId = value; }
        public string Name { get => name; set => name = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Department { get => department; set => department = value; }
        public string Limit { get => limit; set => limit = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string CreateTime { get => createTime; set => createTime = value; }
        public string IsDimission { get => isDimission; set => isDimission = value; }
        public string DimissionTime { get => dimissionTime; set => dimissionTime = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        public string LimitName { get => limitName; set => limitName = value; }
        public string OldPwd { get => oldPwd; set => oldPwd = value; }
    }
}
