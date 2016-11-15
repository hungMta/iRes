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

namespace Login.Plugin.MonAn.View {
    public partial class UctMonAn : UserControl {
        public UctMonAn() {
            InitializeComponent();
        }

        public static UctMonAn uctMonAn = new UctMonAn();

        public void LoadDataGridView() {
            string strTableName = "MonAn";
            string strQuerySelect = "Select * from MonAn";
            DataSet dataset = new DataSet();
            dataset = Database.Database.Read(strTableName, strQuerySelect);
            this.dgvMonAn.DataSource = dataset.Tables[0];
        }

        private void UctMonAn_Load(object sender, EventArgs e) {
            LoadDataGridView();
        }

        private void btnThem_Click(object sender, EventArgs e) {
            this.grbThemMonAn.Text = "Thêm món ăn";
            this.txtMaMon.Focus();
            this.btnThemSuaOk.Enabled = true;
            this.btnHuybo.Enabled = true;
        }

        private void btnThemSuaOk_Click(object sender, EventArgs e) {
            this.grbThemMonAn.Text = "Sửa món ăn";
            this.btnThemSuaOk.Enabled = false;
            this.btnHuybo.Enabled = false;
        }

        private void btnHuybo_Click(object sender, EventArgs e) {
            this.btnThemSuaOk.Enabled = false;
            this.btnHuybo.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e) {
            //if (this.grbThemNhomMon.Text == "Thêm nhóm món") {
            //    ThemNhomMon();
            //} else {
            //    SuaNhomMon();
            //}
            this.btnThemSuaOk.Enabled = false;
            this.btnHuybo.Enabled = false;
        }
    }
}
