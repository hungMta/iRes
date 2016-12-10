namespace Title.GUI {
    partial class UtcQuanLyKhachHang {
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
            this.components = new System.ComponentModel.Container();
            this.gridControlKhachHang = new DevExpress.XtraGrid.GridControl();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iResDatabaseDataSet1 = new Title.iResDatabaseDataSet1();
            this.gridViewKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLanAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanLoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHangTableAdapter = new Title.iResDatabaseDataSet1TableAdapters.KhachHangTableAdapter();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.cbxPhanLoai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTongChi = new DevExpress.XtraEditors.TextEdit();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.textEditSoLanAn = new DevExpress.XtraEditors.TextEdit();
            this.textEditSDT = new DevExpress.XtraEditors.TextEdit();
            this.textEditDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.textEditTen = new DevExpress.XtraEditors.TextEdit();
            this.textEditMaKH = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).BeginInit();
            this.panelTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPhanLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTongChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLanAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlKhachHang
            // 
            this.gridControlKhachHang.DataSource = this.khachHangBindingSource;
            this.gridControlKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKhachHang.Location = new System.Drawing.Point(0, 111);
            this.gridControlKhachHang.MainView = this.gridViewKhachHang;
            this.gridControlKhachHang.Name = "gridControlKhachHang";
            this.gridControlKhachHang.Size = new System.Drawing.Size(932, 379);
            this.gridControlKhachHang.TabIndex = 0;
            this.gridControlKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKhachHang});
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.iResDatabaseDataSet1;
            // 
            // iResDatabaseDataSet1
            // 
            this.iResDatabaseDataSet1.DataSetName = "iResDatabaseDataSet1";
            this.iResDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewKhachHang
            // 
            this.gridViewKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colSDT,
            this.colEmail,
            this.colSoLanAn,
            this.colTongTien,
            this.colPhanLoaiKH,
            this.colDiaChi});
            this.gridViewKhachHang.GridControl = this.gridControlKhachHang;
            this.gridViewKhachHang.Name = "gridViewKhachHang";
            this.gridViewKhachHang.OptionsBehavior.Editable = false;
            this.gridViewKhachHang.OptionsFind.AlwaysVisible = true;
            this.gridViewKhachHang.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            // 
            // colTenKH
            // 
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 1;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 4;
            // 
            // colSoLanAn
            // 
            this.colSoLanAn.FieldName = "SoLanAn";
            this.colSoLanAn.Name = "colSoLanAn";
            this.colSoLanAn.Visible = true;
            this.colSoLanAn.VisibleIndex = 5;
            // 
            // colTongTien
            // 
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 6;
            // 
            // colPhanLoaiKH
            // 
            this.colPhanLoaiKH.FieldName = "PhanLoai";
            this.colPhanLoaiKH.Name = "colPhanLoaiKH";
            this.colPhanLoaiKH.Visible = true;
            this.colPhanLoaiKH.VisibleIndex = 7;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 2;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // panelTextBox
            // 
            this.panelTextBox.Controls.Add(this.cbxPhanLoai);
            this.panelTextBox.Controls.Add(this.labelControl10);
            this.panelTextBox.Controls.Add(this.labelControl9);
            this.panelTextBox.Controls.Add(this.labelControl8);
            this.panelTextBox.Controls.Add(this.labelControl7);
            this.panelTextBox.Controls.Add(this.labelControl5);
            this.panelTextBox.Controls.Add(this.labelControl4);
            this.panelTextBox.Controls.Add(this.labelControl2);
            this.panelTextBox.Controls.Add(this.labelControl1);
            this.panelTextBox.Controls.Add(this.textEditTongChi);
            this.panelTextBox.Controls.Add(this.textEditEmail);
            this.panelTextBox.Controls.Add(this.textEditSoLanAn);
            this.panelTextBox.Controls.Add(this.textEditSDT);
            this.panelTextBox.Controls.Add(this.textEditDiaChi);
            this.panelTextBox.Controls.Add(this.textEditTen);
            this.panelTextBox.Controls.Add(this.textEditMaKH);
            this.panelTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTextBox.Enabled = false;
            this.panelTextBox.Location = new System.Drawing.Point(0, 0);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Size = new System.Drawing.Size(932, 111);
            this.panelTextBox.TabIndex = 2;
            // 
            // cbxPhanLoai
            // 
            this.cbxPhanLoai.Location = new System.Drawing.Point(836, 55);
            this.cbxPhanLoai.Name = "cbxPhanLoai";
            this.cbxPhanLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPhanLoai.Properties.Items.AddRange(new object[] {
            "VIP",
            "Normal"});
            this.cbxPhanLoai.Size = new System.Drawing.Size(145, 20);
            this.cbxPhanLoai.TabIndex = 25;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(755, 55);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(59, 13);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Phân loại KH";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(770, 6);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Số lần ăn";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(23, 58);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(32, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Địa chỉ";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(770, 29);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Tổng chi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(399, 32);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(24, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Email";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Tên KH";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(399, 6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "SĐT";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Mã KH";
            // 
            // textEditTongChi
            // 
            this.textEditTongChi.Location = new System.Drawing.Point(836, 29);
            this.textEditTongChi.Name = "textEditTongChi";
            this.textEditTongChi.Size = new System.Drawing.Size(251, 20);
            this.textEditTongChi.TabIndex = 12;
            // 
            // textEditEmail
            // 
            this.textEditEmail.Location = new System.Drawing.Point(455, 29);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Size = new System.Drawing.Size(251, 20);
            this.textEditEmail.TabIndex = 7;
            // 
            // textEditSoLanAn
            // 
            this.textEditSoLanAn.Location = new System.Drawing.Point(836, 3);
            this.textEditSoLanAn.Name = "textEditSoLanAn";
            this.textEditSoLanAn.Size = new System.Drawing.Size(251, 20);
            this.textEditSoLanAn.TabIndex = 6;
            // 
            // textEditSDT
            // 
            this.textEditSDT.Location = new System.Drawing.Point(455, 3);
            this.textEditSDT.Name = "textEditSDT";
            this.textEditSDT.Size = new System.Drawing.Size(251, 20);
            this.textEditSDT.TabIndex = 5;
            // 
            // textEditDiaChi
            // 
            this.textEditDiaChi.Location = new System.Drawing.Point(81, 55);
            this.textEditDiaChi.Name = "textEditDiaChi";
            this.textEditDiaChi.Size = new System.Drawing.Size(431, 20);
            this.textEditDiaChi.TabIndex = 2;
            // 
            // textEditTen
            // 
            this.textEditTen.Location = new System.Drawing.Point(81, 29);
            this.textEditTen.Name = "textEditTen";
            this.textEditTen.Size = new System.Drawing.Size(251, 20);
            this.textEditTen.TabIndex = 1;
            // 
            // textEditMaKH
            // 
            this.textEditMaKH.Enabled = false;
            this.textEditMaKH.Location = new System.Drawing.Point(81, 3);
            this.textEditMaKH.Name = "textEditMaKH";
            this.textEditMaKH.Size = new System.Drawing.Size(251, 20);
            this.textEditMaKH.TabIndex = 0;
            // 
            // UtcQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlKhachHang);
            this.Controls.Add(this.panelTextBox);
            this.Name = "UtcQuanLyKhachHang";
            this.Size = new System.Drawing.Size(932, 490);
            this.Load += new System.EventHandler(this.UtcQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKhachHang)).EndInit();
            this.panelTextBox.ResumeLayout(false);
            this.panelTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPhanLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTongChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLanAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaKH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlKhachHang;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private iResDatabaseDataSet1 iResDatabaseDataSet1;
        private iResDatabaseDataSet1TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLanAn;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanLoaiKH;
        private System.Windows.Forms.Panel panelTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditTongChi;
        private DevExpress.XtraEditors.TextEdit textEditEmail;
        private DevExpress.XtraEditors.TextEdit textEditSoLanAn;
        private DevExpress.XtraEditors.TextEdit textEditSDT;
        private DevExpress.XtraEditors.TextEdit textEditDiaChi;
        private DevExpress.XtraEditors.TextEdit textEditTen;
        private DevExpress.XtraEditors.TextEdit textEditMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraEditors.ComboBoxEdit cbxPhanLoai;
    }
}
