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
        Configuration config = new Configuration();
        public string currentAction;

        public UtcQuanLyNhanVien() {
            InitializeComponent();
        }

        public void LoadData() {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListNhanVien();
            this.gridControlNhanVien.DataSource = dataTable;
        }

        public void LoadPannelBox() {
            int[] selRows = ((GridView)gridControlNhanVien.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlNhanVien.MainView).GetRow(selRows[0]));
            this.textEditMaNV.Text = selRow[config.NHANVIEN_MANV].ToString();
            this.textEditTenNV.Text = selRow[config.NHANVIEN_TENNV].ToString();
            this.textEditSDT.Text = selRow[config.NHANVIEN_SDT].ToString();
            this.textEditQueQuan.Text = selRow[config.NHANVIEN_DIACHI].ToString();
            this.textEditLuong.Text = selRow[config.NHANVIEN_LUONG].ToString();
            this.textEditMatKhau.Text = selRow[config.NHANVIEN_MATKHAU].ToString();
            this.dateEditNgaySinh.EditValue = selRow[config.NHANVIEN_NGAYSINH];
            this.comboBoxTrangThai.Text = selRow[config.NHANVIEN_TRANGTHAI].ToString();
            this.comboBoxGioiTinh.Text = selRow[config.NHANVIEN_GIOITINH].ToString();
            this.textEditChucVu.Text = selRow[config.NHANVIEN_CHUCVU].ToString();
            this.textEditHinhAnh.Text = selRow[config.NHANVIEN_HINHANH].ToString();
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

        private void UtcQuanLyNhanVien_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            LoadPannelBox();
        }

        public void ClearText() {
            this.textEditMaNV.Text = "";
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

        public NhanVien GetNhanVienInPanelBox() {
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
            return nv;
        }

        public void Save() {
            NhanVien nv = GetNhanVienInPanelBox();
            try {
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

        public void Cancel() {
            this.panelTextBox.Enabled = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            LoadPannelBox();
        }
    }
}
