﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap003.Controllers
{
    public class StudentController : Controller
    {
       

      
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetinfoSV()
        {
            return View();
        }
        public ActionResult GetinfoSV( string Ten, string Lop,int Tuoi)
        {
            ViewBag.Ten = Ten;
            ViewBag.Tuoi = Tuoi;
            ViewBag.Lop = Lop;
            return View();
        }


    }
}