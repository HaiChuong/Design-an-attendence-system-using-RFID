using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    public class AttendanceDAO
    {
        private static AttendanceDAO instance;

        public static AttendanceDAO Instance
        {
            get { if (instance == null) instance = new AttendanceDAO(); return AttendanceDAO.instance; }
            private set { AttendanceDAO.instance = value; }
        }

        private AttendanceDAO() { }

        public List<Attendance> UpdateAttendanceByIdCard(string idCard)
        {
            List<Attendance> listAttendance = new List<Attendance>();
            
            string query = "SELECT stu.student_id, rf.card_id, stu.student_name,att.attendance_status,att.DateCheckIn,att.DateCheckOut FROM dbo.Attendance as att,dbo.Students as stu,dbo.RFIDCards as rf where stu.student_id = att.student_id and rf.student_id = stu.student_id and rf.card_id = '" + idCard + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Attendance menu = new Attendance(item);
                listAttendance.Add(menu);
            }

            return listAttendance;
        }
        public void Update_CheckInOut(string idCard, string thuTrongTuan)
        {
           
            string query = "EXEC Update_CheckInOut @card_id = '" + idCard + "', @thuTrongTuan = N'"+ thuTrongTuan + "'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<Attendance> load_AttendanceTable()
        {
            List<Attendance> listAttendance = new List<Attendance>();
            string query = "SELECT stu.student_id, stu.card_id, stu.student_name,att.attendance_status,att.DateCheckIn,att.DateCheckOut FROM dbo.Attendance as att,dbo.Students as stu where stu.student_id = att.student_id  and CONVERT(DATE, att.DateCheckIn) = CONVERT(DATE, GETDATE()); ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Attendance menu = new Attendance(item);
                listAttendance.Add(menu);
            }

            return listAttendance;
        }

        public List<Attendance> GetListTest(string user_name, string pass)
        {
            List<Attendance> listMenu = new List<Attendance>();
            string query = "SELECT * FROM DBO.Account Where UserName = N'" + user_name + "' AND PassWord = N'" + pass + "' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Attendance menu = new Attendance(item);
                listMenu.Add(menu);
            }
            return listMenu;

        }
        public DataTable summary_Attendance(string start_time, string end_time)
        {
            start_time = string.Join("", start_time.Split('@', ',', '.', ';', '/'));
            end_time = string.Join("", end_time.Split('@', ',', '.', ';', '/'));
            DataTable data = DataProvider.Instance.ExecuteQuery("exec summary_Attendance @checkIn , @checkOut ", new object[] { start_time, end_time });
            return data;
        }
    }
}
