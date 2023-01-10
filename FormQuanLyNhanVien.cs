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
    public partial class FormQuanLyNhanVien : Form
    {
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            getData();
            SetControl(status);
            IsMdiContainer = true;

        }
        
        public static string status ="Reset";
        public void SetControl(string st)
        {
            status = st;
            switch (st)
            {

                case "Reset":
                    grb_ThongTinCaNhan.Enabled = false;
                    grb_ttNghiepVu.Enabled = false;
                    grbDangKiTK.Visible = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;
                    btnThem.Enabled = true;
                    dgvThongTinNv.Visible = true;


                    break;

                case "Insert":
                    grb_ThongTinCaNhan.Enabled = true;
                    grb_ttNghiepVu.Enabled = true;
                    grbDangKiTK.Visible = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    dgvThongTinNv.Visible = false;
                    txtHoTen.Text = "";
                    txtDiaChi.Text = "";
                    txtEmai.Text = "";
                    txtMaNhanVien.Enabled = true;
                    txtMaNhanVien.Text = "";
                    txtSDT.Text = "";
                    txtLuong.Text = "";
                    dtpNgaySinh.Text = "";
                    dtpNgayVaoLam.Text = "";
                    

                    break;

                case "Edit":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhi.Enabled = true;
                    btnHuy.Enabled = true;
                    txtMaNhanVien.Enabled = false;
                    grb_ThongTinCaNhan.Enabled = true;
                    grb_ttNghiepVu.Enabled = true;
                    grbDangKiTK.Visible = false;
                    dgvThongTinNv.Visible = true;

                    break;


            }
        }
        public void getData()
        {
            string query = "SELECT hoTen,ngaySinh,GioiTinh, soDienThoai, email, diaChi,tenChucVu,ngayVaoLam,luong, nv.maChucVu"+
               " FROM tblThongTinCaNhan, tblThongTinNghiepVu nv WHERE tblThongTinCaNhan.maChucVu = nv.maChucVu ";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query, dt);
            dgvThongTinNv.DataSource = dt;
            dgvThongTinNv.AutoGenerateColumns = false;

            try
            {
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
                txtSDT.Text = dt.Rows[0]["soDienThoai"].ToString();
                txtEmai.Text = dt.Rows[0]["email"].ToString();
                txtDiaChi.Text = dt.Rows[0]["diaChi"].ToString();

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
                txtLuong.Text = dt.Rows[0]["luong"].ToString().Substring(0, dt.Rows[0]["luong"].ToString().IndexOf(','));
                txtMaNhanVien.Text = dt.Rows[0]["maChucVu"].ToString();
                lblThamNiem.Text = (DateTime.Now.Year - dtpNgayVaoLam.Value.Year).ToString() + " Year";
            }
            catch
            {

            }
        }
        public void getData(string TenNhanVien)
        {
           string query = "SELECT hoTen,ngaySinh,GioiTinh, soDienThoai, email, diaChi,tenChucVu,ngayVaoLam,luong, nv.maChucVu" +
               " FROM tblThongTinCaNhan , tblThongTinNghiepVu nv WHERE tblThongTinCaNhan.maChucVu = nv.maChucVu AND hoTen LIKE N'%"+TenNhanVien+"%'";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query, dt);
            dgvThongTinNv.DataSource = dt;
            dgvThongTinNv.AutoGenerateColumns = false;

            try
            {
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
                txtSDT.Text = dt.Rows[0]["soDienThoai"].ToString();
                txtEmai.Text = dt.Rows[0]["email"].ToString();
                txtDiaChi.Text = dt.Rows[0]["diaChi"].ToString();

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
                txtLuong.Text = dt.Rows[0]["luong"].ToString().Substring(0, dt.Rows[0]["luong"].ToString().IndexOf(','));
                txtMaNhanVien.Text = dt.Rows[0]["maChucVu"].ToString();
                lblThamNiem.Text = (DateTime.Now.Year - dtpNgayVaoLam.Value.Year).ToString() + " Year";
            }
            catch
            {

            }
        }
        private void dgvThongTinNv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvThongTinNv.CurrentCell.RowIndex;
            var item = dgvThongTinNv.Rows[index];
            try
            {
                txtHoTen.Text = item.Cells["hoTen"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(item.Cells["ngaySinh"].Value.ToString());
                if (String.Compare(item.Cells["gioiTinh"].Value.ToString(), "Nam", true) == 0)
                {
                    cmb_GioiTInh.SelectedIndex = 1;
                }
                else
                {
                    cmb_GioiTInh.SelectedIndex = 0;
                }
                if (String.Compare(item.Cells["tenChucVu"].Value.ToString(), "Giám Đốc", true) == 0)
                {
                    cmbChucVu.SelectedIndex = 0;
                }
                else if (String.Compare(item.Cells["tenChucVu"].Value.ToString(), "Quản Lý", true) == 0)
                {
                    cmbChucVu.SelectedIndex = 1;
                }
                else
                {
                    cmbChucVu.SelectedIndex = 2;
                }

                txtSDT.Text = item.Cells["soDienThoai"].Value.ToString();
                txtEmai.Text = item.Cells["email"].Value.ToString();
                txtDiaChi.Text = item.Cells["diaChi"].Value.ToString();
                txtMaNhanVien.Text = item.Cells["maChucVu"].Value.ToString();
                txtLuong.Text = item.Cells["luong"].Value.ToString().Substring(0, item.Cells["luong"].Value.ToString().IndexOf(','));
                dtpNgayVaoLam.Value = Convert.ToDateTime(item.Cells["ngayVaoLam"].Value.ToString());
                lblThamNiem.Text = (DateTime.Now.Year - dtpNgayVaoLam.Value.Year).ToString() + " Year";
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Insert";
            SetControl(status);

            

        }
        public bool checkRongNhap()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Không để trống trường này");
                txtHoTen.Focus();
                return false;
            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Không để trống trường này");
                txtSDT.Focus();
                return false;
            }

            if (dtpNgaySinh.Text == "")
            {
                MessageBox.Show("Không để trống trường này");
                dtpNgaySinh.Focus();
                return false;
            }
            if (cmb_GioiTInh.Text == "")
            {
                MessageBox.Show("Không để trống trường này");
                cmb_GioiTInh.Focus();
                return false;
            }
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Không để trống trường này");
                txtMaNhanVien.Focus();
                return false;
            }
            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Không để trống trường này");
                txtTaiKhoan.Focus();
                return false;
            }
            if (txtMatkhau.Text == "")
            {
                MessageBox.Show("Không để trống trường này");
                txtMatkhau.Focus();
                return false;
            }
            if (txtXacnhanMk.Text == "")
            {
                MessageBox.Show("Không để trống trường này");
                txtXacnhanMk.Focus();
                return false;
            }
            if (!(txtMatkhau.Text == txtXacnhanMk.Text))
            {
                MessageBox.Show("Mật khẩu không khớp ");
                return false ;
            }
            return true;
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == "Insert")
                {
                    if (checkRongNhap() == false)
                    {
                        return;
                    }
                    string QUERY = "INSERT INTO tblThongTinNghiepVu VALUES('"+txtMaNhanVien.Text+"','"+cmbChucVu.Text+"','"+dtpNgayVaoLam.Value.ToString("yyyy/MM/dd")+"','"+txtLuong.Text+"')";
                    string query = "INSERT INTO tblThongTinCaNhan VALUES ('" + txtTaiKhoan.Text +
                        "','" + txtMatkhau.Text + "','"+cmbTaiKhoan.SelectedIndex+"',N'" + txtHoTen.Text + "','" + dtpNgaySinh.Value.ToString("yyyy/MM/dd") + "', N'" + cmb_GioiTInh.Text + "'," +
                        "'" + txtSDT.Text + "','"+txtEmai.Text+"','"+txtDiaChi.Text+"','"+txtMaNhanVien.Text+"','True','')";
                    string check = "SELECT COUNT(maChucVu) FROM tblThongTinCaNhan WHERE maChucVu = '"+txtMaNhanVien.Text+"' OR user_name = '"+txtTaiKhoan.Text+"'";
                    if (SQLConect.kiemtraIDTrung(check) == true)
                    {
                        return;
                    }
                    SQLConect.luu(QUERY);
                    SQLConect.luu(query);
                    MessageBox.Show("Ghi dữ liệu thành công");                  
                    getData();
                    status = "Reset";
                    SetControl(status);
                }
                else
                {
                    string query1 = "UPDATE tblThongTinCaNhan SET hoTen=N'" + txtHoTen.Text +
                        "',ngaySinh='" + dtpNgaySinh.Value.ToString("yyyy/MM/dd") + "',GioiTinh=N'" + cmb_GioiTInh.Text +
                        "',soDienThoai= '" + txtSDT.Text + "',email=N'" + txtEmai.Text + "',diaChi= N'" + txtDiaChi.Text + "' WHERE maChucVu='" + txtMaNhanVien.Text + "'";
                    string query2 = "UPDATE tblThongTinNghiepVu SET ngayVaoLam='"+dtpNgayVaoLam.Value.ToString("yyyy/MM/dd")+"', luong = '"+txtLuong.Text+ "', tenChucVu = N'"+cmbChucVu.Text+"' WHERE maChucVu='"+txtMaNhanVien.Text+"'";
                    SQLConect.luu(query1);
                    SQLConect.luu(query2);
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    getData();
                    SetControl("Reset");
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Edit";
            SetControl(status);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("chắc chắn xóa không?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string query = "DELETE FROM tblThongTinNghiepVu WHERE maChucVu = '" +txtMaNhanVien.Text+"'";
                string query1 = "DELETE FROM tblThongTinCaNhan WHERE maChucVu = '" +txtMaNhanVien.Text+"'";
                SQLConect.luu(query1);
                SQLConect.luu(query);
                MessageBox.Show("Xoa thanh cong!");
                getData();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetControl(status);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            getData(txtTimKiem.Text); 
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            getData(txtTimKiem.Text);
        }
    }
}
