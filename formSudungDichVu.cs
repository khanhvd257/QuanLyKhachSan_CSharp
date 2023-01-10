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
    public partial class formSudungDichVu : Form
    {
        public formSudungDichVu()
        {
            InitializeComponent();
            GetData();
            Phong_SuDungDichVu();
        }

        private void GetData()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tblQLDichVu WHERE SoLuong > 0";
            SQLConect.LayDuLieu(query, dt);
            dgv_ThogTinDichVu.DataSource = dt;
            grb_ThogTinDichVu.Visible = false;
        }

        private void dgv_ThogTinDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                grb_ThogTinDichVu.Visible = true;
                int index = dgv_ThogTinDichVu.CurrentCell.RowIndex;
                DataGridViewRow item = dgv_ThogTinDichVu.Rows[index];
                lblMaDichVu.Text = item.Cells["MaDichVu"].Value.ToString();
                lblTenDV.Text = item.Cells["TenDichVu"].Value.ToString();
                if (!(Convert.ToInt32(item.Cells["SoLuong"].Value) == 0))
                {
                    lblSoLuong.Text = item.Cells["SoLuong"].Value.ToString();
                    num_SoLuong.Enabled = true;
                }
                else
                {
                    lblSoLuong.Text = "Sản phẩm đã hết hàng";
                    num_SoLuong.Enabled = false;
                }
                lblGhiChu.Text = item.Cells["GhiChu"].Value.ToString();
                lblDonGia.Text = item.Cells["DonGia"].Value.ToString();
            }
            catch
            {
                
            }
        }
        public void Phong_SuDungDichVu()
        {
            string query = "SELECT TenPhong,LoaiPhong,MaPhong FROM tblQLPhong WHERE TinhTrang = '0'";
            DataTable dt1 = new DataTable();
            SQLConect.LayDuLieu(query, dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cmbPhongSuDung.Items.Add("Phòng " + dt1.Rows[i][0] + " (" + dt1.Rows[i][1] + ") _ " + dt1.Rows[i][2] + "");

            }            
        }
        private void btnSuDung_DichVu_Click_1(object sender, EventArgs e)
        {

            if (num_SoLuong.Value == 0)
            {
                MessageBox.Show("Chua chon so luong", "Thông báo");
                num_SoLuong.Focus();
                return;

            }
            if (num_SoLuong.Value > Convert.ToDecimal(lblSoLuong.Text))
            {
                MessageBox.Show("Qúa sô lượng kho đang có rồi", "Thông báo");
                num_SoLuong.Value = Convert.ToDecimal(lblSoLuong.Text);
                return;
            }
            if (cmbPhongSuDung.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPhongSuDung.Focus();
                return;
            }
            if (MessageBox.Show("Bạn có muốn dùng dịch vụ tại " + cmbPhongSuDung.Text + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    string query = "INSERT INTO tblSuDungDichVu VALUES('" + lblMaDichVu.Text + "','" + num_SoLuong.Value + "','" + lblMaPhong.Text + "','"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"')";
                    int soluong = (Convert.ToInt32(lblSoLuong.Text) - Convert.ToInt32(num_SoLuong.Value));
                    string query_update = "UPDATE tblQLDichVu SET SoLuong = '" + soluong + "' WHERE MaDichVu='" + lblMaDichVu.Text + "'";
                    SQLConect.DungDichVu(query, query_update);
                    MessageBox.Show("đã ORDER Dịch vụ " + lblTenDV.Text + " thành công! ", "Thông báo");
                    GetData();
                    grb_ThogTinDichVu.Visible = false;

                }

                catch (Exception E)
                {
                    MessageBox.Show("Loi" + E.Message);
                }
            }
        }

        private void cmbPhongSuDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] arr = cmbPhongSuDung.Text.Split('_');
                lblMaPhong.Text = arr[1].Trim();
            }
            catch
            {
                MessageBox.Show("Da xay ra xung dot he thong");
            }
        }

        private void time_Tick(object sender, EventArgs e)
        {
            
                lblTime.Text = DateTime.Now.DayOfWeek + ", " + DateTime.Now.ToString();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tuDongTim();
          
        }
        public void tuDongTim()
        {
            string query = " SELECT * FROM tblQLDichVu WHERE TenDichVu LIKE N'%" + txtTimKiem.Text + "%'";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query, dt);
            dgv_ThogTinDichVu.DataSource = dt;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tuDongTim();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            grb_ThogTinDichVu.Visible = false;

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
