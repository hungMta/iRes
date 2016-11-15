namespace WindowsFormsApplication1.Views
{
    partial class uctThucDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctThucDon));
            this.grbThemNhomMon = new System.Windows.Forms.GroupBox();
            this.txtSoLuongMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnThemSuaOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNhomMon = new System.Windows.Forms.DataGridView();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbSearchNhomMon = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.lblTimKiemTheo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnAnTimKiem = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grbThemNhomMon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMon)).BeginInit();
            this.grbSearchNhomMon.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbThemNhomMon
            // 
            this.grbThemNhomMon.Controls.Add(this.txtSoLuongMon);
            this.grbThemNhomMon.Controls.Add(this.label4);
            this.grbThemNhomMon.Controls.Add(this.txtTenNhom);
            this.grbThemNhomMon.Controls.Add(this.label3);
            this.grbThemNhomMon.Controls.Add(this.txtMaNhom);
            this.grbThemNhomMon.Controls.Add(this.label2);
            this.grbThemNhomMon.Location = new System.Drawing.Point(27, 41);
            this.grbThemNhomMon.Name = "grbThemNhomMon";
            this.grbThemNhomMon.Size = new System.Drawing.Size(395, 303);
            this.grbThemNhomMon.TabIndex = 0;
            this.grbThemNhomMon.TabStop = false;
            this.grbThemNhomMon.Text = "Thêm nhóm món";
            // 
            // txtSoLuongMon
            // 
            this.txtSoLuongMon.Location = new System.Drawing.Point(30, 189);
            this.txtSoLuongMon.Name = "txtSoLuongMon";
            this.txtSoLuongMon.Size = new System.Drawing.Size(215, 20);
            this.txtSoLuongMon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng món";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(30, 134);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(215, 20);
            this.txtTenNhom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhóm món:";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(30, 75);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(215, 20);
            this.txtMaNhom.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhóm món:";
            // 
            // btnHuybo
            // 
            this.btnHuybo.Enabled = false;
            this.btnHuybo.Location = new System.Drawing.Point(347, 388);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(75, 31);
            this.btnHuybo.TabIndex = 2;
            this.btnHuybo.Text = "HỦY";
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnThemSuaOk
            // 
            this.btnThemSuaOk.Enabled = false;
            this.btnThemSuaOk.Location = new System.Drawing.Point(266, 388);
            this.btnThemSuaOk.Name = "btnThemSuaOk";
            this.btnThemSuaOk.Size = new System.Drawing.Size(75, 31);
            this.btnThemSuaOk.TabIndex = 1;
            this.btnThemSuaOk.Text = "OK";
            this.btnThemSuaOk.UseVisualStyleBackColor = true;
            this.btnThemSuaOk.Click += new System.EventHandler(this.btnThemSuaOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(93, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhóm món";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhomMon);
            this.groupBox2.Location = new System.Drawing.Point(488, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 303);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // dgvNhomMon
            // 
            this.dgvNhomMon.AllowUserToAddRows = false;
            this.dgvNhomMon.AllowUserToDeleteRows = false;
            this.dgvNhomMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom,
            this.SoLuongMon});
            this.dgvNhomMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhomMon.Location = new System.Drawing.Point(3, 16);
            this.dgvNhomMon.Name = "dgvNhomMon";
            this.dgvNhomMon.ReadOnly = true;
            this.dgvNhomMon.Size = new System.Drawing.Size(716, 284);
            this.dgvNhomMon.TabIndex = 0;
            // 
            // MaNhom
            // 
            this.MaNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNhom.DataPropertyName = "MaNhom";
            this.MaNhom.HeaderText = "Mã Nhóm";
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.ReadOnly = true;
            // 
            // TenNhom
            // 
            this.TenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenNhom.DataPropertyName = "TenNhom";
            this.TenNhom.HeaderText = "Tên Nhóm";
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            // 
            // SoLuongMon
            // 
            this.SoLuongMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongMon.DataPropertyName = "SoLuongMon";
            this.SoLuongMon.HeaderText = "Số Lượng Món";
            this.SoLuongMon.Name = "SoLuongMon";
            this.SoLuongMon.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(770, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Danh sách nhóm món";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(185, 388);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(105, 388);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 31);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(25, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbSearchNhomMon
            // 
            this.grbSearchNhomMon.Controls.Add(this.btnTim);
            this.grbSearchNhomMon.Controls.Add(this.txtNoiDung);
            this.grbSearchNhomMon.Controls.Add(this.cboTimKiem);
            this.grbSearchNhomMon.Controls.Add(this.lblTimKiemTheo);
            this.grbSearchNhomMon.Location = new System.Drawing.Point(683, 374);
            this.grbSearchNhomMon.Name = "grbSearchNhomMon";
            this.grbSearchNhomMon.Size = new System.Drawing.Size(525, 57);
            this.grbSearchNhomMon.TabIndex = 7;
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
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
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
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(489, 388);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(89, 31);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnAnTimKiem
            // 
            this.btnAnTimKiem.Location = new System.Drawing.Point(584, 388);
            this.btnAnTimKiem.Name = "btnAnTimKiem";
            this.btnAnTimKiem.Size = new System.Drawing.Size(83, 31);
            this.btnAnTimKiem.TabIndex = 8;
            this.btnAnTimKiem.Text = "Ẩn tìm kiếm";
            this.btnAnTimKiem.UseVisualStyleBackColor = true;
            this.btnAnTimKiem.Click += new System.EventHandler(this.btnAnTimKiem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uctThucDon
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbThemNhomMon);
            this.Name = "uctThucDon";
            this.Size = new System.Drawing.Size(1255, 693);
            this.Load += new System.EventHandler(this.uctThucDon_Load);
            this.grbThemNhomMon.ResumeLayout(false);
            this.grbThemNhomMon.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMon)).EndInit();
            this.grbSearchNhomMon.ResumeLayout(false);
            this.grbSearchNhomMon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThemNhomMon;
        private System.Windows.Forms.TextBox txtSoLuongMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNhomMon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuybo;
        private System.Windows.Forms.Button btnThemSuaOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongMon;
        private System.Windows.Forms.GroupBox grbSearchNhomMon;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label lblTimKiemTheo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnAnTimKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnTim;
    }
}
