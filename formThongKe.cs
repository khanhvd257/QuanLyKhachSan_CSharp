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
    public partial class formThongKe : Form
    {
        public formThongKe()
        {
            InitializeComponent();
            grbThongTin.Visible = false;
        }

        private void formThongKe_Load(object sender, EventArgs e)
        {

        }
        public void getData()
        {
            string query = "SELECT Sum(tblHoaDon.TongGiaDichVu) AS dichVu, SUM(tblHoaDon.TongGiaPhong) AS tongPhong, SUM(tblSuDungPhong.SoNguoi) AS soNguoi " +
                "FROM tblHoaDon,tblSuDungPhong WHERE tblHoaDon.NgayLapHoaDon  BETWEEN '"+dtpTuNgay.Value.ToString("yyyy/MM/dd HH:mm:ss")+"' AND '"+dtpDenNgay.Value.ToString("yyyy/MM/dd HH:mm:ss") +"'";
            DataTable dt = new DataTable();
            SQLConect.LayDuLieu(query,dt);
            if (dt.Rows.Count > 0)
            {
                try
                {
                    grbThongTin.Visible = true;
                    lblTB.Visible = false;
                    lblTienDichVu.Text = dt.Rows[0]["dichVu"].ToString().Substring(0, dt.Rows[0]["dichVu"].ToString().IndexOf(',')) + " VND";
                    lblTienPhong.Text = dt.Rows[0]["tongPhong"].ToString().Substring(0, dt.Rows[0]["tongPhong"].ToString().IndexOf(',')) + " VND";
                  
                    lblTongDoanhThu.Text =Convert.ToString(Convert.ToInt32( dt.Rows[0]["dichVu"].ToString().Substring(0, dt.Rows[0]["dichVu"].ToString().IndexOf(',')))
                        + Convert.ToInt32(dt.Rows[0]["tongPhong"].ToString().Substring(0, dt.Rows[0]["tongPhong"].ToString().IndexOf(',')))) +" VND";
                }
                catch
                {

                }
            }
            else
            {
                lblTB.Text = "Chưa có giao dịch trong thời gian này";
                lblTB.Visible = true;
            }
        }

            private void btnTraCuu_Click(object sender, EventArgs e)
        {
            getData();
          
        }
    }
}
