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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource();
            this.iResDatabaseDataSet1 = new Title.iResDatabaseDataSet1();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colMaKH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colHoDemKH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colHoDemKH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTenKH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTenKH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSDT = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSDT = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colEmail = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colEmail = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colSoLanAn = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colSoLanAn = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colTongChi = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colTongChi = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPhanLoaiKH = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPhanLoaiKH = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.khachHangTableAdapter = new Title.iResDatabaseDataSet1TableAdapters.KhachHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMaKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHoDemKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTenKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSoLanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTongChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhanLoaiKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.khachHangBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(932, 490);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
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
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colMaKH,
            this.colHoDemKH,
            this.colTenKH,
            this.colSDT,
            this.colEmail,
            this.colSoLanAn,
            this.colTongChi,
            this.colPhanLoaiKH});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.LayoutViewField = this.layoutViewField_colMaKH;
            this.colMaKH.Name = "colMaKH";
            // 
            // layoutViewField_colMaKH
            // 
            this.layoutViewField_colMaKH.EditorPreferredWidth = 129;
            this.layoutViewField_colMaKH.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colMaKH.Name = "layoutViewField_colMaKH";
            this.layoutViewField_colMaKH.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colMaKH.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colHoDemKH
            // 
            this.colHoDemKH.FieldName = "HoDemKH";
            this.colHoDemKH.LayoutViewField = this.layoutViewField_colHoDemKH;
            this.colHoDemKH.Name = "colHoDemKH";
            // 
            // layoutViewField_colHoDemKH
            // 
            this.layoutViewField_colHoDemKH.EditorPreferredWidth = 129;
            this.layoutViewField_colHoDemKH.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colHoDemKH.Name = "layoutViewField_colHoDemKH";
            this.layoutViewField_colHoDemKH.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colHoDemKH.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colTenKH
            // 
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.LayoutViewField = this.layoutViewField_colTenKH;
            this.colTenKH.Name = "colTenKH";
            // 
            // layoutViewField_colTenKH
            // 
            this.layoutViewField_colTenKH.EditorPreferredWidth = 129;
            this.layoutViewField_colTenKH.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colTenKH.Name = "layoutViewField_colTenKH";
            this.layoutViewField_colTenKH.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colTenKH.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.LayoutViewField = this.layoutViewField_colSDT;
            this.colSDT.Name = "colSDT";
            // 
            // layoutViewField_colSDT
            // 
            this.layoutViewField_colSDT.EditorPreferredWidth = 129;
            this.layoutViewField_colSDT.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colSDT.Name = "layoutViewField_colSDT";
            this.layoutViewField_colSDT.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colSDT.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.LayoutViewField = this.layoutViewField_colEmail;
            this.colEmail.Name = "colEmail";
            // 
            // layoutViewField_colEmail
            // 
            this.layoutViewField_colEmail.EditorPreferredWidth = 129;
            this.layoutViewField_colEmail.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colEmail.Name = "layoutViewField_colEmail";
            this.layoutViewField_colEmail.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colEmail.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colSoLanAn
            // 
            this.colSoLanAn.FieldName = "SoLanAn";
            this.colSoLanAn.LayoutViewField = this.layoutViewField_colSoLanAn;
            this.colSoLanAn.Name = "colSoLanAn";
            // 
            // layoutViewField_colSoLanAn
            // 
            this.layoutViewField_colSoLanAn.EditorPreferredWidth = 129;
            this.layoutViewField_colSoLanAn.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colSoLanAn.Name = "layoutViewField_colSoLanAn";
            this.layoutViewField_colSoLanAn.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colSoLanAn.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colTongChi
            // 
            this.colTongChi.FieldName = "TongChi";
            this.colTongChi.LayoutViewField = this.layoutViewField_colTongChi;
            this.colTongChi.Name = "colTongChi";
            // 
            // layoutViewField_colTongChi
            // 
            this.layoutViewField_colTongChi.EditorPreferredWidth = 129;
            this.layoutViewField_colTongChi.Location = new System.Drawing.Point(0, 144);
            this.layoutViewField_colTongChi.Name = "layoutViewField_colTongChi";
            this.layoutViewField_colTongChi.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colTongChi.TextSize = new System.Drawing.Size(66, 13);
            // 
            // colPhanLoaiKH
            // 
            this.colPhanLoaiKH.FieldName = "PhanLoaiKH";
            this.colPhanLoaiKH.LayoutViewField = this.layoutViewField_colPhanLoaiKH;
            this.colPhanLoaiKH.Name = "colPhanLoaiKH";
            // 
            // layoutViewField_colPhanLoaiKH
            // 
            this.layoutViewField_colPhanLoaiKH.EditorPreferredWidth = 129;
            this.layoutViewField_colPhanLoaiKH.Location = new System.Drawing.Point(0, 168);
            this.layoutViewField_colPhanLoaiKH.Name = "layoutViewField_colPhanLoaiKH";
            this.layoutViewField_colPhanLoaiKH.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colPhanLoaiKH.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colMaKH,
            this.layoutViewField_colHoDemKH,
            this.layoutViewField_colTenKH,
            this.layoutViewField_colSDT,
            this.layoutViewField_colEmail,
            this.layoutViewField_colSoLanAn,
            this.layoutViewField_colTongChi,
            this.layoutViewField_colPhanLoaiKH});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // UtcQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UtcQuanLyKhachHang";
            this.Size = new System.Drawing.Size(932, 490);
            this.Load += new System.EventHandler(this.UtcQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colMaKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colHoDemKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTenKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colSoLanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colTongChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPhanLoaiKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private iResDatabaseDataSet1 iResDatabaseDataSet1;
        private iResDatabaseDataSet1TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colMaKH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colMaKH;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colHoDemKH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colHoDemKH;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colTenKH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colTenKH;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSDT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSDT;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colEmail;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colEmail;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colSoLanAn;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colSoLanAn;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colTongChi;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colTongChi;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPhanLoaiKH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPhanLoaiKH;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}
