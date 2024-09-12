using MeyawoPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeyawoPortfolio.Controllers
{
   
    public class AboutController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        // GET: About
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
    }
}