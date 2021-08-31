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
        public ActionResult Index ( string soThuNhat , string soThuHai)
        {
            gpt.SoA = convert.ToInt32(soThuNhat);
            gpt.SoB = convert.ToInt32(soThuHai);
            ViewBag.x = gpt.x(gpt.SoA, gpt.SoB);
            return View();

        }


    }
}