using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;

namespace QuanLyThuVien
{
    public static class Library
    {
        public static readonly string connectionString = ConfigurationManager.ConnectionStrings["qltv"].ConnectionString;

        public static DataTable GetDataTable(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static void LoadDataToGridView(DataGridView dgv, string query, SqlParameter[] parameters = null)
        {
            dgv.DataSource = GetDataTable(query, parameters);
        }

        // Hàm nạp dữ liệu từ mã -> tên vào ComboBox (Có hỗ trợ isDeleted = 0)
        public static void LoadComboBox(ComboBox cbo, string tableName, string valueField, string displayField, bool hasIsDeleted = false)
        {
            string query = $"SELECT {valueField}, {displayField} FROM {tableName}";
            if (hasIsDeleted)
            {
                query += " WHERE isDeleted = 0";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbo.DataSource = dt;
                        cbo.ValueMember = valueField;   // Giá trị ẩn (Mã)
                        cbo.DisplayMember = displayField; // Hiển thị (Tên)
                    }
                }
            }
        }

        // Hàm sinh mã tự động cho tất cả các bảng
        public static string GenerateNewID(string tableName, string idField, string prefix, int numberLength)
        {
            string query = $"SELECT TOP 1 {idField} FROM {tableName} WHERE isDeleted = 0 ORDER BY {idField} DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string lastID = result.ToString();
                        if (lastID.StartsWith(prefix))
                        {
                            int number = int.Parse(lastID.Substring(prefix.Length)) + 1;
                            return prefix + number.ToString($"D{numberLength}"); // Tạo mã với số chữ số linh hoạt
                        }
                    }
                    return prefix + new string('0', numberLength - 1) + "1"; // Nếu chưa có, bắt đầu từ 001 hoặc 0001
                }
            }
        }
    }
}
