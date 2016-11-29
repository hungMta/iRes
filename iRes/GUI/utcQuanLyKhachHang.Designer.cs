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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iResDatabaseDataSet1 = new Title.iResDatabaseDataSet1();
            this.khachHangTableAdapter = new Title.iResDatabaseDataSet1TableAdapters.KhachHangTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoDemKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLanAn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanLoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.khachHangBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(932, 490);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colHoDemKH,
            this.colTenKH,
            this.colSDT,
            this.colEmail,
            this.colSoLanAn,
            this.colTongChi,
            this.colPhanLoaiKH});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            // 
            // colHoDemKH
            // 
            this.colHoDemKH.FieldName = "HoDemKH";
            this.colHoDemKH.Name = "colHoDemKH";
            this.colHoDemKH.Visible = true;
            this.colHoDemKH.VisibleIndex = 1;
            // 
            // colTenKH
            // 
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 2;
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
            // colTongChi
            // 
            this.colTongChi.FieldName = "TongChi";
            this.colTongChi.Name = "colTongChi";
            this.colTongChi.Visible = true;
            this.colTongChi.VisibleIndex = 6;
            // 
            // colPhanLoaiKH
            // 
            this.colPhanLoaiKH.FieldName = "PhanLoaiKH";
            this.colPhanLoaiKH.Name = "colPhanLoaiKH";
            this.colPhanLoaiKH.Visible = true;
            this.colPhanLoaiKH.VisibleIndex = 7;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private iResDatabaseDataSet1 iResDatabaseDataSet1;
        private iResDatabaseDataSet1TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colHoDemKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLanAn;
        private DevExpress.XtraGrid.Columns.GridColumn colTongChi;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanLoaiKH;
    }
}
