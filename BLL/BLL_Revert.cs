using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;
namespace BLL
{
    public class BLL_Revert
    {
        #region  成员方法
        DAL.DAL_Revert dal = new DAL.DAL_Revert();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.Revert model)
        {
            dal.Add(model);
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
        public Model.Revert GetModel(int ID)
        {
            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(int id)
        {
            return dal.GetList(id);
        }
        /// <summary>
        /// 获得数据
        /// </summary>
        public DataTable selectt(int id)
        {

            return dal.selectt(id);
        }
        /// <summary>
        /// 获得全部数据条数
        /// </summary>
        public DataTable Getli(int id)
        {

            return dal.Getli(id);
        }
        #endregion  成员方法
    }
}
