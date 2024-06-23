using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.DataObject;
using DataLayer;

namespace BusinessLayer
{
    public class DIEUCHUYEN
    {
        QLTIENLUONGEntities db = new QLTIENLUONGEntities();
        public tb_DIEUCHUYEN getItem(string soqd)
        {
            return db.tb_DIEUCHUYEN.FirstOrDefault(x=>x.SOQD == soqd);
        }
        public List<tb_DIEUCHUYEN> getList()
        {
            return db.tb_DIEUCHUYEN.ToList();
        }
        public List<DIEUCHUYEN_DTO> getListFull()
        {
            var lstDC = db.tb_DIEUCHUYEN.ToList();
            List<DIEUCHUYEN_DTO> lstDTO = new List<DIEUCHUYEN_DTO>();
            DIEUCHUYEN_DTO nvDTO;
            foreach (var item in lstDC )
            {
                nvDTO = new DIEUCHUYEN_DTO();
                nvDTO.SOQD = item.SOQD;
                nvDTO.MANV = item.MANV;
                var nv = db.tb_NHANVIEN.FirstOrDefault(n=>n.MANV == item.MANV);
                nvDTO.HOTEN = nv.HOTEN;
                nvDTO.IDPB1 = nv.IDPB;
                var pb = db.tb_PHONGBAN.FirstOrDefault(p => p.IDPB == item.IDPB1);
                nvDTO.TENPB1 = pb.TENPB;
                nvDTO.IDPB2 = item.IDPB2;
                var pb2 = db.tb_PHONGBAN.FirstOrDefault(p2 => p2.IDPB == item.IDPB2);
                nvDTO.TENPB2 = pb2.TENPB;
                nvDTO.NGAY = item.NGAY;
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
        public tb_DIEUCHUYEN Add(tb_DIEUCHUYEN dc)
        {
            try
            {
                db.tb_DIEUCHUYEN.Add(dc);
                db.SaveChanges();
                return dc;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_DIEUCHUYEN Update(tb_DIEUCHUYEN dc)
        {
            try
            {
                var _dc = db.tb_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == dc.SOQD);
                _dc.IDPB2 = dc.IDPB2;
                _dc.MANV = dc.MANV;
                _dc.NGAY = dc.NGAY;
                _dc.LYDO = dc.LYDO;
                _dc.GHICHU = dc.GHICHU;
                _dc.UPDATED_BY = dc.UPDATED_BY;
                _dc.UPDATED_DATE = dc.UPDATED_DATE;
                db.SaveChanges();
                return dc;
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
                var _dc = db.tb_DIEUCHUYEN.FirstOrDefault(x => x.SOQD == soqd);
                _dc.DELETED_BY = iduser;
                _dc.DELETED_DATE = DateTime.Now;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public string MaxSoQuyetDinh()
        {
            var _qd = db.tb_DIEUCHUYEN.OrderByDescending(x => x.CREATED_DATE).FirstOrDefault();
            if (_qd != null)
            {
                return _qd.SOQD;
            }  
            else
            {
                return "00000";
            }    
        }
    }
}
