using BusinessLayer.DataObject;
using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace QLTIENLUONG.Reports
{
    public partial class rptNhanVienThoiViec : DevExpress.XtraReports.UI.XtraReport
    {
        public rptNhanVienThoiViec()
        {
            InitializeComponent();
        }
        public rptNhanVienThoiViec(List<THOIVIEC_DTO> lstTV)
        {
            InitializeComponent();
            this._lstTV = lstTV;
            this.DataSource = _lstTV;
            loadData();
        }
        List<THOIVIEC_DTO> _lstTV;
        void loadData()
        {
            lblSoQD.DataBindings.Add("Text", _lstTV, "SOQD");
        }
    }
}
