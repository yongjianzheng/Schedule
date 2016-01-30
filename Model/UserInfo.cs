using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class UserInfo
    {
        private string _username;
        private string _password;
        
        //用户名
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        //密码
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
      
    }
}
