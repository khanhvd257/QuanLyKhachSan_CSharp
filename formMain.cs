using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS_N6
{
    public partial class formMain : Form
    {
        public static string name_user;
        public formMain(string user_name)
        {
            
            name_user = user_name;
            InitializeComponent();
            this.IsMdiContainer = true;
            LableWELCOME(user_name);
            checkAdmin();
        }
        public static string sqlString = "Data Source=DESKTOP-PRH98VN;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        
        private void formMain_Load(object sender, EventArgs e)
        {

         
        }
        public static string tenNguoiDung = "";
        public static string PhanQuyen; //true la ADMIN ; false la User
        public void LableWELCOME(string user_name)

        {
            DataTable dt = new DataTable("NguoiDung");
            string query = "SELECT hoTen,phanQuyen  FROM tblThongTinCaNhan WHERE user_name = '" + user_name + "'";
            SQLConect.LayDuLieu(query,dt);
            var name = dt.Rows[0]["hoTen"].ToString();
            PhanQuyen = dt.Rows[0]["phanQuyen"].ToString();
            lblWellcome.Text = "Chào "+buoiTrongNgay()+name+" !";
            tenNguoiDung = name;
        }
        public void checkAdmin()
        {
            if (String.Compare(PhanQuyen,"True",true) == 0)
            {
                mnuQLDichVuAdmin.Visible = true;
            }
            else
            {
                mnuQLDichVuAdmin.Visible = false;
            }
        }
        public string buoiTrongNgay()
        {
            string buoi = "";
            if(DateTime.Now.Hour < 11)
            {
                buoi = "Buổi Sáng, ";

            }
            else if(DateTime.Now.Hour < 18)
            {
                buoi = "Buổi Chiều, ";
            }
            else
            {
                buoi = "Buổi Tối, ";
            }
            return buoi;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text =DateTime.Now.DayOfWeek +", " + DateTime.Now.ToString();
        }

        private void mnu_dangXuat_Click_1(object sender, EventArgs e)
        {
           if(MessageBox.Show("Bạn có muốn đăng xuất không? ","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                formDangNhap fr = new formDangNhap();
                fr.Show();
                this.Hide();
            }     
        }

        private void mnu_ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            formThongTinUser fr = new formThongTinUser(name_user);
            //fr.MdiParent = true;
            fr.Show();

        }

        private void mnu_doiMatKhau_Click(object sender, EventArgs e)
        {
            formDoiMatKhau fr = new formDoiMatKhau(name_user);
            fr.Show();
          
        }

        private void ptb_DichVu_Click(object sender, EventArgs e)
        {
            formSudungDichVu fr1 = new formSudungDichVu();
            fr1.Show();
        }

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn THOÁT không? ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                
                this.Close();
            }
            
        }

        private void ptb_DatPhong_Click(object sender, EventArgs e)
        {
            formThuePhong frphong = new formThuePhong(tenNguoiDung);
            frphong.Show();
        }

        private void mnuThuePhong_Click(object sender, EventArgs e)
        {
            formThuePhong fr = new formThuePhong(tenNguoiDung);
            fr.Show();
        }

       

        private void mnuQLPhong_Click(object sender, EventArgs e)
        {
            FormQuanLyPhong FR = new FormQuanLyPhong();
            FR.Show();
        }

        private void mnuQLDichVu_Click(object sender, EventArgs e)
        {
            FormQuanLyDichVu fr = new FormQuanLyDichVu();
            fr.Show();
        }

        private void mnuQLNhanVien_Click(object sender, EventArgs e)
        {
            FormQuanLyNhanVien fr = new FormQuanLyNhanVien();
            fr.Show();
        }

        private void mnuTraPhong_Click(object sender, EventArgs e)
        {
            formTraPhong FR = new formTraPhong(tenNguoiDung);
            FR.Show();
        }

        private void mnuSDungDVu_Click(object sender, EventArgs e)
        {
            formSudungDichVu ft = new formSudungDichVu();
            ft.Show();
        }

        private void mnu_moKhoaTK_Click(object sender, EventArgs e)
        {
            formMoKhoaTaiKhoan fr = new formMoKhoaTaiKhoan();
           
            
           
            fr.Show();
        }

        private void ptb_TraPhong_Click(object sender, EventArgs e)
        {
            formTraPhong fr = new formTraPhong(tenNguoiDung);
            fr.Show();
        }

        private void ptb_ThongKe_Click(object sender, EventArgs e)
        {
            formThongKe fr = new formThongKe();
            fr.Show();
        }

        private void mnu_Phongdangdung_Click(object sender, EventArgs e)
        {
            formPhongDangThue fr = new formPhongDangThue();
            fr.Show();
        }

        private void xemThôngTinKháchThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPhongDangThue fr = new formPhongDangThue();
                fr.Show();
        }

        private void formMain_Load_1(object sender, EventArgs e)
        {

        }
 

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            formThongKe FR = new formThongKe();
            FR.Show();
        }
    }
}
