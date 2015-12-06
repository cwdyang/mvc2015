using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public interface IHomeController
    {
        ActionResult GetAccount(int accountNumber);
    }

    //NOTE
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        //NOTE
        [Route("index")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("accounts/{accountNumber:int}")]
        public ActionResult GetAccount(int accountNumber)
        {
            
            return Json(new {account=accountNumber.ToString() },JsonRequestBehavior.AllowGet);
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