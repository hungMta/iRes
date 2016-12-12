namespace Title.GUI
{
    partial class FrmSuaChiTietHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuaChiTietHoaDon));
            this.textEditSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.textEditGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.textEditTenMon = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditMaMon = new DevExpress.XtraEditors.TextEdit();
            this.lbMaMon = new System.Windows.Forms.Label();
            this.simpleButtonHuy = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaMon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditSoLuong
            // 
            this.textEditSoLuong.Location = new System.Drawing.Point(136, 165);
            this.textEditSoLuong.Name = "textEditSoLuong";
            this.textEditSoLuong.Size = new System.Drawing.Size(182, 20);
            this.textEditSoLuong.TabIndex = 18;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbGhiChu.Location = new System.Drawing.Point(49, 207);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(48, 13);
            this.lbGhiChu.TabIndex = 17;
            this.lbGhiChu.Text = "Ghi Chú:";
            // 
            // textEditGhiChu
            // 
            this.textEditGhiChu.EditValue = " ";
            this.textEditGhiChu.Location = new System.Drawing.Point(136, 204);
            this.textEditGhiChu.Name = "textEditGhiChu";
            this.textEditGhiChu.Size = new System.Drawing.Size(182, 20);
            this.textEditGhiChu.TabIndex = 16;
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSoLuong.Location = new System.Drawing.Point(47, 167);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(56, 13);
            this.lbSoLuong.TabIndex = 15;
            this.lbSoLuong.Text = "Số Lượng:";
            // 
            // textEditTenMon
            // 
            this.textEditTenMon.Enabled = false;
            this.textEditTenMon.Location = new System.Drawing.Point(136, 119);
            this.textEditTenMon.Name = "textEditTenMon";
            this.textEditTenMon.Size = new System.Drawing.Size(182, 20);
            this.textEditTenMon.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(46, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên Món:";
            // 
            // textEditMaMon
            // 
            this.textEditMaMon.Enabled = false;
            this.textEditMaMon.Location = new System.Drawing.Point(136, 78);
            this.textEditMaMon.Name = "textEditMaMon";
            this.textEditMaMon.Size = new System.Drawing.Size(182, 20);
            this.textEditMaMon.TabIndex = 12;
            // 
            // lbMaMon
            // 
            this.lbMaMon.AutoSize = true;
            this.lbMaMon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMaMon.Location = new System.Drawing.Point(47, 83);
            this.lbMaMon.Name = "lbMaMon";
            this.lbMaMon.Size = new System.Drawing.Size(49, 13);
            this.lbMaMon.TabIndex = 11;
            this.lbMaMon.Text = "Mã Món:";
            // 
            // simpleButtonHuy
            // 
            this.simpleButtonHuy.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonHuy.Image")));
            this.simpleButtonHuy.Location = new System.Drawing.Point(213, 262);
            this.simpleButtonHuy.Name = "simpleButtonHuy";
            this.simpleButtonHuy.Size = new System.Drawing.Size(75, 42);
            this.simpleButtonHuy.TabIndex = 20;
            this.simpleButtonHuy.Text = "Hủy ";
            this.simpleButtonHuy.Click += new System.EventHandler(this.simpleButtonHuy_Click);
            // 
            // simpleButtonLuu
            // 
            this.simpleButtonLuu.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonLuu.Image")));
            this.simpleButtonLuu.Location = new System.Drawing.Point(77, 266);
            this.simpleButtonLuu.Name = "simpleButtonLuu";
            this.simpleButtonLuu.Size = new System.Drawing.Size(75, 42);
            this.simpleButtonLuu.TabIndex = 19;
            this.simpleButtonLuu.Text = "Lưu";
            this.simpleButtonLuu.Click += new System.EventHandler(this.simpleButtonLuu_Click_1);
            // 
            // FrmSuaChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(357, 343);
            this.Controls.Add(this.simpleButtonHuy);
            this.Controls.Add(this.simpleButtonLuu);
            this.Controls.Add(this.textEditSoLuong);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.textEditGhiChu);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.textEditTenMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEditMaMon);
            this.Controls.Add(this.lbMaMon);
            this.Name = "FrmSuaChiTietHoaDon";
            this.Text = "FrmSuaChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaMon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonHuy;
        private DevExpress.XtraEditors.SimpleButton simpleButtonLuu;
        private DevExpress.XtraEditors.TextEdit textEditSoLuong;
        private System.Windows.Forms.Label lbGhiChu;
        private DevExpress.XtraEditors.TextEdit textEditGhiChu;
        private System.Windows.Forms.Label lbSoLuong;
        private DevExpress.XtraEditors.TextEdit textEditTenMon;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditMaMon;
        private System.Windows.Forms.Label lbMaMon;
    }
}