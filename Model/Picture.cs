using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Picture
    {
        public Picture()
        { }
        #region Model
        private int _id;
        private int _typeid;
        private string _imgname;
        private string _imgurl;
        private string _imgsdescribe;

        public string Imgsdescribe
        {
            get { return _imgsdescribe; }
            set { _imgsdescribe = value; }
        }
        private DateTime _date;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TypeId
        {
            set { _typeid = value; }
            get { return _typeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ImgName
        {
            set { _imgname = value; }
            get { return _imgname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ImgUrl
        {
            set { _imgurl = value; }
            get { return _imgurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime date
        {
            set { _date = value; }
            get { return _date; }
        }
        #endregion Model

    }
}
