namespace Title.GUI {
    partial class UtcQuanLyNhanVien {
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
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iResDatabaseDataSet = new Title.iResDatabaseDataSet();
            this.nhanVienTableAdapter = new Title.iResDatabaseDataSetTableAdapters.NhanVienTableAdapter();
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iResDatabaseDataSet2 = new Title.iResDatabaseDataSet2();
            this.nhanVienTableAdapter1 = new Title.iResDatabaseDataSet2TableAdapters.NhanVienTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.iResDatabaseDataSet;
            // 
            // iResDatabaseDataSet
            // 
            this.iResDatabaseDataSet.DataSetName = "iResDatabaseDataSet";
            this.iResDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.DataSource = this.nhanVienBindingSource1;
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhanVien.MainView = this.gridView1;
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(1075, 550);
            this.gridControlNhanVien.TabIndex = 0;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.iResDatabaseDataSet2;
            // 
            // iResDatabaseDataSet2
            // 
            this.iResDatabaseDataSet2.DataSetName = "iResDatabaseDataSet2";
            this.iResDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter1
            // 
            this.nhanVienTableAdapter1.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colNgaySinh,
            this.colQueQuan,
            this.colLuong,
            this.colChucVu,
            this.colMatKhau});
            this.gridView1.GridControl = this.gridControlNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colTenNV
            // 
            this.colTenNV.FieldName = "TenNV";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Visible = true;
            this.colTenNV.VisibleIndex = 1;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            // 
            // colQueQuan
            // 
            this.colQueQuan.FieldName = "QueQuan";
            this.colQueQuan.Name = "colQueQuan";
            this.colQueQuan.Visible = true;
            this.colQueQuan.VisibleIndex = 3;
            // 
            // colLuong
            // 
            this.colLuong.FieldName = "Luong";
            this.colLuong.Name = "colLuong";
            this.colLuong.Visible = true;
            this.colLuong.VisibleIndex = 4;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 5;
            // 
            // colMatKhau
            // 
            this.colMatKhau.FieldName = "MatKhau";
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.Visible = true;
            this.colMatKhau.VisibleIndex = 6;
            // 
            // UtcQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.gridControlNhanVien);
            this.Name = "UtcQuanLyNhanVien";
            this.Size = new System.Drawing.Size(1075, 550);
            this.Load += new System.EventHandler(this.UtcQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iResDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private iResDatabaseDataSet iResDatabaseDataSet;
        private iResDatabaseDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private iResDatabaseDataSet2 iResDatabaseDataSet2;
        private iResDatabaseDataSet2TableAdapters.NhanVienTableAdapter nhanVienTableAdapter1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colQueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
    }
}
