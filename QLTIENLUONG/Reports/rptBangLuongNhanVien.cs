using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DataLayer;
using BusinessLayer;
using System.Collections.Generic;

namespace QLTIENLUONG.Reports
{
    public partial class rptBangLuongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangLuongNhanVien()
        {
            InitializeComponent();
        }
        List<tb_BANGLUONG> _lst;
        int _namky;
        public rptBangLuongNhanVien(List<tb_BANGLUONG> _lstBangLuong, int namky)
        {
            InitializeComponent();
            this._lst = _lstBangLuong;
            this._namky = namky;
            lblThangNam.Text = "Tháng " + _namky.ToString().Substring(4) + " năm " + _namky.ToString().Substring(0, 4);
            this.DataSource = _lst;
            loadData();
        }
        void loadData()
        {
            lblMANV.DataBindings.Add("Text", DataSource, "MANV");
            lblHOTEN.DataBindings.Add("Text", DataSource, "HOTEN");
            lblNGAYCONG.DataBindings.Add("Text", DataSource, "NGAYCONGTRONGTHANG");
            lblNGAYPHEP.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            lblNGAYLE.DataBindings.Add("Text", DataSource, "NGAYLE");
            lblCHUNHAT.DataBindings.Add("Text", DataSource, "NGAYCHUNHAT");
            lblTANGCA.DataBindings.Add("Text", DataSource, "TANGCA");
            lblPHUCAP.DataBindings.Add("Text", DataSource, "PHUCAP");
            lblUNGLUONG.DataBindings.Add("Text", DataSource, "UNGLUONG");
            lblNGAYTHUONG.DataBindings.Add("Text", DataSource, "NGAYTHUONG");
            lblTHUCLANH.DataBindings.Add("Text", DataSource, "THUCLANH");
        }
    }
}
