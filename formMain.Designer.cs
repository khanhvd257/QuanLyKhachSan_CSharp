
namespace QuanLyKS_N6
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_doiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_dangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDichVuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_moKhoaTK = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThuePhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTraPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSDungDVu = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Phongdangdung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_QLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.xemThôngTinKháchThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblWellcome = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ptb_DatPhong = new System.Windows.Forms.PictureBox();
            this.ptb_ThongKe = new System.Windows.Forms.PictureBox();
            this.ptb_TraPhong = new System.Windows.Forms.PictureBox();
            this.ptb_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.ptb_DichVu = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_TraPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.mnuQLDichVuAdmin,
            this.chứcNăngToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.mnu_QLKhachHang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1009, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_doiMatKhau,
            this.mnu_ThongTinTaiKhoan,
            this.mnu_dangXuat});
            this.tàiKhoảnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tàiKhoảnToolStripMenuItem.Image")));
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài Khoản";
            // 
            // mnu_doiMatKhau
            // 
            this.mnu_doiMatKhau.Name = "mnu_doiMatKhau";
            this.mnu_doiMatKhau.Size = new System.Drawing.Size(179, 22);
            this.mnu_doiMatKhau.Text = "Đổi mật Khẩu";
            this.mnu_doiMatKhau.Click += new System.EventHandler(this.mnu_doiMatKhau_Click);
            // 
            // mnu_ThongTinTaiKhoan
            // 
            this.mnu_ThongTinTaiKhoan.Name = "mnu_ThongTinTaiKhoan";
            this.mnu_ThongTinTaiKhoan.Size = new System.Drawing.Size(179, 22);
            this.mnu_ThongTinTaiKhoan.Text = "Thông tin Tài Khoản";
            this.mnu_ThongTinTaiKhoan.Click += new System.EventHandler(this.mnu_ThongTinTaiKhoan_Click);
            // 
            // mnu_dangXuat
            // 
            this.mnu_dangXuat.BackColor = System.Drawing.Color.Chartreuse;
            this.mnu_dangXuat.Name = "mnu_dangXuat";
            this.mnu_dangXuat.Size = new System.Drawing.Size(179, 22);
            this.mnu_dangXuat.Text = "Đăng xuất";
            this.mnu_dangXuat.Click += new System.EventHandler(this.mnu_dangXuat_Click_1);
            // 
            // mnuQLDichVuAdmin
            // 
            this.mnuQLDichVuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLPhong,
            this.mnuQLDichVu,
            this.mnuQLNhanVien,
            this.mnu_moKhoaTK});
            this.mnuQLDichVuAdmin.Image = ((System.Drawing.Image)(resources.GetObject("mnuQLDichVuAdmin.Image")));
            this.mnuQLDichVuAdmin.Name = "mnuQLDichVuAdmin";
            this.mnuQLDichVuAdmin.Size = new System.Drawing.Size(122, 24);
            this.mnuQLDichVuAdmin.Text = "Quản lý dịch vụ";
            // 
            // mnuQLPhong
            // 
            this.mnuQLPhong.Name = "mnuQLPhong";
            this.mnuQLPhong.Size = new System.Drawing.Size(173, 22);
            this.mnuQLPhong.Text = "Quản lý phòng";
            this.mnuQLPhong.Click += new System.EventHandler(this.mnuQLPhong_Click);
            // 
            // mnuQLDichVu
            // 
            this.mnuQLDichVu.Name = "mnuQLDichVu";
            this.mnuQLDichVu.Size = new System.Drawing.Size(173, 22);
            this.mnuQLDichVu.Text = "Quản lý dịch vụ";
            this.mnuQLDichVu.Click += new System.EventHandler(this.mnuQLDichVu_Click);
            // 
            // mnuQLNhanVien
            // 
            this.mnuQLNhanVien.Name = "mnuQLNhanVien";
            this.mnuQLNhanVien.Size = new System.Drawing.Size(173, 22);
            this.mnuQLNhanVien.Text = "Quản lý Nhân Viên";
            this.mnuQLNhanVien.Click += new System.EventHandler(this.mnuQLNhanVien_Click);
            // 
            // mnu_moKhoaTK
            // 
            this.mnu_moKhoaTK.Name = "mnu_moKhoaTK";
            this.mnu_moKhoaTK.Size = new System.Drawing.Size(173, 22);
            this.mnu_moKhoaTK.Text = "Mở khóa tài khóa";
            this.mnu_moKhoaTK.Click += new System.EventHandler(this.mnu_moKhoaTK_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThuePhong,
            this.mnuTraPhong,
            this.mnuSDungDVu});
            this.chứcNăngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chứcNăngToolStripMenuItem.Image")));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // mnuThuePhong
            // 
            this.mnuThuePhong.Name = "mnuThuePhong";
            this.mnuThuePhong.Size = new System.Drawing.Size(160, 22);
            this.mnuThuePhong.Text = "Thuê Phòng";
            this.mnuThuePhong.Click += new System.EventHandler(this.mnuThuePhong_Click);
            // 
            // mnuTraPhong
            // 
            this.mnuTraPhong.Name = "mnuTraPhong";
            this.mnuTraPhong.Size = new System.Drawing.Size(160, 22);
            this.mnuTraPhong.Text = "Trả Phòng";
            this.mnuTraPhong.Click += new System.EventHandler(this.mnuTraPhong_Click);
            // 
            // mnuSDungDVu
            // 
            this.mnuSDungDVu.Name = "mnuSDungDVu";
            this.mnuSDungDVu.Size = new System.Drawing.Size(160, 22);
            this.mnuSDungDVu.Text = "Sử dụng dịch vụ";
            this.mnuSDungDVu.Click += new System.EventHandler(this.mnuSDungDVu_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Phongdangdung,
            this.mnuThongKe});
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // mnu_Phongdangdung
            // 
            this.mnu_Phongdangdung.Name = "mnu_Phongdangdung";
            this.mnu_Phongdangdung.Size = new System.Drawing.Size(186, 22);
            this.mnu_Phongdangdung.Text = "Số Phòng đang dùng";
            this.mnu_Phongdangdung.Click += new System.EventHandler(this.mnu_Phongdangdung_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(186, 22);
            this.mnuThongKe.Text = "Thống kê doanh thu";
            this.mnuThongKe.Click += new System.EventHandler(this.mnuThongKe_Click);
            // 
            // mnu_QLKhachHang
            // 
            this.mnu_QLKhachHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinKháchThuêToolStripMenuItem});
            this.mnu_QLKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("mnu_QLKhachHang.Image")));
            this.mnu_QLKhachHang.Name = "mnu_QLKhachHang";
            this.mnu_QLKhachHang.Size = new System.Drawing.Size(146, 24);
            this.mnu_QLKhachHang.Text = "Quản lý Khách hàng";
            // 
            // xemThôngTinKháchThuêToolStripMenuItem
            // 
            this.xemThôngTinKháchThuêToolStripMenuItem.Name = "xemThôngTinKháchThuêToolStripMenuItem";
            this.xemThôngTinKháchThuêToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.xemThôngTinKháchThuêToolStripMenuItem.Text = "Xem thông tin khách thuê";
            this.xemThôngTinKháchThuêToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinKháchThuêToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // lblWellcome
            // 
            this.lblWellcome.AutoSize = true;
            this.lblWellcome.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWellcome.ForeColor = System.Drawing.Color.Yellow;
            this.lblWellcome.Location = new System.Drawing.Point(5, 230);
            this.lblWellcome.Name = "lblWellcome";
            this.lblWellcome.Size = new System.Drawing.Size(98, 17);
            this.lblWellcome.TabIndex = 4;
            this.lblWellcome.Text = "Xin chào User!";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(3, 251);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(72, 19);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Thời gian";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1, 22);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1014, 204);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // ptb_DatPhong
            // 
            this.ptb_DatPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_DatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_DatPhong.Image = ((System.Drawing.Image)(resources.GetObject("ptb_DatPhong.Image")));
            this.ptb_DatPhong.Location = new System.Drawing.Point(1, 536);
            this.ptb_DatPhong.Name = "ptb_DatPhong";
            this.ptb_DatPhong.Size = new System.Drawing.Size(310, 210);
            this.ptb_DatPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_DatPhong.TabIndex = 11;
            this.ptb_DatPhong.TabStop = false;
            this.ptb_DatPhong.Click += new System.EventHandler(this.ptb_DatPhong_Click);
            // 
            // ptb_ThongKe
            // 
            this.ptb_ThongKe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_ThongKe.Image = ((System.Drawing.Image)(resources.GetObject("ptb_ThongKe.Image")));
            this.ptb_ThongKe.Location = new System.Drawing.Point(621, 536);
            this.ptb_ThongKe.Name = "ptb_ThongKe";
            this.ptb_ThongKe.Size = new System.Drawing.Size(310, 210);
            this.ptb_ThongKe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_ThongKe.TabIndex = 11;
            this.ptb_ThongKe.TabStop = false;
            this.ptb_ThongKe.Click += new System.EventHandler(this.ptb_ThongKe_Click);
            // 
            // ptb_TraPhong
            // 
            this.ptb_TraPhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_TraPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_TraPhong.Image = ((System.Drawing.Image)(resources.GetObject("ptb_TraPhong.Image")));
            this.ptb_TraPhong.Location = new System.Drawing.Point(311, 536);
            this.ptb_TraPhong.Name = "ptb_TraPhong";
            this.ptb_TraPhong.Size = new System.Drawing.Size(310, 210);
            this.ptb_TraPhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptb_TraPhong.TabIndex = 11;
            this.ptb_TraPhong.TabStop = false;
            this.ptb_TraPhong.Click += new System.EventHandler(this.ptb_TraPhong_Click);
            // 
            // ptb_Exit
            // 
            this.ptb_Exit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ptb_Exit.Image")));
            this.ptb_Exit.Location = new System.Drawing.Point(931, 536);
            this.ptb_Exit.Name = "ptb_Exit";
            this.ptb_Exit.Size = new System.Drawing.Size(79, 210);
            this.ptb_Exit.TabIndex = 12;
            this.ptb_Exit.TabStop = false;
            this.ptb_Exit.Click += new System.EventHandler(this.ptb_Exit_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1, 224);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(1010, 76);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // ptb_DichVu
            // 
            this.ptb_DichVu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptb_DichVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptb_DichVu.Image = ((System.Drawing.Image)(resources.GetObject("ptb_DichVu.Image")));
            this.ptb_DichVu.Location = new System.Drawing.Point(1, 300);
            this.ptb_DichVu.Name = "ptb_DichVu";
            this.ptb_DichVu.Size = new System.Drawing.Size(1010, 244);
            this.ptb_DichVu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_DichVu.TabIndex = 10;
            this.ptb_DichVu.TabStop = false;
            this.ptb_DichVu.Click += new System.EventHandler(this.ptb_DichVu_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1009, 746);
            this.Controls.Add(this.lblWellcome);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.ptb_Exit);
            this.Controls.Add(this.ptb_ThongKe);
            this.Controls.Add(this.ptb_TraPhong);
            this.Controls.Add(this.ptb_DatPhong);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ptb_DichVu);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.formMain_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_ThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_TraPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_DichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_doiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDichVuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuQLPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThuePhong;
        private System.Windows.Forms.ToolStripMenuItem mnuTraPhong;
        private System.Windows.Forms.ToolStripMenuItem mnuSDungDVu;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Label lblWellcome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnu_dangXuat;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox ptb_DatPhong;
        private System.Windows.Forms.PictureBox ptb_ThongKe;
        private System.Windows.Forms.PictureBox ptb_TraPhong;
        private System.Windows.Forms.PictureBox ptb_Exit;
        private System.Windows.Forms.PictureBox ptb_DichVu;
        private System.Windows.Forms.ToolStripMenuItem mnu_QLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnu_moKhoaTK;
        private System.Windows.Forms.ToolStripMenuItem mnu_Phongdangdung;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinKháchThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
    }
}