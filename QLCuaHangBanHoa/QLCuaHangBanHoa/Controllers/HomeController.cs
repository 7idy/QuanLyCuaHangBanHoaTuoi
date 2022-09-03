using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCuaHangBanHoa.Controllers
{
    public class HomeController : Controller
    {
        // Trang chủ --------------------------------------------------------------------------------
        public ActionResult Home()
        {
            return View();
        }

        // Lỗi 404 ----------------------------------------------------------------------------------
        public ActionResult Error()
        {
            return View();
        }

        // Giới thiệu -------------------------------------------------------------------------------
        public ActionResult Introduce()
        {
            return View();
        }
    }
}