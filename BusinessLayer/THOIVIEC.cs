using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;

namespace BusinessLayer
{
    public class THOIVIEC
    {
        QLTIENLUONGEntities db = new QLTIENLUONGEntities();
        public tb_THOIVIEC getItem(string soqd)
        {
            return db.tb_THOIVIEC.FirstOrDefault(x=>x.SOQD == soqd);
        }
        public List<THOIVIEC_DTO> getItemFull(string soqd)
        {
            List<tb_THOIVIEC> lstTV = db.tb_THOIVIEC.Where(x=>x.SOQD == soqd).ToList();
            List<THOIVIEC_DTO> lstDTO = new List<THOIVIEC_DTO>();
            THOIVIEC_DTO tv;
            foreach (var item in lstTV)
            {
                tv = new THOIVIEC_DTO();
                tv.SOQD = item.SOQD;
                tv.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                tv.HOTEN = nv.HOTEN;
                tv.NGAYNOPDON = item.NGAYNOPDON;
                tv.NGAYNGHI = item.NGAYNGHI;
                tv.LYDO = item.LYDO;
                tv.GHICHU = item.GHICHU;
                tv.CREATED_BY = item.CREATED_BY;
                tv.CREATED_DATE = item.CREATED_DATE;
                tv.UPDATED_BY = item.UPDATED_BY;
                tv.UPDATED_DATE = item.UPDATED_DATE;
                tv.DELETED_BY = item.DELETED_BY;
                tv.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(tv);
            }
            return lstDTO;
        }
        public List<tb_THOIVIEC> getList()
        {
            return db.tb_THOIVIEC.ToList();
        }
        public List<THOIVIEC_DTO> getListFull()
        {
            var lstTV = db.tb_THOIVIEC.ToList();
            List<THOIVIEC_DTO> lstDTO = new List<THOIVIEC_DTO>();
            THOIVIEC_DTO nvDTO;
            foreach (var item in lstTV)
            {
                nvDTO = new THOIVIEC_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n => n.MANV == item.MANV);
                nvDTO.HOTEN = nv.HOTEN;             
                nvDTO.NGAYNOPDON = item.NGAYNOPDON;
                nvDTO.NGAYNGHI = item.NGAYNGHI;
                nvDTO.LYDO = item.LYDO;
                nvDTO.GHICHU = item.GHICHU;
                nvDTO.CREATED_BY = item.CREATED_BY;
                nvDTO.CREATED_DATE = item.CREATED_DATE;
                nvDTO.UPDATED_BY = item.UPDATED_BY;
                nvDTO.UPDATED_DATE = item.UPDATED_DATE;
                nvDTO.DELETED_BY = item.DELETED_BY;
                nvDTO.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nvDTO);
            }
            return lstDTO;
        }
        public tb_THOIVIEC Add(tb_THOIVIEC tv)
        {
            try
            {
                db.tb_THOIVIEC.Add(tv);
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_THOIVIEC Update(tb_THOIVIEC tv)
        {
            try
            {
                var _tv = db.tb_THOIVIEC.FirstOrDefault(x => x.SOQD == tv.SOQD);
                _tv.MANV = tv.MANV;
                _tv.NGAYNOPDON = tv.NGAYNOPDON;
                _tv.NGAYNGHI = tv.NGAYNGHI;
                _tv.LYDO = tv.LYDO;
                _tv.GHICHU = tv.GHICHU;
                _tv.UPDATED_BY = tv.UPDATED_BY;
                _tv.UPDATED_DATE = tv.UPDATED_DATE;
                db.SaveChanges();
                return tv;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soqd, int iduser)
        {
            try
            {
                var _tv = db.tb_THOIVIEC.FirstOrDefault(x => x.SOQD == soqd);
                _tv.DELETED_BY = iduser;
                _tv.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _tv = db.tb_THOIVIEC.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_tv != null)
            {
                return _tv.SOQD;
            }
            else
            {
                return "00000";
            }
        }
    }
}
