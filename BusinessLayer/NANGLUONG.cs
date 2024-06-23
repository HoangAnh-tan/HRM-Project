using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;

namespace BusinessLayer
{
    public class NANGLUONG
    {
        QLTIENLUONGEntities db = new QLTIENLUONGEntities();
        public tb_NANGLUONG getItem(string soqd)
        {
            return db.tb_NANGLUONG.FirstOrDefault(x => x.SOQD == soqd);
        }
        public List<tb_NANGLUONG> getList()
        {
            return db.tb_NANGLUONG.ToList();
        }
        public List<NANGLUONG_DTO> getListFull()
        {
            var lstNL = db.tb_NANGLUONG.ToList();
            List<NANGLUONG_DTO> lstDTO = new List<NANGLUONG_DTO>();
            NANGLUONG_DTO nlDTO;
            foreach(var item in lstNL)
            {
                nlDTO = new NANGLUONG_DTO();
                nlDTO.SOHD = item.SOHD;
                nlDTO.SOQD = item.SOQD;
                nlDTO.NGAYKY = item.NGAYKY;
                nlDTO.NGAYLENLUONG = item.NGAYLENLUONG;
                nlDTO.HESOLUONGHIENTAI = item.HESOLUONGHIENTAI;
                nlDTO.HESOLUONGMOI = item.HESOLUONGMOI;
                nlDTO.GHICHU = item.GHICHU;
                nlDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(x=>x.MANV == item.MANV);
                nlDTO.HOTEN = nv.HOTEN;
                nlDTO.CREATED_BY = item.CREATED_BY;
                nlDTO.CREATED_DATE = item.CREATED_DATE;
                nlDTO.UPDATED_BY = item.UPDATED_BY;
                nlDTO.UPDATED_DATE = item.UPDATED_DATE;
                nlDTO.DELETED_BY = item.DELETED_BY;
                nlDTO.DELETED_DATE = item.DELETED_DATE;
                lstDTO.Add(nlDTO);
            }
            return lstDTO;
        }
        public tb_NANGLUONG Add(tb_NANGLUONG nl)
        {
            try
            {
                db.tb_NANGLUONG.Add(nl);
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_NANGLUONG Update(tb_NANGLUONG nl)
        {
            try
            {
                var _nl = db.tb_NANGLUONG.FirstOrDefault(x => x.SOQD == nl.SOQD);
                _nl.SOHD = nl.SOHD;
                _nl.HESOLUONGHIENTAI = nl.HESOLUONGHIENTAI;
                _nl.HESOLUONGMOI = nl.HESOLUONGMOI;
                _nl.NGAYKY = nl.NGAYKY;
                _nl.NGAYLENLUONG = nl.NGAYLENLUONG;
                _nl.GHICHU = nl.GHICHU;
                _nl.MANV = nl.MANV;
                _nl.UPDATED_BY = nl.UPDATED_BY;
                _nl.UPDATED_DATE = nl.UPDATED_DATE;
                db.SaveChanges();
                return nl;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void Delete(string soqd, int uid)
        {
            try
            {
                var _nl = db.tb_NANGLUONG.FirstOrDefault(x => x.SOQD == soqd);
                _nl.DELETED_BY = uid;
                _nl.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _nl = db.tb_NANGLUONG.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_nl != null)
            {
                return _nl.SOQD;
            }
            else
            {
                return "00000";
            }
        }
    }
}
