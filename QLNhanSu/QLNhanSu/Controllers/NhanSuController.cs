using QLNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNhanSu.Controllers
{
    public class NhanSuController : Controller
    {
        // GET: NhanSu
        public ActionResult Index()
        {
            var listNhanVien = new DBNhanSuContext().NhanViens.ToList();
            return View(listNhanVien);
        }

        // GET: NhanSu/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NhanSu/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanSu/Create
        [HttpPost]
        public ActionResult Create(NhanVien model)
        {
            try
            {
                // TODO: Add insert logic here
                var context = new DBNhanSuContext();
                context.NhanViens.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: NhanSu/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NhanSu/Edit/5
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

        // GET: NhanSu/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NhanSu/Delete/5
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
