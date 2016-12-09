using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Title.BUS;
using Title.Config;
using iRes;

namespace Title.GUI {
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm {
        public FrmLogin() {
            InitializeComponent();
        }

        Configuration config = new Configuration();
        string passWord;
        DataTable dataTableNhanVien;

        private void frmLogin_Load(object sender, EventArgs e) {
            dataTableNhanVien = Bus.GetListNhanVien();
            this.lookUpEditUsername.Properties.DataSource = dataTableNhanVien;
            this.lookUpEditUsername.Properties.DisplayMember = "TenNV";
            this.lookUpEditUsername.Properties.ValueMember = "MatKhau";
            this.lookUpEditUsername.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(lookUpEditUsername.Properties.DisplayMember));
        }

        private void lookUpEditUsername_EditValueChanged(object sender, EventArgs e) {
            this.passWord = this.lookUpEditUsername.EditValue.ToString();
        }

        private void simpleButtonLogin_Click(object sender, EventArgs e) {
            string passWord = this.textEditPassword.Text;
            if (passWord.Trim() == this.passWord.Trim()) {
                this.Hide();
                frmMain main = new frmMain();
                main.Closed += (s, args) => this.Close();
                main.Show();
            } else {
                this.labelControlShowInfo.Text = "* Sai mật khẩu";
                this.labelControlShowInfo.Visible = true;
                this.labelControlShowInfo.BackColor = Color.Red;

            }
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}