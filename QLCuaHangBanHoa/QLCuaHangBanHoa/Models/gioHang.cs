using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLCuaHangBanHoa.Models
{
    public class gioHang
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public string sMaSP { get; set; }
        public string sTenSP { get; set; }
        public string sHinhAnh { get; set; }
        public double dDonGia { get; set; }
        public int iSL { get; set; }

        // Tính thành tiền
        public double dTinhThanhTien
        {
            get { return iSL * dDonGia; }
        }

        // Giỏ hàng
        public gioHang(string MaSP)
        {
            sMaSP = MaSP;
            SANPHAM sp = db.SANPHAMs.Single(c => c.maSP == sMaSP);
            sTenSP = sp.tenSP;
            sHinhAnh = sp.hinhAnh;
            dDonGia = double.Parse(sp.donGia.ToString());
            iSL = 1;
        }
    }
}