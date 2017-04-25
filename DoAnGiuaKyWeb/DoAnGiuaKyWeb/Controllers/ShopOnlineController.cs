using DoAnGiuaKyWeb.Models.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnGiuaKyWeb.Controllers
{
    public class ShopOnlineController : Controller
    {
        // GET: ShopOnline
        public ActionResult Index()
        {
            return View(ShopOnlineBus.DS());
        }

        // GET: ShopOnline/Details/5
        public ActionResult Details(String id)
        {
            return View(ShopOnlineBus.ChiTiet(id));
        }

        // GET: ShopOnline/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopOnline/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopOnline/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopOnline/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ShopOnline/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopOnline/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
