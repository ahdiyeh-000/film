using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;


namespace DigiMovie.Controllers
{
    public class HomeController : Controller
<<<<<<< HEAD



=======
>>>>>>> c937385... 1
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(int? id,string message)
        {
            // ViewBag.Message = "Your application description page.";

             return View();
        //    if (id==null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);


        //    }
        //    return Content(id.ToString()+"<hr>"+ message);
       
       }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}