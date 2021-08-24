using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap02.Models;
namespace BaiTap02.Controllers
{
    public class HomeController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double HeSoA , double  HeSoB)
        {
            double x = gpt.GiaiPhuongTrinhBacNhat(HeSoA,HeSoB);
            ViewBag.nghiemPT = x;
            return View();
        }
    }
}