using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENR_Model
{
    public class UserInfo
    {
        private String id;          //编号
        private String uName;       //用户名
        private String email;       //邮箱
        private String pwd;         //密码

        public UserInfo()
        {
            id = IDUtils.GetGuid16String();
        }

        public string Id { get => id; set => id = value; }
        public string UName { get => uName; set => uName = value; }
        public string Email { get => email; set => email = value; }
        public string Pwd { get => pwd; set => pwd = value; }
    }
}
