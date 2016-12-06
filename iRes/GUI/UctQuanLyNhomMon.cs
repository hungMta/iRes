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

namespace Title.GUI {
    public partial class UctQuanLyNhomMon : UserControl {
        public UctQuanLyNhomMon() {
            InitializeComponent();
        }

        private void UctQuanLyNhomMon_Load(object sender, EventArgs e) {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListNhomMon();
            this.gridControlNhomMon.DataSource = dataTable;
        }
    }
}
