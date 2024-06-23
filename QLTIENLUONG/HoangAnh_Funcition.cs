using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace QLTIENLUONG
{
    public class HoangAnh_Funcition
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
        public static string layThuTrongTuan(int nam, int thang, int ngay)
        {
            string thu = "";
            DateTime newDate = new DateTime(nam, thang, ngay);
            switch (newDate.DayOfWeek.ToString())
            {
                case "Monday":
                    thu = "Thứ hai";
                    break;
                case "Tuesday":
                    thu = "Thứ ba";
                    break;
                case "Wednesday":
                    thu = "Thứ tư";
                    break;
                case "Thursday":
                    thu = "Thứ năm";
                    break;
                case "Friday":
                    thu = "Thứ sáu";
                    break;
                case "Saturday":
                    thu = "Thứ bảy";
                    break;
                case "Sunday":
                    thu = "Chủ nhật";
                    break;
            }
            return thu;   
        }
        // Khai báo 1 biến SqlConnection
        static SqlConnection con = new SqlConnection();

        //Hàm tạo kêt nối
        public static void taoKetNoi()
        {
            con.ConnectionString = @"Data Source=DESKTOP-52E5OR5\SQLEXPRESS;Initial Catalog=QLTIENLUONG;Integrated Security=True";
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }
        // Hàm đóng kết nối
        public static void dongKetNoi()
        {
            con.Close();
        }
        // Hàm đổ dữ liệu vào Datable
        public static DataTable getData(string query)
        {
            taoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongKetNoi();
            return tb;
        }
        // Hàm lấy dữ liệu bằng Dataset
        public static DataSet getDataSet(string query)
        {
            taoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        //Hàm Insert/Update dữ liệu
        public static void execQuery(string qr)
        {
            taoKetNoi();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongKetNoi();
        }

    }
}
