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
using Title.VO;
using Title.Config;
using DevExpress.XtraGrid.Views.Grid;

namespace Title.GUI {
    public partial class UctQuanLyNhomMon : UserControl {
        string feature;
        NhomMon nhomMon;
        Configuration config = new Configuration();

        public UctQuanLyNhomMon() {
            InitializeComponent();
        }

        private void UctQuanLyNhomMon_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void LoadData() {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListNhomMon();
            this.gridControlNhomMon.DataSource = dataTable;
        }

        public void Add() {
            this.feature = "Add";
            ClearTextBox();
            panelNhomMon.Enabled = true;
        }

        public void Edit() {
            this.feature = "Edit";
            panelNhomMon.Enabled = true;
        }

        public void Delete() {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                string maNhom = this.textEditMaNhom.Text;
                NhomMon nhomMon = new NhomMon();
                nhomMon.MaNhom = maNhom;
                int res = Bus.DeleteNhomMon(nhomMon);
                if (res == 1) {
                    MessageBox.Show("Đã xóa thành công!");
                    LoadData();
                }
                else {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            this.panelNhomMon.Enabled = false;
        }

        private void ClearTextBox() {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetIDNhomMon();
            textEditMaNhom.Text =dataTable.Rows[0]["MaNhom"].ToString();
            textEditTenNhom.Text = "";
            textEditTongSoMon.Text = "0";
        }

        public void Save()
        {
            try {
                string maNhom;
                string tenNhom;
                int tongSoMon;
                maNhom = textEditMaNhom.Text;
                tenNhom = textEditTenNhom.Text;
                tongSoMon = int.Parse(textEditTongSoMon.Text);
                NhomMon nhomMon = new NhomMon(maNhom, tenNhom, tongSoMon);
                if (this.feature == "Add") {
                    int res = Bus.InsertNhomMon(nhomMon);
                    if (res == 1) {
                        LoadData();
                        MessageBox.Show("Đã thay đổi thành công!!");
                        this.panelNhomMon.Enabled = false;
                    }
                }
                if (this.feature == "Edit") {
                    int res = Bus.UpdateNhomMon(nhomMon);
                    if (res == 1) {
                        LoadData();
                        MessageBox.Show("Đã thay đổi thành công!");
                        this.panelNhomMon.Enabled = false;
                    }
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadPannelBox() {
            int[] selRows = ((GridView)gridControlNhomMon.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlNhomMon.MainView).GetRow(selRows[0]));
            try {
                this.textEditMaNhom.Text = selRow[config.NHOMMON_MANHOM].ToString();
                this.textEditTenNhom.Text = selRow[config.NHOMMON_TENNHOM].ToString();
                this.textEditTongSoMon.Text = selRow[config.NHOMMON_TONGSOMON].ToString();
            }
            catch { }
        }
          
        private void gridViewNhomMon_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e) {
            LoadPannelBox();
        }

        private void gridViewNhomMon_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            LoadPannelBox();
        }
    }
}
