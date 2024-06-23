using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DataLayer;
using System.Collections.Generic;

namespace QLTIENLUONG.Reports
{
    public partial class rptBangCongChiTiet : DevExpress.XtraReports.UI.XtraReport
    {
        public rptBangCongChiTiet()
        {
            InitializeComponent();
        }
        public List<tb_BANGCONG_NHANVIEN_CHITIET> _bcct;
        public rptBangCongChiTiet(List<tb_BANGCONG_NHANVIEN_CHITIET> bcct)
        {
            InitializeComponent();
            this._bcct = bcct;
            this.DataSource = _bcct;
            BindingData();
        }
        void BindingData()
        {
            ID.DataBindings.Add("Text", DataSource, "MANV");
            HOTEN.DataBindings.Add("Text", DataSource, "HOTEN");
            NGAY.DataBindings.Add("Text", DataSource, "NGAY");
            THU.DataBindings.Add("Text", DataSource, "THU");
            GIOVAO.DataBindings.Add("Text", DataSource, "GIOVAO");
            GIORA.DataBindings.Add("Text", DataSource, "GIORA");
            NGAYLE.DataBindings.Add("Text", DataSource, "CONGNGAYLE");
            NGAYPHEP.DataBindings.Add("Text", DataSource, "NGAYPHEP");
            CHUNHAT.DataBindings.Add("Text", DataSource, "CONGCHUNHAT");
            NGAYCONG.DataBindings.Add("Text", DataSource, "NGAYCONG");
            KYHIEU.DataBindings.Add("Text", DataSource, "KYHIEU");
            GHICHU.DataBindings.Add("Text", DataSource, "GHICHU");
        }
    }
}
