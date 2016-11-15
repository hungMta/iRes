using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain() {
            InitializeComponent();
        }

        internal static List<byte> typePages = new List<byte>();  

        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab) {
            // kiem tra ton tai cua trang nay chua
            for (int i = 0; i < tabHienThi.TabPages.Count; i++ ) {
                if (tabHienThi.TabPages[i].Contains(uct) == true) {
                    tabHienThi.SelectedTab = tabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = tenTab;
            tabHienThi.TabPages.Add(tab);
            tabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
        }
     
        public void DongTabHienTai() {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTab);
        }

        public void DongAllTab() {
            while (tabHienThi.TabPages.Count > 0) {
                DongTabHienTai();
            }
        }


        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e) {
            DialogResult exit = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( exit == DialogResult.Yes) {
                this.Close();
            } 
            else {
                return;
            }
        }

        private void mnuDongTrangHienTai_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void mnuDongTatCaCacTrang_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }
        
        private void tabThucDon_Click(object sender, EventArgs e) {
        }

        private void mnuQuanLyNhomMon_Click(object sender, EventArgs e) {
            ThemTabPages(Views.uctThucDon.uctTD, 4, "Quản lý nhóm món");
        }

        private void mnuQuanLyMonAn_Click(object sender, EventArgs e) {
            ThemTabPages(Login.Plugin.MonAn.View.UctMonAn.uctMonAn, 4, "Quản lý món ăn");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ThemTabPages(Login.Plugin.NhanVien.View.UctNhanVien.uctNhanVien, 4, "Quản lý nhân viên");
        }
    }
}
