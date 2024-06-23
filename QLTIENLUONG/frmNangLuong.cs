using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace QLTIENLUONG
{
    public partial class frmNangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmNangLuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        NANGLUONG _nl;
        HOPDONGLAODONG _hopdong;
        NHANVIEN _nv;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmNangLuong_Load(object sender, EventArgs e)
        {
            _nl = new NANGLUONG();
            _hopdong = new HOPDONGLAODONG();
            _nv = new NHANVIEN();
            _showHide(true);
            _them = false;
            loadData();
            loadHopDong ();
            splitContainer1.Panel1Collapsed = true;
        }
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnThem.Enabled = kt;
            btnThoat.Enabled = kt;
            btnIn.Enabled = kt;
            gcNangLuong.Enabled = kt;
            txtSoQD.Enabled = !kt;          
            dtNgayKy.Enabled = !kt;
            dtNgayNangLuong.Enabled = !kt;
            txtNhanVien.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            slkSoHD.Enabled = !kt;
        }
        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dtNgayKy.Value = DateTime.Now;
            dtNgayNangLuong.Value = dtNgayKy.Value.AddDays(5);
        }
        void loadData()
        {
            gcNangLuong.DataSource = _nl.getListFull();
            gvNangLuong.OptionsBehavior.Editable = false;
        }
        void loadHopDong()
        {
            slkSoHD.Properties.DataSource = _hopdong.getListFull();
            slkSoHD.Properties.ValueMember = "SOHD";
            slkSoHD.Properties.DisplayMember = "SOHD";
        }
        void saveData()
        {
            tb_NANGLUONG nl;
            if (_them)
            {
                var maxSoQD = _nl.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                nl = new tb_NANGLUONG();
                nl.SOQD = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐNL";
                nl.SOHD = slkSoHD.EditValue.ToString();    
                nl.NGAYKY = dtNgayKy.Value;
                nl.NGAYLENLUONG = dtNgayNangLuong.Value;
                nl.HESOLUONGHIENTAI = _hopdong.getItem(slkSoHD.EditValue.ToString()).HESOLUONG;
                nl.HESOLUONGMOI = double.Parse(spHeSoLuongMoi.EditValue.ToString());
                nl.GHICHU = txtGhiChu.Text;
                nl.MANV = (_hopdong.getItem(slkSoHD.EditValue.ToString()).MANV);
                nl.CREATED_BY = 1;
                nl.CREATED_DATE = DateTime.Now;
                _nl.Add(nl);
            }
            else
            {
                nl = _nl.getItem(_soQD);
                nl.SOHD = slkSoHD.EditValue.ToString();
                nl.NGAYKY = dtNgayKy.Value;
                nl.NGAYLENLUONG = dtNgayNangLuong.Value;
                nl.HESOLUONGHIENTAI = _hopdong.getItem(slkSoHD.EditValue.ToString()).HESOLUONG;
                nl.HESOLUONGMOI = double.Parse(spHeSoLuongMoi.EditValue.ToString());
                nl.GHICHU = txtGhiChu.Text;
                nl.MANV = (_hopdong.getItem(slkSoHD.EditValue.ToString()).MANV);
                nl.UPDATED_BY = 1;
                nl.UPDATED_DATE = DateTime.Now;
                _nl.Update(nl);
            }
            var hd = _hopdong.getItem(slkSoHD.EditValue.ToString());
            hd.HESOLUONG = double.Parse(spHeSoLuongMoi.EditValue.ToString());
            _hopdong.Update(hd);
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            _reset();
            splitContainer1.Panel1Collapsed = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
            splitContainer1.Panel1Collapsed = false;
            gcNangLuong.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nl.Delete(_soQD, 1);
                var hd = _hopdong.getItem(slkSoHD.EditValue.ToString());
                hd.HESOLUONG = double.Parse(spHeSoLuongHienTai.EditValue.ToString());
                _hopdong.Update(hd);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
            splitContainer1.Panel1Collapsed = true;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvNangLuong_Click(object sender, EventArgs e)
        {
            if (gvNangLuong.RowCount > 0)
            {
                _soQD = gvNangLuong.GetFocusedRowCellValue("SOQD").ToString();
                var nl = _nl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgayKy.Value = nl.NGAYKY.Value;
                dtNgayNangLuong.Value = nl.NGAYLENLUONG.Value;
                spHeSoLuongHienTai.EditValue = nl.HESOLUONGHIENTAI;
                spHeSoLuongMoi.EditValue = nl.HESOLUONGMOI;
                txtGhiChu.Text = nl.GHICHU;
                slkSoHD.EditValue = nl.SOHD;
                txtNhanVien.Text = gvNangLuong.GetFocusedRowCellValue("HOTEN").ToString();
            }
        }

        private void gvNangLuong_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.Famfamfam_Mini_Icon_alert_16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }
        }

        private void slkSoHD_EditValueChanged(object sender, EventArgs e)
        {
            var hd = _hopdong.getItemFull(slkSoHD.EditValue.ToString());
            if (hd.Count != 0)
            {
                txtNhanVien.Text = hd[0].MANV + " - " + hd[0].HOTEN;
                spHeSoLuongHienTai.EditValue = hd[0].HESOLUONG; 
            }    
        }
    }
}