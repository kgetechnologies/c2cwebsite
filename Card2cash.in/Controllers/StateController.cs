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
        [Route("state/{stateName=Tamil-Nadu}")]
        public ActionResult Index(string stateName)
        {
            
            ViewBag.DisplayName = stateName?.Replace("-", " ");
            ViewBag.LinkValue = stateName?.Replace(" ", "-");

            return View();
        }
    }
}