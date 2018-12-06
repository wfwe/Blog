using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
namespace DAL
{
    public class DAL_User
    {
        #region  成员方法

        Model.BlogUser model = new Model.BlogUser();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string UserID, string UserPwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [User]");
            strSql.Append(" where [User]='" + UserID + "' and Pwd='" + UserPwd + "'");
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
        public void Add(Model.BlogUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into User(");
            strSql.Append("User,Pwd,Name,Img,sex,Birthday,Fristaddress,Secondaddress,Email");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.User + "',");
            strSql.Append("'" + model.Pwd + "',");
            strSql.Append("'" + model.Name + "',");
            strSql.Append("'" + model.Img + "',");
            strSql.Append("'" + model.sex + "',");
            strSql.Append("'" + model.Birthday + "',");
            strSql.Append("'" + model.Fristaddress + "',");
            strSql.Append("'" + model.Secondaddress + "',");
            strSql.Append("'" + model.Email + "'");
            strSql.Append(")");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.BlogUser model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [User] set ");
            strSql.Append("[Name]='" + model.Name + "',");

            strSql.Append("sex='" + model.sex + "',");
            strSql.Append("Birthday='" + model.Birthday + "',");
            strSql.Append("Fristaddress='" + model.Fristaddress + "',");
            strSql.Append("Secondaddress='" + model.Secondaddress + "',");
            strSql.Append("Email='" + model.Email + "'");
            strSql.Append(" where ID=" + model.ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from User ");
            strSql.Append(" where ID=" + ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.BlogUser GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   ");
            strSql.Append(" ID,User,Pwd,Name,Img,sex,Birthday,Fristaddress,Secondaddress,Email,date ");
            strSql.Append(" from User ");
            strSql.Append(" where ID=" + ID + " ");
            using (IDataReader dataReader = SQLHelper.ExecuteReader(strSql.ToString()))
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,[User],Pwd,Name,Img,sex,Birthday,Fristaddress,Secondaddress,School,Email,date ");
            strSql.Append(" FROM [User] ");
            return SQLHelper.ExecuteTable(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            Database db = DatabaseFactory.CreateDatabase();
            DbCommand dbCommand = db.GetStoredProcCommand("UP_GetRecordByPage");
            db.AddInParameter(dbCommand, "tblName", DbType.AnsiString, "User");
            db.AddInParameter(dbCommand, "fldName", DbType.AnsiString, "System.Collections.Generic.List`1[LTP.CodeHelper.ColumnInfo]");
            db.AddInParameter(dbCommand, "PageSize", DbType.Int32, PageSize);
            db.AddInParameter(dbCommand, "PageIndex", DbType.Int32, PageIndex);
            db.AddInParameter(dbCommand, "IsReCount", DbType.Boolean, 0);
            db.AddInParameter(dbCommand, "OrderType", DbType.Boolean, 0);
            db.AddInParameter(dbCommand, "strWhere", DbType.AnsiString, strWhere);
            return db.ExecuteDataSet(dbCommand);
        }*/



        /// <summary>
        /// 对象实体绑定数据
        /// </summary>
        public Model.BlogUser ReaderBind(IDataReader dataReader)
        {

            object ojb;
            ojb = dataReader["ID"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.ID = (int)ojb;
            }
            model.User = dataReader["User"].ToString();
            model.Pwd = dataReader["Pwd"].ToString();
            model.Name = dataReader["Name"].ToString();
            model.Img = dataReader["Img"].ToString();
            model.sex = dataReader["sex"].ToString();
            ojb = dataReader["Birthday"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.Birthday = (DateTime)ojb;
            }
            model.Fristaddress = dataReader["Fristaddress"].ToString();
            model.Secondaddress = dataReader["Secondaddress"].ToString();
            model.Email = dataReader["Email"].ToString();
            ojb = dataReader["date"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.date = (DateTime)ojb;
            }
            return model;
        }

        #endregion  成员方法
    }
}
