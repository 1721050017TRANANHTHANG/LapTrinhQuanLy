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
        public ActionResult Permission(int id)
        {
            var context = new DBNhanSuContext();
            var editing = context.NhanViens.Find(id);
            return View(editing);
        }
        // POST: NhanSu/Edit/5
        [HttpPost]
        public ActionResult Permission(NhanVien model)
        {
            try
            {
                // TODO: Add update Permission logic here
                var context = new DBNhanSuContext();
                var oldItem = context.NhanViens.Find(model.ld);
                oldItem.MatKhau = model.MatKhau;
                oldItem.LaQuanTri = model.LaQuanTri;
                oldItem.LaChuyenVien = model.LaChuyenVien;
                oldItem.LaNhanVien = model.LaNhanVien;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: NhanSu/Create
        public ActionResult Create()
        {
            var context = new DBNhanSuContext();
            var chucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu");
            ViewBag.IdChucVu = chucVuSelect;
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
            var context = new DBNhanSuContext();
            var editing = context.NhanViens.Find(id);
            var chucVuSelect = new SelectList(context.ChucVus, "Id", "TenChucVu",editing.IdChucVu);
            ViewBag.IdChucVu = chucVuSelect;
            return View(editing);
        }

        // POST: NhanSu/Edit/5
        [HttpPost]
        public ActionResult Edit(NhanVien model)
        {
            try
            {
                // TODO: Add update logic here
                var context = new DBNhanSuContext();
                var oldItem = context.NhanViens.Find(model.ld);
                oldItem.HoVaTen = model.HoVaTen;
                oldItem.GioiTinh = model.GioiTinh;
                oldItem.Email = model.Email;
                oldItem.IdChucVu = model.IdChucVu;
                oldItem.SoCanCuoc = model.SoCanCuoc;
                oldItem.SoDienThoai = model.SoDienThoai;
                context.SaveChanges();
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
            var context = new DBNhanSuContext();
            var deleting = context.NhanViens.Find(id);
            return View(deleting);
        }

        // POST: NhanSu/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var context = new DBNhanSuContext();
                var deleting = context.NhanViens.Find(id);
                context.NhanViens.Remove(deleting);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
