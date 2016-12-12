namespace Title.GUI {
    partial class UctQuanLyNhomMon {
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridControlNhomMon = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhomMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelNhomMon = new System.Windows.Forms.Panel();
            this.textEditTongSoMon = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditTenNhom = new DevExpress.XtraEditors.TextEdit();
            this.lbTenNhom = new System.Windows.Forms.Label();
            this.textEditMaNhom = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhomMon)).BeginInit();
            this.panelNhomMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTongSoMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaNhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNhomMon
            // 
            this.gridControlNhomMon.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControlNhomMon.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControlNhomMon.Location = new System.Drawing.Point(0, 97);
            this.gridControlNhomMon.MainView = this.gridViewNhomMon;
            this.gridControlNhomMon.Name = "gridControlNhomMon";
            this.gridControlNhomMon.Size = new System.Drawing.Size(1247, 419);
            this.gridControlNhomMon.TabIndex = 0;
            this.gridControlNhomMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhomMon});
            // 
            // gridViewNhomMon
            // 
            this.gridViewNhomMon.GridControl = this.gridControlNhomMon;
            this.gridViewNhomMon.Name = "gridViewNhomMon";
            this.gridViewNhomMon.OptionsBehavior.Editable = false;
            this.gridViewNhomMon.OptionsFind.AlwaysVisible = true;
            this.gridViewNhomMon.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewNhomMon_RowClick);
            this.gridViewNhomMon.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewNhomMon_FocusedRowChanged);
            // 
            // panelNhomMon
            // 
            this.panelNhomMon.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelNhomMon.Controls.Add(this.textEditTongSoMon);
            this.panelNhomMon.Controls.Add(this.label2);
            this.panelNhomMon.Controls.Add(this.textEditTenNhom);
            this.panelNhomMon.Controls.Add(this.lbTenNhom);
            this.panelNhomMon.Controls.Add(this.textEditMaNhom);
            this.panelNhomMon.Controls.Add(this.label1);
            this.panelNhomMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNhomMon.Enabled = false;
            this.panelNhomMon.Location = new System.Drawing.Point(0, 0);
            this.panelNhomMon.Name = "panelNhomMon";
            this.panelNhomMon.Size = new System.Drawing.Size(1247, 97);
            this.panelNhomMon.TabIndex = 3;
            // 
            // textEditTongSoMon
            // 
            this.textEditTongSoMon.EditValue = "";
            this.textEditTongSoMon.Enabled = false;
            this.textEditTongSoMon.Location = new System.Drawing.Point(868, 31);
            this.textEditTongSoMon.Name = "textEditTongSoMon";
            this.textEditTongSoMon.Size = new System.Drawing.Size(169, 20);
            this.textEditTongSoMon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(788, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng Số Món:";
            // 
            // textEditTenNhom
            // 
            this.textEditTenNhom.EditValue = "";
            this.textEditTenNhom.Location = new System.Drawing.Point(537, 31);
            this.textEditTenNhom.Name = "textEditTenNhom";
            this.textEditTenNhom.Size = new System.Drawing.Size(169, 20);
            this.textEditTenNhom.TabIndex = 3;
            // 
            // lbTenNhom
            // 
            this.lbTenNhom.AutoSize = true;
            this.lbTenNhom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTenNhom.Location = new System.Drawing.Point(462, 34);
            this.lbTenNhom.Name = "lbTenNhom";
            this.lbTenNhom.Size = new System.Drawing.Size(63, 13);
            this.lbTenNhom.TabIndex = 2;
            this.lbTenNhom.Text = "Tên Nhóm: ";
            // 
            // textEditMaNhom
            // 
            this.textEditMaNhom.Enabled = false;
            this.textEditMaNhom.Location = new System.Drawing.Point(166, 31);
            this.textEditMaNhom.Name = "textEditMaNhom";
            this.textEditMaNhom.Size = new System.Drawing.Size(169, 20);
            this.textEditMaNhom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(91, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhóm: ";
            // 
            // UctQuanLyNhomMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlNhomMon);
            this.Controls.Add(this.panelNhomMon);
            this.Name = "UctQuanLyNhomMon";
            this.Size = new System.Drawing.Size(1247, 516);
            this.Load += new System.EventHandler(this.UctQuanLyNhomMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhomMon)).EndInit();
            this.panelNhomMon.ResumeLayout(false);
            this.panelNhomMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTongSoMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaNhom.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNhomMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhomMon;
        private System.Windows.Forms.Panel panelNhomMon;
        private DevExpress.XtraEditors.TextEdit textEditTongSoMon;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditTenNhom;
        private System.Windows.Forms.Label lbTenNhom;
        private DevExpress.XtraEditors.TextEdit textEditMaNhom;
        private System.Windows.Forms.Label label1;
    }
}
