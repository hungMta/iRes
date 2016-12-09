namespace Title.GUI
{
    partial class FrmThemMon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThemMon));
            this.label1 = new System.Windows.Forms.Label();
            this.textEditMaMon = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.textEditTenMon = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textEditSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.textEditHinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.pictureEditMonAn = new DevExpress.XtraEditors.PictureEdit();
            this.lookUpEditNhomMon = new DevExpress.XtraEditors.LookUpEdit();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonHủy = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textEditDonGia = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditMonAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNhomMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã món :";
            // 
            // textEditMaMon
            // 
            this.textEditMaMon.Enabled = false;
            this.textEditMaMon.Location = new System.Drawing.Point(71, 69);
            this.textEditMaMon.Name = "textEditMaMon";
            this.textEditMaMon.Size = new System.Drawing.Size(100, 20);
            this.textEditMaMon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món :";
            // 
            // textEditTenMon
            // 
            this.textEditTenMon.Location = new System.Drawing.Point(74, 101);
            this.textEditTenMon.Name = "textEditTenMon";
            this.textEditTenMon.Size = new System.Drawing.Size(97, 20);
            this.textEditTenMon.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhóm món :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số lượng  :";
            // 
            // textEditSoLuong
            // 
            this.textEditSoLuong.Location = new System.Drawing.Point(71, 174);
            this.textEditSoLuong.Name = "textEditSoLuong";
            this.textEditSoLuong.Size = new System.Drawing.Size(100, 20);
            this.textEditSoLuong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(231, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hình ảnh :";
            // 
            // textEditHinhAnh
            // 
            this.textEditHinhAnh.Location = new System.Drawing.Point(292, 154);
            this.textEditHinhAnh.Name = "textEditHinhAnh";
            this.textEditHinhAnh.Size = new System.Drawing.Size(66, 20);
            this.textEditHinhAnh.TabIndex = 1;
            // 
            // pictureEditMonAn
            // 
            this.pictureEditMonAn.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEditMonAn.Location = new System.Drawing.Point(258, 23);
            this.pictureEditMonAn.Name = "pictureEditMonAn";
            this.pictureEditMonAn.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditMonAn.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEditMonAn.Size = new System.Drawing.Size(100, 96);
            this.pictureEditMonAn.TabIndex = 2;
            // 
            // lookUpEditNhomMon
            // 
            this.lookUpEditNhomMon.Location = new System.Drawing.Point(82, 35);
            this.lookUpEditNhomMon.Name = "lookUpEditNhomMon";
            this.lookUpEditNhomMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditNhomMon.Size = new System.Drawing.Size(100, 20);
            this.lookUpEditNhomMon.TabIndex = 3;
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLuu.Image")));
            this.simpleButtonLuu.Location = new System.Drawing.Point(82, 217);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(71, 35);
            this.simpleButtonLuu.TabIndex = 4;
            this.simpleButtonLuu.Text = "Lưu";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click);
            // 
            // simpleButtonHủy
            // 
            this.simpleButtonHủy.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonHủy.Image")));
            this.simpleButtonHủy.Location = new System.Drawing.Point(211, 217);
            this.simpleButtonHủy.Name = "simpleButtonHủy";
            this.simpleButtonHủy.Size = new System.Drawing.Size(75, 35);
            this.simpleButtonHủy.TabIndex = 5;
            this.simpleButtonHủy.Text = "Hủy";
            this.simpleButtonHủy.Click += new System.EventHandler(this.simpleButtonHủy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(14, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đơn giá :";
            // 
            // textEditDonGia
            // 
            this.textEditDonGia.Location = new System.Drawing.Point(83, 136);
            this.textEditDonGia.Name = "textEditDonGia";
            this.textEditDonGia.Size = new System.Drawing.Size(88, 20);
            this.textEditDonGia.TabIndex = 6;
            // 
            // FrmThemMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(386, 268);
            this.Controls.Add(this.textEditDonGia);
            this.Controls.Add(this.simpleButtonHủy);
            this.Controls.Add(this.simpleButtonLuu);
            this.Controls.Add(this.lookUpEditNhomMon);
            this.Controls.Add(this.pictureEditMonAn);
            this.Controls.Add(this.textEditHinhAnh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textEditSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEditTenMon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEditMaMon);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThemMon";
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditMonAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditNhomMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDonGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditMaMon;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditTenMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit textEditSoLuong;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit textEditHinhAnh;
        private DevExpress.XtraEditors.PictureEdit pictureEditMonAn;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditNhomMon;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.SimpleButton simpleButtonHủy;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textEditDonGia;

    }
}