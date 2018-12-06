using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL;
namespace BLL
{
    public class BLL_Article
    {
        DAL_Article dal_Article = new DAL_Article();


        #region  成员方法

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Subject)
        {
            return dal_Article.Exists(Subject);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.Article model)
        {
            dal_Article.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.Article model)
        {
            dal_Article.Update(model);
        }
        /// <summary>
        /// 访问次数
        /// </summary>
        public void addCount(Model.Article model)
        {
            dal_Article.addCount(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            dal_Article.Delete(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Article GetModel(int ID)
        {
            return dal_Article.GetModel(ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        public DataTable GetList(int top)
        {
            return dal_Article.GetList(top);
        }
        /// <summary>
        /// 获得数据
        /// </summary>
        public DataTable GetListRevert(int top)
        {
            return dal_Article.GetListRevert(top);
        }

        #endregion  成员方法
            
    }
}
