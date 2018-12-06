using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Href
    {
        public Href()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _url;
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
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Url
        {
            set { _url = value; }
            get { return _url; }
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
