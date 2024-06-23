﻿using DevExpress.XtraEditors;
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
using BusinessLayer;
using QLTIENLUONG.Reports;
using DevExpress.XtraReports.UI;

namespace QLTIENLUONG.TINHLUONG
{
    public partial class frmBangLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }
        BANGLUONG _bangluong;
        List<tb_BANGLUONG> _lstBangLuong;
        int _namky;
        void loadData()
        {
            gcBangLuong.DataSource = _bangluong.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            gvBangLuong.OptionsBehavior.Editable = false;
            _lstBangLuong = _bangluong.getList(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            _namky = int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text);
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBangLuong_Load(object sender, EventArgs e)
        {
            _bangluong = new BANGLUONG();
            cboNam.Text = DateTime.Now.Year.ToString();
            cboThang.Text = DateTime.Now.Month.ToString();
        }

        private void btnTinhLuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bangluong.TinhLuongNhanVien(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            loadData();
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rptBangLuongNhanVien rpt = new rptBangLuongNhanVien(_lstBangLuong, _namky);
            rpt.ShowPreviewDialog();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _bangluong.delete(int.Parse(cboNam.Text) * 100 + int.Parse(cboThang.Text));
            loadData();
        }

        private void btnCachTinh_Click(object sender, EventArgs e)
        {
            frmCachTinhLuong frm = new frmCachTinhLuong();
            frm.ShowDialog();
        }
    }
}