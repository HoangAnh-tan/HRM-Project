using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BANGLUONG
    {
        QLTIENLUONGEntities db = new QLTIENLUONGEntities();
        public tb_BANGLUONG getItem(int makycong, int manv)
        {
            return db.tb_BANGLUONG.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == manv);
        }
        public List<tb_BANGLUONG> getList(int makycong)
        {
            return db.tb_BANGLUONG.Where(x=>x.MAKYCONG == makycong).ToList();
        }
        public void TinhLuongNhanVien(int makycong)
        {
            double luongngaythuong, luongphep, luongtangca, luongchunhat, luongngayle, phucap, ungluong, thuclanh, hesoluong;
            var lstNV = db.tb_NHANVIEN.Where(x=>x.DATHOIVIEC == null).ToList();
            foreach (var item in lstNV)
            {
                var hd = db.tb_HOPDONG.FirstOrDefault(x=>x.MANV == item.MANV && x.DELETED_BY == null);
                if (hd!=null)
                {
                    var kcct = db.tb_KYCONGCHITIET.FirstOrDefault(x => x.MAKYCONG == makycong && x.MANV == item.MANV);
                    var nangluong = db.tb_NANGLUONG.OrderByDescending(x => x.NGAYKY).FirstOrDefault(x => x.SOHD == hd.SOHD && x.MANV == item.MANV && x.DELETED_BY == null);
                    if (nangluong != null)
                        hesoluong = Convert.ToDouble(nangluong.HESOLUONGMOI);
                    else
                        hesoluong = Convert.ToDouble(hd.HESOLUONG);
                    var luong1ngaycong = hd.LUONGCOBAN * hesoluong / kcct.NGAYCONG;
                    // Tính lương ngày thường
                    luongngaythuong = Convert.ToDouble(kcct.TONGNGAYCONG * luong1ngaycong);
                    // Tính lương ngày phép
                    luongphep = Convert.ToDouble(kcct.NGAYPHEP * luong1ngaycong * 0.3);
                    // Tính lương chủ nhật
                    luongchunhat = Convert.ToDouble(kcct.CONGCHUNHAT * luong1ngaycong * 2);
                    // Tính lương ngày lễ
                    luongngayle = Convert.ToDouble(kcct.CONGNGAYLE * luong1ngaycong * 3);
                    // Tính lương tăng ca
                    luongtangca = Convert.ToDouble(db.tb_TANGCA.Where(x => x.NAM * 100 + x.THANG == makycong && x.MANV == item.MANV).Sum(x => x.SOTIEN));
                    // Tính tiền phụ cấp
                    phucap = Convert.ToDouble(db.tb_NHANVIEN_PHUCAP.Where(x => x.MANV == item.MANV).Sum(x => x.SOTIEN));
                    // Tính ứng lương
                    ungluong = Convert.ToDouble(db.tb_UNGLUONG.Where(x => x.NAM * 100 + x.THANG == makycong && x.MANV == item.MANV).Sum(x => x.SOTIEN));
                    // Tính thực lãnh
                    thuclanh = luongngaythuong + luongphep + luongngayle + luongchunhat + luongtangca + phucap - ungluong;

                    tb_BANGLUONG bl = new tb_BANGLUONG();
                    bl.MAKYCONG = makycong;
                    bl.MANV = item.MANV;
                    bl.HOTEN = item.HOTEN;
                    bl.NGAYCONGTRONGTHANG = int.Parse(kcct.NGAYCONG.ToString());
                    bl.NGAYPHEP = luongphep;
                    bl.NGAYLE = luongngayle;
                    bl.NGAYCHUNHAT = luongchunhat;
                    bl.NGAYTHUONG = luongngaythuong;
                    bl.PHUCAP = phucap;
                    bl.TANGCA = luongtangca;
                    bl.UNGLUONG = ungluong;
                    bl.THUCLANH = thuclanh;
                    bl.CREATED_BY = 1;
                    bl.CREATED_DATE = DateTime.Now;
                    Add(bl);
                }               
            }
        }
        public tb_BANGLUONG Add(tb_BANGLUONG bl)
        {
            try
            {
                db.tb_BANGLUONG.Add(bl);
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_BANGLUONG Update(tb_BANGLUONG bl)
        {
            try
            {
                tb_BANGLUONG _bl = db.tb_BANGLUONG.FirstOrDefault(x => x.MAKYCONG == bl.MAKYCONG && x.MANV == bl.MANV);
                _bl.MANV = bl.MANV;
                _bl.MAKYCONG = bl.MAKYCONG;
                _bl.HOTEN = bl.HOTEN;
                _bl.NGAYPHEP = bl.NGAYPHEP;
                _bl.KHONGPHEP = bl.KHONGPHEP;
                _bl.NGAYCONGTRONGTHANG = bl.NGAYCONGTRONGTHANG;
                _bl.NGAYCHUNHAT = bl.NGAYCHUNHAT;
                _bl.NGAYLE = bl.NGAYLE;
                _bl.NGAYTHUONG = bl.NGAYTHUONG;
                _bl.TANGCA = bl.TANGCA;
                _bl.PHUCAP = bl.PHUCAP;
                _bl.UNGLUONG = bl.UNGLUONG;
                _bl.THUCLANH = bl.THUCLANH;
                _bl.UPDATED_BY = bl.UPDATED_BY;
                _bl.UPDATED_DATE = bl.UPDATED_DATE;
                db.SaveChanges();
                return bl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void delete(int makycong)
        {

            try
            {
                var _bl = db.tb_BANGLUONG.FirstOrDefault(x => x.MAKYCONG == makycong);
                db.tb_BANGLUONG.Remove(_bl);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
