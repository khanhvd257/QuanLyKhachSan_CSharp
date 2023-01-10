
namespace QuanLyKS_N6
{
    partial class formMoKhoaTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMoKhoaTaiKhoan));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grb_TimKiem = new System.Windows.Forms.GroupBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.grb_thongTinTK = new System.Windows.Forms.GroupBox();
            this.btnMoKhoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.lblThoiGianKhoa = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grb_TimKiem.SuspendLayout();
            this.grb_thongTinTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(394, 34);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(78, 26);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(227, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập tài khoản bị khóa";
            this.txtTimKiem.Size = new System.Drawing.Size(161, 26);
            this.txtTimKiem.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(84, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tìm Kiếm Tài Khoản";
            // 
            // grb_TimKiem
            // 
            this.grb_TimKiem.Controls.Add(this.btnTimKiem);
            this.grb_TimKiem.Controls.Add(this.txtTimKiem);
            this.grb_TimKiem.Controls.Add(this.lblThongBao);
            this.grb_TimKiem.Controls.Add(this.label8);
            this.grb_TimKiem.Location = new System.Drawing.Point(70, 149);
            this.grb_TimKiem.Name = "grb_TimKiem";
            this.grb_TimKiem.Size = new System.Drawing.Size(568, 111);
            this.grb_TimKiem.TabIndex = 23;
            this.grb_TimKiem.TabStop = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThongBao.ForeColor = System.Drawing.Color.Red;
            this.lblThongBao.Location = new System.Drawing.Point(171, 77);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(70, 19);
            this.lblThongBao.TabIndex = 20;
            this.lblThongBao.Text = "Thongbao";
            // 
            // grb_thongTinTK
            // 
            this.grb_thongTinTK.Controls.Add(this.btnMoKhoa);
            this.grb_thongTinTK.Controls.Add(this.label3);
            this.grb_thongTinTK.Controls.Add(this.label2);
            this.grb_thongTinTK.Controls.Add(this.label4);
            this.grb_thongTinTK.Controls.Add(this.lblTenNguoiDung);
            this.grb_thongTinTK.Controls.Add(this.lblThoiGianKhoa);
            this.grb_thongTinTK.Controls.Add(this.lblTenDangNhap);
            this.grb_thongTinTK.Controls.Add(this.label1);
            this.grb_thongTinTK.Location = new System.Drawing.Point(70, 301);
            this.grb_thongTinTK.Name = "grb_thongTinTK";
            this.grb_thongTinTK.Size = new System.Drawing.Size(567, 217);
            this.grb_thongTinTK.TabIndex = 24;
            this.grb_thongTinTK.TabStop = false;
            // 
            // btnMoKhoa
            // 
            this.btnMoKhoa.ForeColor = System.Drawing.Color.Black;
            this.btnMoKhoa.Location = new System.Drawing.Point(422, 179);
            this.btnMoKhoa.Name = "btnMoKhoa";
            this.btnMoKhoa.Size = new System.Drawing.Size(116, 32);
            this.btnMoKhoa.TabIndex = 21;
            this.btnMoKhoa.Text = "Mở Khóa";
            this.btnMoKhoa.UseVisualStyleBackColor = true;
            this.btnMoKhoa.Click += new System.EventHandler(this.btnMoKhoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(26, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên Người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Thời gian Khóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Thông tin tài khoản khóa";
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenNguoiDung.ForeColor = System.Drawing.Color.Yellow;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(158, 133);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(63, 19);
            this.lblTenNguoiDung.TabIndex = 20;
            this.lblTenNguoiDung.Text = "---------";
            // 
            // lblThoiGianKhoa
            // 
            this.lblThoiGianKhoa.AutoSize = true;
            this.lblThoiGianKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThoiGianKhoa.ForeColor = System.Drawing.Color.Yellow;
            this.lblThoiGianKhoa.Location = new System.Drawing.Point(158, 91);
            this.lblThoiGianKhoa.Name = "lblThoiGianKhoa";
            this.lblThoiGianKhoa.Size = new System.Drawing.Size(63, 19);
            this.lblThoiGianKhoa.TabIndex = 20;
            this.lblThoiGianKhoa.Text = "---------";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.Yellow;
            this.lblTenDangNhap.Location = new System.Drawing.Point(158, 49);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(63, 19);
            this.lblTenDangNhap.TabIndex = 20;
            this.lblTenDangNhap.Text = "---------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // formMoKhoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(729, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grb_thongTinTK);
            this.Controls.Add(this.grb_TimKiem);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMoKhoaTaiKhoan";
            this.Text = "formMoKhoaTaiKhoan";
            this.grb_TimKiem.ResumeLayout(false);
            this.grb_TimKiem.PerformLayout();
            this.grb_thongTinTK.ResumeLayout(false);
            this.grb_thongTinTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grb_TimKiem;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.GroupBox grb_thongTinTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.Label lblThoiGianKhoa;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoKhoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}