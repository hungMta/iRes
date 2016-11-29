namespace Title.GUI
{
    partial class UtcQuanLyMonAn
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
            this.gridControlMonAn = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlMonAn
            // 
            this.gridControlMonAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMonAn.Location = new System.Drawing.Point(0, 0);
            this.gridControlMonAn.MainView = this.gridView1;
            this.gridControlMonAn.Name = "gridControlMonAn";
            this.gridControlMonAn.Size = new System.Drawing.Size(803, 402);
            this.gridControlMonAn.TabIndex = 0;
            this.gridControlMonAn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlMonAn;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.RowAutoHeight = true;
            // 
            // UtcQuanLyMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlMonAn);
            this.Name = "UtcQuanLyMonAn";
            this.Size = new System.Drawing.Size(803, 402);
            this.Load += new System.EventHandler(this.UtcQuanLyMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMonAn;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
