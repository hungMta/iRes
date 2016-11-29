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
using Title.Lib;
using System.Data.SqlClient;

namespace Title.GUI
{
    public partial class UtcQuanLyMonAn : UserControl
    {
        Configuration config = new Configuration();

        public UtcQuanLyMonAn()
        {
            InitializeComponent();
        }
        SqlConnection conn;

        public void TaoKetNoi()
        {
            conn = new SqlConnection(@"Server = DESKTOP-8IKVHJR ; DataBase = QuanLyNhaHang ; Trusted_Connection = true");
            conn.Open();
        }


        public void LoadData()
        {
            TaoKetNoi();
            DataTable dt = LoadDataTable();
            gridControlMonAn.DataSource = dt;
            RepositoryItemGraphicsEdit repItemGraphicsEdit = new RepositoryItemGraphicsEdit();

            repItemGraphicsEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            repItemGraphicsEdit.BestFitWidth = 100;
            gridView1.Columns["Hình ảnh"].ColumnEdit = repItemGraphicsEdit; 


        }

        public DataTable LoadDataTable()
        {

            string ds = @"select Cast('C:/Users/Tran/Desktop/hinhanh/'
                                                + hinhanh as nvarchar(4000)) as [Hình ảnh],
                                                MaMon as [Mã món ăn], 
                                                TenMon as [Tên món ăn],
                                                MaNhom as [Mã nhóm],
                                                DonGia as [Đơn giá],
                                                SoLuong as [Số lương] from MonAn";


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(config.GET_LIST_MONAN_AND_IMAGE, conn);
            da.Fill(dt);
            return dt;

        }



        private void UtcQuanLyMonAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
