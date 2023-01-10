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
    public partial class FormQuanLyDichVu : Form
    {
        
        public string status = "";
        public FormQuanLyDichVu()
        {
            InitializeComponent();
            GetData();
            SetControl("Idle");
        }

        public void SetControl(string st)
        {
            status = st;
            switch (st)
            {
                case "Idle":
                    txtMaDv.Enabled = false;
                    txtTendv.Enabled = false;
                    txtDongia.Enabled = false;
                    txtGhichu.Enabled = false;
                    dtpNgayNhap.Enabled = false;
                    txtSoLuong.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhiDL.Enabled = false;
                    btnHuy.Enabled = false;
                    break;

                case "Reset":
                    txtMaDv.Enabled = false;
                    txtTendv.Enabled = false;
                    txtDongia.Enabled = false;
                    txtGhichu.Enabled = false;
                    dtpNgayNhap.Enabled = false;
                    txtSoLuong.Enabled = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhiDL.Enabled = false;
                    btnHuy.Enabled = false;
                    txtTendv.Text = "";
                    txtMaDv.Text = "";
                    dtpNgayNhap.Value = DateTime.Now;
                    txtSoLuong.Text = "";
                    txtDongia.Text = "";
                    txtGhichu.Text = "";
                    

                    break;

                case "Insert":
                    txtMaDv.Enabled = true;
                    txtTendv.Enabled = true;
                    txtDongia.Enabled = true;
                    txtGhichu.Enabled = true;                 
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDL.Enabled = true;
                    btnHuy.Enabled = true;
                    dtpNgayNhap.Value = DateTime.Now;
                    txtSoLuong.Text = "";
                    dtpNgayNhap.Enabled = true;
                    txtSoLuong.Enabled = true;
                    txtTendv.Text = "";
                    txtMaDv.Text = "";
                    txtDongia.Text = "";
                    txtGhichu.Text = "";
                    
                    break;

                case "Edit":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDL.Enabled = true;
                    btnHuy.Enabled = true;
                    dtpNgayNhap.Enabled = true;
                    txtSoLuong.Enabled = true;
                    txtMaDv.Enabled = false;
                    txtTendv.Enabled = true;
                    txtDongia.Enabled = true;
                    txtGhichu.Enabled = true;

                    break;
                default:
                    break;


            }
        }

        public void GetData()
        {
            string query = "SELECT * FROM tblQLDichVu";
            DataSet ds = new DataSet();
            SQLConect.LayDuLieu(query, ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dgvMain.DataSource = ds.Tables[0];
                txtMaDv.Text = ds.Tables[0].Rows[0]["MaDichVu"].ToString();
                txtTendv.Text = ds.Tables[0].Rows[0]["TenDichVu"].ToString();
                txtSoLuong.Text = ds.Tables[0].Rows[0]["SoLuong"].ToString();
                txtDongia.Text = ds.Tables[0].Rows[0]["DonGia"].ToString().Substring(0, ds.Tables[0].Rows[0]["DonGia"].ToString().IndexOf(','));
                dtpNgayNhap.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["ngayNhap"].ToString());
                txtGhichu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();               
            }
        }
        public void GetData(string query)
        {

            DataSet ds1 = new DataSet();
            SQLConect.LayDuLieu(query, ds1);
            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
            {
                dgvMain.DataSource = ds1.Tables[0];
                txtMaDv.Text = ds1.Tables[0].Rows[0]["MaDichVu"].ToString();
                txtTendv.Text = ds1.Tables[0].Rows[0]["TenDichVu"].ToString();
                txtSoLuong.Text = ds1.Tables[0].Rows[0]["SoLuong"].ToString();
                txtDongia.Text = ds1.Tables[0].Rows[0]["DonGia"].ToString().Substring(0, ds1.Tables[0].Rows[0]["DonGia"].ToString().IndexOf(','));
                dtpNgayNhap.Value = Convert.ToDateTime(ds1.Tables[0].Rows[0]["ngayNhap"].ToString());
                txtGhichu.Text = ds1.Tables[0].Rows[0]["GhiChu"].ToString();
            }
        }

            private void btnThem_Click(object sender, EventArgs e)
        {
            SetControl("Insert");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControl("Reset");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetControl("Edit");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    string query = "DELETE FROM tblQLDichVu WHERE MaDichVu='" + txtMaDv.Text + "'";
                    SQLConect.Xoa(query);
                    GetData();
                    SetControl("Reset");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGhiDL_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == "Insert")
                {

                    string query = "INSERT INTO tblQLDichVu VALUES ('" + txtMaDv.Text +
                        "',N'" + txtTendv.Text + "','" + txtSoLuong.Text + "','" + txtDongia.Text + "','" + dtpNgayNhap.Value.ToString("yyyy/MM/dd") + "',N'" + txtGhichu.Text + "')";
                    SQLConect.luu(query);
                    MessageBox.Show("Ghi dữ liệu thành công");
                    GetData();
                    SetControl("Reset");
                }
                else
                {

                    string query = "UPDATE tblQLDichVu SET TenDichVu=N'" + txtTendv.Text +
                        "',SoLuong ='" + txtSoLuong.Text + "',DonGia=N'" + txtDongia.Text +
                        "',ngayNhap ='"+dtpNgayNhap.Value.ToString("yyyy/MM/dd") +"',GhiChu=N'" + txtGhichu.Text + "' WHERE MaDichVu='" + txtMaDv.Text + "'";

                    SQLConect.update(query);
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    SetControl("Reset");
                    
                    GetData();
                }
            }
            catch (Exception ex)
            {
                lblErrol.Text = ex.Message;
            }
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMain.CurrentCell.RowIndex;
            var item = dgvMain.Rows[index];
            txtSoLuong.Text = item.Cells["SoLuong"].Value.ToString();
            dtpNgayNhap.Value = Convert.ToDateTime(item.Cells["NgayNhap"].Value.ToString());
            txtMaDv.Text = item.Cells["madichvu"].Value.ToString();
            txtTendv.Text = item.Cells["tendv"].Value.ToString();
            txtDongia.Text = item.Cells["gia"].Value.ToString().Substring(0, item.Cells["gia"].Value.ToString().IndexOf(','));
            txtGhichu.Text = item.Cells["ghichu"].Value.ToString();
            
        }
        public void tuDongTim()
        {
            string query = " SELECT * FROM tblQLDichVu WHERE TenDichVu LIKE N'%" + txtTimKiem.Text + "%'";
            GetData(query);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tuDongTim();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tuDongTim();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
