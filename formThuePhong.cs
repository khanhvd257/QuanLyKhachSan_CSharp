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
    public partial class formThuePhong : Form
    {
        public formThuePhong(string user_name)
        {
            InitializeComponent();
            getData(user_name);
            grb_ThongTinPhong.Visible = false;
        }
        public static string status = "";
        public void SetControl(string st)
        {
            status = st;
            switch (st)
            {

                case "Reset":
                    txtHoTen.Text = "";
                    dtpNgaySinhKhach.Value = DateTime.Now;
                    txtCCCD.Text = "";
                    txtSDT.Text = "";
                    txtGhiChu.Text = "";
                    txtDiaChi.Text = "";
                    grb_ThongTinPhong.Visible = false;
                    break;

            }
        }
            public void getData(string user_name)
        {
            
            string query = "SELECT MaPhong FROM tblQLPhong WHERE TinhTrang = '1'";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query, dt);
            lblMaNhanVien.Text = user_name;
            
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbMaPhong.Items.Add(dt.Rows[i]["MaPhong"].ToString());
                }
            
           

        }
        public void thongTinPhong(string maPhong)
        {
            DataTable dt1 = new DataTable();
            string query = "SELECT * FROM tblQLPhong WHERE MaPhong = '" + maPhong + "'";
            SQLConect.LayDuLieu(query, dt1);
            if (dt1.Rows.Count >= 0)
            {
                lblTenPhong.Text = dt1.Rows[0]["TenPhong"].ToString();
                lblLoaiPhong.Text = dt1.Rows[0]["LoaiPhong"].ToString();
                lblGiaPhong.Text = dt1.Rows[0]["GiaPhong"].ToString();
                if (String.Compare(dt1.Rows[0]["TinhTrang"].ToString(), "1", true) == 0)
                {
                    lblTinhTrang.Text = "Trống";
                }

            }
        }

        private void cmbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            thongTinPhong(cmbMaPhong.Text);
            grb_ThongTinPhong.Visible = true;
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            string MaKH = "KH" + txtCCCD.Text.Trim(); 
            int gioiTinh;
            if(cmbGioiTinh.SelectedIndex ==0)
            {
                gioiTinh = 0;
            }
            else
            {
                gioiTinh = 1;
            }
            if(txtHoTen.Text == "")
            {
                MessageBox.Show("Trường này không để trống");
                txtHoTen.Focus();
                return;
            }
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Trường này không để trống");
                txtCCCD.Focus();
                return;

            }
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Trường này không để trống");
                txtSDT.Focus();
                return;

            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Trường này không để trống");
                txtDiaChi.Focus();
                return;

            }
     
            try
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn thuê không? ", "Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    string query2 = "INSERT INTO tblSuDungPhong VALUES('" + cmbMaPhong.Text + "', '" + MaKH + "','" + dtpNgayDen.Value.ToString("yyyy/MM/dd") + "','" + dtpNgayDI.Value.ToString("yyyy/MM/dd") + "','" + nudSoNguoi.Value + "')";
                    string query1 = "INSERT INTO tblKhachHang VALUES('" + txtSDT.Text + "', '" + MaKH + "',N'" + txtHoTen.Text + "', N'" + txtDiaChi.Text + "','" + txtCCCD.Text + "','" + gioiTinh + "','"+ dtpNgaySinhKhach.Value.ToString("yyyy/MM/dd") + "',N'"+txtGhiChu.Text+"','0')";
                    SQLConect.thuePhong(query1, query2);
                    string query_update_Trang_thai_phong = "UPDATE tblQLPhong SET TinhTrang = '0' WHERE MaPhong = '"+cmbMaPhong.Text+"'";
                    SQLConect.update(query_update_Trang_thai_phong);
                    MessageBox.Show("Phòng " + lblTenPhong.Text + " Đã được nhân viên " + lblMaNhanVien.Text + " Thuê!", "Thông báo", MessageBoxButtons.OK);
                    cmbMaPhong.Items.Clear();
                    getData(lblMaNhanVien.Text);
                    status = "Reset";
                    SetControl(status);
                }

            }
            catch
            {
                MessageBox.Show("loi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetControl(status);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
