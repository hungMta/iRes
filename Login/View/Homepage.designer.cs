namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyNhomMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyBanAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyMonAn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyPhieuGoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyPhieuDatTruoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trựcTiếpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtTrướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kíchHoạtPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraCậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtTabHienThi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuDongTrangHienTai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDongTatCaTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.tabHienThi = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.ctxtTabHienThi.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.khuVựcToolStripMenuItem,
            this.tabThucDon,
            this.gọiMónToolStripMenuItem,
            this.thoátToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyNhanVien,
            this.mnuQuanLyKhachHang,
            this.mnuQuanLyNhomMon,
            this.mnuQuanLyBanAn,
            this.mnuQuanLyMonAn,
            this.mnuQuanLyPhieuGoi,
            this.mnuQuanLyPhieuDatTruoc,
            this.mnuQuanLyHoaDon});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuQuanLyNhanVien
            // 
            this.mnuQuanLyNhanVien.Name = "mnuQuanLyNhanVien";
            this.mnuQuanLyNhanVien.Size = new System.Drawing.Size(199, 22);
            this.mnuQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.mnuQuanLyNhanVien.Click += new System.EventHandler(this.mnuQuanLyNhanVien_Click);
            // 
            // mnuQuanLyKhachHang
            // 
            this.mnuQuanLyKhachHang.Name = "mnuQuanLyKhachHang";
            this.mnuQuanLyKhachHang.Size = new System.Drawing.Size(199, 22);
            this.mnuQuanLyKhachHang.Text = "Quản lý khách hàng";
            // 
            // mnuQuanLyNhomMon
            // 
            this.mnuQuanLyNhomMon.Name = "mnuQuanLyNhomMon";
            this.mnuQuanLyNhomMon.Size = new System.Drawing.Size(199, 22);
            this.mnuQuanLyNhomMon.Text = "Quản lý nhóm món";
            this.mnuQuanLyNhomMon.Click += new System.EventHandler(this.mnuQuanLyNhomMon_Click);
            // 
            // mnuQuanLyBanAn
            // 
            this.mnuQuanLyBanAn.Name = "mnuQuanLyBanAn";
            this.mnuQuanLyBanAn.Size = new System.Drawing.Size(199, 22);
            this.mnuQuanLyBanAn.Text = "Quản lý bàn ăn";
            // 
            // mnuQuanLyMonAn
            // 
            this.mnuQuanLyMonAn.Name = "mnuQuanLyMonAn";
            this.mnuQuanLyMonAn.Size = new System.Drawing.Size(199, 22);
            this.mnuQuanLyMonAn.Text = "Quản lý món ăn";
            this.mnuQuanLyMonAn.Click += new System.EventHandler(this.mnuQuanLyMonAn_Click);
            // 
            // mnuQuanLyPhieuGoi
            // 
            this.mnuQuanLyPhieuGoi.Name = "mnuQuanLyPhieuGoi";
            this.mnuQuanLyPhieuGoi.Size = new System.Drawing.Size(199, 22);
            this.mnuQuanLyPhieuGoi.Text = "Quản lý phiếu gọi";
            // 
            // mnuQuanLyPhieuDatTruoc
            // 
            this.mnuQuanLyPhieuDatTruoc.Name = "mnuQuanLyPhieuDatTruoc";
            this.mnuQuanLyPhieuDatTruoc.Size = new System.Drawing.Size(199, 22);
            this.mnuQuanLyPhieuDatTruoc.Text = "Quản lý phiếu đặt trước";
            // 
            // mnuQuanLyHoaDon
            // 
            this.mnuQuanLyHoaDon.Name = "mnuQuanLyHoaDon";
            this.mnuQuanLyHoaDon.Size = new System.Drawing.Size(199, 22);
            this.mnuQuanLyHoaDon.Text = "Quản lý hóa đơn";
            // 
            // khuVựcToolStripMenuItem
            // 
            this.khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            this.khuVựcToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.khuVựcToolStripMenuItem.Text = "Khu vực";
            // 
            // tabThucDon
            // 
            this.tabThucDon.Name = "tabThucDon";
            this.tabThucDon.Size = new System.Drawing.Size(70, 20);
            this.tabThucDon.Text = "Thực đơn";
            this.tabThucDon.Click += new System.EventHandler(this.tabThucDon_Click);
            // 
            // gọiMónToolStripMenuItem
            // 
            this.gọiMónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trựcTiếpToolStripMenuItem,
            this.đặtTrướcToolStripMenuItem});
            this.gọiMónToolStripMenuItem.Name = "gọiMónToolStripMenuItem";
            this.gọiMónToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.gọiMónToolStripMenuItem.Text = "Gọi món";
            // 
            // trựcTiếpToolStripMenuItem
            // 
            this.trựcTiếpToolStripMenuItem.Name = "trựcTiếpToolStripMenuItem";
            this.trựcTiếpToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.trựcTiếpToolStripMenuItem.Text = "Trực tiếp";
            // 
            // đặtTrướcToolStripMenuItem
            // 
            this.đặtTrướcToolStripMenuItem.Name = "đặtTrướcToolStripMenuItem";
            this.đặtTrướcToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.đặtTrướcToolStripMenuItem.Text = "Đặt trước";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.thoátToolStripMenuItem.Text = "Nhập hàng";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.kíchHoạtPhầnMềmToolStripMenuItem,
            this.kiểmTraCậpNhậtToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // kíchHoạtPhầnMềmToolStripMenuItem
            // 
            this.kíchHoạtPhầnMềmToolStripMenuItem.Name = "kíchHoạtPhầnMềmToolStripMenuItem";
            this.kíchHoạtPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kíchHoạtPhầnMềmToolStripMenuItem.Text = "Kích hoạt phần mềm";
            // 
            // kiểmTraCậpNhậtToolStripMenuItem
            // 
            this.kiểmTraCậpNhậtToolStripMenuItem.Name = "kiểmTraCậpNhậtToolStripMenuItem";
            this.kiểmTraCậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kiểmTraCậpNhậtToolStripMenuItem.Text = "Kiểm tra cập nhật";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            // 
            // ctxtTabHienThi
            // 
            this.ctxtTabHienThi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDongTrangHienTai,
            this.mnuDongTatCaTrang});
            this.ctxtTabHienThi.Name = "ctxtTabHienThi";
            this.ctxtTabHienThi.Size = new System.Drawing.Size(182, 48);
            // 
            // mnuDongTrangHienTai
            // 
            this.mnuDongTrangHienTai.Name = "mnuDongTrangHienTai";
            this.mnuDongTrangHienTai.Size = new System.Drawing.Size(181, 22);
            this.mnuDongTrangHienTai.Text = "Đóng trang hiện tại";
            this.mnuDongTrangHienTai.Click += new System.EventHandler(this.mnuDongTrangHienTai_Click);
            // 
            // mnuDongTatCaTrang
            // 
            this.mnuDongTatCaTrang.Name = "mnuDongTatCaTrang";
            this.mnuDongTatCaTrang.Size = new System.Drawing.Size(181, 22);
            this.mnuDongTatCaTrang.Text = "Đóng tất cả cá trang";
            this.mnuDongTatCaTrang.Click += new System.EventHandler(this.mnuDongTatCaCacTrang_Click);
            // 
            // tabHienThi
            // 
            this.tabHienThi.ContextMenuStrip = this.ctxtTabHienThi;
            this.tabHienThi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabHienThi.Location = new System.Drawing.Point(0, 24);
            this.tabHienThi.Name = "tabHienThi";
            this.tabHienThi.SelectedIndex = 0;
            this.tabHienThi.Size = new System.Drawing.Size(1074, 503);
            this.tabHienThi.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1074, 527);
            this.Controls.Add(this.tabHienThi);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iRes Phần mềm quản lý nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxtTabHienThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyNhomMon;
        private System.Windows.Forms.ToolStripMenuItem khuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gọiMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trựcTiếpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tabThucDon;
        private System.Windows.Forms.ToolStripMenuItem đặtTrướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kíchHoạtPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraCậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyBanAn;
        private System.Windows.Forms.ContextMenuStrip ctxtTabHienThi;
        private System.Windows.Forms.ToolStripMenuItem mnuDongTrangHienTai;
        private System.Windows.Forms.ToolStripMenuItem mnuDongTatCaTrang;
        private System.Windows.Forms.TabControl tabHienThi;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyMonAn;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyPhieuGoi;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyPhieuDatTruoc;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyHoaDon;
    }
}

