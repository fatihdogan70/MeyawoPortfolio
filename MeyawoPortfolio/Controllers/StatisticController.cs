using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        DbMyPortfolioEntities1 db=new DbMyPortfolioEntities1(); 
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.TblCategory.Count();
            ViewBag.ProjectCount=db.TblProject.Count();
            ViewBag.MessageCount=db.TblContact.Count();
            ViewBag.FlutterProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            ViewBag.IsNotReadMessageCount=db.TblContact.Where(x=>x.IsRead==false).Count();
            ViewBag.LastProjectName = db.LastProjectName().FirstOrDefault();
            ViewBag.SocialMediaCount=db.TblSocialMedia.Count();
            ViewBag.TestimonialCount=db.TblTestimonial.Count();
            ViewBag.ServiceCount=db.TblService.Count();
            ViewBag.LastTestimonialName = db.LastNameTestimonial().FirstOrDefault();


            return View();
        }
    }
}