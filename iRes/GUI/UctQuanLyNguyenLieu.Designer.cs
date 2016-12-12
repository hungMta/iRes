namespace Title.GUI
{
    partial class UctQuanLyNguyenLieu
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControlNguyenLieu = new DevExpress.XtraGrid.GridControl();
            this.gridViewNguyenLieu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNguyenLieu = new System.Windows.Forms.Panel();
            this.textEditDonGia = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.textEditDonVi = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditTenNL = new DevExpress.XtraEditors.TextEdit();
            this.lbTenNhom = new System.Windows.Forms.Label();
            this.textEditMaNL = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguyenLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguyenLieu)).BeginInit();
            this.panelNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaNL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNguyenLieu
            // 
            this.gridControlNguyenLieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gridControlNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlNguyenLieu.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlNguyenLieu.Location = new System.Drawing.Point(0, 146);
            this.gridControlNguyenLieu.MainView = this.gridViewNguyenLieu;
            this.gridControlNguyenLieu.Name = "gridControlNguyenLieu";
            this.gridControlNguyenLieu.Size = new System.Drawing.Size(944, 365);
            this.gridControlNguyenLieu.TabIndex = 6;
            this.gridControlNguyenLieu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNguyenLieu});
            // 
            // gridViewNguyenLieu
            // 
            this.gridViewNguyenLieu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNL,
            this.TenNL,
            this.DonVi,
            this.DonGia});
            this.gridViewNguyenLieu.GridControl = this.gridControlNguyenLieu;
            this.gridViewNguyenLieu.Name = "gridViewNguyenLieu";
            this.gridViewNguyenLieu.OptionsBehavior.Editable = false;
            this.gridViewNguyenLieu.OptionsFind.AlwaysVisible = true;
            this.gridViewNguyenLieu.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewNguyenLieu_RowClick);
            this.gridViewNguyenLieu.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNguyenLieu_FocusedRowChanged);
            // 
            // MaNL
            // 
            this.MaNL.Caption = "Mã nguyên liệu";
            this.MaNL.FieldName = "MaNL";
            this.MaNL.Name = "MaNL";
            this.MaNL.Visible = true;
            this.MaNL.VisibleIndex = 0;
            // 
            // TenNL
            // 
            this.TenNL.Caption = "Tên nguyên liệu";
            this.TenNL.FieldName = "TenNL";
            this.TenNL.Name = "TenNL";
            this.TenNL.Visible = true;
            this.TenNL.VisibleIndex = 1;
            // 
            // DonVi
            // 
            this.DonVi.Caption = "Đơn vị";
            this.DonVi.FieldName = "DonVi";
            this.DonVi.Name = "DonVi";
            this.DonVi.Visible = true;
            this.DonVi.VisibleIndex = 2;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            // 
            // panelNguyenLieu
            // 
            this.panelNguyenLieu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelNguyenLieu.Controls.Add(this.textEditDonGia);
            this.panelNguyenLieu.Controls.Add(this.label3);
            this.panelNguyenLieu.Controls.Add(this.textEditDonVi);
            this.panelNguyenLieu.Controls.Add(this.label2);
            this.panelNguyenLieu.Controls.Add(this.textEditTenNL);
            this.panelNguyenLieu.Controls.Add(this.lbTenNhom);
            this.panelNguyenLieu.Controls.Add(this.textEditMaNL);
            this.panelNguyenLieu.Controls.Add(this.label1);
            this.panelNguyenLieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNguyenLieu.Enabled = false;
            this.panelNguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.panelNguyenLieu.Name = "panelNguyenLieu";
            this.panelNguyenLieu.Size = new System.Drawing.Size(944, 146);
            this.panelNguyenLieu.TabIndex = 7;
            // 
            // textEditDonGia
            // 
            this.textEditDonGia.EditValue = "";
            this.textEditDonGia.Location = new System.Drawing.Point(586, 75);
            this.textEditDonGia.Name = "textEditDonGia";
            this.textEditDonGia.Size = new System.Drawing.Size(225, 20);
            this.textEditDonGia.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(500, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đơn giá:";
            // 
            // textEditDonVi
            // 
            this.textEditDonVi.EditValue = "";
            this.textEditDonVi.Location = new System.Drawing.Point(586, 33);
            this.textEditDonVi.Name = "textEditDonVi";
            this.textEditDonVi.Size = new System.Drawing.Size(225, 20);
            this.textEditDonVi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(500, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đơn vị: ";
            // 
            // textEditTenNL
            // 
            this.textEditTenNL.EditValue = "";
            this.textEditTenNL.Location = new System.Drawing.Point(193, 75);
            this.textEditTenNL.Name = "textEditTenNL";
            this.textEditTenNL.Size = new System.Drawing.Size(219, 20);
            this.textEditTenNL.TabIndex = 3;
            // 
            // lbTenNhom
            // 
            this.lbTenNhom.AutoSize = true;
            this.lbTenNhom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTenNhom.Location = new System.Drawing.Point(51, 78);
            this.lbTenNhom.Name = "lbTenNhom";
            this.lbTenNhom.Size = new System.Drawing.Size(89, 13);
            this.lbTenNhom.TabIndex = 2;
            this.lbTenNhom.Text = "Tên nguyên liệu: ";
            // 
            // textEditMaNL
            // 
            this.textEditMaNL.Enabled = false;
            this.textEditMaNL.Location = new System.Drawing.Point(193, 33);
            this.textEditMaNL.Name = "textEditMaNL";
            this.textEditMaNL.Size = new System.Drawing.Size(219, 20);
            this.textEditMaNL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nguyên liệu:";
            // 
            // UctQuanLyNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlNguyenLieu);
            this.Controls.Add(this.panelNguyenLieu);
            this.Name = "UctQuanLyNguyenLieu";
            this.Size = new System.Drawing.Size(944, 511);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNguyenLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNguyenLieu)).EndInit();
            this.panelNguyenLieu.ResumeLayout(false);
            this.panelNguyenLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaNL.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNguyenLieu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNguyenLieu;
        private DevExpress.XtraGrid.Columns.GridColumn MaNL;
        private DevExpress.XtraGrid.Columns.GridColumn TenNL;
        private DevExpress.XtraGrid.Columns.GridColumn DonVi;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private System.Windows.Forms.Panel panelNguyenLieu;
        private DevExpress.XtraEditors.TextEdit textEditDonGia;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEditDonVi;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditTenNL;
        private System.Windows.Forms.Label lbTenNhom;
        private DevExpress.XtraEditors.TextEdit textEditMaNL;
        private System.Windows.Forms.Label label1;
    }
}
