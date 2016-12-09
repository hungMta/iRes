using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Title.BUS;
using Title.Config;
using Title.VO;

namespace Title.GUI
{
    public partial class FrmThemMon : Form
    {
        public FrmThemMon()
        {
            InitializeComponent();
           textEditMaMon.Text =   GetMaMonNext();
           LoadLookUpEditNhomMon();
        }

        Configuration config = new Configuration();

        public void LoadLookUpEditNhomMon()
        {
            DataTable dataTableNhomMon = new DataTable();
            dataTableNhomMon = Bus.GetListNhomMon();
            try
            {
                this.lookUpEditNhomMon.Properties.DisplayMember = config.NhomMon_TenNhom;
                this.lookUpEditNhomMon.Properties.ValueMember = config.NhomMon_MaNhom;
                this.lookUpEditNhomMon.Properties.DataSource = dataTableNhomMon;
            }
            catch { }
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            try
            {

                string maMon = textEditMaMon.Text;
                string tenMon = textEditTenMon.Text;
                object obj = lookUpEditNhomMon.EditValue;
                 string maNhom =    obj.ToString();

                int soLuong = int.Parse(textEditSoLuong.Text);
                decimal donGia = decimal.Parse(textEditDonGia.Text);
                string hinhAnh = textEditHinhAnh.Text;
                MonAn monAn = new MonAn(tenMon, maNhom, donGia, soLuong, hinhAnh);
                int res = Bus.InsertMonAn(monAn);
                if (res != -1)
                {
                    MessageBox.Show("Thêm món thành công.", "Thông báo");
                }
                else MessageBox.Show("Thêm món lỗi.", "Thông báo");
            }
            catch { MessageBox.Show("Thêm món lỗi.", "Thông báo"); }
            this.Close();

        }

        private string GetMaMonNext()
        {
            DataTable dt_MaMon = new DataTable();
            dt_MaMon = Bus.GetMaMonNext();
            string maMon = dt_MaMon.Rows[0]["MaMon"].ToString();
            return maMon;
        }

        private void simpleButtonHủy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
