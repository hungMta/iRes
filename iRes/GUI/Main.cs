using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Title.Config;
using Title.GUI;

namespace iRes{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm {
        public frmMain() {
            InitializeComponent();
        }

        Configuration config = new Configuration();

        UtcQuanLyNhanVien utcQuanLyNhanVien = new UtcQuanLyNhanVien();
        UtcQuanLyKhachHang utcQuanLyKhachHang = new UtcQuanLyKhachHang();
        UtcQuanLyMonAn utcQuanLyMonAn = new UtcQuanLyMonAn();

        private string currentTabName;

        private void tclItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e) {
        }

        private void navBarItemNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            utcQuanLyNhanVien.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(utcQuanLyNhanVien);
            this.currentTabName = config.TAB_NHAN_VIEN;
        }

        private void navBarItemKhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            utcQuanLyKhachHang.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(utcQuanLyKhachHang);
            this.currentTabName = config.TAB_KHACH_HANG;
        }

        private void barButtonClipBoardCut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
        }

        private void navBarItemMonAn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            utcQuanLyMonAn.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(utcQuanLyMonAn);
            this.currentTabName = config.TAB_MON_AN;
        }

        private void groupControlClientArea_Paint(object sender, PaintEventArgs e) {
        }

        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (this.currentTabName) {
                case "TabNhanVien":
                    utcQuanLyNhanVien.Edit();
                    break;
                case "TabKhachHang":
                    utcQuanLyKhachHang.Edit();
                    break;
            }
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (this.currentTabName) {
                case "TabNhanVien":
                    utcQuanLyNhanVien.Delete();
                    break;
                case "TabKhachHang":
                    utcQuanLyKhachHang.Delete();
                    break;
            }
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (this.currentTabName) {
                case "TabNhanVien":
                    utcQuanLyNhanVien.Add();
                    break;
                case "TabKhachHang":
                    utcQuanLyKhachHang.Add();
                    break;
            }
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (this.currentTabName) {
                case "TabNhanVien":
                    utcQuanLyNhanVien.Save();
                    break;
                case "TabKhachHang":
                    utcQuanLyKhachHang.Save();
                    break;
            }
        }
    }
}
