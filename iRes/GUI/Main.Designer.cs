namespace iRes{
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControlTop = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonClipBoardCut = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonClipBoardCopy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonClipBoardPaste = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMoveUp = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMoveDown = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupClipBoard = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupMove = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageView = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControlClientArea = new DevExpress.XtraEditors.GroupControl();
            this.navBarItemNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemKhachHang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemMonAn = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemNhomMon = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupQuanLy = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupGoiMon = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupQuanLyMonAn = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupNhapHang = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlClientArea)).BeginInit();
            this.groupControlClientArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlTop
            // 
            this.ribbonControlTop.ExpandCollapseItem.Id = 0;
            this.ribbonControlTop.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlTop.ExpandCollapseItem,
            this.barButtonClipBoardCut,
            this.barButtonClipBoardCopy,
            this.barButtonClipBoardPaste,
            this.barButtonMoveUp,
            this.barButtonMoveDown,
            this.barButtonDelete,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControlTop.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlTop.MaxItemId = 11;
            this.ribbonControlTop.Name = "ribbonControlTop";
            this.ribbonControlTop.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHome,
            this.ribbonPageView});
            this.ribbonControlTop.Size = new System.Drawing.Size(1070, 141);
            this.ribbonControlTop.StatusBar = this.ribbonStatusBar1;
            // 
            // barButtonClipBoardCut
            // 
            this.barButtonClipBoardCut.Caption = "Cut";
            this.barButtonClipBoardCut.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonClipBoardCut.Glyph")));
            this.barButtonClipBoardCut.Id = 1;
            this.barButtonClipBoardCut.Name = "barButtonClipBoardCut";
            this.barButtonClipBoardCut.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barButtonClipBoardCut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonClipBoardCut_ItemClick);
            // 
            // barButtonClipBoardCopy
            // 
            this.barButtonClipBoardCopy.Caption = "Copy";
            this.barButtonClipBoardCopy.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonClipBoardCopy.Glyph")));
            this.barButtonClipBoardCopy.Id = 2;
            this.barButtonClipBoardCopy.Name = "barButtonClipBoardCopy";
            this.barButtonClipBoardCopy.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // barButtonClipBoardPaste
            // 
            this.barButtonClipBoardPaste.Caption = "Paste";
            this.barButtonClipBoardPaste.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonClipBoardPaste.Glyph")));
            this.barButtonClipBoardPaste.Id = 3;
            this.barButtonClipBoardPaste.Name = "barButtonClipBoardPaste";
            this.barButtonClipBoardPaste.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonMoveUp
            // 
            this.barButtonMoveUp.Caption = "Move Up";
            this.barButtonMoveUp.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonMoveUp.Glyph")));
            this.barButtonMoveUp.Id = 4;
            this.barButtonMoveUp.Name = "barButtonMoveUp";
            this.barButtonMoveUp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonMoveDown
            // 
            this.barButtonMoveDown.Caption = "Move Down";
            this.barButtonMoveDown.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonMoveDown.Glyph")));
            this.barButtonMoveDown.Id = 5;
            this.barButtonMoveDown.Name = "barButtonMoveDown";
            this.barButtonMoveDown.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonDelete
            // 
            this.barButtonDelete.Caption = "Delete";
            this.barButtonDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonDelete.Glyph")));
            this.barButtonDelete.Id = 6;
            this.barButtonDelete.Name = "barButtonDelete";
            this.barButtonDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Save";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPageHome
            // 
            this.ribbonPageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupClipBoard,
            this.ribbonPageGroupMove,
            this.ribbonPageGroup1});
            this.ribbonPageHome.Name = "ribbonPageHome";
            this.ribbonPageHome.Text = "Home";
            // 
            // ribbonPageGroupClipBoard
            // 
            this.ribbonPageGroupClipBoard.ItemLinks.Add(this.barButtonClipBoardCut);
            this.ribbonPageGroupClipBoard.ItemLinks.Add(this.barButtonClipBoardCopy);
            this.ribbonPageGroupClipBoard.ItemLinks.Add(this.barButtonClipBoardPaste);
            this.ribbonPageGroupClipBoard.Name = "ribbonPageGroupClipBoard";
            this.ribbonPageGroupClipBoard.Text = "Clip Board";
            // 
            // ribbonPageGroupMove
            // 
            this.ribbonPageGroupMove.ItemLinks.Add(this.barButtonMoveUp);
            this.ribbonPageGroupMove.ItemLinks.Add(this.barButtonMoveDown);
            this.ribbonPageGroupMove.Name = "ribbonPageGroupMove";
            // 
            // ribbonPageView
            // 
            this.ribbonPageView.Name = "ribbonPageView";
            this.ribbonPageView.Text = "View";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(2, 362);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControlTop;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(829, 27);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style";
            // 
            // groupControlClientArea
            // 
            this.groupControlClientArea.Controls.Add(this.ribbonStatusBar1);
            this.groupControlClientArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlClientArea.Location = new System.Drawing.Point(237, 141);
            this.groupControlClientArea.Name = "groupControlClientArea";
            this.groupControlClientArea.Size = new System.Drawing.Size(833, 391);
            this.groupControlClientArea.TabIndex = 3;
            this.groupControlClientArea.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControlClientArea_Paint);
            // 
            // navBarItemNhanVien
            // 
            this.navBarItemNhanVien.Caption = "Nhân Viên";
            this.navBarItemNhanVien.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemNhanVien.LargeImage")));
            this.navBarItemNhanVien.Name = "navBarItemNhanVien";
            this.navBarItemNhanVien.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemNhanVien.SmallImage")));
            this.navBarItemNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemNhanVien_LinkClicked);
            // 
            // navBarItemKhachHang
            // 
            this.navBarItemKhachHang.Caption = "Khách Hàng";
            this.navBarItemKhachHang.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemKhachHang.LargeImage")));
            this.navBarItemKhachHang.Name = "navBarItemKhachHang";
            this.navBarItemKhachHang.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemKhachHang.SmallImage")));
            this.navBarItemKhachHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemKhachHang_LinkClicked);
            // 
            // navBarItemMonAn
            // 
            this.navBarItemMonAn.Caption = "Món Ăn";
            this.navBarItemMonAn.LargeImage = global::Title.Properties.Resources.Aha_Soft_Food_Hamburger;
            this.navBarItemMonAn.Name = "navBarItemMonAn";
            this.navBarItemMonAn.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemMonAn.SmallImage")));
            this.navBarItemMonAn.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemMonAn_LinkClicked);
            // 
            // navBarItemNhomMon
            // 
            this.navBarItemNhomMon.Caption = "Nhóm Món";
            this.navBarItemNhomMon.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemNhomMon.LargeImage")));
            this.navBarItemNhomMon.Name = "navBarItemNhomMon";
            this.navBarItemNhomMon.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemNhomMon.SmallImage")));
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "navBarItem2";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "navBarItem3";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "navBarItem4";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarGroupQuanLy
            // 
            this.navBarGroupQuanLy.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroupQuanLy.Appearance.Options.UseFont = true;
            this.navBarGroupQuanLy.Caption = "Quản lý";
            this.navBarGroupQuanLy.Expanded = true;
            this.navBarGroupQuanLy.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small;
            this.navBarGroupQuanLy.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroupQuanLy.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemKhachHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemMonAn),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemNhomMon)});
            this.navBarGroupQuanLy.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupQuanLy.LargeImage")));
            this.navBarGroupQuanLy.Name = "navBarGroupQuanLy";
            this.navBarGroupQuanLy.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupQuanLy.SmallImage")));
            // 
            // navBarGroupGoiMon
            // 
            this.navBarGroupGoiMon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroupGoiMon.Appearance.Options.UseFont = true;
            this.navBarGroupGoiMon.Caption = "Gọi Món";
            this.navBarGroupGoiMon.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroupGoiMon.Name = "navBarGroupGoiMon";
            this.navBarGroupGoiMon.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupGoiMon.SmallImage")));
            // 
            // navBarGroupQuanLyMonAn
            // 
            this.navBarGroupQuanLyMonAn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroupQuanLyMonAn.Appearance.Options.UseFont = true;
            this.navBarGroupQuanLyMonAn.Caption = "Thanh Toán";
            this.navBarGroupQuanLyMonAn.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroupQuanLyMonAn.Name = "navBarGroupQuanLyMonAn";
            this.navBarGroupQuanLyMonAn.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupQuanLyMonAn.SmallImage")));
            // 
            // navBarGroupNhapHang
            // 
            this.navBarGroupNhapHang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroupNhapHang.Appearance.Options.UseFont = true;
            this.navBarGroupNhapHang.Caption = "Nhập hàng";
            this.navBarGroupNhapHang.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroupNhapHang.Name = "navBarGroupNhapHang";
            this.navBarGroupNhapHang.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupNhapHang.SmallImage")));
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroupQuanLy;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupQuanLy,
            this.navBarGroupGoiMon,
            this.navBarGroupQuanLyMonAn,
            this.navBarGroupNhapHang});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemNhanVien,
            this.navBarItemKhachHang,
            this.navBarItemMonAn,
            this.navBarItemNhomMon,
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4});
            this.navBarControl1.Location = new System.Drawing.Point(0, 141);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 237;
            this.navBarControl1.OptionsNavPane.ShowGroupImageInHeader = true;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(237, 391);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Edit";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Add";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 10;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1070, 532);
            this.Controls.Add(this.groupControlClientArea);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.ribbonControlTop);
            this.Name = "frmMain";
            this.Text = "iRes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlClientArea)).EndInit();
            this.groupControlClientArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlTop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupClipBoard;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageView;
        private DevExpress.XtraBars.BarButtonItem barButtonClipBoardCut;
        private DevExpress.XtraBars.BarButtonItem barButtonClipBoardCopy;
        private DevExpress.XtraBars.BarButtonItem barButtonClipBoardPaste;
        private DevExpress.XtraBars.BarButtonItem barButtonMoveUp;
        private DevExpress.XtraBars.BarButtonItem barButtonMoveDown;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupMove;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.GroupControl groupControlClientArea;
        private DevExpress.XtraNavBar.NavBarItem navBarItemNhanVien;
        private DevExpress.XtraNavBar.NavBarItem navBarItemKhachHang;
        private DevExpress.XtraNavBar.NavBarItem navBarItemMonAn;
        private DevExpress.XtraNavBar.NavBarItem navBarItemNhomMon;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupQuanLy;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupGoiMon;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupQuanLyMonAn;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupNhapHang;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

