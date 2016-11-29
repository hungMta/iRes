using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Title.Config;
using Title.BUS; 

namespace Title.GUI {

    public partial class UtcQuanLyKhachHang : UserControl {
        public UtcQuanLyKhachHang() {
            InitializeComponent();
        }

        Configuration config = new Configuration();

        public void LoadData() {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListKhachHang();
            this.gridControl1.DataSource = dataTable;
        }

        private void UtcQuanLyKhachHang_Load(object sender, EventArgs e) {
            LoadData();
        }

        public void Add() {
        }

        public void Edit() {
        }

        public void Delete() {
        }

        public void Save() {
        }
    }
}
