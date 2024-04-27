using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DAO
{
    public class ThoiKhoaBieuDAO
    {
        private static ThoiKhoaBieuDAO instance;

        public static ThoiKhoaBieuDAO Instance
        {
            get { if (instance == null) instance = new ThoiKhoaBieuDAO(); return instance; }
            private set { instance = value; }
        }




        private ThoiKhoaBieuDAO() { }
        public DataTable GetListSchedule()
        {
            string query = "select ThuTrongTuan, ThoiGianVaoHoc, ThoiGianTanHoc  FROM ThoiKhoaBieu";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool editSche(string thuTrongTuan, string thoiGianVaoHoc, string thoiGianTanHoc)
        {
            string query = "UPDATE ThoiKhoaBieu SET ThoiGianVaoHoc = N'" + thoiGianVaoHoc + "', ThoiGianTanHoc =  N'" + thoiGianTanHoc + "' WHERE ThuTrongTuan = N'" + thuTrongTuan + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public ThoiKhoaBieu GetThoiKhoaBieuByThu(string thuTrongTuan)
        {
            string query = "Select *from ThoiKhoaBieu where ThuTrongTuan = N'" + thuTrongTuan + "' ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new ThoiKhoaBieu(item);
            }
            return null;
        }
        
    }
}
