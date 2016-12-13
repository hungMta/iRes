using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Title.BUS;
using Title.Config;
using Title.VO;
using DevExpress.XtraBars;

namespace Title.GUI {
    public partial class FrmMonAn : DevExpress.XtraEditors.XtraForm {
        public MonAn monAn = new MonAn();
        Configuration config = new Configuration();
        string maMon;
        public FrmMonAn(string maMon) {
            InitializeComponent();
            this.maMon = maMon;
            if (maMon != "add")
            {
                SetMonAn(maMon);
            }
            
        }

        


        public void SetMonAn(string maMon) {
            this.monAn.MaMon = maMon;
            DataTable dataTable = Bus.GetMonAnByMaMon(maMon);
            this.monAn.MaNhom = dataTable.Rows[0][config.MONAN_MANHOM].ToString();
            this.monAn.TenMon = dataTable.Rows[0][config.MONAN_TENMON].ToString();
            this.monAn.DonGia = int.Parse(dataTable.Rows[0][config.MONAN_DONGIA].ToString());
            this.monAn.SoLuong = int.Parse(dataTable.Rows[0][config.MONAN_SOLUONG_DANGCO].ToString());
            this.monAn.hinhanh = dataTable.Rows[0][config.MONAN_HINHANH].ToString(); 
        }

        public void LoadLookUpEditNhomMon() {
            DataTable dataTableNhomMon = Bus.GetListNhomMon();
            this.lookUpEditNhomMon.Properties.DataSource = dataTableNhomMon;
            this.lookUpEditNhomMon.Properties.DisplayMember = config.NHOMMON_MANHOM;
            this.lookUpEditNhomMon.Properties.ValueMember = config.NHOMMON_MANHOM;
        }

        public void LoadTextBox() {
            this.Text = this.monAn.MaMon + " - " + this.monAn.TenMon;
            this.textEditTenMon.Text = this.monAn.TenMon;
            this.textEditDonGia.Text = this.monAn.DonGia.ToString();
            this.textEditSoLuong.Text = this.monAn.SoLuong.ToString();
            this.lookUpEditNhomMon.Text = this.monAn.MaNhom;
            this.textEditHinhAnh.Text = this.monAn.hinhanh;
            string imagePath = config.GetProjectLinkDirectory() + config.MONAN_IMAGE_RESOURCE + this.monAn.hinhanh;
            this.pictureEditHinhAnh.Image = Image.FromFile(imagePath);
        }

        public void LoadData() {
            LoadLookUpEditNhomMon();
            if(maMon != "add")
            LoadTextBox();
        }

        private void FrmMonAn_Load(object sender, EventArgs e) {
            LoadData();
        }

        private void simpleButtonExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        public MonAn CheckError() {
            string maMon = this.monAn.MaMon;
            string tenMon = this.textEditTenMon.Text;
            string maNhom = this.lookUpEditNhomMon.Text;
            decimal donGia = int.Parse(this.textEditDonGia.Text);
            int soLuong = int.Parse(this.textEditSoLuong.Text);
            string hinhAnh = this.textEditHinhAnh.Text;
            MonAn monAn = new MonAn(maMon, tenMon, maNhom, donGia, soLuong, hinhAnh);
            return monAn;
        }

        private void simpleButtonSave_Click(object sender, EventArgs e) {
            if (maMon != "add")
            {
                int res = Bus.UpdateMonAn(monAn);
            }
            else {
                DataTable dt = new DataTable();
                dt = Bus.GetMaMonNext();
                string tenMon = this.textEditTenMon.Text;
                string maNhom = this.lookUpEditNhomMon.Text;
                decimal donGia = int.Parse(this.textEditDonGia.Text);
                int soLuong = int.Parse(this.textEditSoLuong.Text);
                string hinhAnh = this.textEditHinhAnh.Text;
                MonAn monAn = new MonAn(maMon, tenMon, maNhom, donGia, soLuong, hinhAnh);
                //monAn.MaMon = dt.Rows[0]["MaMon"].ToString();
                int res = Bus.InsertMonAn(monAn);
                if (res != -1)
                    MessageBox.Show("Them thanh cong");
                else MessageBox.Show("Khong thanh cong");
            
            }
            this.Close();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e) {
            if (maMon != "add")
            LoadTextBox();
            this.Close();
        }

        private void simpleButtonDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("","Do you want to delete?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                int res = Bus.DeleteMonAn(this.monAn.MaMon);
           }
            this.Close();
        }

        private void textEditDonGia_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}