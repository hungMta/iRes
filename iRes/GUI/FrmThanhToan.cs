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

        private BanAn banAn;
        public FrmThanhToan(BanAn banAn) {
            InitializeComponent();
            this.banAn = banAn;
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



            System.Drawing.Image img = System.Drawing.Image.FromFile("C:/Users/Tran/Documents/Visual Studio 2012/Projects/iRes/iRes/Resources/BanAn/table_Red.png");
            Point loc = new Point(100, 100);
            e.Graphics.DrawImage(img, loc);  









           // e.Graphics.DrawImage(@"C:\Users\Tran\Documents\Visual Studio 2012\Projects\iRes\iRes\Resources\BanAn\table_Red", e.PageBounds);
            e.Graphics.DrawString("Hóa Đơn", new Font("Century", 40, FontStyle.Bold), Brushes.Red, new Point(300, 50));
            e.Graphics.DrawString("Mã hóa đơn : " + this.lblMaHD.Text,new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("Thời gian : " + this.lblNgayThang.Text,new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(450, 160));
            e.Graphics.DrawString("Mã khách hàng  : " + this.lblMaKH.Text, new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Số Đt  : " + this.lblSDT.Text, new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString("Tên khách hàng  : " + this.lblTenKH.Text, new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(10, 240));
            e.Graphics.DrawString("Địa chỉ  : " + this.lblDiaChi.Text, new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(500, 240));
            e.Graphics.DrawString("Tổng tiền  : " + this.lblTongTien.Text + "VND", new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(500, 280));

            for (int i = 10; i <= 820; i++)
            {
                e.Graphics.DrawString("_", new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(i, 310));
            }

            e.Graphics.DrawString("Tên món", new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(20, 340));
            e.Graphics.DrawString("Tên nhóm", new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(200, 340));
            e.Graphics.DrawString("Số lượng", new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(400, 340));
            e.Graphics.DrawString("Đơn giá", new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(500, 340));
            e.Graphics.DrawString("Thành tiền", new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(700, 340));

            for (int i = 10; i <= 820; i++)
            {
                e.Graphics.DrawString("_", new Font("Century", 15, FontStyle.Bold), Brushes.Black, new Point(i, 340));
            }
            int y = 380;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                
                string TenMon = dataTable.Rows[i]["TenMon"].ToString();
                e.Graphics.DrawString(TenMon, new Font("Century", 10, FontStyle.Bold), Brushes.Black, new Point(20, y));
                y = y + 30;
            }

             y = 380;
             for (int i = 0; i < dataTable.Rows.Count; i++)
             {

                 string TenMon = dataTable.Rows[i]["TenNhom"].ToString();
                 e.Graphics.DrawString(TenMon, new Font("Century", 10, FontStyle.Bold), Brushes.Black, new Point(200, y));
                 y = y + 30;
             }

             y = 380;
             for (int i = 0; i < dataTable.Rows.Count; i++)
             {

                 string TenMon = dataTable.Rows[i]["SoLuong"].ToString();
                 e.Graphics.DrawString(TenMon, new Font("Century", 10, FontStyle.Bold), Brushes.Black, new Point(400, y));
                 y = y + 30;
             }

             y = 380;
             for (int i = 0; i < dataTable.Rows.Count; i++)
             {

                 string TenMon = dataTable.Rows[i]["GiaMon"].ToString();
                 e.Graphics.DrawString(TenMon, new Font("Century", 10, FontStyle.Bold), Brushes.Black, new Point(500, y));
                 y = y + 30;
             }

             y = 380;
             for (int i = 0; i < dataTable.Rows.Count; i++)
             {

                 string TenMon = dataTable.Rows[i]["ThanhTien"].ToString();
                 e.Graphics.DrawString(TenMon, new Font("Century", 10, FontStyle.Bold), Brushes.Black, new Point(700, y));
                 y = y + 30;
             }

             for (int i = 0; i < dataTable.Rows.Count; i++)
             {

                 string TenMon = dataTable.Rows[i]["GhiChu"].ToString();
                 e.Graphics.DrawString(TenMon, new Font("Century", 10, FontStyle.Bold), Brushes.Black, new Point(900, y));
                 y = y + 30;
             }



            //e.Graphics.DrawRectangle(Pens.Black, 800, 800, this.gridControl1.Width, this.gridControl1.Height);
            ////Fills the above drawn rectangle with a light gray colour just to distinguish the header 
            //e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(800, 800, this.gridControl1.Width, this.gridControl1.Height));
        }
    }
}
