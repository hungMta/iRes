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
        UctNhapHang uctNhapHang = new UctNhapHang();
        UctThongKe uctThongKe = new UctThongKe();
        UctQuanLyNguyenLieu uctQuanLyNguyenLieu = new UctQuanLyNguyenLieu();
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

        private void navBarNhapHangMoi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            uctNhapHang.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(uctNhapHang);
            this.currentTabName = config.TAB_NHAP_HANG;
        }

        private void navBarDoanhThu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e) {
            uctThongKe.LoadData();
            uctThongKe.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(uctThongKe);
            this.currentTabName = config.TAB_NHAP_HANG;
        }

        public void DisableButtonBar() {
            this.barButtonAdd.Enabled = false;
            this.barButtonEdit.Enabled = false;
            this.barButtonDelete.Enabled = false;
            this.barButtonSave.Enabled = true;
            this.barButtonCancel.Enabled = true;
        }

        public void EnableButtonBar() {
            this.barButtonAdd.Enabled = true;
            this.barButtonEdit.Enabled = true;
            this.barButtonDelete.Enabled = true;
            this.barButtonSave.Enabled = false;
            this.barButtonCancel.Enabled = false;
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
                case "TabMonAn":
                    FrmEditMonAn frmEditMonAN = new FrmEditMonAn();
                    frmEditMonAN.ShowDialog();
                    EnableButtonBar();
                    break;
                case "TabNhomMon":
                    uctQuanLyNhomMon.Edit();
                    break;
                case "TabNguyenLieu":
                    uctQuanLyNguyenLieu.Edit();
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
                case "TabNhomMon":
                    uctQuanLyNhomMon.Delete();
                    break;
                case "TabNguyenLieu":
                    uctQuanLyNguyenLieu.Delete();
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
                case "TabMonAn":
                    utcQuanLyMonAn.LoadData();
                    EnableButtonBar();
                    break;
                case "TabNhomMon":
                    uctQuanLyNhomMon.Add();
                    break;
                case "TabNguyenLieu":
                    uctQuanLyNguyenLieu.Add();
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
                case "TabNhomMon":
                    uctQuanLyNhomMon.Save();
                    break;
                case "TabNguyenLieu":
                    uctQuanLyNguyenLieu.Save();
                    break;
            }
            EnableButtonBar();
        }

        private void barButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            switch (this.currentTabName) {
                case "TabNhanVien":
                    utcQuanLyNhanVien.Cancel();
                    break;
                case "TabKhachHang":
                    utcQuanLyKhachHang.Cancel();
                    break;
                case "TabNhomMon":
                    break;
                case "TabNguyenLieu":
                    uctQuanLyNguyenLieu.Cancel();
                    break;
            }
            EnableButtonBar();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uctQuanLyNguyenLieu.LoadData();
            uctQuanLyNguyenLieu.Dock = DockStyle.Fill;
            this.groupControlClientArea.Controls.Clear();
            this.groupControlClientArea.Controls.Add(uctQuanLyNguyenLieu);
            this.currentTabName = config.TAB_NGUYEN_LIEU;

        }


    }
}
