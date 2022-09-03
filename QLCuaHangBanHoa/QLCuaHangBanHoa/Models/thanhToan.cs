using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QLCuaHangBanHoa.Models
{
    public class thanhToan
    {
        public string conStr = "Data Source=LAPTOP-PEPM7OTH; database=QLCuaHangBanHoa; User ID=sa;" +
            "Password=giabao04";

        int maHD = 0;

        // Thanh toán --------------------------------------------------------------------------------
        public int ThanhToanTien(int maHD, string userName, string maSP, int sLuong)
        {


            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            int rs = 0;
            string sql = "exec thanhToanHD '" + maHD + "','" + userName + "'," + maSP + 
                ",'" + sLuong + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            rs = cmd.ExecuteNonQuery(); //thuc hien cau lenh
            con.Close();
            return rs; //thành công nếu thành công trả về 1
        }

        // Lấy mã HD của dh vừa tạo ------------------------------------------------------------------
        public int LayMaHD(string userName)
        {
            if (maHD != 0)
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                string sql = "select MAX(maHD) from HOADON where userName='" + userName + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                int kt = (int)cmd.ExecuteScalar(); // xem co bao nhieu hoa don
                con.Close();
                return kt; // Mã số hóa đơn người dùng vừa tạo
            }
            else
            {
                maHD++;
                return 0;
            }
        }
    }
}