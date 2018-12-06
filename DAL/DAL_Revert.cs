using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL;
namespace DAL
{
    public class DAL_Revert
    {
        Model.Revert model = new Model.Revert();
        public DAL_Revert()
		{}
		#region  成员方法

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{ 
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) from myRevert");
			strSql.Append(" where ID="+ID+" ");
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
		public void Add(Model.Revert model)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into myRevert(");
            strSql.Append("Content,ArticleID,[user]");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+model.Content+"',");
            strSql.Append("" + model.ArticleID + ",");
            strSql.Append("'" + model.User+"'");
			strSql.Append(")");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
		}


		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();

            strSql.Append("delete from myRevert ");
			strSql.Append(" where ID="+ID+" " );
            SQLHelper.ExecuteNonQuery(strSql.ToString());
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Revert GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			strSql.Append(" ID,Content,user,ArticleID,date ");
            strSql.Append(" from myRevert ");
			strSql.Append(" where ID="+ID+" " );
            
			using (IDataReader dataReader = SQLHelper.ExecuteReader(strSql.ToString()))
			{
				if(dataReader.Read())
				{
					model=ReaderBind(dataReader);
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
            strSql.Append(" FROM myRevert where ArticleID=" + id + "order by ID desc");
            return SQLHelper.ExecuteTable(strSql.ToString());
		}
        /// <summary>
        /// 获得数据
        /// </summary>
        public DataTable selectt(int top)
        {
            StringBuilder strSql = new StringBuilder();
            string addsql = "top " + top;
            if (top <= 0)
            {
                addsql = "";
            }
            strSql.Append("select " + addsql + " * ");
            strSql.Append(" FROM myRevert order by ID desc");
            return SQLHelper.ExecuteTable(strSql.ToString());
        }
        /// <summary>
        /// 获得全部数据条数
        /// </summary>
        public DataTable Getli(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) ");
            strSql.Append("from myRevert");
            strSql.Append("where ArticleID="+id);
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
			db.AddInParameter(dbCommand, "tblName", DbType.AnsiString, "Revert");
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
		public Model.Revert ReaderBind(IDataReader dataReader)
		{
			object ojb; 
			ojb = dataReader["ID"];
			if(ojb != null && ojb != DBNull.Value)
			{
				model.ID=(int)ojb;
			}
			model.Content=dataReader["Content"].ToString();
            model.User = dataReader["user"].ToString();
			ojb = dataReader["ArticleID"];
			if(ojb != null && ojb != DBNull.Value)
			{
				model.ArticleID=(int)ojb;
			}
			ojb = dataReader["date"];
			if(ojb != null && ojb != DBNull.Value)
			{
				model.date=(DateTime)ojb;
			}
			return model;
		}

		#endregion  成员方法
    }
}
