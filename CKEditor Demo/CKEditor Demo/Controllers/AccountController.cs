using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using CKEditor_Demo.Models;

namespace CKEditor_Demo.Controllers
{
    public class AccountController : Controller
    {
        Encrytion encry = new Encrytion();
        LapTrinhQuanLyDBEntities db = new LapTrinhQuanLyDBEntities();
        // GET: Account
       [HttpGet]
       public ActionResult Register ()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(Account acc)
        {
            if (ModelState.IsValid)
            {
                // Mã hóa mật khẩu trước khi lưu và database
                acc.Password = encry.PasswordEncrytion(acc.Password);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login (Account acc)
        {
            if (ModelState .IsValid)
            {
                string encrytionpass = encry.PasswordEncrytion(acc.Password);
                var model = db.Accounts.Where(m => m.UserName == acc.Usename && m.Password == encrytionpass).ToList().Count();
                // Thông tin đăng nhập chính xác
                if (model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.Usename, true);
                    return RedirectToAction("Index", "Home");
                }   
                else
                {
                    ModelState.AddModelError("", "Thông tin không chính xác");
                }    
            }
            return View(acc);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Home");
        }

    }
}