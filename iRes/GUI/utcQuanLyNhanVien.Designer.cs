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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtcQuanLyNhanVien));
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureEditAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.comboBoxTrangThai = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSDT = new DevExpress.XtraEditors.TextEdit();
            this.comboBoxGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditQueQuan = new DevExpress.XtraEditors.TextEdit();
            this.textEditMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.textEditChucVu = new DevExpress.XtraEditors.TextEdit();
            this.textEditTenNV = new DevExpress.XtraEditors.TextEdit();
            this.textEditHinhAnh = new DevExpress.XtraEditors.TextEdit();
            this.textEditLuong = new DevExpress.XtraEditors.TextEdit();
            this.textEditMaNV = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditAvatar.Properties)).BeginInit();
            this.panelTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQueQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaNV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 123);
            this.gridControlNhanVien.MainView = this.gridView1;
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(1075, 427);
            this.gridControlNhanVien.TabIndex = 0;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControlNhanVien);
            this.panel2.Controls.Add(this.pictureEditAvatar);
            this.panel2.Controls.Add(this.panelTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 550);
            this.panel2.TabIndex = 2;
            // 
            // pictureEditAvatar
            // 
            this.pictureEditAvatar.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEditAvatar.EditValue = ((object)(resources.GetObject("pictureEditAvatar.EditValue")));
            this.pictureEditAvatar.Location = new System.Drawing.Point(991, 2);
            this.pictureEditAvatar.Name = "pictureEditAvatar";
            this.pictureEditAvatar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditAvatar.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEditAvatar.Size = new System.Drawing.Size(115, 115);
            this.pictureEditAvatar.TabIndex = 26;
            // 
            // panelTextBox
            // 
            this.panelTextBox.Controls.Add(this.comboBoxTrangThai);
            this.panelTextBox.Controls.Add(this.labelControl11);
            this.panelTextBox.Controls.Add(this.textEditSDT);
            this.panelTextBox.Controls.Add(this.comboBoxGioiTinh);
            this.panelTextBox.Controls.Add(this.dateEditNgaySinh);
            this.panelTextBox.Controls.Add(this.labelControl10);
            this.panelTextBox.Controls.Add(this.labelControl9);
            this.panelTextBox.Controls.Add(this.labelControl3);
            this.panelTextBox.Controls.Add(this.labelControl8);
            this.panelTextBox.Controls.Add(this.labelControl7);
            this.panelTextBox.Controls.Add(this.labelControl6);
            this.panelTextBox.Controls.Add(this.labelControl5);
            this.panelTextBox.Controls.Add(this.labelControl4);
            this.panelTextBox.Controls.Add(this.labelControl2);
            this.panelTextBox.Controls.Add(this.labelControl1);
            this.panelTextBox.Controls.Add(this.textEditQueQuan);
            this.panelTextBox.Controls.Add(this.textEditMatKhau);
            this.panelTextBox.Controls.Add(this.textEditChucVu);
            this.panelTextBox.Controls.Add(this.textEditTenNV);
            this.panelTextBox.Controls.Add(this.textEditHinhAnh);
            this.panelTextBox.Controls.Add(this.textEditLuong);
            this.panelTextBox.Controls.Add(this.textEditMaNV);
            this.panelTextBox.Enabled = false;
            this.panelTextBox.Location = new System.Drawing.Point(0, 0);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Size = new System.Drawing.Size(982, 117);
            this.panelTextBox.TabIndex = 0;
            // 
            // comboBoxTrangThai
            // 
            this.comboBoxTrangThai.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxTrangThai.Location = new System.Drawing.Point(394, 84);
            this.comboBoxTrangThai.Name = "comboBoxTrangThai";
            this.comboBoxTrangThai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxTrangThai.Properties.Items.AddRange(new object[] {
            "Đang làm việc",
            "Đã nghỉ"});
            this.comboBoxTrangThai.Size = new System.Drawing.Size(251, 20);
            this.comboBoxTrangThai.TabIndex = 27;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(676, 58);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(30, 13);
            this.labelControl11.TabIndex = 25;
            this.labelControl11.Text = "Phone";
            // 
            // textEditSDT
            // 
            this.textEditSDT.Location = new System.Drawing.Point(728, 55);
            this.textEditSDT.Name = "textEditSDT";
            this.textEditSDT.Size = new System.Drawing.Size(251, 20);
            this.textEditSDT.TabIndex = 8;
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(728, 4);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxGioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(251, 20);
            this.comboBoxGioiTinh.TabIndex = 2;
            // 
            // dateEditNgaySinh
            // 
            this.dateEditNgaySinh.EditValue = null;
            this.dateEditNgaySinh.Location = new System.Drawing.Point(69, 84);
            this.dateEditNgaySinh.Name = "dateEditNgaySinh";
            this.dateEditNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditNgaySinh.Size = new System.Drawing.Size(251, 20);
            this.dateEditNgaySinh.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(329, 87);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(49, 13);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Trạng thái";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(668, 7);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(38, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Giới tính";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Ngày Sinh";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 58);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Hình ảnh";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(346, 58);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Địa chỉ";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(662, 33);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 13);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "Mật khẩu";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(338, 33);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Chức vụ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Lương";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(344, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Tên NV";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã NV";
            // 
            // textEditQueQuan
            // 
            this.textEditQueQuan.Location = new System.Drawing.Point(394, 55);
            this.textEditQueQuan.Name = "textEditQueQuan";
            this.textEditQueQuan.Size = new System.Drawing.Size(251, 20);
            this.textEditQueQuan.TabIndex = 7;
            // 
            // textEditMatKhau
            // 
            this.textEditMatKhau.Location = new System.Drawing.Point(728, 30);
            this.textEditMatKhau.Name = "textEditMatKhau";
            this.textEditMatKhau.Size = new System.Drawing.Size(251, 20);
            this.textEditMatKhau.TabIndex = 5;
            // 
            // textEditChucVu
            // 
            this.textEditChucVu.Location = new System.Drawing.Point(394, 30);
            this.textEditChucVu.Name = "textEditChucVu";
            this.textEditChucVu.Size = new System.Drawing.Size(251, 20);
            this.textEditChucVu.TabIndex = 4;
            // 
            // textEditTenNV
            // 
            this.textEditTenNV.Location = new System.Drawing.Point(394, 4);
            this.textEditTenNV.Name = "textEditTenNV";
            this.textEditTenNV.Size = new System.Drawing.Size(251, 20);
            this.textEditTenNV.TabIndex = 1;
            // 
            // textEditHinhAnh
            // 
            this.textEditHinhAnh.Location = new System.Drawing.Point(69, 55);
            this.textEditHinhAnh.Name = "textEditHinhAnh";
            this.textEditHinhAnh.Size = new System.Drawing.Size(251, 20);
            this.textEditHinhAnh.TabIndex = 6;
            // 
            // textEditLuong
            // 
            this.textEditLuong.Location = new System.Drawing.Point(69, 29);
            this.textEditLuong.Name = "textEditLuong";
            this.textEditLuong.Size = new System.Drawing.Size(251, 20);
            this.textEditLuong.TabIndex = 3;
            // 
            // textEditMaNV
            // 
            this.textEditMaNV.Location = new System.Drawing.Point(69, 3);
            this.textEditMaNV.Name = "textEditMaNV";
            this.textEditMaNV.Properties.ReadOnly = true;
            this.textEditMaNV.Size = new System.Drawing.Size(251, 20);
            this.textEditMaNV.TabIndex = 0;
            // 
            // UtcQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.panel2);
            this.Name = "UtcQuanLyNhanVien";
            this.Size = new System.Drawing.Size(1075, 550);
            this.Load += new System.EventHandler(this.UtcQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditAvatar.Properties)).EndInit();
            this.panelTextBox.ResumeLayout(false);
            this.panelTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditQueQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMaNV.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panelTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditQueQuan;
        private DevExpress.XtraEditors.TextEdit textEditMatKhau;
        private DevExpress.XtraEditors.TextEdit textEditChucVu;
        private DevExpress.XtraEditors.TextEdit textEditTenNV;
        private DevExpress.XtraEditors.TextEdit textEditHinhAnh;
        private DevExpress.XtraEditors.TextEdit textEditLuong;
        private DevExpress.XtraEditors.TextEdit textEditMaNV;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEditNgaySinh;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxGioiTinh;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit textEditSDT;
        private DevExpress.XtraEditors.PictureEdit pictureEditAvatar;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxTrangThai;
    }
}
