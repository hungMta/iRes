namespace Title.GUI {
    partial class UctNhapHang {
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
            this.groupControlPhieuNhap = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridViewPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlChiTietPhieuNhap = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDonGia = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTenNguyenLieu = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonHuyChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThemChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.textEditDonGia = new DevExpress.XtraEditors.TextEdit();
            this.textEditSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditNguyenLieu = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControlChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridViewChiTietPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButtonThemPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonHuyPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlButton = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControlMaPhieuNhap = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPhieuNhap)).BeginInit();
            this.groupControlPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChiTietPhieuNhap)).BeginInit();
            this.groupControlChiTietPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNguyenLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButton)).BeginInit();
            this.groupControlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControlPhieuNhap
            // 
            this.groupControlPhieuNhap.Controls.Add(this.labelControl2);
            this.groupControlPhieuNhap.Controls.Add(this.gridControlPhieuNhap);
            this.groupControlPhieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlPhieuNhap.Enabled = false;
            this.groupControlPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.groupControlPhieuNhap.Name = "groupControlPhieuNhap";
            this.groupControlPhieuNhap.Size = new System.Drawing.Size(472, 533);
            this.groupControlPhieuNhap.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(70, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(297, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Danh sách phiếu nhập";
            // 
            // gridControlPhieuNhap
            // 
            this.gridControlPhieuNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlPhieuNhap.Location = new System.Drawing.Point(2, 123);
            this.gridControlPhieuNhap.MainView = this.gridViewPhieuNhap;
            this.gridControlPhieuNhap.Name = "gridControlPhieuNhap";
            this.gridControlPhieuNhap.Size = new System.Drawing.Size(468, 408);
            this.gridControlPhieuNhap.TabIndex = 0;
            this.gridControlPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhieuNhap});
            // 
            // gridViewPhieuNhap
            // 
            this.gridViewPhieuNhap.GridControl = this.gridControlPhieuNhap;
            this.gridViewPhieuNhap.Name = "gridViewPhieuNhap";
            this.gridViewPhieuNhap.OptionsBehavior.Editable = false;
            this.gridViewPhieuNhap.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPhieuNhap_RowClick);
            // 
            // groupControlChiTietPhieuNhap
            // 
            this.groupControlChiTietPhieuNhap.Controls.Add(this.labelControlMaPhieuNhap);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.labelControl3);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.labelControlSoLuong);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.labelControlDonGia);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.labelControlTenNguyenLieu);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.simpleButtonHuyChiTiet);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.simpleButtonThemChiTiet);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.textEditDonGia);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.textEditSoLuong);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.label2);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.label1);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.labelControl1);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.lookUpEditNguyenLieu);
            this.groupControlChiTietPhieuNhap.Controls.Add(this.gridControlChiTietPhieuNhap);
            this.groupControlChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControlChiTietPhieuNhap.Enabled = false;
            this.groupControlChiTietPhieuNhap.Location = new System.Drawing.Point(733, 0);
            this.groupControlChiTietPhieuNhap.Name = "groupControlChiTietPhieuNhap";
            this.groupControlChiTietPhieuNhap.Size = new System.Drawing.Size(529, 533);
            this.groupControlChiTietPhieuNhap.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(143, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(255, 33);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Chi tiết phiếu nhập";
            // 
            // labelControlSoLuong
            // 
            this.labelControlSoLuong.Location = new System.Drawing.Point(295, 131);
            this.labelControlSoLuong.Name = "labelControlSoLuong";
            this.labelControlSoLuong.Size = new System.Drawing.Size(103, 13);
            this.labelControlSoLuong.TabIndex = 11;
            this.labelControlSoLuong.Text = "labelControlShowInfo";
            this.labelControlSoLuong.Visible = false;
            // 
            // labelControlDonGia
            // 
            this.labelControlDonGia.Location = new System.Drawing.Point(295, 169);
            this.labelControlDonGia.Name = "labelControlDonGia";
            this.labelControlDonGia.Size = new System.Drawing.Size(103, 13);
            this.labelControlDonGia.TabIndex = 10;
            this.labelControlDonGia.Text = "labelControlShowInfo";
            this.labelControlDonGia.Visible = false;
            // 
            // labelControlTenNguyenLieu
            // 
            this.labelControlTenNguyenLieu.Location = new System.Drawing.Point(295, 97);
            this.labelControlTenNguyenLieu.Name = "labelControlTenNguyenLieu";
            this.labelControlTenNguyenLieu.Size = new System.Drawing.Size(103, 13);
            this.labelControlTenNguyenLieu.TabIndex = 9;
            this.labelControlTenNguyenLieu.Text = "labelControlShowInfo";
            this.labelControlTenNguyenLieu.Visible = false;
            // 
            // simpleButtonHuyChiTiet
            // 
            this.simpleButtonHuyChiTiet.Location = new System.Drawing.Point(201, 201);
            this.simpleButtonHuyChiTiet.Name = "simpleButtonHuyChiTiet";
            this.simpleButtonHuyChiTiet.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonHuyChiTiet.TabIndex = 8;
            this.simpleButtonHuyChiTiet.Text = "Hủy";
            this.simpleButtonHuyChiTiet.Click += new System.EventHandler(this.simpleButtonHuyChiTiet_Click);
            // 
            // simpleButtonThemChiTiet
            // 
            this.simpleButtonThemChiTiet.Location = new System.Drawing.Point(104, 201);
            this.simpleButtonThemChiTiet.Name = "simpleButtonThemChiTiet";
            this.simpleButtonThemChiTiet.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonThemChiTiet.TabIndex = 7;
            this.simpleButtonThemChiTiet.Text = "Thêm";
            this.simpleButtonThemChiTiet.Click += new System.EventHandler(this.simpleButtonThemChiTiet_Click);
            // 
            // textEditDonGia
            // 
            this.textEditDonGia.Location = new System.Drawing.Point(104, 166);
            this.textEditDonGia.Name = "textEditDonGia";
            this.textEditDonGia.Size = new System.Drawing.Size(172, 20);
            this.textEditDonGia.TabIndex = 6;
            // 
            // textEditSoLuong
            // 
            this.textEditSoLuong.Location = new System.Drawing.Point(104, 128);
            this.textEditSoLuong.Name = "textEditSoLuong";
            this.textEditSoLuong.Size = new System.Drawing.Size(172, 20);
            this.textEditSoLuong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số lượng";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên nguyên liệu";
            // 
            // lookUpEditNguyenLieu
            // 
            this.lookUpEditNguyenLieu.Location = new System.Drawing.Point(104, 94);
            this.lookUpEditNguyenLieu.Name = "lookUpEditNguyenLieu";
            this.lookUpEditNguyenLieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNguyenLieu.Properties.NullText = "";
            this.lookUpEditNguyenLieu.Size = new System.Drawing.Size(172, 20);
            this.lookUpEditNguyenLieu.TabIndex = 1;
            // 
            // gridControlChiTietPhieuNhap
            // 
            this.gridControlChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlChiTietPhieuNhap.Location = new System.Drawing.Point(2, 239);
            this.gridControlChiTietPhieuNhap.MainView = this.gridViewChiTietPhieuNhap;
            this.gridControlChiTietPhieuNhap.Name = "gridControlChiTietPhieuNhap";
            this.gridControlChiTietPhieuNhap.Size = new System.Drawing.Size(525, 292);
            this.gridControlChiTietPhieuNhap.TabIndex = 0;
            this.gridControlChiTietPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChiTietPhieuNhap});
            // 
            // gridViewChiTietPhieuNhap
            // 
            this.gridViewChiTietPhieuNhap.GridControl = this.gridControlChiTietPhieuNhap;
            this.gridViewChiTietPhieuNhap.Name = "gridViewChiTietPhieuNhap";
            // 
            // simpleButtonThemPhieuNhap
            // 
            this.simpleButtonThemPhieuNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonThemPhieuNhap.Appearance.Options.UseFont = true;
            this.simpleButtonThemPhieuNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.simpleButtonThemPhieuNhap.Location = new System.Drawing.Point(0, 103);
            this.simpleButtonThemPhieuNhap.Name = "simpleButtonThemPhieuNhap";
            this.simpleButtonThemPhieuNhap.Size = new System.Drawing.Size(257, 96);
            this.simpleButtonThemPhieuNhap.TabIndex = 2;
            this.simpleButtonThemPhieuNhap.Text = "Thêm";
            this.simpleButtonThemPhieuNhap.Click += new System.EventHandler(this.simpleButtonThemPhieuNhap_Click);
            // 
            // simpleButtonHuyPhieuNhap
            // 
            this.simpleButtonHuyPhieuNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonHuyPhieuNhap.Appearance.Options.UseFont = true;
            this.simpleButtonHuyPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.simpleButtonHuyPhieuNhap.Enabled = false;
            this.simpleButtonHuyPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.simpleButtonHuyPhieuNhap.Name = "simpleButtonHuyPhieuNhap";
            this.simpleButtonHuyPhieuNhap.Size = new System.Drawing.Size(257, 99);
            this.simpleButtonHuyPhieuNhap.TabIndex = 3;
            this.simpleButtonHuyPhieuNhap.Text = "Hủy";
            this.simpleButtonHuyPhieuNhap.Click += new System.EventHandler(this.simpleButtonHuyPhieuNhap_Click);
            // 
            // groupControlButton
            // 
            this.groupControlButton.Controls.Add(this.groupControl2);
            this.groupControlButton.Controls.Add(this.groupControl1);
            this.groupControlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlButton.Location = new System.Drawing.Point(472, 0);
            this.groupControlButton.Name = "groupControlButton";
            this.groupControlButton.Size = new System.Drawing.Size(261, 533);
            this.groupControlButton.TabIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl2.Controls.Add(this.simpleButtonHuyPhieuNhap);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 239);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(257, 292);
            this.groupControl2.TabIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControl1.Controls.Add(this.simpleButtonThemPhieuNhap);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 20);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(257, 199);
            this.groupControl1.TabIndex = 3;
            // 
            // labelControlMaPhieuNhap
            // 
            this.labelControlMaPhieuNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlMaPhieuNhap.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelControlMaPhieuNhap.Appearance.Options.UseFont = true;
            this.labelControlMaPhieuNhap.Appearance.Options.UseForeColor = true;
            this.labelControlMaPhieuNhap.Location = new System.Drawing.Point(6, 23);
            this.labelControlMaPhieuNhap.Name = "labelControlMaPhieuNhap";
            this.labelControlMaPhieuNhap.Size = new System.Drawing.Size(159, 14);
            this.labelControlMaPhieuNhap.TabIndex = 12;
            this.labelControlMaPhieuNhap.Text = "labelControlMaPhieuNhap";
            this.labelControlMaPhieuNhap.Visible = false;
            // 
            // UctNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlButton);
            this.Controls.Add(this.groupControlChiTietPhieuNhap);
            this.Controls.Add(this.groupControlPhieuNhap);
            this.Name = "UctNhapHang";
            this.Size = new System.Drawing.Size(1262, 533);
            this.Load += new System.EventHandler(this.UctNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPhieuNhap)).EndInit();
            this.groupControlPhieuNhap.ResumeLayout(false);
            this.groupControlPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlChiTietPhieuNhap)).EndInit();
            this.groupControlChiTietPhieuNhap.ResumeLayout(false);
            this.groupControlChiTietPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNguyenLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButton)).EndInit();
            this.groupControlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlPhieuNhap;
        private DevExpress.XtraGrid.GridControl gridControlPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhieuNhap;
        private DevExpress.XtraEditors.GroupControl groupControlChiTietPhieuNhap;
        private DevExpress.XtraGrid.GridControl gridControlChiTietPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChiTietPhieuNhap;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThemPhieuNhap;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHuyPhieuNhap;
        private DevExpress.XtraEditors.GroupControl groupControlButton;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditNguyenLieu;
        private DevExpress.XtraEditors.LabelControl labelControlSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControlDonGia;
        private DevExpress.XtraEditors.LabelControl labelControlTenNguyenLieu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHuyChiTiet;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThemChiTiet;
        private DevExpress.XtraEditors.TextEdit textEditDonGia;
        private DevExpress.XtraEditors.TextEdit textEditSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControlMaPhieuNhap;
    }
}
