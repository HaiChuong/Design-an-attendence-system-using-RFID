using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class Process
    {
        public static string[] TachChuoi(string chuoi)
        {
            if (chuoi.Length < 13)
            {
                throw new ArgumentException("Chuỗi quá ngắn để tách.");
            }
            
            string[] chuoiConArray = new string[5];
            chuoiConArray[0] = chuoi.Substring(0, 2);
            chuoiConArray[1] = chuoi.Substring(2, 1);
            chuoiConArray[2] = chuoi.Substring(3, 1);
            chuoiConArray[3] = chuoi.Substring(4, 8);
            chuoiConArray[4] = chuoi.Substring(12,2);
            return chuoiConArray;
        }
        public static string[] TachChuoiMe(string chuoiMe)
        {
            
            string[] chuoiConArray = chuoiMe.Split('-');

            
            if (chuoiConArray.Length < 4)
            {
                throw new ArgumentException("Chuỗi mẹ không đúng định dạng");
            }

            
            Array.Resize(ref chuoiConArray, 5);

            return chuoiConArray;
        }
    }
}
