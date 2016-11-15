namespace Login.Plugin.MonAn.View {
    partial class UctMonAn {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UctMonAn));
            this.lblQuanLyMonAn = new System.Windows.Forms.Label();
            this.grbThemMonAn = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.lblTenMon = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.grbDanhSachMonAn = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAnTimKiem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grbSearchNhomMon = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSuaOk = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.grbThemMonAn.SuspendLayout();
            this.grbDanhSachMonAn.SuspendLayout();
            this.grbSearchNhomMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanLyMonAn
            // 
            this.lblQuanLyMonAn.AutoSize = true;
            this.lblQuanLyMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblQuanLyMonAn.Location = new System.Drawing.Point(96, 17);
            this.lblQuanLyMonAn.Name = "lblQuanLyMonAn";
            this.lblQuanLyMonAn.Size = new System.Drawing.Size(119, 20);
            this.lblQuanLyMonAn.TabIndex = 1;
            this.lblQuanLyMonAn.Text = "Quản lý món ăn";
            // 
            // grbThemMonAn
            // 
            this.grbThemMonAn.Controls.Add(this.txtDonGia);
            this.grbThemMonAn.Controls.Add(this.lblDonGia);
            this.grbThemMonAn.Controls.Add(this.txtMaNhom);
            this.grbThemMonAn.Controls.Add(this.lblMaNhom);
            this.grbThemMonAn.Controls.Add(this.txtSoLuong);
            this.grbThemMonAn.Controls.Add(this.lblSoLuong);
            this.grbThemMonAn.Controls.Add(this.txtTenMon);
            this.grbThemMonAn.Controls.Add(this.lblTenMon);
            this.grbThemMonAn.Controls.Add(this.txtMaMon);
            this.grbThemMonAn.Controls.Add(this.lblMaMon);
            this.grbThemMonAn.Location = new System.Drawing.Point(30, 40);
            this.grbThemMonAn.Name = "grbThemMonAn";
            this.grbThemMonAn.Size = new System.Drawing.Size(445, 303);
            this.grbThemMonAn.TabIndex = 1;
            this.grbThemMonAn.TabStop = false;
            this.grbThemMonAn.Text = "Thêm món ăn";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(257, 134);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(162, 20);
            this.txtDonGia.TabIndex = 3;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(237, 109);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(44, 13);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(30, 134);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(162, 20);
            this.txtMaNhom.TabIndex = 2;
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Location = new System.Drawing.Point(10, 111);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(74, 13);
            this.lblMaNhom.TabIndex = 3;
            this.lblMaNhom.Text = "Mã nhóm món";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(30, 189);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(162, 20);
            this.txtSoLuong.TabIndex = 4;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(7, 168);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(49, 13);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(257, 75);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(162, 20);
            this.txtTenMon.TabIndex = 1;
            // 
            // lblTenMon
            // 
            this.lblTenMon.AutoSize = true;
            this.lblTenMon.Location = new System.Drawing.Point(234, 52);
            this.lblTenMon.Name = "lblTenMon";
            this.lblTenMon.Size = new System.Drawing.Size(64, 13);
            this.lblTenMon.TabIndex = 0;
            this.lblTenMon.Text = "Tên món ăn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Location = new System.Drawing.Point(30, 75);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(162, 20);
            this.txtMaMon.TabIndex = 0;
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Location = new System.Drawing.Point(7, 50);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(60, 13);
            this.lblMaMon.TabIndex = 0;
            this.lblMaMon.Text = "Mã món ăn";
            // 
            // grbDanhSachMonAn
            // 
            this.grbDanhSachMonAn.Controls.Add(this.dgvMonAn);
            this.grbDanhSachMonAn.Location = new System.Drawing.Point(510, 40);
            this.grbDanhSachMonAn.Name = "grbDanhSachMonAn";
            this.grbDanhSachMonAn.Size = new System.Drawing.Size(722, 303);
            this.grbDanhSachMonAn.TabIndex = 11;
            this.grbDanhSachMonAn.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(785, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Danh sách món ăn";
            // 
            // btnAnTimKiem
            // 
            this.btnAnTimKiem.Location = new System.Drawing.Point(608, 385);
            this.btnAnTimKiem.Name = "btnAnTimKiem";
            this.btnAnTimKiem.Size = new System.Drawing.Size(83, 31);
            this.btnAnTimKiem.TabIndex = 20;
            this.btnAnTimKiem.Text = "Ẩn tìm kiếm";
            this.btnAnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(513, 385);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 31);
            this.btnTimKiem.TabIndex = 18;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // grbSearchNhomMon
            // 
            this.grbSearchNhomMon.Controls.Add(this.btnTim);
            this.grbSearchNhomMon.Controls.Add(this.txtNoiDung);
            this.grbSearchNhomMon.Controls.Add(this.cboTimKiem);
            this.grbSearchNhomMon.Controls.Add(this.lblTimKiemTheo);
            this.grbSearchNhomMon.Location = new System.Drawing.Point(707, 371);
            this.grbSearchNhomMon.Name = "grbSearchNhomMon";
            this.grbSearchNhomMon.Size = new System.Drawing.Size(525, 57);
            this.grbSearchNhomMon.TabIndex = 19;
            this.grbSearchNhomMon.TabStop = false;
            this.grbSearchNhomMon.Visible = false;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(438, 20);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(262, 20);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(157, 21);
            this.txtNoiDung.TabIndex = 1;
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã nhóm món",
            "Tên nhóm món",
            "Số lượng món "});
            this.cboTimKiem.Location = new System.Drawing.Point(115, 20);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(121, 21);
            this.cboTimKiem.TabIndex = 0;
            // 
            // lblTimKiemTheo
            // 
            this.lblTimKiemTheo.AutoSize = true;
            this.lblTimKiemTheo.Location = new System.Drawing.Point(16, 23);
            this.lblTimKiemTheo.Name = "lblTimKiemTheo";
            this.lblTimKiemTheo.Size = new System.Drawing.Size(73, 13);
            this.lblTimKiemTheo.TabIndex = 0;
            this.lblTimKiemTheo.Text = "Tìm kiếm theo";
            // 
            // btnHuybo
            // 
            this.btnHuybo.Enabled = false;
            this.btnHuybo.Location = new System.Drawing.Point(351, 386);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(75, 31);
            this.btnHuybo.TabIndex = 3;
            this.btnHuybo.Text = "HỦY";
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(189, 386);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThemSuaOk
            // 
            this.btnThemSuaOk.Enabled = false;
            this.btnThemSuaOk.Location = new System.Drawing.Point(270, 386);
            this.btnThemSuaOk.Name = "btnThemSuaOk";
            this.btnThemSuaOk.Size = new System.Drawing.Size(75, 31);
            this.btnThemSuaOk.TabIndex = 2;
            this.btnThemSuaOk.Text = "OK";
            this.btnThemSuaOk.UseVisualStyleBackColor = true;
            this.btnThemSuaOk.Click += new System.EventHandler(this.btnThemSuaOk_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(109, 386);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 31);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(29, 386);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.ReadOnly = true;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Món";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToAddRows = false;
            this.dgvMonAn.AllowUserToDeleteRows = false;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.MaNhom,
            this.DonGia,
            this.SoLuong});
            this.dgvMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonAn.Location = new System.Drawing.Point(3, 16);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.Size = new System.Drawing.Size(716, 284);
            this.dgvMonAn.TabIndex = 0;
            // 
            // UctMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.grbSearchNhomMon);
            this.Controls.Add(this.btnHuybo);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemSuaOk);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grbDanhSachMonAn);
            this.Controls.Add(this.lblQuanLyMonAn);
            this.Controls.Add(this.grbThemMonAn);
            this.Name = "UctMonAn";
            this.Size = new System.Drawing.Size(1282, 534);
            this.Load += new System.EventHandler(this.UctMonAn_Load);
            this.grbThemMonAn.ResumeLayout(false);
            this.grbThemMonAn.PerformLayout();
            this.grbDanhSachMonAn.ResumeLayout(false);
            this.grbSearchNhomMon.ResumeLayout(false);
            this.grbSearchNhomMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanLyMonAn;
        private System.Windows.Forms.GroupBox grbThemMonAn;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label lblTenMon;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.GroupBox grbDanhSachMonAn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.Button btnAnTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grbSearchNhomMon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSuaOk;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}
