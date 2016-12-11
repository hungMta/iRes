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
        SqlConnection conn;

        public UtcQuanLyMonAn() {
            InitializeComponent();
            gridControlMonAn.UseEmbeddedNavigator = true;
        }

        public void TaoKetNoi() {
            conn = new SqlConnection(config.DATA_SOURCE);
            conn.Open();
        }

        public void LoadData() {
            TaoKetNoi();
            DataTable dt = LoadDataTable();
            gridControlMonAn.DataSource = dt;
            RepositoryItemGraphicsEdit repItemGraphicsEdit = new RepositoryItemGraphicsEdit();

            repItemGraphicsEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            repItemGraphicsEdit.BestFitWidth = 100;
            layoutView1.Columns["Hình ảnh"].ColumnEdit = repItemGraphicsEdit;
        }

        public DataTable LoadDataTable() {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            string projectDirectoryPath = config.GetProjectLinkDirectory();
            string monAnImagePath = config.GetProjectLinkDirectory() + config.MONAN_IMAGE_RESOURCE;
            string GET_LIST_MONAN_AND_IMAGE = @"select Cast('" + monAnImagePath + @"'
                                                        + HinhAnh as nvarchar(4000)) as [Hình ảnh],
                                                        MaMon as [Mã món ăn], 
                                                        TenMon as [Tên món ăn],
                                                        MaNhom as [Mã nhóm],
                                                        DonGia as [Đơn giá],
                                                        SoLuongDangCo as [Số lương] from MonAn";
            da.SelectCommand = new SqlCommand(GET_LIST_MONAN_AND_IMAGE, conn);
            da.Fill(dt);
            return dt;
        }

        private void UtcQuanLyMonAn_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void layoutView1_DoubleClick(object sender, EventArgs e) {
            DataRowView dataViewRow = (DataRowView)this.layoutView1.GetFocusedRow();
            string maMon = dataViewRow.Row.ItemArray[1].ToString();
            FrmMonAn frmMonAn = new FrmMonAn(maMon);
            frmMonAn.ShowDialog();
            LoadData();
        }
    }
}
