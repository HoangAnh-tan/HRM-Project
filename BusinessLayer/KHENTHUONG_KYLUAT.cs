using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;

namespace BusinessLayer
{
    public class KHENTHUONG_KYLUAT
    {
        QLTIENLUONGEntities db = new QLTIENLUONGEntities();
        public tb_KHENTHUONG_KYLUAT getItem (string SoQD)
        {
            return db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x=>x.SOQUYETDINH == SoQD);
        }
        public List<tb_KHENTHUONG_KYLUAT> getList(int loai)
        {
            return db.tb_KHENTHUONG_KYLUAT.Where(x => x.LOAI == loai).ToList();
        }
        public List<KHENTHUONG_KYLUAT_DTO> getListFull(int loai)
        {
            List<tb_KHENTHUONG_KYLUAT> lstKT = db.tb_KHENTHUONG_KYLUAT.Where(x=>x.LOAI == loai).ToList();
            List<KHENTHUONG_KYLUAT_DTO> lstDTO = new List<KHENTHUONG_KYLUAT_DTO>();
            KHENTHUONG_KYLUAT_DTO kt;
            foreach (var item in lstKT)
            {
                kt = new KHENTHUONG_KYLUAT_DTO();
                kt.SOQUYETDINH = item.SOQUYETDINH;
                kt.TUNGAY = item.TUNGAY;
                kt.DENNGAY = item.DENNGAY;
                kt.NOIDUNG = item.NOIDUNG;
                kt.LOAI = item.LOAI;
                kt.LYDO = item.LYDO;
                kt.NGAY = item.NGAY;
                kt.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                kt.HOTEN = nv.HOTEN;             
                kt.CREATED_BY = item.CREATED_BY;
                kt.CREATED_DATE = item.CREATED_DATE;
                kt.UPDATE_BY = item.UPDATE_BY;
                kt.UPDATE_DATE = item.UPDATE_DATE;
                kt.DELETED_BY = item.DELETED_BY;
                kt.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(kt);
            }
            return lstDTO;      
        }
        public tb_KHENTHUONG_KYLUAT Add(tb_KHENTHUONG_KYLUAT ktkl)
        {
            try
            {
                db.tb_KHENTHUONG_KYLUAT.Add(ktkl);
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_KHENTHUONG_KYLUAT Update(tb_KHENTHUONG_KYLUAT ktkl)
        {
            try
            {
                tb_KHENTHUONG_KYLUAT _ktkl = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == ktkl.SOQUYETDINH);
                _ktkl.LOAI = ktkl.LOAI;
                _ktkl.NGAY = ktkl.NGAY;
                _ktkl.TUNGAY = ktkl.TUNGAY;
                _ktkl.DENNGAY = ktkl.DENNGAY;
                _ktkl.LYDO = ktkl.LYDO;
                _ktkl.NOIDUNG = ktkl.NOIDUNG;
                _ktkl.MANV = ktkl.MANV;
                _ktkl.UPDATE_BY = ktkl.UPDATE_BY;
                _ktkl.UPDATE_DATE = ktkl.UPDATE_DATE;
                db.SaveChanges();
                return ktkl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soQD, int maNV)
        {
             try
             {
             tb_KHENTHUONG_KYLUAT _ktkl = db.tb_KHENTHUONG_KYLUAT.FirstOrDefault(x => x.SOQUYETDINH == soQD);
             _ktkl.DELETED_BY = maNV;
             _ktkl.DELETED_DATE = DateTime.Now;
             db.SaveChanges();
             }
             catch (Exception ex)
             {
                 throw new Exception("Lỗi: " + ex.Message);
             }
        }
        public string MaxSoQuyetDinh(int loai)
        {
            var _ktkl = db.tb_KHENTHUONG_KYLUAT.Where(x=>x.LOAI == loai).OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_ktkl != null)
            {
                return _ktkl.SOQUYETDINH;
            }
            else
            {
                return "00000";
            }
        }
    }
}
