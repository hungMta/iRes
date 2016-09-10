using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        internal static List<byte> typePages = new List<byte>();  // ???  kieu byte???
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            
            // kiem tra ton tai cua trang nay chua
            for (int i = 0; i < tabHienThi.TabPages.Count; i++ )
            {
                if (tabHienThi.TabPages[i].Contains(uct) == true)
                {
                    
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
            //uct.Focus();
        }
        // Dong tab hien tai 
        public void DongTabHienTai()
        {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTab);
        }
        //Dong all tab
        public void DongAllTab()
        {
            while (tabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }


        private void đặtMónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( exit == DialogResult.Yes)
            {
                this.Close();
            } 
            else
            {
                return;
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctNhanVien.uctNV,4,"Quản lý nhân viên");
        }

        private void trựcTiếpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctGoiMonTrucTiep.uctGMTT, 4, "Gọi món trực tiếp");
        }

        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctThucDon.uctTD, 4, "Quản lý thực đơn");
        }

        private void đóngTrangHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngTấtCảCáTrangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }


       
    }
}
