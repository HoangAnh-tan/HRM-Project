using BusinessLayer;
using DataLayer;
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

namespace QLTIENLUONG
{
    public partial class frmDieuChuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmDieuChuyen()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        DIEUCHUYEN _dc;
        NHANVIEN _nhanvien;
        PHONGBAN _phongban;

        private void frmDieuChuyen_Load(object sender, EventArgs e)
        {
            _dc = new DIEUCHUYEN();
            _nhanvien = new NHANVIEN();
            _phongban = new PHONGBAN();
            _showHide(true);
            _them = false;
            loadData();
            loadNhanVien();
            loadDonViDen();
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
            gcDieuChuyen.Enabled = kt;
            txtSoQD.Enabled = !kt;
            dtNgay.Enabled = !kt;
            cboDonViDen.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtGhiChu.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
        }
        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            dtNgay.Value = DateTime.Now;
            //dtNgayKy.Value = DateTime.Now;
            //dtNgayBatDau.Value = DateTime.Now;          
        }
        void loadData()
        {
            gcDieuChuyen.DataSource = _dc.getListFull();
            gvDieuChuyen.OptionsBehavior.Editable = false;
        }
        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void loadDonViDen()
        {
            cboDonViDen.DataSource = _phongban.getList();
            cboDonViDen.ValueMember = "IDPB";
            cboDonViDen.DisplayMember = "TENPB";

        }
        void saveData()
        {
            tb_DIEUCHUYEN dc;
            if (_them)
            {
                var maxSoQD = _dc.MaxSoQuyetDinh();
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                dc = new tb_DIEUCHUYEN();
                dc.SOQD  = so.ToString("00000") + @"/" + DateTime.Now.Year.ToString() + @"/QĐĐC";
                dc.NGAY = dtNgay.Value;
                dc.LYDO = txtLyDo.Text;
                dc.GHICHU = txtGhiChu.Text;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.IDPB1 = _nhanvien.getItem(int.Parse(slkNhanVien.EditValue.ToString())).IDBP;
                dc.IDPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.CREATED_BY = 1;
                dc.CREATED_DATE = DateTime.Now;
                _dc.Add(dc);
            }
            else
            {
                dc = _dc.getItem(_soQD);
                dc.NGAY = dtNgay.Value;               
                dc.LYDO = txtLyDo.Text;
                dc.GHICHU = txtGhiChu.Text;
                dc.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                dc.IDPB2 = int.Parse(cboDonViDen.SelectedValue.ToString());
                dc.UPDATED_BY = 1;
                dc.UPDATED_DATE = DateTime.Now;
                _dc.Update(dc);
            }
            var nv = _nhanvien.getItem(dc.MANV.Value);
            nv.IDPB = dc.IDPB2;
            _nhanvien.Update(nv);
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
            gcDieuChuyen.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _dc.Delete(_soQD, 1);
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

        private void gvDieuChuyen_Click(object sender, EventArgs e)
        {
            if (gvDieuChuyen.RowCount > 0)
            {
                _soQD = gvDieuChuyen.GetFocusedRowCellValue("SOQD").ToString();
                var dc = _dc.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgay.Value = dc.NGAY.Value;              
                txtLyDo.Text = dc.LYDO;
                txtGhiChu.Text = dc.GHICHU;
                slkNhanVien.EditValue = dc.MANV;
                cboDonViDen.SelectedValue = dc.IDPB2;   
            }
        }

        private void gvDieuChuyen_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "DELETED_BY" && e.CellValue != null)
            {
                Image img = Properties.Resources.Famfamfam_Mini_Icon_alert_16;
                e.Graphics.DrawImage(img, e.Bounds.X, e.Bounds.Y);
                e.Handled = true;
            }     
        }

        private void gcDieuChuyen_Click(object sender, EventArgs e)
        {

        }
    }
}