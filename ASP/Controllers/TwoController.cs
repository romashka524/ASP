using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class TwoController : Controller
    {
        //
        // GET: /Two/
        public ActionResult View1()
        {
            ViewBag.Message = "Какое прекрасное утро! Не правда ли?";
            return View();
        }
	}
}