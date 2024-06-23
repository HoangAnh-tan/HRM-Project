using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using BusinessLayer.DataObject;
using System.Collections.Generic;

namespace QLTIENLUONG.Reports
{
    public partial class rptHopDongLaoDong : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHopDongLaoDong()
        {
            InitializeComponent();
        }
        public rptHopDongLaoDong(List<HOPDONG_DTO> lstHD)
        {
            InitializeComponent();
            this._lstHD = lstHD;
            this.DataSource = lstHD;
            loadData();
        }
        List<HOPDONG_DTO> _lstHD;
        void loadData()
        {
            lblSoHD.DataBindings.Add("Text", _lstHD, "SOHD");
        }
    }
}
