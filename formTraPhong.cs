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
    public partial class formTraPhong : Form
    {
        public formTraPhong(string tenNv)
        {
           string tenNV = tenNv;
          InitializeComponent();
            setControll(status);
            lblNVgiaoDich.Text = tenNV;
        }
        static string status = "Start";
        
        public void setControll(string status)
        {
            switch (status)
            {
                case "Start":
                    grbDichVu.Visible = false;
                    grbHoaDon.Visible = false;
                    grbPhong.Visible = false;
                    grbThongTinKhach.Visible = false;
                    btnThanhToan.Visible = false;
                    break;
                case "Active":
                    grbDichVu.Visible = true;
                    grbHoaDon.Visible = false;
                    grbPhong.Visible = true;
                    grbThongTinKhach.Visible = true;
                    btnThanhToan.Visible = true;
                    break;

                case "End":
                    grbDichVu.Visible = true;
                    grbHoaDon.Visible = true;
                    grbPhong.Visible = true;
                    grbThongTinKhach.Visible = true;
                    btnThanhToan.Visible = false;
                    break;
            }
        }
        public void LayThongTinKhach_Phong(string MaPhong)
        {
            string query = "SELECT * FROM tblKhachHang kh JOIN tblSuDungPhong p ON p.MaKH = kh.MaKH " +
                "JOIN tblQLPhong ph ON ph.MaPhong = p.MaPhong WHERE ph.MaPhong = '" + MaPhong + "' AND TrangThaiThanhToan = '0'";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query, dt);
            if (dt.Rows.Count > 0)
            { 
                lblThongBao.Visible = false;
                lblMaKh.Text = dt.Rows[0]["MaKH"].ToString();
                lblTenKhach.Text = dt.Rows[0]["HoTen"].ToString();
                lblNamSinh.Text = dt.Rows[0]["NamSinh"].ToString();
                lblCCCd.Text = dt.Rows[0]["CCCD"].ToString();
                lblSoDT.Text = dt.Rows[0]["SoDienThoai"].ToString();
                lblNgayDen.Text = dt.Rows[0]["NgayDatPhong"].ToString();
                lblNgayDi.Text = dt.Rows[0]["NgayDi"].ToString();
                lblTongNgayO.Text = ((Convert.ToDateTime(lblNgayDi.Text)).Day - (Convert.ToDateTime(lblNgayDen.Text)).Day + 1).ToString();
                lblTenPhong.Text = dt.Rows[0]["TenPhong"].ToString();
                string[] arr = dt.Rows[0]["GiaPhong"].ToString().Split(',');
                lblGiaPhong.Text = arr[0];
                lblLoaiPhong.Text = dt.Rows[0]["LoaiPhong"].ToString();
                status = "Active";
                setControll(status);
            }
            else {
                lblThongBao.Text = "Khong tim thay phong";
                lblThongBao.Visible = true;
                lblThongBaoThanhToan.Visible = false;
                status = "Start";
                setControll(status);
            }


        }

        public void thongTinDV(string MaPhong)
        {
            string query = "SELECT sddv.MaDichVu, SUM(sddv.SLSuDungDichVu) as SLSuDung, dv.TenDichVu ,dv.DonGia FROM tblSuDungDichVu sddv " +
                "JOIN tblQLDichVu dv ON dv.MaDichVu = sddv.MaDichVu WHERE MaPhong = '" + MaPhong + "' GROUP BY sddv.MaDichVu, dv.TenDichVu ,dv.DonGia";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query, dt);
            DataColumn newCol = new DataColumn("ThanhTien");
            dt.Columns.Add(newCol);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] arr = (dt.Rows[i]["DonGia"]).ToString().Split(',');
                dt.Rows[i]["ThanhTien"] = Convert.ToInt32(dt.Rows[i]["SLSuDung"]) * Convert.ToInt32(arr[0]);
            }
            dgvDichVuSd.DataSource = dt;
            double TienThanhToan = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TienThanhToan += Convert.ToDouble(dt.Rows[i]["ThanhTien"]);
            }
            lblTongTienDichVu.Text = TienThanhToan.ToString() + " VND";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LayThongTinKhach_Phong(txtTimKiemPhongTra.Text);
            thongTinDV(txtTimKiemPhongTra.Text);
         
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có muốn thanh toán không?", "Thong báo!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblTongTienPhong.Text = (Convert.ToDouble(lblTongNgayO.Text) * Convert.ToDouble(lblGiaPhong.Text)).ToString() + " VND";

                lblTongThanhToan.Text = (Convert.ToDouble(lblTongTienDichVu.Text.Substring(0, lblTongTienDichVu.Text.IndexOf(' ')))
                    + Convert.ToDouble(lblTongTienPhong.Text.Substring(0, lblTongTienPhong.Text.IndexOf(' ')))).ToString() + " VND";
                lblThoigianThanhToan.Text = DateTime.Now.ToString();
                
                string MaHoaDon = DateTime.Now.ToString() + "_" +lblTenPhong.Text;
                string query = "INSERT INTO tblHoaDon VALUES('" + MaHoaDon + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "','" + lblTenPhong.Text + "','" + lblMaKh.Text + "'" +
                    ",'" + lblTongTienDichVu.Text.Substring(0, lblTongTienDichVu.Text.IndexOf(' ')) + "','" + lblTongTienPhong.Text.Substring(0, lblTongTienPhong.Text.IndexOf(' ')) + "')";
                SQLConect.luu(query);
                //1 là đã thanh toán, 0 là chưua thanh toán
                string query_UpdateThanhToan = "UPDATE tblKhachHang SET TrangThaiThanhToan = '1' WHERE MaKH = '" + lblMaKh.Text + "'";
                // 1 là trạng thái phòng trống, 0 là tt thuê
                string query_UpdatePhong = "UPDATE tblQLPhong  SET TinhTrang = '1' WHERE TenPhong = '" + lblTenPhong.Text + "'";
                SQLConect.update(query_UpdateThanhToan);
                SQLConect.update(query_UpdatePhong);
                status = "End";
                setControll(status);
                lblThongBaoThanhToan.Text = "Thanh Toán thành công cảm ơn quý khách";
                lblThongBaoThanhToan.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.DayOfWeek + ", " + DateTime.Now.ToString();
        }

        private void grbThongTinKhach_Enter(object sender, EventArgs e)
        {

        }
    }
}
