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
    public partial class FormQuanLyPhong : Form
    {
        public string status = "";
        public FormQuanLyPhong()
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
                    txtMaPhong.Enabled = false;
                    txtTenPhong.Enabled = false;
                    txtGia.Enabled = false;
                    txtGhiChu.Enabled = false;
                    cbbLoaiPhong.Enabled = false;
                    cbbTinhTrang.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhiDL.Enabled = false;
                    btnHuy.Enabled = false;
                    break;

                case "Reset":
                    txtMaPhong.Enabled = false;
                    txtTenPhong.Enabled = false;
                    txtGia.Enabled = false;
                    txtGhiChu.Enabled = false;
                    cbbLoaiPhong.Enabled = false;
                    cbbTinhTrang.Enabled = false;

                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhiDL.Enabled = true;
                    btnHuy.Enabled = true;
                    txtMaPhong.Text = "";
                    txtTenPhong.Text = "";
                    txtGhiChu.Text = "";
                    txtGia.Text = "";
                    cbbTinhTrang.Text = "";
                    cbbLoaiPhong.Text = "";

                    break;

                case "Insert":
                    txtMaPhong.Enabled = true;
                    txtTenPhong.Enabled = true;
                    txtGia.Enabled = true;
                    txtGhiChu.Enabled = true;
                    cbbLoaiPhong.Enabled = true;
                    cbbTinhTrang.Enabled = true;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDL.Enabled = true;
                    btnHuy.Enabled = true;

                    txtMaPhong.Text = "";
                    txtTenPhong.Text = "";
                    txtGhiChu.Text = "";
                    txtGia.Text = "";
                    cbbTinhTrang.Text = "";
                    cbbLoaiPhong.Text = "";
                    break;

                case "Edit":
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGhiDL.Enabled = true;
                    btnHuy.Enabled = true;

                    txtMaPhong.Enabled = false;
                    txtTenPhong.Enabled = true;
                    txtGia.Enabled = true;
                    txtGhiChu.Enabled = true;
                    cbbLoaiPhong.Enabled = true;
                    cbbTinhTrang.Enabled = true;

                    break;
                default:
                    break;


            }
        }

        public void GetData()
        {
            string query = "SELECT * FROM tblQLPhong ";
            DataSet ds = new DataSet();
            SQLConect.LayDuLieu(query,ds);
            DataColumn newCol = new DataColumn("TrangThai");
            ds.Tables[0].Columns.Add(newCol);
            for(int i=0; i< ds.Tables[0].Rows.Count; i++)
            {
                if(ds.Tables[0].Rows[i]["TinhTrang"].ToString() == "1")
                {
                    ds.Tables[0].Rows[i]["TrangThai"] = "Đang Trống";
                }
                else
                {
                    ds.Tables[0].Rows[i]["TrangThai"] = "Đã Thuê";
                }
            }
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgrMain.AutoGenerateColumns = false;
                dtgrMain.DataSource = ds.Tables[0];
                txtMaPhong.Text = ds.Tables[0].Rows[0]["MaPhong"].ToString();
                txtTenPhong.Text = ds.Tables[0].Rows[0]["TenPhong"].ToString();
                if (ds.Tables[0].Rows[0]["TinhTrang"].ToString() == "1")
                {
                    cbbTinhTrang.SelectedIndex = 1;
                }
                else
                {
                    cbbTinhTrang.SelectedIndex = 0;
                }
                cbbLoaiPhong.Text = ds.Tables[0].Rows[0]["LoaiPhong"].ToString();
                txtGia.Text = ds.Tables[0].Rows[0]["GiaPhong"].ToString().Substring(0, ds.Tables[0].Rows[0]["GiaPhong"].ToString().IndexOf(","));
                txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
            }      

        }
        public void GetData(string query)
        {        
            DataSet ds = new DataSet();
            SQLConect.LayDuLieu(query, ds);
            DataColumn newCol = new DataColumn("TrangThai");
            ds.Tables[0].Columns.Add(newCol);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["TinhTrang"].ToString() == "1")
                {
                    ds.Tables[0].Rows[i]["TrangThai"] = "Đang Trống";
                }
                else
                {
                    ds.Tables[0].Rows[i]["TrangThai"] = "Đã Thuê";
                }
            }
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgrMain.AutoGenerateColumns = false;
                dtgrMain.DataSource = ds.Tables[0];
                txtMaPhong.Text = ds.Tables[0].Rows[0]["MaPhong"].ToString();
                txtTenPhong.Text = ds.Tables[0].Rows[0]["TenPhong"].ToString();
                if (ds.Tables[0].Rows[0]["TinhTrang"].ToString() == "1")
                {
                    cbbTinhTrang.SelectedIndex = 1;
                }
                else
                {
                    cbbTinhTrang.SelectedIndex = 0;
                }
                cbbLoaiPhong.Text = ds.Tables[0].Rows[0]["LoaiPhong"].ToString();
                txtGia.Text = ds.Tables[0].Rows[0]["GiaPhong"].ToString().Substring(0, ds.Tables[0].Rows[0]["GiaPhong"].ToString().IndexOf(","));
                txtGhiChu.Text = ds.Tables[0].Rows[0]["GhiChu"].ToString();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Insert";
            SetControl(status);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetControl(status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Edit";
            SetControl(status);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {               
                    string query = "DELETE FROM tblQLPhong WHERE MaPhong='" + txtMaPhong.Text + "'";
                    SQLConect.Xoa(query);                    
                    GetData();
                    status = "Reset";
                    SetControl(status);
                }
            }
            catch (Exception ex)
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
                    
                    string query = "INSERT INTO tblQLPhong VALUES (N'" + txtTenPhong.Text +
                        "','" + cbbTinhTrang.SelectedIndex + "',N'" + cbbLoaiPhong.Text + "','" + txtGia.Text + "', N'" + txtGhiChu.Text + "','" + txtMaPhong.Text + "')";
                    SQLConect.luu(query);
                    MessageBox.Show("Ghi dữ liệu thành công");
                    GetData();
                    SetControl("Insert");
                }
                else
                { 
                    string query = "UPDATE tblQLPhong SET TenPhong=N'" + txtTenPhong.Text +
                        "',TinhTrang=N'" + cbbTinhTrang.SelectedIndex + "',LoaiPhong=N'" + cbbLoaiPhong.Text +
                        "',GiaPhong= '" + txtGia.Text + "',GhiChu=N'" + txtGhiChu.Text + "',MaPhong='" + txtMaPhong.Text + "' WHERE MaPhong='" + txtMaPhong.Text + "'";
                    SQLConect.luu(query);
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

        private void dtgrMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgrMain.CurrentCell.RowIndex;
            var item = dtgrMain.Rows[index];
            txtMaPhong.Text = item.Cells["maphong"].Value.ToString();
            txtTenPhong.Text = item.Cells["tenphong"].Value.ToString();
            if (item.Cells["TrangThai"].Value.ToString() == "Đang Trống") 
            {
                cbbTinhTrang.SelectedIndex = 1;
            }
            else
            {
                cbbTinhTrang.SelectedIndex = 0;
            }
            txtGia.Text = item.Cells["Gia"].Value.ToString().Substring(0, item.Cells["Gia"].Value.ToString().IndexOf(","));
            txtGhiChu.Text = item.Cells["GhiChu"].Value.ToString();
            cbbLoaiPhong.Text = item.Cells["loaiphong"].Value.ToString();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tuDongTim();

        }
        public void tuDongTim()
        
        {
            string query = " SELECT * FROM tblQLPhong WHERE TenPhong LIKE N'%" + txtTimKiem.Text.Trim() + "%'";
            GetData(query);
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
