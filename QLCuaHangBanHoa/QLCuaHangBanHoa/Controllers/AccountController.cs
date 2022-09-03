using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLCuaHangBanHoa.Models;

namespace QLCuaHangBanHoa.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        // Kết nối database
        DataClasses1DataContext db = new DataClasses1DataContext();

        // Đăng nhập ---------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        // Xử lý đăng nhập 
        [HttpPost]
        public ActionResult XuLyDangNhap(FormCollection col)
        {
            string ten = col["txtTenDN"];
            string mk = col["txtPassword"];

            KHACHHANG kh = db.KHACHHANGs.SingleOrDefault(k => k.userName == ten && k.pass == mk);
            if (kh == null) // Đăng nhập không thành công, hiển thị thông báo
                return RedirectToAction("Error", "Home");

            if (ten == "Admin" || ten == "admin") // Tài khoản quản trị viên
                return RedirectToAction("HomeAdmin", "Admin");

            Session["KhachHang"] = kh; // Kiểu đối tượng khách hàng
            return RedirectToAction("Home", "Home");
        }

        // Đăng xuất ---------------------------------------------------------------------------------
        public ActionResult DangXuat()
        {
            Session["KhachHang"] = null;
            Session["GioHang"] = null;
            return RedirectToAction("Home", "Home");
        }

        // Đăng ký -----------------------------------------------------------------------------------
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }

        // Xử lý đăng ký
        [HttpPost]
        public ActionResult XLDangKy(KHACHHANG kh)
        {
            db.KHACHHANGs.InsertOnSubmit(kh);
            db.SubmitChanges();
            return RedirectToAction("DangNhap", "Account");
        }
    }
}