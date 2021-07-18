﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LainausjarjestelmaMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tietoa näistä sivuista";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Careerian yhteystieto sivusto";

            return View();
        }
    }
}