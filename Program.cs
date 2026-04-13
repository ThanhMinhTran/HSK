using System;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace QuanLyThuVien
{
    static class Program
    {
        [DllImport("user32.dll")] 
        private static extern bool SetProcessDPIAware();
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) // Kiểm tra phiên bản Windows
                SetProcessDPIAware(); // Gọi hàm để kích hoạt DPI Awareness
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
