using DoAnGiuaKyWeb.Areas.Admin.Models.BusAdmin;
using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnGiuaKyWeb.Areas.Admin.Controllers
{
    public class SanPhamAdminController : Controller
    {
        // GET: Admin/SanPhamAdmin
        public ActionResult Index()
        {
            return View(SanPhamAdmin.DS());
        }

        // GET: Admin/SanPhamAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SanPhamAdmin/Create
        public ActionResult Create()
        {
            ViewBag.Maloaisanpham = new SelectList(SanPhamAdmin.LoaiSanPham(), "Maloaisanpham", "Tenloaisanpham");
            ViewBag.Manhasanxuat = new SelectList(SanPhamAdmin.NhaSanXuat(), "Manhasanxuat", "Tennhasanxuat");
            return View();
        }

        // POST: Admin/SanPhamAdmin/Create
        [HttpPost]
        public ActionResult Create(SanPham sp)
        {
            try
            {
                // TODO: Add insert logic here
                sp.Luotview = 0;
                sp.Tinhtrang = "0";
                SanPhamAdmin.Them(sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPhamAdmin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/SanPhamAdmin/Edit/5
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

        // GET: Admin/SanPhamAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/SanPhamAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {

            // TODO: Add delete logic here

            SanPhamAdmin.XoaSanPham(id);
            return RedirectToAction("Index");

        }

        public ActionResult xoatam(string id)
        {

            // TODO: Add delete logic here
            SanPhamAdmin.DeleteDS(id);
            return RedirectToAction("Index");
        }
        public ActionResult KhoiPhucTinhTrang(string id)
        {

            // TODO: Add delete logic here
            SanPhamAdmin.KhoiPhuc(id);
            return RedirectToAction("Index");
        }
    }
}
