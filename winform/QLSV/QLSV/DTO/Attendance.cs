using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    public class Attendance
    {
        private int id;
        private string card_id;
        private string student_name;       
        private string status_att;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;

        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }


        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }


        public string Status_att
        {
            get { return status_att; }
            set { status_att = value; }
        }


        public string Card_id
        {
            get { return card_id; }
            set { card_id = value; }
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
        public Attendance(int id, string card_id, string name, DateTime dateCheckIn, DateTime dateCheckOut)
        {
            this.ID = id;
            this.Card_id = card_id;
            this.Student_name = name;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
        }
        public Attendance(DataRow row)
        {
            this.ID = (int)row["student_id"];
            this.Card_id = row["card_id"].ToString();
            
            this.Student_name = row["student_name"].ToString();
            this.Status_att = row["attendance_status"].ToString();
            this.DateCheckIn = (DateTime?)row["DateCheckIn"]; 
            var dataCheckOutTemp = row["DateCheckOut"];
            if (dataCheckOutTemp.ToString() != "")
            {
                this.DateCheckOut = (DateTime?)dataCheckOutTemp;
            }

        }
    }
}
