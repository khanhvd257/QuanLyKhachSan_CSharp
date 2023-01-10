using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS_N6
{
    public partial class formDoiMatKhau : Form
    {
        public static string user_name = "";
        public formDoiMatKhau(string user_name1)
        {
            InitializeComponent();
            user_name = user_name1;

        }

        private void formDoiMatKhau_Load(object sender, EventArgs e)
        {
            label1.Parent = this.pictureBox1;
            label5.Parent = this.pictureBox1;
            label4.Parent = this.pictureBox1;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu cũ", "thong bao", MessageBoxButtons.OK);
                txtMatKhauCu.Focus();
                return;
            }
            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Nhập mật mới", "thong bao", MessageBoxButtons.OK);
                txtMatKhauMoi.Focus();
                return;

            }
            if (txtXacnhanMatkhau.Text == "")
            {
                MessageBox.Show("xác nhận mật khẩu mới", "thong bao", MessageBoxButtons.OK);
                txtXacnhanMatkhau.Focus();
                return;

            }
            if (txtMatKhauMoi.Text == txtXacnhanMatkhau.Text)
            {
                string query = "UPDATE tblThongTinCaNhan SET user_password = '" + txtMatKhauMoi.Text + "' WHERE user_name = '" + user_name + "'";
                if (SQLConect.doi_MatKhau(user_name, txtMatKhauCu.Text, query) == 1)
                    MessageBox.Show("Doi thanh cong", "thong bao", MessageBoxButtons.OK);
                else MessageBox.Show("Sai mat khau");
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp!","Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
