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
    public partial class FrmSuaChiTietHoaDon : Form
    {
        Configuration config = new Configuration();
        string maHoaDon;


        public FrmSuaChiTietHoaDon(ChiTietHoaDon cthd)
        {
            InitializeComponent();
            LoadData(cthd);
        }

        public void LoadData(ChiTietHoaDon cthd)
        {
            textEditMaMon.Text = cthd.MaMon;
            textEditSoLuong.Text = cthd.SoLuong.ToString();
            DataTable dt_MonAn = new DataTable();
            dt_MonAn = Bus.GetMonAnByMaMon(cthd.MaMon);
            textEditTenMon.Text = dt_MonAn.Rows[0]["TenMon"].ToString();
            this.maHoaDon = cthd.MaHoaDon;
        }

      

        private void simpleButtonLuu_Click_1(object sender, EventArgs e)
        {
            string maHoaDon, maMonAn, GhiChu;
            int soLuong;
            int luong;
            maHoaDon = this.maHoaDon;
            maMonAn = textEditMaMon.Text;
            soLuong = int.Parse(textEditSoLuong.Text);
            ChiTietHoaDon cthd = new ChiTietHoaDon(maHoaDon, maMonAn, soLuong);
            int res = Bus.EditChiTietHoaDon(cthd);
            if (res != -1)
            {
                MessageBox.Show("Đã thay đổi thành công");
            }
            else { MessageBox.Show("Sửa không thành công!"); }
            this.Close();
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
