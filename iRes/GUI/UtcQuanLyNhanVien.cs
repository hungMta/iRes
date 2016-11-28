using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Title.GUI {
    public partial class UtcQuanLyNhanVien : UserControl {
        public UtcQuanLyNhanVien() {
            InitializeComponent();
        }

        private void UtcQuanLyNhanVien_Load(object sender, EventArgs e) {
            this.nhanVienTableAdapter1.Fill(this.iResDatabaseDataSet2.NhanVien);
        }
    }
}
