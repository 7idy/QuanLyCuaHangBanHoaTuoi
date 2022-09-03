using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLCuaHangBanHoa.Models;

namespace QLCuaHangBanHoa.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        // Kết nối database
        DataClasses1DataContext db = new DataClasses1DataContext();

        // Hiển thị loại SP --------------------------------------------------------------------------
        public ActionResult showLSP() // Dùng partial view
        {
            List<LOAISP> dsLSP = db.LOAISPs.ToList();
            return PartialView(dsLSP);
        }

        // Hiển thị SP theo loại SP ------------------------------------------------------------------
        public ActionResult showSPByLSP(string maLoai)
        {
            List<SANPHAM> dsSP = db.SANPHAMs.Where(t => t.maLSP == maLoai).ToList();
            // Trả về cùng 1 view
            return View("Product", dsSP);
        }

        // Hiển thị sản phẩm -------------------------------------------------------------------------
        public ActionResult Product()
        {
            List<SANPHAM> dsSP = db.SANPHAMs.ToList();
            return View(dsSP);
        }

        // Hiển thị chi tiết của sản phẩm theo mã loại SP --------------------------------------------
        public ActionResult ProductDetails(string id)
        {
            // Lấy ra 1 sản phẩm 
            SANPHAM sp = db.SANPHAMs.FirstOrDefault(t => t.maSP == id);
            // Lấy ds SP cùng mã loại với SP có mã là maSP
            List<SANPHAM> dsSP = db.SANPHAMs.Where(i => i.maLSP == sp.maLSP).ToList();
            // Truyền qua viewbag
            ViewBag.dsSP = dsSP;
            return View(sp);
        }

        // Tìm kiếm sản phẩm -------------------------------------------------------------------------
        public ActionResult Find()
        {
            ViewBag.maLSP = new SelectList(db.LOAISPs.ToList(), "maLSP", "tenLSP");
            return View();
        }

        // Xử lý tìm kiếm
        [HttpPost]
        public ActionResult FindHandle(FormCollection fct)
        {
            string tuKhoa = fct["txtTuKhoa"].ToString();
            string maLSP = fct["maLSP"].ToString();

            List<SANPHAM> dsSP = db.SANPHAMs.Where(t => t.tenSP.Contains(tuKhoa) == true
                && t.maLSP == maLSP).ToList();

            return View("Product", dsSP);
        }
    }
}