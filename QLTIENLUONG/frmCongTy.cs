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
    public partial class frmCongTy : DevExpress.XtraEditors.XtraForm
    {
        public frmCongTy()
        {
            InitializeComponent();
        }

        CONGTY _congty;
        bool _them;
        int _id;
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
            txtDienthoai.Enabled = !kt;
            txtEmail.Enabled = !kt;
            txtDiachi.Enabled = !kt;
        }

        void loadData()
        {
            gcCongty.DataSource = _congty.getList();
            gvCongty.OptionsBehavior.Editable = false;
        }
        void saveData()
        {
            if (_them)
            {
                tb_CONGTY ct = new tb_CONGTY();
                ct.TENCT = txtTen.Text;
                ct.DIENTHOAI = txtDienthoai.Text;
                ct.EMAIL = txtEmail.Text;
                ct.DIACHI = txtDiachi.Text;
                _congty.Add(ct);
            }
            else
            {
                var ct = _congty.getItem(_id);
                ct.TENCT = txtTen.Text;
                ct.DIENTHOAI = txtDienthoai.Text;
                ct.EMAIL = txtEmail.Text;
                ct.DIACHI = txtDiachi.Text;
                _congty.Update(ct);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _them = false;
            _congty = new CONGTY();
            _showHide(true);
            loadData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = true;
            _showHide(false);
            txtTen.Text = string.Empty;
            txtDienthoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiachi.Text = string.Empty;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(false);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _congty.delete(_id);
                loadData();
            }
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveData();
            loadData();
            _them = false;
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _them = false;
            _showHide(true);
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gvCongty_Click(object sender, EventArgs e)
        {
            if (gvCongty.RowCount > 0)
            {
                _id = int.Parse(gvCongty.GetFocusedRowCellValue("IDCT").ToString());
                txtTen.Text = gvCongty.GetFocusedRowCellValue("TENCT").ToString();
                txtDienthoai.Text = gvCongty.GetFocusedRowCellValue("DIENTHOAI").ToString();
                txtEmail.Text = gvCongty.GetFocusedRowCellValue("EMAIL").ToString();
                txtDiachi.Text = gvCongty.GetFocusedRowCellValue("DIACHI").ToString();
            }    
            
        }
    }
}