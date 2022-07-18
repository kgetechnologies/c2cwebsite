using System.Web.Mvc;

namespace Card2cashin.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.DisplayName = "India";
			ViewBag.LinkValue = "Home";

			ViewBag.CanonicalUri = "";
			ViewBag.desc = "Credit card to Cash, Cheap card to cash service,credit card to instant cash, credit card to Spot cash, card swipe to cash, Spot Cash on Credit Card, Credit Card to Cash, Card to Cash, Instant Card to Cash, Master Card to Cash, Visa Card to Cash, Amex Card to Cash";
			ViewBag.Title = "Credit Card to Cash|Instant Cash on any Credit Card|Spot Cash on Credit Card|Credit Card to Cash|Card to Cash";


			return View();
		}

		public ActionResult About()
		{
			
			ViewBag.DisplayName = "About";
			ViewBag.LinkValue = "About";

			ViewBag.CanonicalUri = "About";
			ViewBag.desc = "About Credit card to Cash service, About Cheap card to cash, About credit card to instant cash, About credit card to Spot cash, About card swipe to cash, About Spot Cash on Credit Card, About Credit Card to Cash, About Card to Cash, About Instant Card to Cash, About Master Card to Cash, About Visa Card to Cash, About Amex Card to Cash";
			ViewBag.Title = "About Credit Card to Cash| About Instant Cash on any Credit Card| About Spot Cash on Credit Card| About Credit Card to Cash| About Card to Cash";
			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.DisplayName = "Contact";
			ViewBag.LinkValue = "Contact";

			ViewBag.CanonicalUri = "contact";
			ViewBag.desc = "Contact us for Credit card to Cash service, Contact us for Cheap card to cash, Contact us for credit card to instant cash, Contact us for credit card to Spot cash, Contact us for card swipe to cash, Contact us for Spot Cash on Credit Card, Contact us for Credit Card to Cash, Contact us for Card to Cash, Contact us for Instant Card to Cash, Contact us for Master Card to Cash, Contact us for Visa Card to Cash, Contact us for Amex Card to Cash";
			ViewBag.Title = "Contact us for Credit Card to Cash| Contact us for Instant Cash on any Credit Card| Contact us for Spot Cash on Credit Card| Contact us for Credit Card to Cash| Contact us for Card to Cash";
			return View();
		}
	}
}