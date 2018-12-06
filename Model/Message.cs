using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Message
    {
        public Message()
        { }
        #region Model
        private int _id;
        private string _user;
        private string _usermessage;
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
        public string User
        {
            set { _user = value; }
            get { return _user; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserMessage
        {
            set { _usermessage = value; }
            get { return _usermessage; }
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
