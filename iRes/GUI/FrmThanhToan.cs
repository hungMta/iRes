using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Title;
using Title.Config;
using Title.VO;
using Title.BUS;
using DevExpress.XtraGrid.Views.Grid;

namespace Title.GUI
{
    public partial class FrmThanhToan : Form
    {
        private UctGoiMonTheoBan uctGoiMonTheoBan;
        private string printHoaDon = "";
        private DataTable dataTable;
        Configuration config = new Configuration();
    
        public FrmThanhToan(BanAn banAn) {
            InitializeComponent();
            LoadFormThanhToan(banAn);
        }

        public void LoadHeaderHoaDon(BanAn banAn) {
            lblMaHD.Text = banAn.MaHoaDon;
            lblNgayThang.Text = DateTime.UtcNow.Date.ToString();
            DataTable dt = Bus.GetInfoKhachHangTheoMaHoaDon(banAn);
            lblMaKH.Text =  dt.Rows[0]["MaKH"].ToString();
            lblTenKH.Text = dt.Rows[0]["TenKH"].ToString();
            lblSDT.Text = dt.Rows[0]["SDT"].ToString();
            lblDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            DataTable dt_HoaDon = Bus.GetInfoHoaDonTheoBanAn(banAn);
            lblTongTien.Text = dt_HoaDon.Rows[0]["TongTien"].ToString();
        }

        public void LoadChiTietHoaDon(BanAn banAn) {
            DataTable dataTable = Bus.GetListChiTietHoaDon(banAn);
            this.dataTable = dataTable;
            this.gridControl1.DataSource = this.dataTable;
        }

        public void LoadFormThanhToan(BanAn banAn) {
            LoadHeaderHoaDon(banAn);
            LoadChiTietHoaDon(banAn);
        }

        public string getPrintHoaDon() {
            return printHoaDon;
        }

        public FrmThanhToan(UctGoiMonTheoBan uctGoiMonTheoBan) {
            // TODO: Complete member initialization
            this.uctGoiMonTheoBan = uctGoiMonTheoBan;
        }

        private void FrmThanhToan_Load(object sender, EventArgs e) {
        }

        public UctGoiMonTheoBan mainForm { get; set; }

        private void simpleButtonPrint_Click(object sender, EventArgs e) {
            PrintDocument printDialog = new PrintDocument();
            printDialog.PrintPage += new PrintPageEventHandler(printDocumentHoaDon_PrintPage);
            printDialog.Print();
            printHoaDon = config.PRINT_HOA_DON;
            printHoaDon = "printed";
            this.Close();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void simpleButtonPreview_Click(object sender, EventArgs e) {
            this.printPreviewHoaDon.Document = this.printDocumentHoaDon;
            this.printPreviewHoaDon.ShowDialog();
        }

        private void printDocumentHoaDon_PrintPage(object sender, PrintPageEventArgs e) {
            e.Graphics.DrawString("Hóa Đơn", new Font("Century", 40, FontStyle.Bold), Brushes.Red, new Point(300, 50));
            e.Graphics.DrawRectangle(Pens.Black, 100, 400, this.gridControl1.Width, this.gridControl1.Height);
            //Fills the above drawn rectangle with a light gray colour just to distinguish the header 
            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(100, 400, this.gridControl1.Width, this.gridControl1.Height));
        }
    }
}
