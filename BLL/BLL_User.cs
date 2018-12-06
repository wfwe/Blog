using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;
using System.Data;
namespace BLL
{
    public class BLL_User
    {
        #region  成员方法

        DAL.DAL_User dal = new DAL_User();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string UserID, string UserPwd)
        {
            return dal.Exists(UserID, UserPwd);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.BlogUser model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.BlogUser model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            dal.Delete(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.BlogUser GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList()
        {
            return dal.GetList();
        }

       
        #endregion  成员方法
    }
}
