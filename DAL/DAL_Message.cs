using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
namespace DAL
{
    public class DAL_Message
    {
        Model.Message model = new Model.Message();
        public DAL_Message()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(Model.Message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Message(");
			strSql.Append("[User],UserMessage");
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append("'"+model.User+"',");
			strSql.Append("'"+model.UserMessage+"'");
			strSql.Append(")");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Model.Message model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Message set ");
			strSql.Append("[User]='"+model.User+"',");
			strSql.Append("UserMessage='"+model.UserMessage+"'");
			strSql.Append(" where ID="+ model.ID+" ");
            SQLHelper.ExecuteNonQuery(strSql.ToString());
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Message ");
			strSql.Append(" where ID="+ID+" " );
            SQLHelper.ExecuteNonQuery(strSql.ToString());
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Message GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select   ");
			strSql.Append(" ID,[User],UserMessage,date ");
			strSql.Append(" from Message ");
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
		public DataTable GetList(int top)
		{
            string addsql = "top " + top;
            if (top <= 0)
            {
                addsql = "";
            }
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select "+addsql+" ID,[User],UserMessage,date ");
			strSql.Append(" FROM Message ");
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
			db.AddInParameter(dbCommand, "tblName", DbType.AnsiString, "Message");
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
		public Model.Message ReaderBind(IDataReader dataReader)
		{
			object ojb; 
			ojb = dataReader["ID"];
			if(ojb != null && ojb != DBNull.Value)
			{
				model.ID=(int)ojb;
			}
			model.User=dataReader["User"].ToString();
			model.UserMessage=dataReader["UserMessage"].ToString();
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
