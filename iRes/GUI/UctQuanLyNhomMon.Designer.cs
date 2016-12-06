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
            this.gridControlNhomMon = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhomMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhomMon)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNhomMon
            // 
            this.gridControlNhomMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhomMon.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhomMon.MainView = this.gridViewNhomMon;
            this.gridControlNhomMon.Name = "gridControlNhomMon";
            this.gridControlNhomMon.Size = new System.Drawing.Size(1247, 516);
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
            // 
            // UctQuanLyNhomMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlNhomMon);
            this.Name = "UctQuanLyNhomMon";
            this.Size = new System.Drawing.Size(1247, 516);
            this.Load += new System.EventHandler(this.UctQuanLyNhomMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhomMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhomMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNhomMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhomMon;
    }
}
