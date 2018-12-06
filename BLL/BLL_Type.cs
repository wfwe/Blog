using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using Model;
using System.Data;
namespace BLL
{
    public class BLL_Type
    {
        DAL_Type dal_type = new DAL_Type();
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(int top)
        {
            return dal_type.GetList(top);
        }

        /// <summary>
        /// 要据类型获得新闻列表
        /// </summary>
        public DataTable GetListTypeNew(int id)
        {
            return dal_type.GetListTypeNew(id);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string NewType)
        {
            return dal_type.Exists(NewType);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.BlogType model)
        {
            dal_type.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.BlogType model)
        {
            dal_type.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            dal_type.Delete(ID);
        }
    }
}
