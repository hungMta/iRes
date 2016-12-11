using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Title.Config;
using Title.BUS;
using DevExpress.XtraGrid.Views.Grid;
using Title.VO;

namespace Title.GUI
{

    public partial class UtcQuanLyKhachHang : UserControl
    {
        public UtcQuanLyKhachHang()
        {
            InitializeComponent();
        }

        Configuration config = new Configuration();
        KhachHang khachHang;
        string feature;

        public void LoadData()
        {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListKhachHang();
            this.gridControlKhachHang.DataSource = dataTable;
        }

        private void UtcQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void Add() {
            feature = "add";
            clearTextBox();
            panelTextBox.Enabled = true;
        }

        public void Edit() {
            feature = "edit";
            panelTextBox.Enabled = true;
        }

        public void Delete() {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            getKhachHang();
            if (dialogResult == DialogResult.Yes)
            try {
               int res = Bus.DeleteKhachHang(khachHang);
               LoadData();
            }
            catch (Exception e) {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        public void Save() {
            int res = 0;
            getKhachHang();
            if (feature == "add") {
                res = Bus.InsertKhachHang(khachHang);
                if (res == 1) {
                    MessageBox.Show("Thêm thành công!");
                } else {
                    MessageBox.Show("Thêm không thành công!");
                }
            }

            if (feature == "edit") {
                res = Bus.UpdateKhachHang(khachHang);
                if (res == 1) {
                    MessageBox.Show("Sửa thành công!");
                } else {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            LoadData();
            clearTextBox(); 
            this.panelTextBox.Enabled = false;
        }

        public void Cancel() {
            this.panelTextBox.Enabled = false;
        }

        private void getKhachHang() {
            int solan;
            decimal tongTien;

            string ma = textEditMaKH.Text;
            string ten = textEditTen.Text;
            string diachi = textEditDiaChi.Text;
            string sdt = textEditSDT.Text;
            string email = textEditEmail.Text;
            try {
                solan = int.Parse(textEditSoLanAn.Text);
            } catch {
                solan = 0;
            }
            try {
                tongTien = decimal.Parse(textEditTongChi.Text);
            } catch {
                tongTien = 0;
            }
            string phanloai = cbxPhanLoai.Text;
            khachHang = new KhachHang(ma, ten, diachi, sdt, email, solan, tongTien, phanloai);
        }

        private void clearTextBox() {
            textEditMaKH.Text = "";
            textEditTen.Text = "";
            textEditDiaChi.Text = "";
            textEditSDT.Text = "";
            textEditEmail.Text = "";
            textEditSoLanAn.Text = "0";
            textEditTongChi.Text = "0";
            cbxPhanLoai.Text = "";
        }

        public void LoadGroupBoxKhachHang() {
            int[] selRows = ((GridView)gridControlKhachHang.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlKhachHang.MainView).GetRow(selRows[0]));
            try {
                this.textEditMaKH.Text = selRow[config.KHACHHANG_MAKH].ToString();
                this.textEditTen.Text = selRow[config.KHACHHANG_TENKH].ToString();
                this.textEditDiaChi.Text = selRow[config.KHACHHANG_DIACHI].ToString();
                this.textEditSDT.Text = selRow[config.KHACHHANG_SDT].ToString();
                this.textEditEmail.Text = selRow[config.KHACHHANG_EMAIL].ToString();
                this.textEditSoLanAn.Text = selRow[config.KHACHHANG_SOLANAN].ToString();
                this.textEditTongChi.Text = selRow[config.KHACHHANG_TONGTIEN].ToString();
                this.cbxPhanLoai.Text = selRow[config.KHACHHANG_PHANLOAI].ToString();
            } catch { }
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e) {
            LoadGroupBoxKhachHang();
        }

        private void gridViewKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            LoadGroupBoxKhachHang();
        }
    }
}
