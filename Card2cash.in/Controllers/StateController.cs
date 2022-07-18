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
            var prefix = "credit-card-to-cash-in-";
            if (stateName?.ToLower().StartsWith(prefix)??false) {
                stateName = stateName.Replace(prefix, "");
            }
            ViewBag.DisplayName = stateName?.Replace("-", " ");
            ViewBag.LinkValue = stateName?.Replace(" ", "-");

            return View();
        }

        //https://card2cash.in/credit-card-to-cash-in-andra-pradesh
        //https://card2cash.in/credit-card-to-cash-in-tamil-nadu
        //https://card2cash.in/credit-card-to-cash-in-kerala
        //https://card2cash.in/credit-card-to-cash-in-Chennai
        //https://card2cash.in/credit-card-to-cash-in-Guduvancheri
        //https://card2cash.in/
        //https://card2cash.in/contact
        //https://card2cash.in/CreditCardToCash
    }
}