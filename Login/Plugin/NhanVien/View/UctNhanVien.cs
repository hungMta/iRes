using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Plugin.NhanVien.Enitity;
using Login.Plugin.NhanVien.Utils;

namespace Login.Plugin.NhanVien.View
{
    public partial class UctNhanVien : UserControl
    {
        public static UctNhanVien uctNhanVien = new UctNhanVien();
        private bool statusThem = false;
        private Util utils = new Util();

        private int caseLuu = 0;
        /* = 1 : them moi
         * = 2 : sua 
         * = 3 : xoa
         */
        private string oldMaNV;
        public UctNhanVien()
        {
            InitializeComponent();
        }

        public void LoadDataGridView()
        {
            string strTableName = "NhanVien";
            string strQuerySelect = "Select * from NhanVien";
            DataSet dataset = new DataSet();
            dataset = Database.Database.Read(strTableName, strQuerySelect);
            this.dgvNhanVien.DataSource = dataset.Tables[0];
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UctNhanVien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
          
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            setEnabled(true);
            resetTextBox();
            setLuuHuyEnabled(true);
            caseLuu = 1;
        }
        
        private void setEnabled(bool tf)
        {
            txtDiaChi.Enabled = tf;
            txtLuong.Enabled = tf;
            cbxChucVu.Enabled = tf;
            txtIDNhanVien.Enabled = tf;
            txtTen.Enabled = tf;
            dtpNgaySih.Enabled = tf;
            cbxGioiTinh.Enabled = tf;
            btnLuu.Enabled = tf;
            btnHuy.Enabled = tf;
        }

        private void setLuuHuyEnabled(bool tf)
        {
            btnLuu.Enabled = tf;
            btnHuy.Enabled = tf;
        }

        private void resetTextBox()
        {
            txtDiaChi.Text = "";
            txtIDNhanVien.Text = "";
            txtLuong.Text = "";
            txtTen.Text = "";
            cbxChucVu.SelectedIndex = 0;
            cbxGioiTinh.SelectedIndex = 0;
        }

        private void checkValueInsert()
        {
           
        }

        private NhanVienEntity getNhanVienValues()
        {
            NhanVienEntity nhanVien ;
            string idNV = txtIDNhanVien.Text;
            string tenNV = txtTen.Text;
            string gioiTinh = cbxGioiTinh.Text;
            DateTime ngaySinh = dtpNgaySih.Value;
            string queQuan = txtDiaChi.Text;
            decimal luong = decimal.Parse(txtLuong.Text);
            string chucVu = cbxChucVu.Text;
            nhanVien = new NhanVienEntity(idNV, tenNV, gioiTinh, ngaySinh, queQuan, luong, chucVu);
            return nhanVien; 
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if ((txtTen.Text == "" || txtDiaChi.Text == "" || txtLuong.Text == "" || txtIDNhanVien.Text == ""))
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin của nhân viên");
                resetTextBox();
                setEnabled(false);
                setLuuHuyEnabled(false);
                caseLuu = 0;
                return;
            }
            if (caseLuu == 1)
            {
                themNhanVien();
            }
            else
            {
                suaNhanVien(oldMaNV);
            }

            LoadDataGridView();
        }

        private void themNhanVien()
        {
            NhanVienEntity nhanVien = getNhanVienValues();
            String queryInsert = utils.queryInsert(nhanVien);
            Database.Database.Update(queryInsert);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            resetTextBox();
            setEnabled(false);
            setLuuHuyEnabled(false);
            caseLuu = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            caseLuu = 2;
            setLuuHuyEnabled(true);
            setEnabled(true);
            int currentSelectedRowIndex = dgvNhanVien.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvNhanVien.Rows[currentSelectedRowIndex];
            txtIDNhanVien.Text = Convert.ToString(selectedRow.Cells["MaNV"].Value);
            txtTen.Text = Convert.ToString(selectedRow.Cells["TenNV"].Value);
            cbxGioiTinh.Text = Convert.ToString(selectedRow.Cells["GioiTinh"].Value);
            dtpNgaySih.Value = Convert.ToDateTime(selectedRow.Cells["NgaySinh"].Value);
            txtDiaChi.Text = Convert.ToString((selectedRow.Cells["QueQuan"].Value));
            cbxChucVu.Text = Convert.ToString(selectedRow.Cells["ChucVu"].Value);
            txtLuong.Text = Convert.ToString(selectedRow.Cells["Luong"].Value);
             oldMaNV = txtIDNhanVien.Text;

        }

        private void suaNhanVien(string MaNV)
        {
            NhanVienEntity nhanVien = getNhanVienValues();
            string queryUpdate = utils.queryUpdate(nhanVien, MaNV);
            Database.Database.Update(queryUpdate);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "" ,  MessageBoxButtons.OKCancel);
             if (dialogResult == DialogResult.OK)
             {
                 int currentSelectedRowIndex = dgvNhanVien.SelectedCells[0].RowIndex;
                 DataGridViewRow selectedRow = dgvNhanVien.Rows[currentSelectedRowIndex];
                 string MaNV = Convert.ToString(selectedRow.Cells["MaNV"].Value);
                 string queryDelete = utils.queryDelete(MaNV);
                 Database.Database.Delete(queryDelete);
                 LoadDataGridView();
             }
        }



        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           
        }


        // BUTTON TIM KIEM :3 :3
        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = cboTimKiem.SelectedIndex;
            string strQuerySelectWhere = "";
            switch (selectedIndex)
            {
                case 0:
                    strQuerySelectWhere = @"Select * from NhanVien where MaNV ='" + this.txtNoiDung.Text + "'";
                    break;
                case 1:
                    strQuerySelectWhere = @"Select * from NhanVien where TenNV=N'" + this.txtNoiDung.Text + "'";
                    break;
                case 2:
                    strQuerySelectWhere = @"Select * from NhanVien where GioiTinh='" + this.txtNoiDung.Text + "'";
                    break;
                case 3:
                    strQuerySelectWhere = @"Select * from NhanVien where QueQuan=N'" + this.txtNoiDung.Text + "'";
                    break;
                case 4:
                    strQuerySelectWhere = @"Select * from NhanVien where Luong='" + this.txtNoiDung.Text + "'";
                    break;
                case 5:
                    strQuerySelectWhere = @"Select * from NhanVien where ChucVu=N'" + this.txtNoiDung.Text + "'";
                    break;
            }
            DataSet dataset = new DataSet();
            dataset = Database.Database.Read("NhanVien", strQuerySelectWhere);
            dgvNhanVien.DataSource = dataset.Tables[0];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }


    }
}
