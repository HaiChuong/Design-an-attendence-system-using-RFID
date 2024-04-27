using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.DTO
{
    public class ThoiKhoaBieu
    {
        private int iD;
        private string thuTrongTuan;
        private TimeSpan thoiGianVaoHoc;
        private TimeSpan thoiGianTanHoc;

        public TimeSpan ThoiGianTanHoc

        {
            get { return thoiGianTanHoc; }
            set { thoiGianTanHoc = value; }
        }



        public string ThuTrongTuan
        {
            get { return thuTrongTuan; }
            set { thuTrongTuan = value; }
        }

        

        public TimeSpan ThoiGianVaoHoc
        {
            get { return thoiGianVaoHoc; }
            set { thoiGianVaoHoc = value; }
        }


        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public ThoiKhoaBieu(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.ThoiGianVaoHoc =TimeSpan.Parse( row["ThoiGianVaoHoc"].ToString());
            this.ThoiGianTanHoc = TimeSpan.Parse(row["ThoiGianTanHoc"].ToString());
         
        }
        public ThoiKhoaBieu(int iD, TimeSpan thoiGianVaoHoc, TimeSpan thoiGianTanHoc)
        {
            this.ID = iD;
            this.ThoiGianVaoHoc = thoiGianTanHoc;
            this.ThoiGianTanHoc = thoiGianTanHoc;
        }

    }
}
