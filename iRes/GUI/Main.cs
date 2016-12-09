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
        UctQuanLyNhomMon uctQuanLyNhomMon = new UctQuanLyNhomMon();
        UctGoiMonTheoBan uctGoiMonTheoBan = new UctGoiMonTheoBan();

        private string currentTabName;

        private void tclItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e) { }

        private void navBarItemNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            utcQuanLyNhanVien.LoadData();
            utcQuanLyNhanVien.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(utcQuanLyNhanVien);
            this.currentTabName = config.TAB_NHAN_VIEN;
        }

        private void navBarItemKhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            utcQuanLyKhachHang.LoadData();
            utcQuanLyKhachHang.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(utcQuanLyKhachHang);
            this.currentTabName = config.TAB_KHACH_HANG;
        }

        private void navBarItemMonAn_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            utcQuanLyMonAn.LoadData();
            utcQuanLyMonAn.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(utcQuanLyMonAn);
            this.currentTabName = config.TAB_MON_AN;
        }

        private void navBarItemNhomMon_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            uctQuanLyNhomMon.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(uctQuanLyNhomMon);
            this.currentTabName = config.TAB_NHOM_MON;
        }

        private void navBarGoiMonTheoBan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            uctGoiMonTheoBan.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(uctGoiMonTheoBan);
            this.currentTabName = config.TAB_GOI_MON_THEO_BAN;
        }

        public void DisableButtonBar() {
            this.barButtonAdd.Enabled = false;
            this.barButtonEdit.Enabled = false;
            this.barButtonDelete.Enabled = false;
        }

        public void EnableButtonBar() {
            this.barButtonAdd.Enabled = true;
            this.barButtonEdit.Enabled = true;
            this.barButtonDelete.Enabled = true;
        }

        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DisableButtonBar();
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
            DisableButtonBar();
            switch (this.currentTabName) {
                case "TabNhanVien":
                    utcQuanLyNhanVien.Add();
                    break;
                case "TabKhachHang":
                    utcQuanLyKhachHang.Add();
                    break;
                case "TabMonAn" :
                    EnableButtonBar();
                    FrmThemMon frmThemMon = new FrmThemMon();
                    frmThemMon.ShowDialog();
                    utcQuanLyMonAn.LoadData();
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
            EnableButtonBar();
        }

        private void barButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            EnableButtonBar();
        }

    }
}
