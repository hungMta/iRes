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
    }
}
