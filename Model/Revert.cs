using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Revert
    {
        public Revert()
        { }
        #region Model
        private int _id;
        private string _content;
        private string _user;
        private int _articleid;
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
        public string Content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string User
        {
            set { _user= value; }
            get { return _user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ArticleID
        {
            set { _articleid = value; }
            get { return _articleid; }
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
