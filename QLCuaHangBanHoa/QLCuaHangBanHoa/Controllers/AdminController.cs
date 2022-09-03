using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLCuaHangBanHoa.Models;

namespace QLCuaHangBanHoa.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        // Kết nối database
        DataClasses1DataContext db = new DataClasses1DataContext();

        // Trang chủ ---------------------------------------------------------------------------------
        public ActionResult HomeAdmin()
        {
            return View();
        }

        // Đơn hàng ----------------------------------------------------------------------------------
        public ActionResult Bill()
        {
            List<HOADON> dshd = db.HOADONs.ToList();
            return View(dshd);
        }

        // Cập nhật giao hàng ------------------------------------------------------------------------
        [HttpPost]
        public ActionResult GiaoHang(FormCollection col)
        {
            int tong = int.Parse(col["tong"]);

            for (int i = 1; i <= tong; i++)
            {
                string tenckb = i.ToString();
                if (col[tenckb] != null) // Hóa đơn được chọn
                {
                    // Cập nhật tình trạng giao hàng tại hd có maHD la GT của nút checkbox
                    int mhd = int.Parse(col[tenckb]);
                    HOADON hd = db.HOADONs.SingleOrDefault(t => t.maHD == mhd);
                    hd.ngayDat = DateTime.Now;

                    UpdateModel(hd);
                    db.SubmitChanges(); // Lưu xuống db
                }
            }
            return RedirectToAction("Bill", "Admin");
        }

        // Đếm sl, cthd, tổng thành tiền khi có mã hóa đơn, chọn partialView -------------------------
        public ActionResult ThongKe(int maHD)
        {
            List<CTHOADON> dsct = db.CTHOADONs.Where(c => c.maHD == maHD).ToList();

            // Thống kê thành tiền
            var thanhTien = dsct.Sum(ct => ct.soLuong * ct.SANPHAM.donGia);
            ViewBag.tt = thanhTien;

            return View(dsct);
        }

        // Liệt kê các hóa đơn trong dropdown list ---------------------------------------------------
        public ActionResult LietKeHD(int maHD)
        {
            List<CTHOADON> dsct = db.CTHOADONs.Where(c => c.maHD == maHD).ToList();

            return View(dsct);
        }

        // Liệt kê các khách hàng --------------------------------------------------------------------
        public ActionResult KhachHang()
        {
            List<KHACHHANG> dskh = db.KHACHHANGs.ToList();
            return View(dskh);
        }

        // Liệt kê các sản phẩm ----------------------------------------------------------------------
        public ActionResult SanPham()
        {
            List<SANPHAM> dssp = db.SANPHAMs.ToList();
            return View(dssp);
        }
    }
}