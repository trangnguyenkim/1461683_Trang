using DoAnGiuaKyWeb.Areas.Admin.Models.BusAdmin;
using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnGiuaKyWeb.Areas.Admin.Controllers
{
    public class LoaiSanPhamAdminController : Controller
    {
        // GET: Admin/LoaiSanPhamAdmin
        public ActionResult Index()
        {
            return View(LoaiSanPhamAdmin.DS());
        }

        // GET: Admin/LoaiSanPhamAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/LoaiSanPhamAdmin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiSanPhamAdmin/Create
        [HttpPost]
        public ActionResult Create(LoaiSanPham l)
        {
            try
            {
                // TODO: Add insert logic here
                l.TinhTrang = 0;
                LoaiSanPhamAdmin.Them(l);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiSanPhamAdmin/Edit/5
        public ActionResult Edit(string id)
        {
            return View(LoaiSanPhamAdmin.Update(id));
        }

        // POST: Admin/LoaiSanPhamAdmin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, LoaiSanPham lsp)
        {
            try
            {
                // TODO: Add update logic here
                lsp.Maloaisanpham = null;
                lsp.TinhTrang = 0;
                LoaiSanPhamAdmin.UpdateDS(lsp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/LoaiSanPhamAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/LoaiSanPhamAdmin/Delete/5
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
                LoaiSanPhamAdmin.DeleteDS(id);
                return RedirectToAction("Index");
        }
        public ActionResult KhoiPhucTinhTrang(string id)
        {

            // TODO: Add delete logic here
            LoaiSanPhamAdmin.KhoiPhuc(id);
            return RedirectToAction("Index");
        }
    }
}
