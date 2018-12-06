using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
namespace DAL
{
    public class DAL_Picture
    {
        #region  成员方法
        Model.Picture model = new Model.Picture();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ImgName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Picture");
            strSql.Append(" where ImgName='" + ImgName + "' ");
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
        public void Add(Model.Picture model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Picture(");
            strSql.Append("TypeId,ImgName,ImgUrl,Imgsdescribe");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("" + model.TypeId + ",");
            strSql.Append("'" + model.ImgName + "',");
            strSql.Append("'" + model.ImgUrl + "',");
            strSql.Append("'" + model.Imgsdescribe + "'");
            strSql.Append(")");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.Picture model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Picture set ");
            strSql.Append("TypeId=" + model.TypeId + ",");
            strSql.Append("ImgName='" + model.ImgName + "',");
            strSql.Append("ImgUrl='" + model.ImgUrl + "'");
            strSql.Append("Imgsdescribe='" + model.ImgUrl + "'");
            strSql.Append(" where ID=" + model.ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Picture ");
            strSql.Append(" where ID=" + ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Picture GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   ");
            strSql.Append(" ID,TypeId,ImgName,ImgUrl,Imgsdescribe,date ");
            strSql.Append(" from Picture ");
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
        /// 通过类别获取数据列表
        /// </summary>
        public DataTable GetlestID(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select   ");
            strSql.Append(" ID,TypeId,ImgName,ImgUrl,Imgsdescribe,date ");
            strSql.Append(" from Picture ");
            strSql.Append(" where TypeId=" + ID + " ");
            return SQLHelper.ExecuteTable(strSql.ToString());
           
            
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.ID,a.TypeId,a.ImgName,a.ImgUrl,a.Imgsdescribe,a.date,b.TypeName ");
            strSql.Append(" FROM Picture a join PictureType b on a.TypeId = b.ID order by a.ID desc");
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
            db.AddInParameter(dbCommand, "tblName", DbType.AnsiString, "Picture");
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
        public Model.Picture ReaderBind(IDataReader dataReader)
        {
            object ojb;
            ojb = dataReader["ID"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.ID = (int)ojb;
            }
            ojb = dataReader["TypeId"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.TypeId = (int)ojb;
            }
            model.ImgName = dataReader["ImgName"].ToString();
            model.ImgUrl = dataReader["ImgUrl"].ToString();
            model.ImgUrl = dataReader["Imgsdescribe"].ToString(); 
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
