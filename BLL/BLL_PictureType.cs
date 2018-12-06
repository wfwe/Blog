using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using System.Data;
using Model;
namespace BLL
{
    public class BLL_PictureType
    {
        #region  成员方法
        DAL.DAL_PictureType dal = new DAL.DAL_PictureType();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string TypeName)
        {
            return dal.Exists(TypeName);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.PictureType model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.PictureType model)
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
        public Model.PictureType GetModel(int ID)
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
