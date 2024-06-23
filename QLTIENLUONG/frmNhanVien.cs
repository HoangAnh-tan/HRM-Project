using BusinessLayer;
using BusinessLayer.DataObject;
using DataLayer;
using QLTIENLUONG.Reports;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace QLTIENLUONG
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private NHANVIEN _nhanvien;
        private DANTOC _dantoc;
        private TONGIAO _tongiao;
        private TRINHDO _trinhdo;
        private PHONGBAN _phongban;
        private BOPHAN _bophan;
        private CHUCVU _chucvu;
        private bool _them;
        private int _id;
        List<NHANVIEN_DTO> _lstNVDTO;

        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnThem.Enabled = kt;
            btnThoat.Enabled = kt;
            btnIn.Enabled = kt;
            txtTen.Enabled = !kt;
            dtNgaysinh.Enabled = !kt;
            chkGioitinh.Enabled = !kt;
            txtDienthoai.Enabled = !kt;
            txtCCCD.Enabled = !kt;
            txtDiachi.Enabled = !kt;
            //picHinhanh.Enabled = !kt;
            cboBophan.Enabled = !kt;
            cboPhongban.Enabled = !kt;
            cboChucvu.Enabled = !kt;
            cboTrinhdo.Enabled = !kt;
            cboDantoc.Enabled = !kt;
            cboTongiao.Enabled = !kt;
            btnHinhanh.Enabled = !kt;
        }
        void _reset()
        {
            txtTen.Text = string.Empty;
            chkGioitinh.Checked = false;
            txtDienthoai.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtDiachi.Text = string.Empty;
        }

        void loadData()
        {
            gcNhanvien.DataSource = _nhanvien.getListFull();
            gvNhanvien.OptionsBehavior.Editable = false;
            _lstNVDTO = _nhanvien.getListFull();
        }
        void loadCombo()
        {
            cboBophan.DataSource = _bophan.getList();
            cboBophan.DisplayMember = "TENBP";
            cboBophan.ValueMember = "IDBP";

            cboPhongban.DataSource = _phongban.getList();
            cboPhongban.DisplayMember = "TENPB";
            cboPhongban.ValueMember = "IDPB";

            cboChucvu.DataSource = _chucvu.getList();
            cboChucvu.DisplayMember = "TENCV";
            cboChucvu.ValueMember = "IDCV";

            cboTrinhdo.DataSource = _trinhdo.getList();
            cboTrinhdo.DisplayMember = "TENTD";
            cboTrinhdo.ValueMember = "IDTD";

            cboDantoc.DataSource = _dantoc.getList();
            cboDantoc.DisplayMember = "TENDT";
            cboDantoc.ValueMember = "IDDT";

            cboTongiao.DataSource = _tongiao.getList();
            cboTongiao.DisplayMember = "TENTG";
            cboTongiao.ValueMember = "IDTG";
        }
        void saveData()
        {
            if (_them)
            {
                tb_NHANVIEN nv = new tb_NHANVIEN();
                nv.HOTEN = txtTen.Text;
                nv.GIOITINH = chkGioitinh.Checked;
                nv.NGAYSINH = dtNgaysinh.Value;
                nv.DIENTHOAI = txtDienthoai.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiachi.Text;
                nv.HINHANH = ImageToBase64(picHinhanh.Image, picHinhanh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBophan.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongban.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucvu.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhdo.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDantoc.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTongiao.SelectedValue.ToString());
                nv.IDCT = 1;
                _nhanvien.Add(nv);
            }
            else
            {
                var nv = _nhanvien.getItem(_id);
                nv.HOTEN = txtTen.Text;
                nv.GIOITINH = chkGioitinh.Checked;
                nv.NGAYSINH = dtNgaysinh.Value;
                nv.DIENTHOAI = txtDienthoai.Text;
                nv.CCCD = txtCCCD.Text;
                nv.DIACHI = txtDiachi.Text;
                nv.HINHANH = ImageToBase64(picHinhanh.Image, picHinhanh.Image.RawFormat);
                nv.IDBP = int.Parse(cboBophan.SelectedValue.ToString());
                nv.IDPB = int.Parse(cboPhongban.SelectedValue.ToString());
                nv.IDCV = int.Parse(cboChucvu.SelectedValue.ToString());
                nv.IDTD = int.Parse(cboTrinhdo.SelectedValue.ToString());
                nv.IDDT = int.Parse(cboDantoc.SelectedValue.ToString());
                nv.IDTG = int.Parse(cboTongiao.SelectedValue.ToString());
                nv.IDCT = 1;
                _nhanvien.Update(nv);
            }
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtNgaysinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            _them = false;
            _nhanvien = new NHANVIEN();
            _dantoc = new DANTOC();
            _tongiao = new TONGIAO();
            _trinhdo = new TRINHDO();
            _phongban = new PHONGBAN();
            _bophan = new BOPHAN();
            _chucvu = new CHUCVU();
            _showHide(true);
            loadData();
            loadCombo();
            splitContainer1.Panel1Collapsed = true;
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
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _nhanvien.delete(_id);
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
            rptDanhSachNhanVien rpt = new rptDanhSachNhanVien(_lstNVDTO);
            rpt.ShowRibbonPreview();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvNhanvien_Click(object sender, EventArgs e)
        {
            if (gvNhanvien.RowCount > 0)
            {
                _id = int.Parse(gvNhanvien.GetFocusedRowCellValue("MANV").ToString());
                var nv = _nhanvien.getItem(_id);
                txtTen.Text = nv.HOTEN;          
                chkGioitinh.Checked = nv.GIOITINH.Value;
                dtNgaysinh.Value = nv.NGAYSINH.Value;
                txtDienthoai.Text = nv.DIENTHOAI;
                txtCCCD.Text = nv.CCCD;
                txtDiachi.Text = nv.DIACHI;
                picHinhanh.Image = Base64ToImage(nv.HINHANH);
                cboBophan.SelectedValue = nv.IDBP;
                cboPhongban.SelectedValue = nv.IDPB;
                cboChucvu.SelectedValue = nv.IDCV;
                cboTrinhdo.SelectedValue = nv.IDTD;
                cboDantoc.SelectedValue = nv.IDDT;
                cboTongiao.SelectedValue = nv.IDTG;
                //nv.IDCT = 1;
            }
        }
        public byte[] ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }    
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnChonanh_Click(object sender, EventArgs e)
        {

        }

        private void btnHinhanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Picture file (.png, .jpg)|*.png; *.jpg";
            openFile.Title = "Chọn hình ảnh";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picHinhanh.Image = Image.FromFile(openFile.FileName);
                picHinhanh.SizeMode = PictureBoxSizeMode.StretchImage;
            }    
        }
    }
}