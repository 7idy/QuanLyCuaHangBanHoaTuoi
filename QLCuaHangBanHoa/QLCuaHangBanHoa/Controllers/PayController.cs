using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLCuaHangBanHoa.Models;

namespace QLCuaHangBanHoa.Controllers
{
    public class PayController : Controller
    {
        // GET: Pay

        // Kết nối database
        DataClasses1DataContext db = new DataClasses1DataContext();

        // Thanh toán -------------------------------------------------------------------------------
        public ActionResult ThanhToanDH()
        {
            var tk = Session["KhachHang"] as KHACHHANG; // Khách hàng
            thanhToan tt = new thanhToan();
            List<gioHang> lstGioHang = Session["GioHang"] as List<gioHang>; // Giỏ hàng
            foreach (var m in lstGioHang)
            {
                // thanh toán thêm vào csdl
                if (tt.ThanhToanTien(tt.LayMaHD(tk.userName), tk.userName, m.sMaSP, m.iSL) > 0)
                {
                    ViewBag.BT1 = "Thanh toán thành công!";
                }
                else
                {
                    ViewBag.BT1 = "Thanh toán thất bại!";
                }
            }
            Session["GioHang"] = null; // Xóa các sản phẩm trong giỏ hàng
            return RedirectToAction("GioHang", "Cart");
        }
    }
}