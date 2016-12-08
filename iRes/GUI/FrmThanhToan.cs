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

namespace Title.GUI
{
    public partial class FrmThanhToan : Form
    {
    

        private UctGoiMonTheoBan uctGoiMonTheoBan;
        private string printHoaDon = "";
        Configuration config = new Configuration();
    
        public FrmThanhToan(BanAn banAn)
        {
             
            InitializeComponent();
            LoadFormThanhToan(banAn);
        }
        public void LoadFormThanhToan(BanAn banAn)
        {
            lblMaHD.Text = banAn.MaHoaDon;
            lblNgayThang.Text = DateTime.UtcNow.Date.ToString();

            DataTable dt = Bus.GetInfoKhachHangTheoMaHoaDon(banAn);
            lblMaKH.Text =  dt.Rows[0]["MaKH"].ToString();
            lblTenKH.Text = dt.Rows[0]["TenKH"].ToString();
            lblSDT.Text = dt.Rows[0]["SDT"].ToString();
            lblDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
            DataTable dt_HoaDon = Bus.GetInfoHoaDonTheoBanAn(banAn);
            lblTongTien.Text = dt_HoaDon.Rows[0]["TongTien"].ToString();
            this.gridControl1.DataSource = Bus.GetListChiTietHoaDon(banAn);
        }

        public string getPrintHoaDon()
        {
            return printHoaDon;
        }

        public FrmThanhToan(UctGoiMonTheoBan uctGoiMonTheoBan)
        {
            // TODO: Complete member initialization
            this.uctGoiMonTheoBan = uctGoiMonTheoBan;
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {
            //ev.Graphics.DrawString("Hóa Đơn", new Font("Arial", 50), Brushes.Black,
            //                     ev.MarginBounds.Left, 0, new StringFormat());
            //ev.Graphics.DrawString("=========================Hóa Đơn====================", new Font("Arial", 10), Brushes.Black,
            //                     ev.MarginBounds.Left, 0, new StringFormat());


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        public UctGoiMonTheoBan mainForm { get; set; }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButtonPrint_Click(object sender, EventArgs e) {
            PrintDocument printDialog = new PrintDocument();
            printDialog.PrintPage += new PrintPageEventHandler(pd_PrintPage);
            printDialog.Print();
            printHoaDon = config.PRINT_HOA_DON;
            printHoaDon = "printed";
            this.Close();

        }

        private void simpleButtonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
