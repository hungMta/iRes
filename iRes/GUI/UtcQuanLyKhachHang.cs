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
            this.gridControl1.DataSource = dataTable;
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
                MessageBox.Show("Xóa thành công!");
            }
        }

        public void Save() {
            DialogResult dialogResult = MessageBox.Show(  "Bạn có muốn lưu thông tin?","Thông báo", MessageBoxButtons.YesNo);
            getKhachHang();
            if (dialogResult == DialogResult.Yes) {
                int res = 0;
                if (feature == "add") {
                    try {
                        res = Bus.InsertKhachHang(khachHang);
                      }
                      catch (Exception e) {
                         MessageBox.Show("Thêm thành công!");
                      }
                }

                if (feature == "edit") {
                    try {
                         res = Bus.UpdateKhachHang(khachHang);
                      }
                      catch (Exception e) {
                         MessageBox.Show("Sửa thành công!");
                      }
                }

                if (res != -1) {
                    MessageBox.Show("Lưu thành công!");
                }
                LoadData();
            }
            else if (dialogResult == DialogResult.No) {
                panelTextBox.Enabled = false;
            }
            clearTextBox(); 
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

        private void gridView1_RowClick(object sender, RowClickEventArgs e) {
            int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));
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
    }
}
