using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
namespace DAL
{
    public class DAL_Article
    {
        Model.Article model = new Model.Article();
        public DAL_Article()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(string Subject)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Article");
            strSql.Append(" where Subject='" + Subject + "'");
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
        public void Add(Model.Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Article(");
            strSql.Append("Author,TypeId,Subject,Content,[Count]");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.Author + "',");
            strSql.Append("" + model.TypeId + ",");
            strSql.Append("'" + model.Subject + "',");
            strSql.Append("'" + model.Content + "',");
            strSql.Append("" + model.Count);
            strSql.Append(")");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public void Update(Model.Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Article set ");
            strSql.Append("Author='" + model.Author + "',");
            strSql.Append("TypeId=" + model.TypeId + ",");
            strSql.Append("Subject='" + model.Subject + "',");
            strSql.Append("Content='" + model.Content + "',");
            strSql.Append("[Count]=" + model.Count);
            strSql.Append(" where ID=" + model.ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }
        /// <summary>
        /// 访问次数
        /// </summary>
        public void addCount(Model.Article model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Article set ");
            strSql.Append("[Count]=[Count]+1 ");
            strSql.Append(" where ID=" + model.ID + " ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Article ");
            strSql.Append(" where ID=" + ID);
            SQLHelper.ExecuteNonQuery(strSql.ToString());
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public Model.Article GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            strSql.Append(" ID,Author,TypeId,Subject,Content,[Count],date ");
            strSql.Append(" from Article ");
            strSql.Append(" where ID=" + ID + " ");
            using (IDataReader dataReader = SQLHelper.ExecuteReader(strSql.ToString()))
            {
                if (dataReader.Read())
                {
                    model.ID = ID;
                    model.Author = dataReader["Author"].ToString();
                    model.TypeId = Convert.ToInt32(dataReader["TypeId"]);
                    model.Subject = dataReader["Subject"].ToString();
                    model.Content = dataReader["Content"].ToString();
                    model.Count = Convert.ToInt32(dataReader["Count"]);
                    model.date = Convert.ToDateTime(dataReader["Date"]);
                }
            }
            return model;
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList(int top)
        {
            StringBuilder strSql = new StringBuilder();
            string addsql = "top "+top;
            if (top <= 0)
            {
                addsql = "";
            }

            strSql.Append("select " + addsql + " a.ID,a.Author,a.TypeId,a.[Subject],a.[Content],a.[Count],a.date,b.Type ");
            strSql.Append(" FROM Article a join [type] b on a.TypeId = b.ID order by a.ID desc");
            return SQLHelper.ExecuteTable(strSql.ToString());
        }
        /// <summary>
        /// 获得数据
        /// </summary>
        public DataTable GetListRevert(int top)
        {
            StringBuilder strSql = new StringBuilder();
            string addsql = "top " + top;
            if (top <= 0)
            {
                addsql = "";
            }

            //strSql.Append("select " + addsql + " a.ID,a.Author,a.TypeId,a.[Subject],a.[Content],a.[Count],a.date,b.Type ");
            //strSql.Append(" FROM Article a join [type] b on a.TypeId = b.ID order by a.ID desc");
            //strSql.Append("select "+addsql+" * from Article as a join (select count(ArticleID)as b,ArticleID from myRevert group by ArticleID) as c on a.id=c.ArticleID order by ID desc");
            strSql.Append("select " + addsql + " a.*,c.*,d.Type from Article as a left join (select count(ArticleID)as b,ArticleID from myRevert group by ArticleID) as c on a.id=c.ArticleID  join [Type] as d on a.TypeId=d.ID order by a.ID desc");
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
            db.AddInParameter(dbCommand, "tblName", DbType.AnsiString, "Article");
            db.AddInParameter(dbCommand, "fldName", DbType.AnsiString, "System.Collections.Generic.List`1[LTP.CodeHelper.ColumnInfo]");
            db.AddInParameter(dbCommand, "PageSize", DbType.Int32, PageSize);
            db.AddInParameter(dbCommand, "PageIndex", DbType.Int32, PageIndex);
            db.AddInParameter(dbCommand, "IsReCount", DbType.Boolean, 0);
            db.AddInParameter(dbCommand, "OrderType", DbType.Boolean, 0);
            db.AddInParameter(dbCommand, "strWhere", DbType.AnsiString, strWhere);
            return db.ExecuteDataSet(dbCommand);
        }*/

		/// <summary>
		/// 获得数据列表（比DataSet效率高，推荐使用）
		/// </summary>
        //public List<Model.Article> GetListArray(string strWhere)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select ID,Author,TypeId,Subject,Content,Count,date ");
        //    strSql.Append(" FROM Article ");
        //    if(strWhere.Trim()!="")
        //    {
        //        strSql.Append(" where "+strWhere);
        //    }
        //    List<Model.Article> list = new List<Model.Article>();
        //    Database db = DatabaseFactory.CreateDatabase();
        //    using (IDataReader dataReader = db.ExecuteReader(CommandType.Text, strSql.ToString()))
        //    {
        //        while (dataReader.Read())
        //        {
        //            list.Add(ReaderBind(dataReader));
        //        }
        //    }
        //    return list;
        //}



        #endregion  成员方法

    }
        	
}
