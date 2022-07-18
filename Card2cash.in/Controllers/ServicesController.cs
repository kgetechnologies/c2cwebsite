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
            ViewBag.DisplayName = "Credit Card to Cash Support & Services";
            ViewBag.LinkValue = "";

            ViewBag.CanonicalUri = "About";
            ViewBag.desc = "About Credit card to Cash service, About Cheap card to cash, About credit card to instant cash, About credit card to Spot cash, About card swipe to cash, About Spot Cash on Credit Card, About Credit Card to Cash, About Card to Cash, About Instant Card to Cash, About Master Card to Cash, About Visa Card to Cash, About Amex Card to Cash";
            ViewBag.Title = "About Credit Card to Cash| About Instant Cash on any Credit Card| About Spot Cash on Credit Card| About Credit Card to Cash| About Card to Cash";

            return View("CreditCardToCash");
        }
        public ActionResult CreditCardToCash()
        {
            return View("CreditCardToCash");
        }

        public ActionResult InstantCashOnCreditCard()
        {
            return View("InstantCashOnCreditCard");
        }
        public ActionResult SpotCashOnCreditCard()
        {
            return View("SpotCashOnCreditCard");
        }

    }
}