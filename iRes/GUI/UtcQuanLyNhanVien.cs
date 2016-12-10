using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Title.Config;
using Title.BUS;
using DevExpress.XtraGrid.Views.Grid;
using Title.VO;

namespace Title.GUI {
    public partial class UtcQuanLyNhanVien : UserControl {
        public UtcQuanLyNhanVien() {
            InitializeComponent();
        }

        Configuration config = new Configuration();

        public string currentAction;

        public void LoadData() {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListNhanVien();
            this.gridControlNhanVien.DataSource = dataTable;
        }

        private void UtcQuanLyNhanVien_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            int[] selRows = ((GridView)gridControlNhanVien.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlNhanVien.MainView).GetRow(selRows[0]));
            this.textEditMaNV.Text = selRow["MaNV"].ToString();
            this.textEditTenNV.Text = selRow["TenNV"].ToString();
            this.textEditSDT.Text = selRow["SDT"].ToString();
            this.textEditQueQuan.Text = selRow["DiaChi"].ToString();
            this.textEditLuong.Text = selRow["Luong"].ToString();
            this.textEditMatKhau.Text = selRow["MatKhau"].ToString();
            this.dateEditNgaySinh.EditValue = selRow["NgaySinh"];
            this.comboBoxTrangThai.Text = selRow["TrangThai"].ToString();
            this.comboBoxGioiTinh.Text = selRow["GioiTinh"].ToString();
            this.textEditChucVu.Text = selRow["ChucVu"].ToString();
            this.textEditHinhAnh.Text = selRow["HinhAnh"].ToString();
            try {
                if (this.textEditHinhAnh.Text != "") {
                    string imagePath = config.GetProjectLinkDirectory() + config.NHANVIEN_IMAGE_RESOURCE + this.textEditHinhAnh.Text;
                    this.pictureEditAvatar.Image = Image.FromFile(imagePath);
                } else {
                    string imagePath = config.GetProjectLinkDirectory() + config.NHANVIEN_IMAGE_RESOURCE+ @"male.png";
                    this.pictureEditAvatar.Image = Image.FromFile(imagePath);
                }
            } catch { }
        }

        public void ClearText() {
            this.textEditMaNV.Text = "";
            this.textEditMaNV.Text = GetMaNVNext();
            this.textEditTenNV.Text = "";
            this.textEditLuong.Text = "";
            this.textEditMatKhau.Text = "";
            this.textEditQueQuan.Text = "";
            this.textEditMatKhau.Text = "";
            this.textEditChucVu.Text = "";
            this.textEditHinhAnh.Text = "";
            this.textEditSDT.Text = "";
        }

        public void Add() {
            ClearText();
            this.panelTextBox.Enabled = true;
            this.currentAction = "Add";
        }

        public void Edit() {
            this.panelTextBox.Enabled = true;
            this.currentAction = "Edit";
        }

        public void Delete() {
            DialogResult dialogResult = MessageBox.Show("","Do you want to delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                string maNV = this.textEditMaNV.Text;
                NhanVien nv = new NhanVien();
                nv.MaNV = maNV;
                int res = Bus.DeleteNhanVien(nv);
                if (res == 1) {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                } else {
                    MessageBox.Show("Xóa không thành công");
                }
            } else {
            }
            this.panelTextBox.Enabled = false;
        }

        public void Save() {
            try {
                string maNV, tenNV, gioiTinh, SDT, diaChi, chucVu, matKhau, hinhAnh, tinhTrang;
                int luong;
                DateTime ngaySinh;
                maNV = this.textEditMaNV.Text;
                tenNV = this.textEditTenNV.Text;
                ngaySinh = (DateTime)this.dateEditNgaySinh.DateTime;
                gioiTinh = this.comboBoxGioiTinh.SelectedItem.ToString() ;
                SDT = this.textEditSDT.Text;
                diaChi = this.textEditQueQuan.Text;
                luong = int.Parse(this.textEditLuong.Text);
                chucVu = this.textEditChucVu.Text;
                matKhau = this.textEditMatKhau.Text;
                hinhAnh = this.textEditHinhAnh.Text;
                tinhTrang = this.comboBoxTrangThai.SelectedItem.ToString();
                NhanVien nv = new NhanVien(maNV, tenNV, ngaySinh, gioiTinh, SDT ,diaChi, luong, chucVu, matKhau, hinhAnh, tinhTrang);
                if (this.currentAction == "Add") {
                    int res = Bus.InsertNhanVien(nv);
                    if (res == 1) {
                        LoadData();
                        MessageBox.Show("Đã thêm mới thành công");
                        this.panelTextBox.Enabled = false;
                    }
                }
                if (this.currentAction == "Edit") {
                    int res = Bus.UpdateNhanVien(nv);
                    if (res == 1) {
                        LoadData();
                        MessageBox.Show("Đã thay đổi thành công");
                        this.panelTextBox.Enabled = false;
                    }
                }
            } catch (Exception e){
                MessageBox.Show(e.Message);
            }
        }

        private string GetMaNVNext()
        {
            DataTable dt_NV = new DataTable();
            dt_NV = Bus.GetMaNVNext();
            string maNV = dt_NV.Rows[0]["MaKH"].ToString();
            return maNV;
        }
    }
}
