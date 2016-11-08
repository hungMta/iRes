using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace Login
{
    public partial class Login : Form
    {
        public Login() {
            InitializeComponent();
        }

        private void BtnLoginClick(object sender, EventArgs e) {
            this.Hide();
            frmMain frmHomepage = new frmMain();
            frmHomepage.Closed += (s, args) => this.Close();
            frmHomepage.Show();
        }

        private void Login_Load(object sender, EventArgs e) {
        }

        private void btnTest_Click(object sender, EventArgs e) {
        }
    }
}
