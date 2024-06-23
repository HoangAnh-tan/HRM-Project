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
using BusinessLayer;
using DataLayer;

namespace QLTIENLUONG
{
    public partial class frmKhenThuong : DevExpress.XtraEditors.XtraForm
    {
        public frmKhenThuong()
        {
            InitializeComponent();
        }
        bool _them;
        string _soQD;
        KHENTHUONG_KYLUAT _ktkl;
        NHANVIEN _nhanvien;
        private void frmKhenThuong_Load(object sender, EventArgs e)
        {
            _ktkl = new KHENTHUONG_KYLUAT();
            _nhanvien = new NHANVIEN();
            _showHide(true);
            _them = false;
            loadData();
            loadNhanVien();
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
            gcKhenThuong.Enabled = kt;
            txtSoQD.Enabled = !kt;
            dtNgay.Enabled = !kt;
            //dtNgayBatDau.Enabled = !kt;
            //dtNgayKetThuc.Enabled = !kt;
            txtLyDo.Enabled = !kt;
            txtNoiDung.Enabled = !kt;
            slkNhanVien.Enabled = !kt;
        }
        void _reset()
        {
            txtSoQD.Text = string.Empty;
            txtLyDo.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            dtNgay.Value = DateTime.Now;
            //dtNgayKy.Value = DateTime.Now;
            //dtNgayBatDau.Value = DateTime.Now;          
        }
        void loadData()
        {
            gcKhenThuong.DataSource = _ktkl.getListFull(1);
            gvKhenThuong.OptionsBehavior.Editable = false;
        }
        void loadNhanVien()
        {
            slkNhanVien.Properties.DataSource = _nhanvien.getList();
            slkNhanVien.Properties.ValueMember = "MANV";
            slkNhanVien.Properties.DisplayMember = "HOTEN";
        }
        void saveData()
        {
            if (_them)
            {             
                var maxSoQD = _ktkl.MaxSoQuyetDinh(1);
                int so = int.Parse(maxSoQD.Substring(0, 5)) + 1;

                tb_KHENTHUONG_KYLUAT ktkl = new tb_KHENTHUONG_KYLUAT();             
                ktkl.SOQUYETDINH = so.ToString("00000") + @"/2024/QĐKT";
                ktkl.NGAY = dtNgay.Value;
                //ktkl.NGAYBATDAU = dtNgayBatDau.Value;
                //ktkl.NGAYKETTHUC = dtNgayKetThuc.Value;
                ktkl.LYDO = txtLyDo.Text;
                ktkl.NOIDUNG = txtNoiDung.Text;
                ktkl.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                ktkl.LOAI = 1;
                ktkl.CREATED_BY = 1;
                ktkl.CREATED_DATE = DateTime.Now;
                _ktkl.Add(ktkl);
            }
            else
            {
                var ktkl = _ktkl.getItem(_soQD);
                ktkl.NGAY = dtNgay.Value;
                //ktkl.NGAYBATDAU = dtNgayBatDau.Value;
                //ktkl.NGAYKETTHUC = dtNgayKetThuc.Value;
                ktkl.LYDO = txtLyDo.Text;
                ktkl.NOIDUNG = txtNoiDung.Text;
                ktkl.MANV = int.Parse(slkNhanVien.EditValue.ToString());
                ktkl.UPDATE_BY = 1;
                ktkl.UPDATE_DATE = DateTime.Now;
                _ktkl.Update(ktkl);
            }
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
            gcKhenThuong.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _ktkl.Delete(_soQD, 1);
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

        private void gvKhenThuong_Click(object sender, EventArgs e)
        {
            if (gvKhenThuong.RowCount > 0)
            {
                _soQD = gvKhenThuong.GetFocusedRowCellValue("SOQUYETDINH").ToString();
                var ktkl = _ktkl.getItem(_soQD);
                txtSoQD.Text = _soQD;
                dtNgay.Value = ktkl.NGAY.Value;
                //dtNgayBatDau.Value = ktkl.NGAYBATDAU.Value;
                //dtNgayKetThuc.Value = ktkl.NGAYKETTHUC.Value;
                txtLyDo.Text = ktkl.LYDO;

                txtNoiDung.Text = ktkl.NOIDUNG;
                slkNhanVien.EditValue = ktkl.MANV;
                //_lstHD = _hdld.getItemFull(_sohd);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}