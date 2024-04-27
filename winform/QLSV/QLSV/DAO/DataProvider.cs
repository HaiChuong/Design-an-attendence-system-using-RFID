using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLy.DAO
{
    public class DataProvider
    {
        private string s_con_sql = @"Data Source=DESKTOP-9L2848C;Initial Catalog=QLSV;Integrated Security=True"; 

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance;  }
            private set => instance = value;
        }

        private DataProvider() 
            {}

        public DataTable ExecuteQuery (string sql_query, object[] parameter = null ) 
        {
           
           

            
            DataTable data = new DataTable();
            using (SqlConnection con_sql = new SqlConnection(s_con_sql)) 
            {
                con_sql.Open();
                 SqlCommand command = new SqlCommand(sql_query, con_sql); 
                int i = 0;
                if (parameter != null )
                {
                    string[] listPara = sql_query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command); 
                adapter.Fill(data); 
                con_sql.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string sql_query, object[] parameter = null) 
        {

            
            int data = 0;
            using (SqlConnection con_sql = new SqlConnection(s_con_sql)) 
            {
                con_sql.Open();
                SqlCommand command = new SqlCommand(sql_query, con_sql); 
                
                if (parameter != null)
                {
                    string[] listPara = sql_query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = command.ExecuteNonQuery();
                con_sql.Close();
            }

            return data;
        }

        public object ExecuteScalar(string sql_query, object[] parameter = null) 
        {

            
            object data = 0;
            using (SqlConnection con_sql = new SqlConnection(s_con_sql)) 
            {
                con_sql.Open();
                SqlCommand command = new SqlCommand(sql_query, con_sql); 
                int i = 0;
                if (parameter != null)
                {
                    string[] listPara = sql_query.Split(' ');
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }

                    }
                }
                data = command.ExecuteScalar();
                con_sql.Close();
            }

            return data;
        }
    }
}
