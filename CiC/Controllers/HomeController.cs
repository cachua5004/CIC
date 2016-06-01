using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CiC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ApplyCourse() 
        {
            return View();
        }

        public ActionResult Courses() 
        {
            return View();
        }

        public ActionResult Events() {
            return View();
        }

        public ActionResult Teachers() {
            return View();
        }

        public ActionResult TeachingEquipment() {
            return View();
        }

        public ActionResult WhyChooseUs(){
            return View();
        }

        public ActionResult CourseDetail() {
            return View();
        }
    }
}
