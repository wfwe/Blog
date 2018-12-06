using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DAL;
using Model;
namespace BLL
{
    public class BLL_Picture
    {
        DAL_Picture dal = new DAL_Picture();
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ImgName)
        {
            return dal.Exists(ImgName);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.Picture model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.Picture model)
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
        public Model.Picture GetModel(int ID)
        {
            return dal.GetModel(ID);
        }
        /// <summary>
        /// 通过类别获取数据列表
        /// </summary>
        public DataTable GetlestID(int ID)
        {

            return dal.GetlestID(ID);


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
