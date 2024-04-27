using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    public class Student
    {
   
        private int id;
        private string card_id;


        private string student_name;
        private string student_email;
        private string student_phone;

        public string Student_phone
        {
            get { return student_phone; }
            set { student_phone = value; }
        }

        public string Student_email
        {
            get { return student_email; }
            set { student_email = value; }
        }


        public string Student_name
        {
            get { return student_name; }
            set { student_name = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Card_id
        {
            get { return card_id; }
            set { card_id = value; }
        }
        public Student()
        { }

        public Student(string card_id, int id, string name, string student_email, string student_phone)
        {
            this.Card_id = card_id;
            this.ID = id;
            this.Student_name = name;
            this.Student_email = student_email;
            this.Student_phone = student_phone;
        }
        public Student(DataRow row)
        {
            this.Card_id = row["card_id"].ToString();
            this.ID = (int)row["student_id"];
            this.Student_name = row["student_name"].ToString();
            this.Student_email = row["student_email"].ToString();
            this.Student_phone = row["student_phone"].ToString();
        }
    }
}
