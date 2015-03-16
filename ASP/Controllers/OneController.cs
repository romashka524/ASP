using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class OneController : Controller
    {
        //
        // GET: /One/
        public ActionResult View1()
        {
            ViewBag.Message = "Какой сегодня день? ->" + DateTime.Now;
            return View();
        }
	}
}