using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;
namespace DAL
{
   public class DAL_Type
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(int top)
        {
            string addsql = "top " + top;
            if (top <= 0)
            {
                addsql = "";
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select " + addsql + " ID,Type,date ");
            strSql.Append(" FROM [Type] ");
            return SQLHelper.ExecuteTable(strSql.ToString());
        }

        /// <summary>
        /// 要据类型获得新闻列表
        /// </summary>
        public DataTable GetListTypeNew(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM Article where TypeId = " + id);
            return SQLHelper.ExecuteTable(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string NewType)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Type");
            strSql.Append(" where Type='" + NewType + "'");
            int cmdresult;
            object obj = SQLHelper.ExecuteScalar(strSql.ToString());
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.BlogType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [Type](");
            strSql.Append("[Type]");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.Type + "'");
            strSql.Append(")");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.BlogType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [Type] set ");
            strSql.Append("[Type]='" + model.Type + "'");
            strSql.Append(" where ID=" + model.ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Type] ");
            strSql.Append(" where ID=" + ID);
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }
    }
}
