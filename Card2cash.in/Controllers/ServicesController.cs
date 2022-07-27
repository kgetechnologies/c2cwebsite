using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Card2cashin.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
          return  Redirect("/CreditCardToCash");
        }
        public ActionResult CreditCardToCash()
        {
            ViewBag.DisplayName = "Credit Card to Cash Support & Services";
            ViewBag.LinkValue = "";

            ViewBag.CanonicalUri = "Services on ";
            ViewBag.desc = "Services on  Instant Cash on Credit Card | Services on  Spot Cash on Credit Card | Services on  Credit Card to Cash | Services on  Cash on Credit card";
            ViewBag.Title = "Services on  Instant Cash | Services on  Spot Cash | Services on  Credit Card to Cash | Services on  Cash on Credit Card";



            return View("CreditCardToCash");
        }

        public ActionResult InstantCashOnCreditCard()
        {
            ViewBag.DisplayName = "Instant Cash on Credit Card";
            ViewBag.LinkValue = "";

            ViewBag.CanonicalUri = "/services/InstantCashOnCreditCard";
            ViewBag.desc = "Instant Cash on Credit Card | Instant Cash on Card | Credit Card Instant Cash | Card to Instant Cash";
            ViewBag.Title = "Instant Cash on Credit Card | Instant Cash on Card | Credit Card Instant Cash | Card to Instant Cash";

            return View("InstantCashOnCreditCard");
        }
        public ActionResult SpotCashOnCreditCard()
        {
            ViewBag.DisplayName = "Spot Cash on Credit Card";
            ViewBag.LinkValue = "";

            ViewBag.CanonicalUri = "/services/InstantCashOnCreditCard";
            ViewBag.desc = "Spot Cash on Credit Card | Spot Cash on Card | Credit Card Spot Cash | Card to Spot Cash";
            ViewBag.Title = "Spot Cash on Credit Card | Spot Cash on Card | Credit Card Spot Cash | Card to Spot Cash";
            
            return View("SpotCashOnCreditCard");
        }

    }
}