using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public partial class UserInfo
    {
        DAL.UserInfo user = new DAL.UserInfo();
        /*登录身份验证 成功返回true 失败返回false*/
        public bool Login(string userName, string userPassword)
        {
            return user.Login(userName, userPassword);
        }
        public bool AddUserInfoList(Model.UserInfo model)
        {
            return user.AddUserList(model);
        }
    }
}
