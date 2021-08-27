using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap003.Controllers
{
    public class StudentController : Controller
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
       
    }
}