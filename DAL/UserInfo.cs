using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public partial class UserInfo
    {

        public bool Login(string userName, string userPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from [UserInfo]");
            strSql.Append(" where username=@UserName and password=@UserPassword");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@UserName",SqlDbType.VarChar,50), 
                                           new SqlParameter ("@UserPassword",SqlDbType.VarChar ,50)
                                       };
            parameters[0].Value = userName;
            parameters[1].Value = userPassword;

            int n = Convert.ToInt32(SqlDbHelper.ExecuteScalar(strSql.ToString(), CommandType.Text, parameters));
            if (n == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /*增加条目*/
        public bool AddUserList(Model.UserInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [UserInfo] (username,password) ");
            strSql.Append("values (@UserName,@Password);");
            SqlParameter[] parameters ={ 
                                          
                                           new SqlParameter ("@UserName", SqlDbType.VarChar , 50),
                                           new SqlParameter ("@Password", SqlDbType.VarChar, 50), 
                                          
                                       };

            parameters[0].Value = model.UserName;
            parameters[1].Value = model.Password;
           

            int rows = Convert.ToInt32(
                SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters));
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

