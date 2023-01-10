using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyKS_N6
{
    public partial class formThongTinUser : Form
    {
        public formThongTinUser(string user_name)
        {
            InitializeComponent();
            getData(user_name);
            setControll(status);
        }
        public static string status = "Reset";
        public static string user_name1 = "";
        public void setControll(string status)
        {
            switch (status)
            {
                case "Reset":
                    btnHuyBo.Visible = false;
                    btnLuu.Visible = false;
                    btnSuaThongTin.Visible = true;
                    dtpNgayVaoLam.Enabled = false;
                    grb_ThongTinCaNhan.Enabled = false;
                    cmbChucVu.Enabled = false;      
                    break;
                case "Edit":
                    cmbChucVu.Enabled = false;
                    btnHuyBo.Visible = true;
                    btnLuu.Visible = true;
                    btnSuaThongTin.Visible = false;
                    grb_ThongTinCaNhan.Enabled = true;
                    dtpNgayVaoLam.Enabled = false;         
                    break;
            }
        }
        public void getData(string user_name)
        {
            user_name1 = user_name;
            string query = "SELECT * FROM tblThongTinCaNhan, tblThongTinNghiepVu WHERE tblThongTinCaNhan.maChucVu = tblThongTinNghiepVu.maChucVu AND user_name = '" + user_name + "'";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query, dt);
            txtHoTen.Text = dt.Rows[0]["hoTen"].ToString();
            dtpNgaySinh.Value = Convert.ToDateTime(dt.Rows[0]["ngaySinh"].ToString());
            if (String.Compare(dt.Rows[0]["gioiTinh"].ToString(), "Nam", true) == 0)
            {
                cmb_GioiTInh.SelectedIndex = 0;
            }
            else
            {
                cmb_GioiTInh.SelectedIndex = 1;
            }
            txtSoDienThoai.Text = dt.Rows[0]["soDienThoai"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtDiaChi.Text = dt.Rows[0]["diaChi"].ToString();
            if (dt.Rows[0]["phanQuyen"].ToString() == "True")
            {
                lblLoaiTaiKhoan.Text = " ADMIN";

            }
            else
            {
                lblLoaiTaiKhoan.Text = "USER";
            }
            if (String.Compare(dt.Rows[0]["tenChucVu"].ToString(), "Giám Đốc", true) == 0)
            {
                cmbChucVu.SelectedIndex = 0;
            }
            else if (String.Compare(dt.Rows[0]["tenChucVu"].ToString(), "Quản Lý", true) == 0)
            {
                cmbChucVu.SelectedIndex = 1;
            }
            else
            {
                cmbChucVu.SelectedIndex = 2;
            }
            dtpNgayVaoLam.Value = Convert.ToDateTime(dt.Rows[0]["ngayVaoLam"].ToString());
            lblLuongThang.Text = dt.Rows[0]["luong"].ToString() + "VND";
            lblMaNhanVien.Text = dt.Rows[0]["maChucVu"].ToString();
            lblThamNien.Text = (DateTime.Now.Year - dtpNgayVaoLam.Value.Year).ToString() + " Year";

        }



        private void btnTroLai_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            status = "Edit";
            setControll(status);
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            status = "Reset";
            setControll(status);
        }
     
     
        public void luuThongTin()
        {
            string query = "UPDATE tblThongTinCaNhan SET hoTen =    N'" + txtHoTen.Text + "', ngaySinh='" + dtpNgaySinh.Value.ToString("yyyy/MM/dd") +"', GioiTinh='" + cmb_GioiTInh.Text + "',soDienThoai='" + txtSoDienThoai.Text.Trim() + "'" +
                        ",email='" + txtEmail.Text + "', diaChi='" + txtEmail.Text + "' WHERE user_name = '"+user_name1+"'";
            SQLConect.Sua(query);
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                luuThongTin();
                status = "Reset";
                setControll(status);
            }
        }
    }
}
