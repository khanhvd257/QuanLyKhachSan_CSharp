using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKS_N6
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formMain());
             Application.Run(new formDangNhap());
            //Application.Run(new formDoiMatKhau());       
            //Application.Run(new formThuePhong("khanh"));
            //Application.Run(new formSudungDichVu());
            //Application.Run(new FormQuanLyPhong());
            //Application.Run(new FormQuanLyDichVu());
            //Application.Run(new formTraPhong("Khanh"));
            //Application.Run(new formQuanLyDiem());
            //Application.Run(new formThongKe());




        }
    }
}
