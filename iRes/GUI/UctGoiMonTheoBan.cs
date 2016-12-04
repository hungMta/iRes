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
using Title.VO;
using Title.Config;
using DevExpress.XtraGrid.Views.Grid;

namespace Title.GUI {
    public partial class UctGoiMonTheoBan : UserControl {
        List<BanAn> listBanAn = new List<BanAn>();
        Configuration config = new Configuration();

        public UctGoiMonTheoBan() {
            InitializeComponent();
            this.imageListBoxBanAn.ContextMenuStrip = this.contextMenuBanAn;
        }

        public void GetListBanAn() {
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListBanAn();
            foreach (DataRow row in dataTable.Rows) {
                string maBan = row[config.BANAN_MABAN].ToString();
                string trangThai = row[config.BANAN_TRANGTHAI].ToString();
                string maHoaDon = row[config.BANAN_MAHOADON].ToString();
                BanAn banAn = new BanAn(maBan, trangThai, maHoaDon);
                listBanAn.Add(banAn);
            }
        }

        private void UctGoiMonTheoBan_Load(object sender, EventArgs e) {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(50, 50);
            GetListBanAn();
            int i = 0;
            this.imageListBoxBanAn.ImageList = imageList;
            foreach(var banAn in listBanAn) {
                if (banAn.TrangThai == config.BANAN_TRANGTHAI_DANG_DUNG) {
                    string imagePath = config.GetProjectLinkDirectory() + config.BANAN_IMAGE_RESOURCE + @"table_red.png";
                    imageList.Images.Add(Image.FromFile(imagePath));
                } else {
                    string imagePath = config.GetProjectLinkDirectory() + config.BANAN_IMAGE_RESOURCE + @"table_green.png";
                    imageList.Images.Add(Image.FromFile(imagePath));
                }
                this.imageListBoxBanAn.Items.Add(banAn.MaBan, i);
                i++;
            }
            this.imageListBoxBanAn.ColumnWidth = 100;
        }

        private void imageListBoxBanAn_MouseMove(object sender, MouseEventArgs e) {
            Point point = this.imageListBoxBanAn.PointToClient(Cursor.Position);
            int index = this.imageListBoxBanAn.IndexFromPoint(point);
            this.imageListBoxBanAn.GetItemRectangle(index).Inflate(1, 2);
            this.imageListBoxBanAn.SelectedIndex = index;
        }

        private void imageListBoxBanAn_Click(object sender, EventArgs e) {
            int index = this.imageListBoxBanAn.SelectedIndex;
            try {
                DataTable dataTable = Bus.GetListChiTietHoaDon(listBanAn[index]);
                this.gridControlBanAnGoiMon.DataSource = dataTable;
            } catch { }
            this.labelControl1.Text = "Bàn " + listBanAn[index].MaBan;
        }

        private void simpleButtonThemMon_Click(object sender, EventArgs e) {
            this.groupControlThemMon.Enabled = true;
            DataTable dataTableMonAn = new DataTable();
            dataTableMonAn = Bus.GetListMonAn();
            this.gridControlSearchMonAn.DataSource = dataTableMonAn;

            DataTable dataTableNhomMon = new DataTable();
            dataTableNhomMon = Bus.GetListNhomMon();
            try {
                this.lookUpEditNhomMon.Properties.DisplayMember = "TenNhom";
                this.lookUpEditNhomMon.Properties.ValueMember= "MaNhom";
                this.lookUpEditNhomMon.Properties.DataSource = dataTableNhomMon;
            } catch { }
        }

        private void gridControlSearchMonAn_Click(object sender, EventArgs e) {
            int[] selRows = ((GridView)gridControlSearchMonAn.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlSearchMonAn.MainView).GetRow(selRows[0]));
            this.textEditMaMon.Text = selRow["MaMon"].ToString();
            this.textEditTenMon.Text = selRow["TenMon"].ToString();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e) {
        }
    }
}
