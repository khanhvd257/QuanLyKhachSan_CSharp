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
    public partial class formMoKhoaTaiKhoan : Form
    {
        public formMoKhoaTaiKhoan()
        {
            InitializeComponent();
            SetControl(status);
        }
        public static string status = "Reset";
        public void SetControl(string st)
        {
            status = st;
            switch (st)
            {
                case "Reset":
                    grb_thongTinTK.Visible = false;
                    lblThongBao.Visible = false;
                    break;

            }
        }
        public void GetData(string user)
        {
            string query = "SELECT ThoiGianKhoa,user_name,hoTen FROM tblThongTinCaNhan WHERE user_name = '"+user.Trim()+"' AND TrangThai ='0'";
            DataTable DT = new DataTable();
            SQLConect.LayDuLieu(query, DT);
            if(DT.Rows.Count > 0)
            {
                lblThongBao.Visible = false;
                grb_thongTinTK.Visible = true;
                lblTenDangNhap.Text = DT.Rows[0]["user_name"].ToString();
                lblTenNguoiDung.Text = DT.Rows[0]["hoTen"].ToString();
                lblThoiGianKhoa.Text = DT.Rows[0]["ThoiGianKhoa"].ToString();
            }
            else
            {
                lblThongBao.Text = "Không thấy tài khoản bị khóa";
                lblThongBao.Visible = true;
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            GetData(txtTimKiem.Text);
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("chắc chắn mửo khóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "UPDATE tblThongTinCaNhan SET TrangThai = '1', ThoiGianKhoa = '' WHERE user_name = '" + txtTimKiem.Text + "'";
                    SQLConect.luu(query);
                    MessageBox.Show("Mở khóa thành công!");
                }
                status = "Reset";
                SetControl(status);
            }
            catch
            {
                MessageBox.Show("");
            }

        }
    }
}
