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