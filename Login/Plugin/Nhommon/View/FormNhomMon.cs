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

        public void ClearTextBox() {
            this.txtMaNhom.Text = "";
            this.txtTenNhom.Text = "";
            this.txtTongSoMon.Text = "";
        }

        public void LoadDataGridView() {
            string strQueryReadTable = "NhomMon";
            DataSet dataset = new DataSet();
            dataset = Database.Read(strQueryReadTable);
            this.dgvNhomMon.DataSource = dataset.Tables[0];
        }

        private void dgvNhomMon_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        }

        private void btnSua_Click(object sender, EventArgs e) {
        }

        private void uctThucDon_Load(object sender, EventArgs e) {
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e) {
            this.txtMaNhom.Focus();
            this.btnAddNhomMon.Visible = true;
            this.btnHuybo.Visible = true;
        }

        private void Thêm_Click(object sender, EventArgs e) {
            string strQueryInsert =  @"insert into NhomMon(MaNhom, TenNhom, SoLuongMon)" +
                                     @" values('" + this.txtMaNhom.Text + 
                                     @" ', N'" + this.txtTenNhom.Text +
                                     @" ', " + this.txtTongSoMon.Text +
                                     @" )";
            int res = Database.Update(strQueryInsert);
            if (res == 1) {
                MessageBox.Show("Đã thêm mới một nhóm món");
                LoadDataGridView();
            } else {
                MessageBox.Show("Nhóm món đã tồn tại");
            }
            this.btnAddNhomMon.Visible = false;
            this.btnHuybo.Visible = false;
            ClearTextBox();
        }

        private void btnHuybo_Click(object sender, EventArgs e) {
            this.btnAddNhomMon.Visible = false;
            this.btnHuybo.Visible = false;
            ClearTextBox();
        }
    }
}
