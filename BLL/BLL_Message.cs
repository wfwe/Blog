using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;

namespace BLL
{
    public class BLL_Message
    {
        DAL.DAL_Message dal = new DAL.DAL_Message();
        #region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.Message model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.Message model)
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
        public Model.Message GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(int top)
        {
            return dal.GetList(top);
        }


        #endregion  成员方法
    }
}
