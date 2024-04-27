
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QLSV.DAO
{
    public class AccountDAO
    {
        private  static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value;  }
        }




        private AccountDAO() { }
        public DataTable GetListAccount()
        {
            string query = "select UserName, DisplayName, Type  FROM Account";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool Login(string user_name,string pass)
        {
            string query = "SELECT * FROM DBO.Account Where UserName = N'"+ user_name +"' AND PassWord = N'"+ pass +"' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count >0;
        }
        public Account GetAccountByUserName ( string userName)
        {
            string query = "Select *from Account where UserName = N'"+userName+"' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public void UpdateAccount(string use_name,string displayName,string passWord)
        {
            string query = "UPDATE dbo.Account SET DisplayName = N'"+displayName+"', PassWord = '"+passWord+ "' WHERE USERNAME = '"+use_name+"'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool insertAccount(string userName, string displayName, int type)
        {
            string query = "INSERT INTO dbo.Account (UserName	,DisplayName,Type) VALUES (N'" + userName + "' ,N'" + displayName + "' ," + type + ")";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool deleteAccount(string userName)
        {

            int result;

            string query = "delete dbo.Account where userName = '" + userName + "'";
            result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;


        }
        public bool editAccount(string userName, string displayName, int type )
        {
            string query = "UPDATE Account SET DisplayName = N'" + displayName + "', type = " + type + " WHERE userName = N'" + userName + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool resetPassword(string userName)
        {
            string query = "UPDATE Account SET password = '0' WHERE userName = N'" + userName + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }   
}
