using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Card2cashin.Controllers
{
    public class StateController : Controller
    {
       
        public ActionResult Index(string stateName)
        {
            var prefix = "credit-card-to-cash-in-";
            if (stateName?.ToLower().StartsWith(prefix)??false) {
                stateName = stateName.Replace(prefix, "");
            }
            ViewBag.DisplayName = stateName?.Replace("-", " ");
            ViewBag.LinkValue = stateName?.Replace(" ", "-");

            ViewBag.CanonicalUri = "credit-card-to-cash-in-" + ViewBag.LinkValue;

            ViewBag.desc = string.Format("Credit card to Cash in {0}, Cheap card to cash service in {0},credit card to instant cash in {0},credit card to Spot cash in {0}, card swipe to cash in {0}, Spot Cash on Credit Card in {0}, Credit Card to Cash in {0}, Card to Cash in {0}, Instant Card to Cash in {0}, Master Card to Cash in {0}, Visa Card to Cash in {0}, Amex Card to Cash in {0}", ViewBag.DisplayName);
            ViewBag.Title = string.Format("Credit Card to Cash in {0} | Instant Cash on any Credit Card in {0}, Spot Cash on Credit Card in {0}, Credit Card to Cash, Card to Cash in {0}", ViewBag.DisplayName);


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