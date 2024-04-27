using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSV.DTO;

namespace QLSV.DAO
{
    public class StudentDAO
    {
        private static StudentDAO instance;

        public static StudentDAO Instance
        {
            get { if (instance == null) instance = new StudentDAO(); return instance; }
            private set { instance = value; }
        }

        private StudentDAO() { }

        public List<Student> GetListStudentByRfidID(int id)
        {
            List<Student> listStudent = new List<Student>();
            string query = "SELECT *FROM dbo.Food where idCategory = N'" + id + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Student food = new Student(item);
                listStudent.Add(food);
            }

            return listStudent;
        }

        public int Count_student(string card_id)
        {
            string query = "SELECT COUNT(*) FROM dbo.Students WHERE card_id = '" + card_id+ "'";
            int count = 0;
            count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count;
        }
        public int CountStudentById(string ID)
        {
            string query = "SELECT COUNT(*) FROM dbo.Students WHERE ID = '" + ID + "'";
            int count = 0;
            count = (int)DataProvider.Instance.ExecuteScalar(query);
            return count;
        }
        public DataTable GetListStudent()
        {
            string query = "select  stu.student_id, stu.card_id, stu.student_name,stu.student_phone,stu.student_email from dbo.Students as stu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable SearchStudentByName(string name )
        {
            string query = "select  stu.student_id, stu.card_id, stu.student_name,stu.student_phone,stu.student_email from dbo.Students as stu where student_name like N'%" + name + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public void Insert_Student(Student std)
        {
            string query = "exec insert_table @card_id  , @student_name , @student_phone , @student_email ";
             DataProvider.Instance.ExecuteQuery(query, new object[] { std.Card_id, std.Student_name, std.Student_phone, std.Student_email });
            
        }
        public void  Delete_Student(string Card_Id)
        {
            string query = "exec Delete_Table @card_id ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { Card_Id });
        }
        public bool updateStudent(string Card_id,int student_id,string student_name,string student_phone, string student_email)
        {
            string query = "UPDATE Students SET student_name = N'" + student_name + "', student_email = '" + student_email + "' , student_phone = '" + student_phone + "' , card_id = '" + Card_id+ "'WHERE student_id = " + student_id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string getStudentNamebyCardId(string Card_id)
        {
            string str;
            string query = "SELECT student_name FROM dbo.Students WHERE card_id = N'"+ Card_id +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            str = data.Rows[0][0].ToString();
            return str;
        
        }

    }
}
