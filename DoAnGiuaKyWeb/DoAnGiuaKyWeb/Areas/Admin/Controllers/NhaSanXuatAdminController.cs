using DoAnGiuaKyWeb.Areas.Admin.Models.BusAdmin;
using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnGiuaKyWeb.Areas.Admin.Controllers
{
    public class NhaSanXuatAdminController : Controller
    {
        // GET: Admin/NhaSanXuatAdmin
        public ActionResult Index()
        {
            return View(NhaSanXuatAdmin.DS());
        }

        // GET: Admin/NhaSanXuatAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/NhaSanXuatAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/NhaSanXuatAdmin/Create
        [HttpPost]
        public ActionResult Create(NhaSanXuat collection)
        {
            try
            {
                // TODO: Add insert logic here
                collection.TinhTrang = 0;
                NhaSanXuatAdmin.Them(collection);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/NhaSanXuatAdmin/Edit/5
        public ActionResult Edit(string id)
        {
            return View(NhaSanXuatAdmin.Update(id));
        }

        // POST: Admin/NhaSanXuatAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, NhaSanXuat sx)
        {
            try
            {
                // TODO: Add update logic here
                sx.TinhTrang = 0;
                NhaSanXuatAdmin.UpdateDS(sx);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/NhaSanXuatAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/NhaSanXuatAdmin/Delete/5
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

        public ActionResult xoatam(string id)
        {

            // TODO: Add delete logic here
            NhaSanXuatAdmin.DeleteDS(id);
            return RedirectToAction("Index");
        }
        public ActionResult KhoiPhucTinhTrang(string id)
        {

            // TODO: Add delete logic here
            NhaSanXuatAdmin.KhoiPhuc(id);
            return RedirectToAction("Index");
        }
    }
}
