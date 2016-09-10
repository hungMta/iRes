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
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thựcĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.đóngTrangHiệnTạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngTấtCảCáTrangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.thựcĐơnToolStripMenuItem,
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
            this.quảnLýNhânViênToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.phânQuyềnSửDụngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // phânQuyềnSửDụngToolStripMenuItem
            // 
            this.phânQuyềnSửDụngToolStripMenuItem.Name = "phânQuyềnSửDụngToolStripMenuItem";
            this.phânQuyềnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.phânQuyềnSửDụngToolStripMenuItem.Text = "Phân quyền sử dụng";
            // 
            // khuVựcToolStripMenuItem
            // 
            this.khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            this.khuVựcToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.khuVựcToolStripMenuItem.Text = "Khu vực";
            // 
            // thựcĐơnToolStripMenuItem
            // 
            this.thựcĐơnToolStripMenuItem.Name = "thựcĐơnToolStripMenuItem";
            this.thựcĐơnToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thựcĐơnToolStripMenuItem.Text = "Thực đơn";
            this.thựcĐơnToolStripMenuItem.Click += new System.EventHandler(this.thựcĐơnToolStripMenuItem_Click);
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
            this.trựcTiếpToolStripMenuItem.Click += new System.EventHandler(this.trựcTiếpToolStripMenuItem_Click);
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
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // ctxtTabHienThi
            // 
            this.ctxtTabHienThi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đóngTrangHiệnTạiToolStripMenuItem,
            this.đóngTấtCảCáTrangToolStripMenuItem});
            this.ctxtTabHienThi.Name = "ctxtTabHienThi";
            this.ctxtTabHienThi.Size = new System.Drawing.Size(182, 48);
            // 
            // đóngTrangHiệnTạiToolStripMenuItem
            // 
            this.đóngTrangHiệnTạiToolStripMenuItem.Name = "đóngTrangHiệnTạiToolStripMenuItem";
            this.đóngTrangHiệnTạiToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đóngTrangHiệnTạiToolStripMenuItem.Text = "Đóng trang hiện tại";
            this.đóngTrangHiệnTạiToolStripMenuItem.Click += new System.EventHandler(this.đóngTrangHiệnTạiToolStripMenuItem_Click);
            // 
            // đóngTấtCảCáTrangToolStripMenuItem
            // 
            this.đóngTấtCảCáTrangToolStripMenuItem.Name = "đóngTấtCảCáTrangToolStripMenuItem";
            this.đóngTấtCảCáTrangToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.đóngTấtCảCáTrangToolStripMenuItem.Text = "Đóng tất cả cá trang";
            this.đóngTấtCảCáTrangToolStripMenuItem.Click += new System.EventHandler(this.đóngTấtCảCáTrangToolStripMenuItem_Click);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ctxtTabHienThi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gọiMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trựcTiếpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thựcĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtTrướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kíchHoạtPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraCậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtTabHienThi;
        private System.Windows.Forms.ToolStripMenuItem đóngTrangHiệnTạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngTấtCảCáTrangToolStripMenuItem;
        private System.Windows.Forms.TabControl tabHienThi;

    }
}

