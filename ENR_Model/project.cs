using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENR_Model
{
    public class project
    {
        private String type;            //增删查改、登录等操作类型
        private String search_type;    //搜索类型
        private String field;       //增删查改字符串
        private static long serialVersionUID = 4713717217654285562L;

        public string Type { get => type; set => type = value; }
        public String Search_type { get => search_type; set => search_type = value; }
        public string Field { get => field; set => field = value; }
    }
}
