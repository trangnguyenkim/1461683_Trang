using DoAnGiuaKyWeb.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnGiuaKyWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(ShopOnlineBus.DS());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Details(String id)
        {
            return View(ShopOnlineBus.ChiTiet(id));
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}