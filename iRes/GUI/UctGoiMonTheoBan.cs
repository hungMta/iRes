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
        BanAn banAnHienTai;

        public UctGoiMonTheoBan() {
            InitializeComponent();
            this.imageListBoxBanAn.ContextMenuStrip = this.contextMenuBanAn;
            this.gridControlBanAnGoiMon.ContextMenuStrip = this.contextMenuStripChiTietHD;
        }

        public void GetListBanAn() {
            listBanAn.Clear();
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

        public void LoadHoaDon() {
            this.labelControl1.Text = "Bàn " + this.banAnHienTai.MaBan;
            this.textEditMaHoaDon.Text = this.banAnHienTai.MaHoaDon;
            if (this.textEditMaHoaDon.Text == "") {
                simpleButtonSua.Enabled = false;
            } 
            try {
                DataTable dt_HoaDon = Bus.GetInfoHoaDon(this.banAnHienTai.MaHoaDon);
                this.textEditChietKhau.Text = dt_HoaDon.Rows[0][config.HOA_DON_CHIET_KHAU].ToString();
            }
            catch { }

            LoadListChiTietHoaDon();
            LoadLookUpEditKhachHang();
            SetLookUpEditKhachHangText();

            lookUpEditKH.Enabled = false;
            textEditChietKhau.Enabled = false;
            simpleButtonLuu.Enabled = false;
            simpleButtonSua.Enabled = true;
        }

        public void LoadLookUpEditKhachHang() {
            DataTable dataTableKH = new DataTable();
            dataTableKH = Bus.GetListKhachHang();
            try {
                this.lookUpEditKH.Properties.DisplayMember = config.HOA_DON_MA_KHACH_HANG;
                this.lookUpEditKH.Properties.ValueMember = config.HOA_DON_MA_KHACH_HANG;
                this.lookUpEditKH.Properties.DataSource = dataTableKH;
            }
            catch { }
        }

        public void SetLookUpEditKhachHangText() {
            DataTable dt = Bus.GetInfoKhachHangTheoMaHoaDon(this.banAnHienTai);
            try {
                this.lookUpEditKH.Text = dt.Rows[0][config.HOA_DON_MA_KHACH_HANG].ToString();
            }
            catch { }
        }

        public void LoadListChiTietHoaDon() {
            try {
                DataTable dataTable = Bus.GetListChiTietHoaDon(this.banAnHienTai);
                this.gridControlBanAnGoiMon.DataSource = null;
                this.gridViewBanAnGoiMon.Columns.Clear();
                this.gridControlBanAnGoiMon.DataSource = dataTable;
            } catch { }
        }

        public void LoadImageListBoxBanAn() {
            this.imageListBoxBanAn.Items.Clear();
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

        public void LoadGridControlMonAn() {
            DataTable dataTableMonAn = new DataTable();
            dataTableMonAn = Bus.GetListMonAn();
            this.gridControlSearchMonAn.DataSource = null;
            this.gridControlSearchMonAn.DataSource = dataTableMonAn;
        }

        public void LoadLookUpEditNhomMon() {
            DataTable dataTableNhomMon = new DataTable();
            dataTableNhomMon = Bus.GetListNhomMon();
            try {
                this.lookUpEditNhomMon.Properties.DisplayMember = "TenNhom";
                this.lookUpEditNhomMon.Properties.ValueMember = "MaNhom";
                this.lookUpEditNhomMon.Properties.DataSource = dataTableNhomMon;
            } catch { }
        }

        private void UctGoiMonTheoBan_Load(object sender, EventArgs e) {
            LoadImageListBoxBanAn();
        }

        private void imageListBoxBanAn_MouseMove(object sender, MouseEventArgs e) {
            Point point = this.imageListBoxBanAn.PointToClient(Cursor.Position);
            int index = this.imageListBoxBanAn.IndexFromPoint(point);
            this.imageListBoxBanAn.GetItemRectangle(index).Inflate(1, 2);
            this.imageListBoxBanAn.SelectedIndex = index;
        }

        private void imageListBoxBanAn_Click(object sender, EventArgs e) {
            try {
                int index = this.imageListBoxBanAn.SelectedIndex;
                this.banAnHienTai = listBanAn[index];
                LoadHoaDon();
            } catch { }
        }

        private void simpleButtonGoiMon_Click(object sender, EventArgs e) {
            textEditChietKhau.Enabled = false;
            simpleButtonSua.Enabled = true;
            simpleButtonLuu.Enabled = false;
            this.groupControlThemMon.Enabled = true;

            LoadGridControlMonAn();
            LoadLookUpEditNhomMon();

        }

        private void gridControlSearchMonAn_Click(object sender, EventArgs e) {
            int[] selRows = ((GridView)gridControlSearchMonAn.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlSearchMonAn.MainView).GetRow(selRows[0]));
            this.lookUpEditMaMon.Properties.DataSource = null;
            this.lookUpEditMaMon.Properties.NullText = selRow["MaMon"].ToString();
            this.textEditTenMon.Text = selRow["TenMon"].ToString();
        }

        private void lookUpEditNhomMon_EditValueChanged(object sender, EventArgs e) {
            string maNhomMon = this.lookUpEditNhomMon.EditValue.ToString();
            DataTable dataTable = new DataTable();
            dataTable = Bus.GetListMonAnByNhomMon(maNhomMon);
            this.gridControlSearchMonAn.DataSource = dataTable;
            try {
                this.lookUpEditMaMon.Properties.DisplayMember = "MaMon";
                this.lookUpEditMaMon.Properties.ValueMember= "TenMon";
                this.lookUpEditMaMon.Properties.DataSource = dataTable;
            } catch { }
        }

        private void lookUpEditMaMon_EditValueChanged(object sender, EventArgs e) {
            this.textEditTenMon.Text = this.lookUpEditMaMon.EditValue.ToString();
        }

        public void CreateChiTietHoaDon() {
            try {
                int soLuong = int.Parse(this.textEditSoLuong.Text);
                string maMon = this.lookUpEditMaMon.Text.ToString();
                string maHoaDon = this.banAnHienTai.MaHoaDon;
                if (soLuong <= 0 ) {
                    MessageBox.Show("Số lượng phải lớn hơn 0");
                } else {
                    if (maMon == "") {
                        MessageBox.Show("Nhập đầy đủ thông tin");
                    } else {
                        ChiTietHoaDon chitietHoaDon = new ChiTietHoaDon(maHoaDon, maMon, soLuong);
                        Bus.InsertChiTietHoaDon(chitietHoaDon);
                    }
                }
            } catch {
                MessageBox.Show("Nhập đầy đủ thông tin");
            }
        }

        private void simpleButtonThem_Click(object sender, EventArgs e) {
            if (this.banAnHienTai == null) {
                MessageBox.Show("Chưa chọn bàn");
            } else {
                if (this.banAnHienTai.MaHoaDon != "") {
                    CreateChiTietHoaDon();
                    LoadHoaDon();
                    LoadGridControlMonAn();
                } else {
                    try {
                        int soLuong = int.Parse(this.textEditSoLuong.Text);
                        string maMon = this.lookUpEditMaMon.Text.ToString();
                        string maHoaDon = this.banAnHienTai.MaHoaDon;
                        if (soLuong <= 0 ) {
                            MessageBox.Show("Số lượng phải lớn hơn 0");
                        } else {
                            if (maMon == "") {
                                MessageBox.Show("Nhập đầy đủ thông tin");
                            } else {
                                DateTime currentTime = DateTime.Now;
                                string maNV = "NV001";
                                int chietKhau = int.Parse(textEditChietKhau.Text);
                                string maKH = this.lookUpEditKH.Text;
                                HoaDon hoaDon = new HoaDon(currentTime, maKH, maNV, 0, chietKhau, 0);
                                int res = Bus.InsertHoaDon(hoaDon);
                                if (res == 1) {
                                    DataTable dataTable = new DataTable();
                                    dataTable = Bus.GetLastHoaDon();
                                    string maHD = dataTable.Rows[0]["MaHD"].ToString();
                                    this.textEditMaHoaDon.Text = maHD;
                                    this.banAnHienTai.TrangThai = "Đang dùng";
                                    this.banAnHienTai.MaHoaDon = maHD;
                                    Bus.UpdateBanAn(banAnHienTai);
                                    CreateChiTietHoaDon();
                                    LoadHoaDon();
                                    LoadImageListBoxBanAn();
                                    LoadGridControlMonAn();
                                    Console.WriteLine();
                                }
                            }
                        }
                    } catch {
                        MessageBox.Show("Nhập đầy đủ thông tin");
                    }
                }
            }
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e) {
            this.groupControlThemMon.Enabled = false;
        }

        private void simpleButtonThanhToan_Click(object sender, EventArgs e) {
            if (this.banAnHienTai.MaHoaDon != "") {
                FrmThanhToan frmThanhToan = new FrmThanhToan(this.banAnHienTai);
                frmThanhToan.ShowDialog();
                if (frmThanhToan.getPrintHoaDon().Equals(config.PRINT_HOA_DON)) {
                    MessageBox.Show(banAnHienTai.MaBan + "Đã thanh toán và in hóa đơn");
                    Bus.setBanAnTrong(this.banAnHienTai);
                    LoadImageListBoxBanAn();
                    LoadHoaDon();
                }
            }
        }

        private void simpleButtonEditMaKH_Click(object sender, EventArgs e) {
            textEditChietKhau.Enabled = true;
            simpleButtonLuu.Enabled = true;
            simpleButtonSua.Enabled = false;
            lookUpEditKH.Enabled = true;
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e) {
            textEditChietKhau.Enabled = false;
            simpleButtonLuu.Enabled = false;
            simpleButtonSua.Enabled = true;
            lookUpEditKH.Enabled = false;
            DateTime currentTime = DateTime.Now;
            string maHD = this.banAnHienTai.MaHoaDon;
            string maNV = "NV001";
            int chietKhau = int.Parse(textEditChietKhau.Text);
            string maKH = lookUpEditKH.Text;
            HoaDon hoaDon = new HoaDon(maHD,currentTime, maKH, maNV, 0, chietKhau, 0);
            int res = Bus.EditHoaDon(hoaDon);
        }

        private void SuaCTHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gridControlBanAnGoiMon.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlBanAnGoiMon.MainView).GetRow(selRows[0]));
            string maMon = selRow[config.CHI_TIET_HOA_DON_MA_MON].ToString();
            int soLuong = int.Parse(selRow[config.CHI_TIET_HOA_DON_SO_LUONG].ToString());
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(this.banAnHienTai.MaHoaDon, maMon, soLuong);
            FrmSuaChiTietHoaDon frmSuaChiTietHoaDon = new FrmSuaChiTietHoaDon(chiTietHoaDon);
            frmSuaChiTietHoaDon.ShowDialog();
            LoadListChiTietHoaDon();
        }

        private void XoaCTHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gridControlBanAnGoiMon.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControlBanAnGoiMon.MainView).GetRow(selRows[0]));
            string maMon = selRow[config.CHI_TIET_HOA_DON_MA_MON].ToString();
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
            chiTietHoaDon.MaMon = maMon;
            chiTietHoaDon.MaHoaDon = textEditMaHoaDon.Text;
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int res = Bus.DeleteChiTietHoaDon(chiTietHoaDon);
                if (res == -1)
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                else
                {
                    MessageBox.Show("Đã xóa thành công!");
                    LoadListChiTietHoaDon();
                }
            }
        }
    }
}
