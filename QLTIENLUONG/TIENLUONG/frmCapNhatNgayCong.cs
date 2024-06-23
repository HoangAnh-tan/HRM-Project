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

namespace QLTIENLUONG.TIENLUONG
{
    public partial class frmCapNhatNgayCong : DevExpress.XtraEditors.XtraForm
    {
        public frmCapNhatNgayCong()
        {
            InitializeComponent();
        }
        public int _manv;
        public string _hoten;
        public int _makycong;
        public string _ngay;
        public int _cngay;
        KYCONGCHITIET _kcct;
        BANGCONG_NV_CT _bcct_nv;
        frmBangCongChiTiet frmBCCT = (frmBangCongChiTiet) Application.OpenForms["frmBangCongChiTiet"];
        private void frmCapNhatNgayCong_Load(object sender, EventArgs e)
        {
            _kcct = new KYCONGCHITIET();
            _bcct_nv = new BANGCONG_NV_CT();
            lblIDNV.Text = _manv.ToString();
            lblHoTen.Text = _hoten.ToString();
            string nam = _makycong.ToString().Substring(0, 4);
            string thang = _makycong.ToString().Substring(4);
            string ngay = _ngay.Substring(1);
            DateTime _d = DateTime.Parse(nam + "-" + thang + "-" + ngay); 
            cldNgayCong.SetDate(_d);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(_manv.ToString() + " " + _makycong.ToString() + " - " + _ngay);
            string _valueChamCong = rdgChamCong.Properties.Items[rdgChamCong.SelectedIndex].Value.ToString();
            string _valueThoiGian = rdgThoiGian.Properties.Items[rdgThoiGian.SelectedIndex].Value.ToString();
            string filedName = "D" + _cngay.ToString();
            var kcct = _kcct.getItem(_makycong, _manv);
            //double? tongngaycong = kcct.TONGNGAYCONG;
            //double? tongngayphep = kcct.NGAYPHEP;
            //double? tongngaykhongphep = kcct.NGHIKHONGPHEP;
            //double? tongngayle = kcct.CONGNGAYLE;
            if (cldNgayCong.SelectionRange.Start.Year*100 + cldNgayCong.SelectionRange.Start.Month != _makycong)
            {
                MessageBox.Show("Thực hiện chấm công không đúng kỳ công. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            HoangAnh_Funcition.execQuery("UPDATE tb_KYCONGCHITIET SET " + filedName + "='" + _valueChamCong + "' WHERE MAKYCONG=" + _makycong + " AND MANV=" + _manv);
            tb_BANGCONG_NHANVIEN_CHITIET bcctnv = _bcct_nv.getItem(_makycong, _manv, cldNgayCong.SelectionStart.Day);
            if (cldNgayCong.SelectionStart.DayOfWeek == DayOfWeek.Sunday)
            {
                if (_valueThoiGian == "NN")
                {
                    bcctnv.CONGCHUNHAT = 1;
                    bcctnv.NGAYCONG = 0;
                }
                else
                {
                    bcctnv.CONGCHUNHAT = 0.5;
                    bcctnv.NGAYCONG = 0;
                }
            }
            else
            {
                bcctnv.KYHIEU = _valueChamCong;
                switch (_valueChamCong)
                {
                    case "P":
                        if (_valueThoiGian == "NN")
                        {
                            bcctnv.NGAYPHEP = 1;
                            bcctnv.NGAYCONG = 0;
                        }
                        else
                        {
                            bcctnv.NGAYPHEP = 0.5;
                            bcctnv.NGAYCONG = 0.5;
                        }
                        break;
                    case "CT":
                        if (_valueThoiGian == "NN")
                        {
                            bcctnv.NGAYCONG = 1;
                        }
                        else
                        {
                            bcctnv.NGAYCONG = 0.5;
                            bcctnv.NGAYPHEP = 0.5;
                        }
                        break;
                    default:
                        break;
                }
            }
            
            //Update table
            _bcct_nv.Update(bcctnv);
            //Tính lại tổng các ngày phép, công, vắng,...
            double congchunhat = _bcct_nv.tongNgayCongChuNhat(_makycong, _manv);
            double tongngayphep = _bcct_nv.tongNgayPhep(_makycong, _manv);
            double tongngaycong = _bcct_nv.tongNgayCong(_makycong, _manv);
            kcct.CONGCHUNHAT = congchunhat;
            kcct.NGAYPHEP = tongngayphep;
            kcct.TONGNGAYCONG = tongngaycong;
            
            _kcct.Update(kcct);

            frmBCCT.loadBangCong();      
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cldNgayCong_DateSelected(object sender, DateRangeEventArgs e)
        {
           _cngay = cldNgayCong.SelectionRange.Start.Day;
            
        }
    }
}