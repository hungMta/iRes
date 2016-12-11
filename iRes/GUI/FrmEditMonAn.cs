using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmEditMonAn : Form
    {
        public FrmEditMonAn()
        {
            InitializeComponent();
            LoadData();
        }
        Configuration config = new Configuration();
        string feature;
        public void LoadData()
        {
            DataTable dt_MonAn = new DataTable();
            dt_MonAn = BUS.Bus.GetListMonAn();
            this.gridControl1.DataSource = dt_MonAn;
            LoadLookUpEditNhomMon();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));
            try
            {
                this.textEditMaMon.Text = selRow[config.MONAN_MAMON].ToString();
                this.textEditTenMon.Text = selRow[config.MONAN_TENMON].ToString();
                this.textEditSoLuong.Text = selRow[config.MONAN_SOLUONG_DANGCO].ToString();
                this.textEditDonGia.Text = selRow[config.MONAN_DONGIA].ToString();
                this.lookUpEditNhomMon.Text = selRow[config.MONAN_MANHOM].ToString();
                this.textEditHinhAnh.Text = selRow[config.MONAN_HINHANH].ToString();
                try
                {
                    if (this.textEditHinhAnh.Text != "")
                    {
                        string imagePath = config.GetProjectLinkDirectory() + config.MONAN_IMAGE_RESOURCE + this.textEditHinhAnh.Text;
                        this.pictureEditMonAn.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        string imagePath = config.GetProjectLinkDirectory() + config.MONAN_IMAGE_RESOURCE + @"1.png";
                        this.pictureEditMonAn.Image = Image.FromFile(imagePath);
                    }
                }
                catch { }

            }
            catch { }
        }


        public void LoadLookUpEditNhomMon()
        {
            DataTable dataTableNhomMon = new DataTable();
            dataTableNhomMon = Bus.GetListNhomMon();
            try
            {
                this.lookUpEditNhomMon.Properties.DisplayMember = config.NHOMMON_MANHOM;
                this.lookUpEditNhomMon.Properties.ValueMember = config.NHOMMON_MANHOM;
                this.lookUpEditNhomMon.Properties.DataSource = dataTableNhomMon;
            }
            catch { }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));
            try
            {
                this.textEditMaMon.Text = selRow[config.MONAN_MAMON].ToString();
                this.textEditTenMon.Text = selRow[config.MONAN_TENMON].ToString();
                this.textEditSoLuong.Text = selRow[config.MONAN_SOLUONG_DANGCO].ToString();
                this.textEditDonGia.Text = selRow[config.MONAN_DONGIA].ToString();
                this.lookUpEditNhomMon.Text = selRow[config.MONAN_MANHOM].ToString();
                this.textEditHinhAnh.Text = selRow[config.MONAN_HINHANH].ToString();
                try
                {
                    if (this.textEditHinhAnh.Text != "")
                    {
                        string imagePath = config.GetProjectLinkDirectory() + config.MONAN_IMAGE_RESOURCE + this.textEditHinhAnh.Text;
                        this.pictureEditMonAn.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        string imagePath = config.GetProjectLinkDirectory() + config.MONAN_IMAGE_RESOURCE + @"1.png";
                        this.pictureEditMonAn.Image = Image.FromFile(imagePath);
                    }
                }
                catch { }
            }
            catch { }
        }

        private void simpleButtonLuu_Click(object sender, EventArgs e)
        {
            string maMon = this.textEditMaMon.Text;
            string maNhom = this.lookUpEditNhomMon.Text;
            string tenMon = this.textEditTenMon.Text;
            decimal donGia = decimal.Parse(this.textEditDonGia.Text);
            int soLuong = int.Parse(this.textEditSoLuong.Text);
            string hinhAnh = this.textEditHinhAnh.Text;
            MonAn monAn = new MonAn(maMon,tenMon,maNhom,donGia,soLuong,hinhAnh);
            int res = Bus.UpdateMonAn(monAn);
            if (res != -1)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo");
                LoadData();
            }
            else MessageBox.Show("Sửa không thành công", "Lỗi");
            DisEnableBox();
            simpleButtonHuy.Enabled = false;
        }

        private void simpleButtonHuy_Click(object sender, EventArgs e)
        {
            simpleButtonLuu.Enabled = false;

        }

        private void EnableBox()
        {
            this.lookUpEditNhomMon.Enabled = true;
            this.textEditTenMon.Enabled = true;
            this.textEditSoLuong.Enabled = true;
            this.textEditDonGia.Enabled = true;
            this.textEditHinhAnh.Enabled = true;
        }

        private void DisEnableBox()
        {
            this.lookUpEditNhomMon.Enabled = false;
            this.textEditTenMon.Enabled = false;
            this.textEditSoLuong.Enabled = false;
            this.textEditDonGia.Enabled = false;
            this.textEditHinhAnh.Enabled = false;
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            EnableBox();
            this.simpleButtonHuy.Enabled = true;
            this.simpleButtonLuu.Enabled = true;
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                try
                {
                    string maMon = this.textEditMaMon.Text;
                    int res = Bus.DeleteMonAn(maMon);
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            
        }
    }
}
