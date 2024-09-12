using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ContackController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1(); 

        public ActionResult Index()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
    }
}