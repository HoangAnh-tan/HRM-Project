
namespace QLTIENLUONG.TINHLUONG
{
    partial class frmBangLuong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTinhLuong = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCachTinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcBangLuong = new DevExpress.XtraGrid.GridControl();
            this.gvBangLuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAKYCONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCONGTRONGTHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYPHEP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYCHUNHAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYTHUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TANGCA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PHUCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UNGLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THUCLANH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcBangLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTinhLuong,
            this.btnThoat,
            this.btnIn,
            this.btnXoa});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTinhLuong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Caption = "Tính lương";
            this.btnTinhLuong.Id = 0;
            this.btnTinhLuong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTinhLuong.ImageOptions.SvgImage")));
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTinhLuong_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa 1 hàng";
            this.btnXoa.Id = 7;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "In";
            this.btnIn.Id = 6;
            this.btnIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnIn.ImageOptions.SvgImage")));
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(964, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 361);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(964, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 337);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(964, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 337);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCachTinh);
            this.splitContainer1.Panel1.Controls.Add(this.btnXem);
            this.splitContainer1.Panel1.Controls.Add(this.cboThang);
            this.splitContainer1.Panel1.Controls.Add(this.cboNam);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gcBangLuong);
            this.splitContainer1.Size = new System.Drawing.Size(964, 337);
            this.splitContainer1.TabIndex = 7;
            // 
            // btnCachTinh
            // 
            this.btnCachTinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCachTinh.ImageOptions.Image")));
            this.btnCachTinh.Location = new System.Drawing.Point(650, 15);
            this.btnCachTinh.Name = "btnCachTinh";
            this.btnCachTinh.Size = new System.Drawing.Size(111, 23);
            this.btnCachTinh.TabIndex = 17;
            this.btnCachTinh.Text = "Cách tính lương";
            this.btnCachTinh.Click += new System.EventHandler(this.btnCachTinh_Click);
            // 
            // btnXem
            // 
            this.btnXem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.ImageOptions.Image")));
            this.btnXem.Location = new System.Drawing.Point(481, 15);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(111, 23);
            this.btnXem.TabIndex = 16;
            this.btnXem.Text = "Xem bảng lương";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(278, 16);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(139, 21);
            this.cboThang.TabIndex = 15;
            // 
            // cboNam
            // 
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026"});
            this.cboNam.Location = new System.Drawing.Point(50, 16);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(139, 21);
            this.cboNam.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Năm:";
            // 
            // gcBangLuong
            // 
            this.gcBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcBangLuong.Location = new System.Drawing.Point(0, 0);
            this.gcBangLuong.MainView = this.gvBangLuong;
            this.gcBangLuong.MenuManager = this.barManager1;
            this.gcBangLuong.Name = "gcBangLuong";
            this.gcBangLuong.Size = new System.Drawing.Size(964, 283);
            this.gcBangLuong.TabIndex = 0;
            this.gcBangLuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangLuong});
            // 
            // gvBangLuong
            // 
            this.gvBangLuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.MAKYCONG,
            this.HOTEN,
            this.NGAYCONGTRONGTHANG,
            this.MANV,
            this.NGAYPHEP,
            this.NGAYLE,
            this.NGAYCHUNHAT,
            this.NGAYTHUONG,
            this.TANGCA,
            this.PHUCAP,
            this.UNGLUONG,
            this.THUCLANH});
            this.gvBangLuong.GridControl = this.gcBangLuong;
            this.gvBangLuong.Name = "gvBangLuong";
            this.gvBangLuong.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.MaxWidth = 50;
            this.ID.MinWidth = 50;
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // MAKYCONG
            // 
            this.MAKYCONG.Caption = "Mã kỳ công";
            this.MAKYCONG.FieldName = "MAKYCONG";
            this.MAKYCONG.MaxWidth = 75;
            this.MAKYCONG.MinWidth = 75;
            this.MAKYCONG.Name = "MAKYCONG";
            this.MAKYCONG.Visible = true;
            this.MAKYCONG.VisibleIndex = 1;
            // 
            // HOTEN
            // 
            this.HOTEN.Caption = "Họ tên nhân viên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MaxWidth = 125;
            this.HOTEN.MinWidth = 125;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 0;
            this.HOTEN.Width = 125;
            // 
            // NGAYCONGTRONGTHANG
            // 
            this.NGAYCONGTRONGTHANG.Caption = "Ngày công";
            this.NGAYCONGTRONGTHANG.FieldName = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.MaxWidth = 75;
            this.NGAYCONGTRONGTHANG.MinWidth = 75;
            this.NGAYCONGTRONGTHANG.Name = "NGAYCONGTRONGTHANG";
            this.NGAYCONGTRONGTHANG.Visible = true;
            this.NGAYCONGTRONGTHANG.VisibleIndex = 2;
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã nhân viên";
            this.MANV.FieldName = "MANV";
            this.MANV.MaxWidth = 50;
            this.MANV.MinWidth = 50;
            this.MANV.Name = "MANV";
            this.MANV.Width = 50;
            // 
            // NGAYPHEP
            // 
            this.NGAYPHEP.Caption = "Ngày phép";
            this.NGAYPHEP.DisplayFormat.FormatString = "n0";
            this.NGAYPHEP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYPHEP.FieldName = "NGAYPHEP";
            this.NGAYPHEP.MaxWidth = 75;
            this.NGAYPHEP.MinWidth = 75;
            this.NGAYPHEP.Name = "NGAYPHEP";
            this.NGAYPHEP.Visible = true;
            this.NGAYPHEP.VisibleIndex = 3;
            // 
            // NGAYLE
            // 
            this.NGAYLE.Caption = "Ngày lễ";
            this.NGAYLE.DisplayFormat.FormatString = "n0";
            this.NGAYLE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYLE.FieldName = "NGAYLE";
            this.NGAYLE.MaxWidth = 75;
            this.NGAYLE.MinWidth = 75;
            this.NGAYLE.Name = "NGAYLE";
            this.NGAYLE.Visible = true;
            this.NGAYLE.VisibleIndex = 4;
            // 
            // NGAYCHUNHAT
            // 
            this.NGAYCHUNHAT.Caption = "Chủ nhật";
            this.NGAYCHUNHAT.DisplayFormat.FormatString = "n0";
            this.NGAYCHUNHAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYCHUNHAT.FieldName = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.MaxWidth = 75;
            this.NGAYCHUNHAT.MinWidth = 75;
            this.NGAYCHUNHAT.Name = "NGAYCHUNHAT";
            this.NGAYCHUNHAT.Visible = true;
            this.NGAYCHUNHAT.VisibleIndex = 5;
            // 
            // NGAYTHUONG
            // 
            this.NGAYTHUONG.Caption = "Ngày thường";
            this.NGAYTHUONG.DisplayFormat.FormatString = "n0";
            this.NGAYTHUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NGAYTHUONG.FieldName = "NGAYTHUONG";
            this.NGAYTHUONG.MaxWidth = 75;
            this.NGAYTHUONG.MinWidth = 75;
            this.NGAYTHUONG.Name = "NGAYTHUONG";
            this.NGAYTHUONG.Visible = true;
            this.NGAYTHUONG.VisibleIndex = 6;
            // 
            // TANGCA
            // 
            this.TANGCA.Caption = "Tăng ca";
            this.TANGCA.DisplayFormat.FormatString = "n0";
            this.TANGCA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TANGCA.FieldName = "TANGCA";
            this.TANGCA.MaxWidth = 75;
            this.TANGCA.MinWidth = 75;
            this.TANGCA.Name = "TANGCA";
            this.TANGCA.Visible = true;
            this.TANGCA.VisibleIndex = 7;
            // 
            // PHUCAP
            // 
            this.PHUCAP.Caption = "Phụ cấp";
            this.PHUCAP.DisplayFormat.FormatString = "n0";
            this.PHUCAP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PHUCAP.FieldName = "PHUCAP";
            this.PHUCAP.MaxWidth = 75;
            this.PHUCAP.MinWidth = 75;
            this.PHUCAP.Name = "PHUCAP";
            this.PHUCAP.Visible = true;
            this.PHUCAP.VisibleIndex = 8;
            // 
            // UNGLUONG
            // 
            this.UNGLUONG.Caption = "Ứng lương";
            this.UNGLUONG.DisplayFormat.FormatString = "n0";
            this.UNGLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UNGLUONG.FieldName = "UNGLUONG";
            this.UNGLUONG.MaxWidth = 75;
            this.UNGLUONG.MinWidth = 75;
            this.UNGLUONG.Name = "UNGLUONG";
            this.UNGLUONG.Visible = true;
            this.UNGLUONG.VisibleIndex = 9;
            // 
            // THUCLANH
            // 
            this.THUCLANH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.THUCLANH.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.THUCLANH.AppearanceHeader.Options.UseBackColor = true;
            this.THUCLANH.AppearanceHeader.Options.UseFont = true;
            this.THUCLANH.Caption = "Thực lãnh";
            this.THUCLANH.DisplayFormat.FormatString = "n0";
            this.THUCLANH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.THUCLANH.FieldName = "THUCLANH";
            this.THUCLANH.MaxWidth = 125;
            this.THUCLANH.MinWidth = 125;
            this.THUCLANH.Name = "THUCLANH";
            this.THUCLANH.Visible = true;
            this.THUCLANH.VisibleIndex = 10;
            this.THUCLANH.Width = 125;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 381);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmBangLuong";
            this.Text = "Bảng lương nhân viên";
            this.Load += new System.EventHandler(this.frmBangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTinhLuong;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gcBangLuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCONGTRONGTHANG;
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private DevExpress.XtraGrid.Columns.GridColumn MAKYCONG;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYPHEP;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYLE;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYCHUNHAT;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYTHUONG;
        private DevExpress.XtraGrid.Columns.GridColumn TANGCA;
        private DevExpress.XtraGrid.Columns.GridColumn PHUCAP;
        private DevExpress.XtraGrid.Columns.GridColumn UNGLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn THUCLANH;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCachTinh;
    }
}