using System;
using System.Collections.Generic;
using System.Text;
using Model;
using System.Data;
namespace DAL
{
    public class DAL_PictureType
    {
        #region  成员方法
        Model.PictureType model = new Model.PictureType();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string TypeName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PictureType");
            strSql.Append(" where TypeName='" + TypeName + "'");
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
        public void Add(Model.PictureType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PictureType(");
            strSql.Append("TypeName");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.TypeName + "'");
            strSql.Append(")");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.PictureType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PictureType set ");
            strSql.Append("TypeName='" + model.TypeName + "'");
            strSql.Append(" where ID=" + model.ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PictureType ");
            strSql.Append(" where ID=" + ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.PictureType GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   ");
            strSql.Append(" ID,TypeName,date ");
            strSql.Append(" from PictureType ");
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
            strSql.Append("select ID,TypeName,date ");
            strSql.Append(" FROM PictureType order by ID desc ");
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
            db.AddInParameter(dbCommand, "tblName", DbType.AnsiString, "PictureType");
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
        public Model.PictureType ReaderBind(IDataReader dataReader)
        {
            object ojb;
            ojb = dataReader["ID"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.ID = (int)ojb;
            }
            model.TypeName = dataReader["TypeName"].ToString();
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
