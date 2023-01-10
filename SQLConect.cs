using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace QuanLyKS_N6
{
    public class SQLConect
    {
        public static string sqlcon = "Data Source=DESKTOP-PRH98VN;Initial Catalog=QuanLyKhachSan;Integrated Security=True";

        private static SqlConnection mycon;
        public static SqlCommand cmd;
        public static SqlDataAdapter ad;
        public static DataTable dt;
       


        // hàm kết nối
        public static void LayDuLieu(string chuoi, DataGridView db1)
        {
            try
            {

                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable(); 
                ad.Fill(dt);
                db1.DataSource = dt;
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }
        public static void LayDuLieu(string chuoi, DataTable dt1)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);      
                ad.Fill(dt1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }
        public static void LayDuLieu(string chuoi, DataSet ds)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                ad.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");

            }
        }

        // Hàm Tìm kiếm

        

        // hàm thêm dữ liệu

        public static void them_dl(string sql1, DataGridView dt)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                cmd = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Them Thanh công !", "Thong báo ");
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }

        // hàm xóa dữ liệu
        public static void Xoa(string sql)
        {
           
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    cmd = new SqlCommand(sql, mycon);
                    cmd.ExecuteNonQuery();
                    mycon.Close();
                MessageBox.Show("Xóa thanh công!");
                }
                catch
                {
                    MessageBox.Show("Bạn không thể xóa vì đang thuê! Vui lòng ktra lại ");
                }
            
        }


        // hàm sửa 
        public static void Sua(string sql)
        {          
               try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    cmd = new SqlCommand(sql, mycon);
                    cmd.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn sửa thành công, Thông tin sẽ cập nhật ở lần đăng nhập tiếp theo ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }     
        }

      
        public static void dem_nhap(string user_name, int dem)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                string query = "SELECT * FROM tblThongTinCaNhan WHERE user_name = '" + user_name + "'";
                SqlCommand cmd = new SqlCommand(query, mycon);
                mycon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    dem++; 
                }
                else
                {
                    MessageBox.Show("Tai khoan khong tồn tại ", "Thông báo",MessageBoxButtons.OK);
                    dem = 0;
                }
            }
            catch
            {
               
            }
            finally
            {
                mycon.Close();
            }
        }
        // ham mo khoa tai khoan
        public static void MoKhoa(string sql)
        {

            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                cmd = new SqlCommand(sql, mycon);
                cmd.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);

            }

        }


        public static void khoa_taiKhoan(string user_name)
        {
            string query = "UPDATE tblThongTinCaNhan SET TrangThai = '0', ThoiGianKhoa = '"+DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")+"' WHERE user_name = '" + user_name + "'";
            mycon = new SqlConnection(sqlcon);
            cmd = new SqlCommand(query,mycon);
            mycon.Open();
            cmd.ExecuteNonQuery();
            mycon.Close();
        }
        public static int dangNhap_TaiKhoan(string tk, string mk)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                string query = "SELECT * FROM tblThongTinCaNhan WHERE user_name = '" + tk + "' AND user_password= '" + mk + "'";
                SqlCommand cmd = new SqlCommand(query, mycon);
                mycon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                MessageBox.Show("Khong thay tai khoan");
                return -1;
            }
            finally
            {
                mycon.Close();
            }
        }
            public static int doi_MatKhau(string user_name, string matKhauCu,string query1)
            {
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    string query = "SELECT user_password FROM tblThongTinCaNhan WHERE user_name = '"+user_name +"'";
                    SqlCommand cmd = new SqlCommand(query, mycon);
                    mycon.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows[0]["user_password"].ToString() == matKhauCu)
                    {
                    cmd = new SqlCommand(query1, mycon);
                    cmd.ExecuteNonQuery();
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch
                {
                    MessageBox.Show("lỗi");
                    return -1;
                }
            finally
            {
                mycon.Close();
            }
            }
            public static int kiemTraTaiKhoan(string user_name )
        {
            
            string query = "SELECT TrangThai FROM tblThongTinCaNhan WHERE user_name = '" + user_name + "'";
            try { 
            mycon = new SqlConnection(sqlcon);
            cmd = new SqlCommand(query, mycon);
                mycon.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
                if (dt.Rows[0]["TrangThai"].ToString() =="True")
            {
                return 1;
            }
            else
            {
                return 0;
            }
            }
            catch
            {
                mycon.Close();
                return -1;
                
            }
         }

        // kiem tra trung ID
        public static bool kiemtraIDTrung(string select)
        {
            int i;
            mycon = new SqlConnection(sqlcon);
            mycon.Open();
            string sql = select;
            cmd = new SqlCommand(sql, mycon);
            i = (int)cmd.ExecuteScalar();


            if (i != 0)
            {
                MessageBox.Show("Mã đã tồn tại, vui lòng nhập mã mới ! ", "Error", MessageBoxButtons.OK);
                return true;
            }
            return false;
        }

        public static void luu(string sql)
        {


            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                cmd = new SqlCommand(sql, mycon);
                cmd.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);

            }

        }
        public static void thuePhong(string sql,string sql1)
        {


            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                cmd = new SqlCommand(sql, mycon);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sql1, mycon);
                cmd.ExecuteNonQuery();
             
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex);

            }

        }
        public static void DungDichVu(string sql, string sql1)
        {


            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                cmd = new SqlCommand(sql, mycon);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sql1, mycon);
                cmd.ExecuteNonQuery();
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);

            }

        }
        
   

        public static void update(string sql)
        {

            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                cmd = new SqlCommand(sql, mycon);
                cmd.ExecuteNonQuery();
            
                mycon.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thanh toán " + ex);

            }

        }
        //
        public static void them_dl1(string sql1)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                cmd = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(cmd);
                DataTable tb = new DataTable();
                ad.Fill(tb);

                mycon.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("");
            }

        }
     
        
    }
}
