using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS_N6
{
    public partial class formDangNhap : Form
    {
        public static string sqlString = "Data Source=DESKTOP-PRH98VN;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        public formDangNhap()
        {
            InitializeComponent();
            
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            this.chbLuuThongTinDN.Parent = this.pictureBox1;
            this.lblLoi.Parent = this.pictureBox1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int status = 0; // trang thai tai khoan
        public static string tk;

        public static SqlConnection sqlConnection = new SqlConnection(sqlString);

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tk = txtUserName.Text;
            
            string mk = txtUserPassword.Text;
            try
            {     
                if (SQLConect.dangNhap_TaiKhoan(tk,mk)==1 && SQLConect.kiemTraTaiKhoan(tk) == 1)
                { 
                    MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG!", "Thông Báo ", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    formMain fr = new formMain(tk);
                    fr.Show();
                    this.Hide();
                    
                }
                else
                {    
                    if (status<5)
                    {

                       
                        if(  !( SQLConect.kiemTraTaiKhoan(tk) == -1)) //tài khoản ko tồn tại thì sẽ ko tăng
                        {
                            lblLoi.Text = "Sai tài khoản hoặc mật khẩu đăng nhập, vui lòng nhập lại";
                            lblLoi.Visible = true;
                            status++;
                        }
                        else
                        {
                            lblLoi.Text = "Tài khoản không tồn tại, vui lòng nhập lại";
                            lblLoi.Visible = true;

                        }


                    }
                    if(SQLConect.kiemTraTaiKhoan(tk) == 0 || status == 5)
                    {
                        lblLoi.Text = "Tài khoản đã bị khóa";
                        SQLConect.khoa_taiKhoan(tk);
                        status = 0;
                    }
                }
                
            }
            catch 
            {
                MessageBox.Show("hello");
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }
        
        //an mât khẩu 
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtUserPassword.UseSystemPasswordChar == false)
                txtUserPassword.UseSystemPasswordChar = true;
            else
                txtUserPassword.UseSystemPasswordChar = false;
        }
    }
}
