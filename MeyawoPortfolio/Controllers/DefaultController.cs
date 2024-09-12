using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;


namespace MeyawoPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbMyPortfolioEntities1 db = new DbMyPortfolioEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial()
        {
            var values = db.TblFuture.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult PortfolioPartial()
        {
            return PartialView();
        }
        public PartialViewResult PricingPartial()
        {
            return PartialView();
        }
        public PartialViewResult SectionPartial()
        {
            return PartialView();
        }
        public PartialViewResult TestimonialPartial()
        {
            return PartialView();
        }
        public PartialViewResult ContainerPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
        public FileResult DownloadMyCv()
        {
            string filePath = Server.MapPath("~/Files/aa.pdf");
            String fileName = "Fatih Doğan Cv.pdf";
            if(System.IO.File.Exists(filePath))
            {
                return File(filePath, "application/pdf", fileName);
            }
            else
            {
                throw new FileNotFoundException("Belirtilen Yol Bulunamamıştır!");
            }

        }
    

        


    }
}