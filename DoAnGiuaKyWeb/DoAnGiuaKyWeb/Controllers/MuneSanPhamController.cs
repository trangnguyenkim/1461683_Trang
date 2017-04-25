using DoAnGiuaKyWeb.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnGiuaKyWeb.Controllers
{
    public class MuneSanPhamController : Controller
    {
        // GET: MuneSanPham
        public ActionResult Index()
        {
            return View();
        }

        // GET: MuneSanPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult AllProducts(string id)
        {

            return View(ShopOnlineBus.TatCaSanPham(id));
        }

        // GET: MuneSanPham/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: MuneSanPham/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MuneSanPham/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: MuneSanPham/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: MuneSanPham/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: MuneSanPham/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
