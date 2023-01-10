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
    public partial class formPhongDangThue : Form
    {
        public formPhongDangThue()
        {
            InitializeComponent();
            LayThongTinKhach_Phong();
            grbThongTinKhach.Enabled = false;
            grbTTphong.Enabled = false;
            btnGhi.Visible = false;
            btnHuy.Visible = false;
        }
        public void LayThongTinKhach_Phong()
        {
            string query = "SELECT * FROM tblKhachHang kh JOIN tblSuDungPhong p ON p.MaKH = kh.MaKH "+
               "JOIN tblQLPhong ph ON ph.MaPhong = p.MaPhong WHERE kh.TrangThaiThanhToan = '0' AND ph.TinhTrang = '0'";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query, dt);
            dtgrMainPhong.AutoGenerateColumns = false;
            dtgrMainPhong.DataSource = dt;
            
            if (dt.Rows.Count > 0)
            {
               
                lblMaKh.Text = dt.Rows[0]["MaKH"].ToString();
                lblTenKhach.Text = dt.Rows[0]["HoTen"].ToString();
                txtMaPhong.Text = dt.Rows[0]["MaPhong"].ToString();
                lblNamSinh.Value = Convert.ToDateTime( dt.Rows[0]["NamSinh"].ToString());
                lblDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                lblCCCd.Text = dt.Rows[0]["CCCD"].ToString();
                lblSoDT.Text = dt.Rows[0]["SoDienThoai"].ToString();
                dtpNgayDen.Value = Convert.ToDateTime( dt.Rows[0]["NgayDatPhong"].ToString());
                dtpNgayDi.Value = Convert.ToDateTime(dt.Rows[0]["NgayDi"].ToString());
                txtTenPhong.Text = dt.Rows[0]["TenPhong"].ToString();
                txtGia.Text= dt.Rows[0]["GiaPhong"].ToString();
                txtLoaiPhong.Text = dt.Rows[0]["LoaiPhong"].ToString();
            }
           

        }

        private void dtgrMainPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dtgrMainPhong.CurrentCell.RowIndex;
                var item = dtgrMainPhong.Rows[index];
                lblMaKh.Text = item.Cells["MaKH"].Value.ToString();
                lblTenKhach.Text = item.Cells["HoTen"].Value.ToString();
                txtMaPhong.Text = item.Cells["MaPhong"].Value.ToString();
                lblNamSinh.Value =Convert.ToDateTime( item.Cells["NamSinh"].Value.ToString());
                lblDiaChi.Text = item.Cells["DiaChi"].Value.ToString();
                lblCCCd.Text = item.Cells["CCCD"].Value.ToString();
                lblSoDT.Text = item.Cells["SoDienThoai"].Value.ToString();
                dtpNgayDen.Value = Convert.ToDateTime(item.Cells["NgayDatPhong"].Value.ToString());
                dtpNgayDi.Value = Convert.ToDateTime(item.Cells["NgayDi"].Value.ToString());
                txtTenPhong.Text = item.Cells["TenPhong"].Value.ToString();
                txtGia.Text = item.Cells["GiaPhong"].Value.ToString();
                txtLoaiPhong.Text = item.Cells["LoaiPhong"].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Visible = false;
            btnGhi.Visible = true;
            btnHuy.Visible = true;
            grbThongTinKhach.Enabled = true;
            lblMaKh.Enabled = false;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Ban co muon sua thong tin khong?", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "UPDATE tblKhachHang SET SoDienThoai ='" + lblSoDT.Text + "', HoTen= '" + lblTenKhach.Text + "', DiaChi='" + lblDiaChi.Text + "', CCCD= '" + lblCCCd.Text + "' " +
                    ", NamSinh ='" + lblNamSinh.Value.ToString("yyyy/MM/dd") + "' WHERE MaKH ='"+lblMaKh.Text+"'"; 
                    SQLConect.luu(query);
                }
            }
            catch { }
            btnGhi.Visible = false;
            btnHuy.Visible = false;
            btnSua.Visible = true;
            grbThongTinKhach.Enabled = false;
            LayThongTinKhach_Phong();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnGhi.Visible = false;
            btnHuy.Visible = false;
            btnSua.Visible = true;
        }
    }
}
