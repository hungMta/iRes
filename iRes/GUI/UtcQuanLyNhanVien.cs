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

namespace Title.GUI {
    public partial class UtcQuanLyNhanVien : UserControl {
        public UtcQuanLyNhanVien() {
            InitializeComponent();
        }

        Configuration config = new Configuration();

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
            this.textEditQueQuan.Text = selRow["QueQuan"].ToString();
            this.textEditLuong.Text = selRow["Luong"].ToString();
            this.textEditMatKhau.Text = selRow["MatKhau"].ToString();
            this.dateEditNgaySinh.EditValue = selRow["NgaySinh"];
        }

        public void Add() {
        }

        public void Edit() {
        }

        public void Delete() {
            DialogResult dialogResult = MessageBox.Show("","Do you want to delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
            } else {
            }
        }

        public void Save() {
        }

    }
}
