using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class BlogUser
    {
        public BlogUser()
        { }
        #region Model
        private int _id;
        private string _user;
        private string _pwd;
        private string _name;
        private string _img;
        private string _sex;
        private string _School;

        public string School
        {
            get { return _School; }
            set { _School = value; }
        }
        private DateTime _birthday;
        private string _fristaddress;
        private string _secondaddress;
        private string _email;
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
        public string Pwd
        {
            set { _pwd = value; }
            get { return _pwd; }
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
        public string Img
        {
            set { _img = value; }
            get { return _img; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime Birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Fristaddress
        {
            set { _fristaddress = value; }
            get { return _fristaddress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Secondaddress
        {
            set { _secondaddress = value; }
            get { return _secondaddress; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
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
