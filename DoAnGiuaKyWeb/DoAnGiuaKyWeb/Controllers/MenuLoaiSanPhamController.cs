using DoAnGiuaKyWeb.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnGiuaKyWeb.Controllers
{
    public class MenuLoaiSanPhamController : Controller
    {
        // GET: MenuLoaiSanPham
        public ActionResult Index()
        {
            return View();
        }

        // GET: MenuLoaiSanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult DanhSachLoai(string id)
        {
            return View(ShopOnlineBus.TatCaSLoaiSanPham(id));
        }

    }
}
