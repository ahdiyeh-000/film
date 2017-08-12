using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DigiMovie.Controllers
{
    public class TempController : Controller
    {
        // GET: Temp
        public ActionResult Index()
        {
            return View();

        }

        [ Route("Gallery/{year:int range(1300,1400)}/{month:int:range(1,12)}/{message:maxlength(5)?}")]
        public ActionResult ShowAlbum(string year,string month,string message)
        {
            return Content(year + "<hr>" + month + "<hr>" +message);
        }


    }


}