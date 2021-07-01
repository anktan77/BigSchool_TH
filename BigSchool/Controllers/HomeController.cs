using BigSchool.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Data.Entity;

namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        public HomeController()
        {
            db = new ApplicationDbContext();
        }

        public ActionResult Index() {
             
    
                var upcomingCourse = db.Courses.Where(p => p.DateTime > DateTime.Now).OrderBy(p => p.DateTime).ToList();
                foreach (Course i in upcomingCourse)
                {
                ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(i.IdLecturer);
                i.IdLecturer = user.Name;
                }
                return View(upcomingCourse);
             
        }

    public ActionResult About()
    {
        ViewBag.Message = "Your application description page.";

        return View();
    }

    public ActionResult Contact()
    {
        ViewBag.Message = "Your contact page.";

        return View();
    }
}

}