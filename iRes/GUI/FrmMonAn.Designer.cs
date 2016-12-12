namespace Title.GUI {
    partial class FrmMonAn {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonAn));
            this.textEditTenMon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDonGia = new DevExpress.XtraEditors.LabelControl();
            this.textEditDonGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.pictureEditHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonExit = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditNhomMon = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditHinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.errorProviderMonAn = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNhomMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditTenMon
            // 
            this.textEditTenMon.Location = new System.Drawing.Point(107, 51);
            this.textEditTenMon.Name = "textEditTenMon";
            this.textEditTenMon.Size = new System.Drawing.Size(169, 20);
            this.textEditTenMon.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên Món";
            // 
            // labelControlDonGia
            // 
            this.labelControlDonGia.Location = new System.Drawing.Point(26, 100);
            this.labelControlDonGia.Name = "labelControlDonGia";
            this.labelControlDonGia.Size = new System.Drawing.Size(38, 13);
            this.labelControlDonGia.TabIndex = 3;
            this.labelControlDonGia.Text = "Đơn Giá";
            // 
            // textEditDonGia
            // 
            this.textEditDonGia.Location = new System.Drawing.Point(107, 97);
            this.textEditDonGia.Name = "textEditDonGia";
            this.textEditDonGia.Size = new System.Drawing.Size(169, 20);
            this.textEditDonGia.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(23, 238);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Mã Nhóm";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Số Lượng";
            // 
            // textEditSoLuong
            // 
            this.textEditSoLuong.Location = new System.Drawing.Point(107, 143);
            this.textEditSoLuong.Name = "textEditSoLuong";
            this.textEditSoLuong.Size = new System.Drawing.Size(169, 20);
            this.textEditSoLuong.TabIndex = 6;
            // 
            // pictureEditHinhAnh
            // 
            this.pictureEditHinhAnh.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEditHinhAnh.Location = new System.Drawing.Point(302, 54);
            this.pictureEditHinhAnh.Name = "pictureEditHinhAnh";
            this.pictureEditHinhAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditHinhAnh.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEditHinhAnh.Size = new System.Drawing.Size(161, 110);
            this.pictureEditHinhAnh.TabIndex = 8;
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSave.Image")));
            this.simpleButtonSave.Location = new System.Drawing.Point(49, 292);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(75, 39);
            this.simpleButtonSave.TabIndex = 9;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(147, 292);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(75, 39);
            this.simpleButtonCancel.TabIndex = 10;
            this.simpleButtonCancel.Text = "Cancel";
            this.simpleButtonCancel.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButtonDelete
            // 
            this.simpleButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonDelete.Image")));
            this.simpleButtonDelete.Location = new System.Drawing.Point(245, 292);
            this.simpleButtonDelete.Name = "simpleButtonDelete";
            this.simpleButtonDelete.Size = new System.Drawing.Size(75, 39);
            this.simpleButtonDelete.TabIndex = 11;
            this.simpleButtonDelete.Text = "Delete";
            this.simpleButtonDelete.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButtonExit
            // 
            this.simpleButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonExit.Image")));
            this.simpleButtonExit.Location = new System.Drawing.Point(343, 292);
            this.simpleButtonExit.Name = "simpleButtonExit";
            this.simpleButtonExit.Size = new System.Drawing.Size(75, 39);
            this.simpleButtonExit.TabIndex = 12;
            this.simpleButtonExit.Text = "Exit";
            this.simpleButtonExit.Click += new System.EventHandler(this.simpleButtonExit_Click);
            // 
            // lookUpEditNhomMon
            // 
            this.lookUpEditNhomMon.Location = new System.Drawing.Point(107, 235);
            this.lookUpEditNhomMon.Name = "lookUpEditNhomMon";
            this.lookUpEditNhomMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNhomMon.Properties.NullText = "";
            this.lookUpEditNhomMon.Size = new System.Drawing.Size(169, 20);
            this.lookUpEditNhomMon.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(26, 192);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Hình Ảnh";
            // 
            // textEditHinhAnh
            // 
            this.textEditHinhAnh.Location = new System.Drawing.Point(107, 189);
            this.textEditHinhAnh.Name = "textEditHinhAnh";
            this.textEditHinhAnh.Size = new System.Drawing.Size(169, 20);
            this.textEditHinhAnh.TabIndex = 14;
            // 
            // errorProviderMonAn
            // 
            this.errorProviderMonAn.ContainerControl = this;
            // 
            // FrmMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 371);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditHinhAnh);
            this.Controls.Add(this.lookUpEditNhomMon);
            this.Controls.Add(this.simpleButtonExit);
            this.Controls.Add(this.simpleButtonDelete);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonSave);
            this.Controls.Add(this.pictureEditHinhAnh);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditSoLuong);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControlDonGia);
            this.Controls.Add(this.textEditDonGia);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditTenMon);
            this.Name = "FrmMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNhomMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditTenMon;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControlDonGia;
        private DevExpress.XtraEditors.TextEdit textEditDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditSoLuong;
        private DevExpress.XtraEditors.PictureEdit pictureEditHinhAnh;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExit;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditNhomMon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditHinhAnh;
        private System.Windows.Forms.ErrorProvider errorProviderMonAn;
    }
}