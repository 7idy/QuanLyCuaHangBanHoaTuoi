using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLCuaHangBanHoa.Models;

namespace QLCuaHangBanHoa.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        // Kết nối database
        DataClasses1DataContext db = new DataClasses1DataContext();

        // Giỏ hàng rỗng -----------------------------------------------------------------------------
        public ActionResult CartNull()
        {
            return View();
        }

        // Lấy giỏ hàng ------------------------------------------------------------------------------
        public List<gioHang> LayGioHang()
        {
            List<gioHang> lstGioHang = Session["GioHang"] as List<gioHang>;
            // nếu chưa có sản phẩm
            if (lstGioHang == null)
            {
                // tạo giỏ hàng
                lstGioHang = new List<gioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }

        // Thêm sản phẩm vào giỏ hàng ----------------------------------------------------------------
        public ActionResult ThemGioHang(string MaSP, string strURL)
        {
            // nếu đã đăng nhập
            if (Session["KhachHang"] != null)
            {
                List<gioHang> lstGioHang = LayGioHang();
                // tìm sản phảm trong giỏ hàng
                gioHang gh = lstGioHang.Find(c => c.sMaSP == MaSP);
                // nếu không có sản phảm này trong giỏ hàng
                if (gh == null)
                {
                    // thêm sản phẩm vào giỏ
                    gh = new gioHang(MaSP);
                    lstGioHang.Add(gh);
                    return Redirect(strURL);
                }
                else // đã có sản phẩm này trong giỏ hàng
                {
                    gh.iSL++; // tăng số lượng
                    return Redirect(strURL);
                }
            }
            else //chưa đăng nhập
            {
                return RedirectToAction("DangNhap", "Account");
            }
        }

        // Tổng số lượng hàng trong giỏ --------------------------------------------------------------
        public int TongSoLuong()
        {
            int tsl = 0;
            List<gioHang> lstGioHang = Session["GioHang"] as List<gioHang>;
            if (lstGioHang != null) // có sản phẩm trong giỏ
            {
                tsl = lstGioHang.Sum(s => s.iSL);// tổng số lượng sản phẩm cộng lại
            }
            return tsl;
        }

        // Tổng thành tiền ---------------------------------------------------------------------------
        private double TongThanhTien()
        {
            double ttt = 0;
            List<gioHang> lstGioHang = Session["GioHang"] as List<gioHang>;
            if (lstGioHang != null)
            {
                ttt = lstGioHang.Sum(sp => sp.dTinhThanhTien);
            }
            return ttt;
        }

        // Giỏ hàng ----------------------------------------------------------------------------------
        public ActionResult GioHang()
        {
            // nếu chưa đăng nhập
            if (Session["GioHang"] == null)
            {
                return RedirectToAction("CartNull", "Cart");
            }
            // xem giỏ hàng
            List<gioHang> lstGioHang = LayGioHang();
            // cập nhật số lượng sản phẩm
            ViewBag.TongSoLuong = TongSoLuong();
            // cập nhật tổng tiền
            ViewBag.TongThanhTien = TongThanhTien();

            return View(lstGioHang);
        }

        // Xem giỏ bằng icon -------------------------------------------------------------------------
        public ActionResult GioHangPartial()
        {
            // cập nhật số lượng sản phẩm
            ViewBag.TongSoLuong = TongSoLuong();
            // cập nhật tổng tiền
            ViewBag.TongThanhTien = TongThanhTien();
            return PartialView();
        }

        // Thanh toán --------------------------------------------------------------------------------
        public ActionResult ThanhToan()
        {
            ViewBag.TongSoLuong = 0;
            ViewBag.TongThanhTien = 0;
            // làm mới giỏ hàng
            Session["GioHang"] = null;
            return View();
        }

        // Xóa 1 sản phẩm trong giỏ ------------------------------------------------------------------
        public ActionResult XoaGioHang(string MaSP)
        {
            List<gioHang> lstGioHang = LayGioHang();
            gioHang sp = lstGioHang.Single(s => s.sMaSP == MaSP);
            if (sp != null)// có sản phẩm đó
            {
                lstGioHang.RemoveAll(s => s.sMaSP == MaSP);
                return RedirectToAction("GioHang", "Cart");
            }
            else//không có sản phẩm đó
            {
                return RedirectToAction("CartNull", "Cart");
            }
        }

        // Xóa tất cả sản phẩm có trong giỏ ----------------------------------------------------------
        public ActionResult XoaGioHang_ALL()
        {
            List<gioHang> lstGioHang = LayGioHang();
            //xóa tất cả trông giỏ
            lstGioHang.Clear();
            return RedirectToAction("CartNull", "Cart");
        }

        // Cập nhật số lượng sản phẩm có trong giỏ ---------------------------------------------------
        public ActionResult CapNhatGioHang(string MaSP, FormCollection f)
        {
            List<gioHang> lstGioHang = LayGioHang();
            gioHang sp = lstGioHang.Single(s => s.sMaSP == MaSP);
            if (sp != null)//có sản phẩm
            {
                SANPHAM sanpham = db.SANPHAMs.FirstOrDefault(c => c.maLSP == MaSP 
                    && c.sLTon >= int.Parse(f["txtSoLuong"].ToString()));
                if (sanpham != null)//số lượng tồn kho đủ
                {
                    //cập nhật lại số lượng
                    sp.iSL = int.Parse(f["txtSoLuong"].ToString());
                }
                else//số lượng tồn kho không đủ
                {
                    ViewBag.SL = "red";
                }
            }
            return RedirectToAction("GioHang", "Cart");
        }
    }
}