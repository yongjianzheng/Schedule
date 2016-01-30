using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public partial class Task
    {
        public DataTable GetTaskList(string strWhere)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *");
            strSql.Append("from [Task] ");
            if (strWhere.Trim() != "")
                strSql.Append(" where " + strWhere);
            return SqlDbHelper.ExecuteDataTable(strSql.ToString());

        }
        /*增加条目*/
        public bool AddTaskList(Model.Task model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Task] (Title,Detail,BeginTime,NotifyTime,Finished,Type,Priority) ");
            strSql.Append("values (@Title,@Detail,@BeginTime,@NotifyTime,@Finished,@Type,@Priority);");
            SqlParameter[] parameters ={ 
                                          
                                           new SqlParameter ("@Title", SqlDbType.VarChar , 50),
                                           new SqlParameter ("@Detail", SqlDbType.VarChar, 50), 
                                           new SqlParameter ("@BeginTime", SqlDbType.VarChar , 50),
                                           new SqlParameter ("@NotifyTime", SqlDbType.VarChar, 50), 
                                          
                                           new SqlParameter ("@Finished", SqlDbType.Int, 50), 
                                           new SqlParameter ("@Type", SqlDbType.VarChar,50),
                                           new SqlParameter ("@Priority", SqlDbType.VarChar, 50)
                                       };
          
            parameters[0].Value = model.Title;
            parameters[1].Value = model.Detail;
            parameters[2].Value = model.BeginTime;
            parameters[3].Value = model.NotifyTime;
          
            parameters[4].Value = model.Finished;
            parameters[5].Value = model.Type;
            parameters[6].Value = model.Priority;

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
        public bool UpdateTaskList(Model.Task model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Task set ");
            strSql.Append("Detail=@Detail,");
            strSql.Append("BeginTime=@BeginTime ");
            strSql.Append("where Title=@Title ");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@Detail",SqlDbType.VarChar,50),
                                           new SqlParameter ("@BeginTime",SqlDbType.VarChar,50),
                                           new SqlParameter ("@Title",SqlDbType.VarChar,50),
                                       };

            parameters[0].Value = model.Detail;
            parameters[1].Value = model.BeginTime;
            parameters[2].Value = model.Title;



            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
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


                  