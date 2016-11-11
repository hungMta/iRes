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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctThucDon));
            this.grbThemNhomMon = new System.Windows.Forms.GroupBox();
            this.btnHuybo = new System.Windows.Forms.Button();
            this.btnThemSuaOk = new System.Windows.Forms.Button();
            this.txtSoLuongMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.grbThemNhomMon.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMon)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThemNhomMon
            // 
            this.grbThemNhomMon.Controls.Add(this.btnHuybo);
            this.grbThemNhomMon.Controls.Add(this.btnThemSuaOk);
            this.grbThemNhomMon.Controls.Add(this.txtSoLuongMon);
            this.grbThemNhomMon.Controls.Add(this.label4);
            this.grbThemNhomMon.Controls.Add(this.txtTenNhom);
            this.grbThemNhomMon.Controls.Add(this.label3);
            this.grbThemNhomMon.Controls.Add(this.txtMaNhom);
            this.grbThemNhomMon.Controls.Add(this.label2);
            this.grbThemNhomMon.Location = new System.Drawing.Point(27, 41);
            this.grbThemNhomMon.Name = "grbThemNhomMon";
            this.grbThemNhomMon.Size = new System.Drawing.Size(261, 271);
            this.grbThemNhomMon.TabIndex = 0;
            this.grbThemNhomMon.TabStop = false;
            this.grbThemNhomMon.Text = "Thêm nhóm món";
            // 
            // btnHuybo
            // 
            this.btnHuybo.Location = new System.Drawing.Point(184, 217);
            this.btnHuybo.Name = "btnHuybo";
            this.btnHuybo.Size = new System.Drawing.Size(61, 23);
            this.btnHuybo.TabIndex = 4;
            this.btnHuybo.Text = "HỦY";
            this.btnHuybo.UseVisualStyleBackColor = true;
            this.btnHuybo.Visible = false;
            this.btnHuybo.Click += new System.EventHandler(this.btnHuybo_Click);
            // 
            // btnThemSuaOk
            // 
            this.btnThemSuaOk.Location = new System.Drawing.Point(117, 217);
            this.btnThemSuaOk.Name = "btnThemSuaOk";
            this.btnThemSuaOk.Size = new System.Drawing.Size(61, 23);
            this.btnThemSuaOk.TabIndex = 3;
            this.btnThemSuaOk.Text = "OK";
            this.btnThemSuaOk.UseVisualStyleBackColor = true;
            this.btnThemSuaOk.Visible = false;
            this.btnThemSuaOk.Click += new System.EventHandler(this.btnThemSuaOk_Click);
            // 
            // txtSoLuongMon
            // 
            this.txtSoLuongMon.Location = new System.Drawing.Point(30, 172);
            this.txtSoLuongMon.Name = "txtSoLuongMon";
            this.txtSoLuongMon.Size = new System.Drawing.Size(215, 20);
            this.txtSoLuongMon.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng món";
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(30, 117);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(215, 20);
            this.txtTenNhom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhóm món:";
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Location = new System.Drawing.Point(30, 58);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.Size = new System.Drawing.Size(215, 20);
            this.txtMaNhom.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhóm món:";
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
            this.groupBox2.Location = new System.Drawing.Point(433, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(668, 488);
            this.groupBox2.TabIndex = 1;
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
            this.dgvNhomMon.Size = new System.Drawing.Size(662, 469);
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
            this.label8.Location = new System.Drawing.Point(701, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Danh sách nhóm món";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(213, 357);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(119, 357);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(27, 357);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // uctThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbThemNhomMon);
            this.Name = "uctThucDon";
            this.Size = new System.Drawing.Size(1120, 555);
            this.Load += new System.EventHandler(this.uctThucDon_Load);
            this.grbThemNhomMon.ResumeLayout(false);
            this.grbThemNhomMon.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMon)).EndInit();
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
    }
}
