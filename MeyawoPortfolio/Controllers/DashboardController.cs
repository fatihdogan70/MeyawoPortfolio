﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class DashboardController : Controller
    {
        DbMyPortfolioEntities1 db=new DbMyPortfolioEntities1();
        // GET: Dashboard
        public ActionResult Index()
        {
           ViewBag.ServiceCount=db.TblService.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.messageCount = db.TblContact.Count();
            ViewBag.testimonialCount = db.TblTestimonial.Count();

            return View();
        }
    }
}