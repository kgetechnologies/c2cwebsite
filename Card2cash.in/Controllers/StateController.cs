using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Card2cashin.Controllers
{
    public class StateController : Controller
    {
        // GET: State
        public ActionResult Index(string stateName)
        {
            ViewBag.State = stateName;
            return View();
        }
    }
}