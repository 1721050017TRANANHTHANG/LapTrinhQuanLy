using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap004.Models;
namespace BaiTap004.Controllers
{
    public class GiaiPhuongTrinhController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: GiaiPhuongTrinh
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPTB1(string SoA, string SoB)
        {
            double a = double.Parse(SoA);
            double b = double.Parse(SoB);
            double x = gpt.GiaiPTBac1(a, b);
            ViewBag.NghiemPT = x;
            return View();
        }

    }
}