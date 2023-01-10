
namespace QuanLyKS_N6
{
    partial class formThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTienPhong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTienDichVu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đến ngày";
            this.label2.UseWaitCursor = true;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(199, 143);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(622, 145);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 26);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(346, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "THỐNG KÊ BÁO CÁO";
            this.label9.UseWaitCursor = true;
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.lblTongDoanhThu);
            this.grbThongTin.Controls.Add(this.lblTienPhong);
            this.grbThongTin.Controls.Add(this.lblTienDichVu);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Location = new System.Drawing.Point(88, 276);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(798, 278);
            this.grbThongTin.TabIndex = 3;
            this.grbThongTin.TabStop = false;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(400, 194);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(127, 34);
            this.btnTraCuu.TabIndex = 4;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.ForeColor = System.Drawing.Color.Blue;
            this.lblTB.Location = new System.Drawing.Point(361, 245);
            this.lblTB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(72, 19);
            this.lblTB.TabIndex = 0;
            this.lblTB.Text = "ThongBao";
            this.lblTB.UseWaitCursor = true;
            this.lblTB.Visible = false;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(364, 178);
            this.lblTongDoanhThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(75, 19);
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Text = "-----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng doanh thu";
            // 
            // lblTienPhong
            // 
            this.lblTienPhong.AutoSize = true;
            this.lblTienPhong.Location = new System.Drawing.Point(364, 138);
            this.lblTienPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienPhong.Name = "lblTienPhong";
            this.lblTienPhong.Size = new System.Drawing.Size(75, 19);
            this.lblTienPhong.TabIndex = 0;
            this.lblTienPhong.Text = "-----------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng tiền Phòng:";
            // 
            // lblTienDichVu
            // 
            this.lblTienDichVu.AutoSize = true;
            this.lblTienDichVu.Location = new System.Drawing.Point(364, 97);
            this.lblTienDichVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTienDichVu.Name = "lblTienDichVu";
            this.lblTienDichVu.Size = new System.Drawing.Size(75, 19);
            this.lblTienDichVu.TabIndex = 0;
            this.lblTienDichVu.Text = "-----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng tiền Dịch vụ:";
            // 
            // formThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 580);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formThongKe";
            this.Text = " ";
            this.Load += new System.EventHandler(this.formThongKe_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Button btnTraCuu;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTienPhong;
        private System.Windows.Forms.Label lblTienDichVu;
        private System.Windows.Forms.Label label3;
    }
}