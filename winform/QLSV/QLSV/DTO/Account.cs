using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLSV.DTO
{
    public class Account
    {
        private string displayName;
        private string userName;
        private string passWord;
        private int type;

        public Account(string userName, string displayName,int type, string password = null )
        {
            this.DisplayName = displayName;
            this.UserName = userName;
            this.Type = type;
            this.PassWord = password;
        }

        public Account ( DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Type = (int) row["Type"];
            this.PassWord = row["PassWord"].ToString();
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }


        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }


        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

    }
}
