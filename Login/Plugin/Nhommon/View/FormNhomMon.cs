using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Database;

namespace WindowsFormsApplication1.Views
{
    public partial class uctThucDon : UserControl
    {
        public uctThucDon()
        {
            InitializeComponent();
        }
        public static uctThucDon uctTD = new uctThucDon();

        /// <summary>
        /// Clear all text in textbox of groupbox 
        /// </summary>
        public void ClearTextBox() {
            this.txtMaNhom.Text = "";
            this.txtTenNhom.Text = "";
            this.txtSoLuongMon.Text = "";
        }

        /// <summary>
        /// Call API Read data from table Nhommon, and show the result to datagridview
        /// </summary>
        public void LoadDataGridView() {
            string strQueryReadTable = "NhomMon";
            DataSet dataset = new DataSet();
            dataset = Database.Read(strQueryReadTable);
            this.dgvNhomMon.DataSource = dataset.Tables[0];
        }

        private void uctThucDon_Load(object sender, EventArgs e) {
            LoadDataGridView();
        }

        public void ThemNhomMon() {
            string strQueryInsert =  @"insert into NhomMon(MaNhom, TenNhom, SoLuongMon)" +
                                     @" values('" + this.txtMaNhom.Text + 
                                     @" ', N'" + this.txtTenNhom.Text +
                                     @" ', " + this.txtSoLuongMon.Text +
                                     @" )";
            int res = Database.Update(strQueryInsert);
            if (res == 1) {
                MessageBox.Show("Đã thêm mới một nhóm món");
                LoadDataGridView();
            } else {
                MessageBox.Show("Nhóm món đã tồn tại");
            }
            this.btnThemSuaOk.Visible = false;
            this.btnHuybo.Visible = false;
            ClearTextBox();
        }
        
        public void SuaNhomMon() {
            int currentSelectedRowIndex = this.dgvNhomMon.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = this.dgvNhomMon.Rows[currentSelectedRowIndex];
            string strMaNhom = Convert.ToString(selectedRow.Cells["MaNhom"].Value);
            string strQueryInsert =  @"Update NhomMon" +
                                     @" Set MaNhom='" + this.txtMaNhom.Text + 
                                     @" ', TenNhom=N'" + this.txtTenNhom.Text +
                                     @" ', SoLuongMon=" + this.txtSoLuongMon.Text +
                                     @" where MaNhom='" + strMaNhom + "'";
            int res = Database.Update(strQueryInsert);
            if (res == 1) {
                MessageBox.Show("Đã thay đổi nhóm món");
                LoadDataGridView();
            } else {
                MessageBox.Show("Không thể thay đổi nhóm món này");
            }
            this.btnThemSuaOk.Visible = false;
            this.btnHuybo.Visible = false;
            ClearTextBox();
        }

        private void btnThemSuaOk_Click(object sender, EventArgs e) {
            if (this.grbThemNhomMon.Text == "Thêm nhóm món") {
                ThemNhomMon();
            } else {
                SuaNhomMon();
            }
        }

        private void btnHuybo_Click(object sender, EventArgs e) {
            this.btnThemSuaOk.Visible = false;
            this.btnHuybo.Visible = false;
            ClearTextBox();
        }

        private void btnThem_Click(object sender, EventArgs e) {
            this.grbThemNhomMon.Text = "Thêm nhóm món";
            this.txtMaNhom.Focus();
            this.btnThemSuaOk.Visible = true;
            this.btnHuybo.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e) {
            this.grbThemNhomMon.Text = "Sửa nhóm món";
            this.btnThemSuaOk.Visible = true;
            this.btnHuybo.Visible = true;
            int currentSelectedRowIndex = this.dgvNhomMon.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = this.dgvNhomMon.Rows[currentSelectedRowIndex];
            this.txtMaNhom.Text = Convert.ToString(selectedRow.Cells["MaNhom"].Value);
            this.txtTenNhom.Text = Convert.ToString(selectedRow.Cells["TenNhom"].Value);
            this.txtSoLuongMon.Text = Convert.ToString(selectedRow.Cells["SoLuongMon"].Value);
        }

        private void btnXoa_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "" ,  MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK) {
                // Get the current row
                int currentSelectedRowIndex = this.dgvNhomMon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = this.dgvNhomMon.Rows[currentSelectedRowIndex];
                string MaNhom = Convert.ToString(selectedRow.Cells["MaNhom"].Value);
                // Call API to delete row
                string strQueryDelete = "delete NhomMon where MaNhom='" + MaNhom.Trim() + "'";
                int res = Database.Delete(strQueryDelete );
                if (res == 1) {
                    MessageBox.Show("Đã xóa nhóm món thành công!");
                } else {
                    MessageBox.Show("Xóa nhóm món không thành công");
                }
                LoadDataGridView();
            } else {
            }
        }

    }
}
