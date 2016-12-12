using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Title.BUS;
using Title.Config;
using Title.VO;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid.Views.Grid;

namespace Title.GUI {
    public partial class UctNhapHang : UserControl {
        public UctNhapHang() {
            InitializeComponent();
        }

        PhieuNhap currrentPhieuNhap = new PhieuNhap();

        Configuration config = new Configuration();

        private void UctNhapHang_Load(object sender, EventArgs e) {
            LoadGridViewPhieuNhap();
        }

        public void LoadChiTietPhieuNhap() {
        }

        public void LoadGridViewPhieuNhap() {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListPhieuNhap();
            this.gridControlPhieuNhap.DataSource = dataTable;
        }

        public void LoadLookUpEditNguyenLieu() {
            DataTable dataTableNguyenLieu = new DataTable();
            dataTableNguyenLieu = Bus.GetListNguyenLieu();
            try {
                this.lookUpEditNguyenLieu.Properties.DisplayMember = config.NGUYEN_LIEU_TEN_NGUYEN_LIEU;
                this.lookUpEditNguyenLieu.Properties.ValueMember = config.NGUYEN_LIEU_MA_NGUYEN_LIEU;
                this.lookUpEditNguyenLieu.Properties.DataSource = dataTableNguyenLieu;
            } catch { }
        }

        public void ClearTextBox() {
            this.textEditDonGia.Text = "";
            this.textEditSoLuong.Text = "";
        }

        public void ClearLabel() {
            this.labelControlTenNguyenLieu.Visible = false;
            this.labelControlSoLuong.Visible = false;
            this.labelControlDonGia.Visible = false;
        }

        public bool CheckInfoTextBox() {
            ClearLabel();
            Regex regexNumberOnly = new Regex("^[0-9]+$", RegexOptions.Compiled);
            bool resMaNguyenLieu = !string.IsNullOrEmpty(this.lookUpEditNguyenLieu.Text);
            bool resSoLuong = regexNumberOnly.IsMatch(this.textEditSoLuong.Text);
            bool resDonGia = regexNumberOnly.IsMatch(this.textEditDonGia.Text);

            if (resMaNguyenLieu != true) {
                this.labelControlTenNguyenLieu.Text = "* Bắt buộc phải chọn nguyên liệu";
                this.labelControlTenNguyenLieu.BackColor = Color.Red;
                this.labelControlTenNguyenLieu.Visible = true;
            }
            if (resSoLuong != true) {
                this.labelControlSoLuong.Text = "* Bắt buộc. Phải là số";
                this.labelControlSoLuong.BackColor = Color.Red;
                this.labelControlSoLuong.Visible = true;
            }
            if (resDonGia != true) {
                this.labelControlDonGia.Text = "* Bắt buộc. Phải là số";
                this.labelControlDonGia.BackColor = Color.Red;
                this.labelControlDonGia.Visible = true;
            }
            bool res = resMaNguyenLieu & resDonGia & resSoLuong;
            return res;
        }

        private void simpleButtonThemPhieuNhap_Click(object sender, EventArgs e) {
            this.simpleButtonThemPhieuNhap.Enabled = false;
            this.simpleButtonHuyPhieuNhap.Enabled = true;
            this.groupControlChiTietPhieuNhap.Enabled = true;
            this.groupControlPhieuNhap.Enabled = true;
            LoadChiTietPhieuNhap();
            LoadLookUpEditNguyenLieu();
        }

        private void simpleButtonHuyPhieuNhap_Click(object sender, EventArgs e) {
            this.simpleButtonThemPhieuNhap.Enabled = true;
            this.simpleButtonHuyPhieuNhap.Enabled = false;
            this.groupControlChiTietPhieuNhap.Enabled = false;
            this.currrentPhieuNhap = new PhieuNhap();
            ShowLabelControlMaPhieuNhap();
        }

        public void CreatePhieuNhap() {
            if (this.currrentPhieuNhap.MaPhieuNhap == null) {
                DateTime currentTime = DateTime.Now;
                this.currrentPhieuNhap = new PhieuNhap("", 0, currentTime, config.CURRENT_NHAN_VIEN);
                int res = Bus.InsertPhieuNhap(this.currrentPhieuNhap);
                this.currrentPhieuNhap.MaPhieuNhap = Bus.GetLastPhieuNhap().Rows[0][config.PHIEU_NHAP_MA_PHIEU_NHAP].ToString();
            }
        }

        public void CreateNewChiTietPhieuNhap() {
            string maPhieuNhap = this.currrentPhieuNhap.MaPhieuNhap;
            string maNguyenLieu = this.lookUpEditNguyenLieu.EditValue.ToString();
            int donGia = int.Parse(this.textEditDonGia.Text);
            int soLuong = int.Parse(this.textEditSoLuong.Text);
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap(maPhieuNhap, maNguyenLieu, donGia, soLuong, 0, "");
            int res = Bus.InsertChiTietPhieuNhap(chiTietPhieuNhap);
        }

        private void simpleButtonThemChiTiet_Click(object sender, EventArgs e) {
            bool res = CheckInfoTextBox();
            if (res) {
                CreatePhieuNhap();
                CreateNewChiTietPhieuNhap();
                LoadGridViewPhieuNhap();
                LoadGridViewChiTietPhieuNhap(this.currrentPhieuNhap.MaPhieuNhap);
            }
        }

        private void simpleButtonHuyChiTiet_Click(object sender, EventArgs e) {
            ClearTextBox();
            ClearLabel();
        }

        public void LoadGridViewChiTietPhieuNhap(string maPhieuNhap) {
            DataTable dataTableChiTietPhieuNhap = Bus.GetChiTietPhieuNhapByMaPhieuNhap(maPhieuNhap);
            this.gridControlChiTietPhieuNhap.DataSource = dataTableChiTietPhieuNhap;
        }

        public void ShowLabelControlMaPhieuNhap() {
            this.labelControlMaPhieuNhap.Text = this.currrentPhieuNhap.MaPhieuNhap;
            this.labelControlMaPhieuNhap.Visible = true;
        }

        private void gridViewPhieuNhap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            int[] selRows = ((GridView)gridControlPhieuNhap.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlPhieuNhap.MainView).GetRow(selRows[0]));
            string maPhieuNhap = selRow[config.PHIEU_NHAP_MA_PHIEU_NHAP].ToString();

            try {
                this.currrentPhieuNhap.MaPhieuNhap = maPhieuNhap;
                ShowLabelControlMaPhieuNhap();
                LoadGridViewChiTietPhieuNhap(this.currrentPhieuNhap.MaPhieuNhap);
            } catch { }

        }
    }
}
