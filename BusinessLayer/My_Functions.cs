using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class My_Functions
    {
        QLTIENLUONGEntities db = new QLTIENLUONGEntities();
        //Đếm số ngày trong tháng
        public static int DemSoNgayLamViecTrongThang(int thang, int nam)
        {
            int dem = 0;
            DateTime f = new DateTime(nam, thang, 01);
            int x = f.Month + 1;
            while (f.Month < x)
            {
                dem = dem + 1;
                if (f.DayOfWeek == DayOfWeek.Sunday)
                {
                    dem = dem - 1;
                }
                f = f.AddDays(1);
            }
            return dem;
        }
        //Lấy số ngày của tháng
        public static int LaySoNgayCuathang(int thang, int nam)
        {
            return DateTime.DaysInMonth(nam, thang);
        }      
    }
}
