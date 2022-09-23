using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Card2cashin.Controllers
{
	public class StateController : Controller
	{
		
		public static List<string> Keywords = new List<string>()
		{
			"cash against credit card {0}",
"cash against credit card in {0}",
"cash for credit card in {0}",
"cash on credit card {0}",
"cash on credit card in {0}",
"cash on credit card swipe in {0}",
"credit card {0}",
"credit card encashment in {0}",
"credit card in {0}",
"credit card service {0}",
"credit card swipe for cash in {0}",
"credit card to cash in {0}",
"spot cash against credit card in {0}",
"spot cash against credit card swipe {0}",
"spot cash on bajaj emi card in {0}",
"spot cash on credit card in {0}",
"spot cash on credit cards in {0}",
"{0} credit card"
		};


		public ActionResult Index(string stateName)
		{
			var prefix = "credit-card-to-cash-in-";
			if (stateName?.ToLower().StartsWith(prefix) ?? false)
			{
				stateName = stateName.Replace(prefix, "");
			}
			ViewBag.DisplayName = stateName?.Replace("-", " ");
			ViewBag.LinkValue = stateName?.Replace(" ", "-");
			ViewBag.Id = Helper.GetIdByName(stateName);
			ViewBag.CanonicalUri = "credit-card-to-cash-in-" + ViewBag.LinkValue;

			ViewBag.desc = string.Format("cash for credit card in {0} | Credit card to Cash in {0}, Cheap card to cash service in {0},credit card to instant cash in {0},credit card to Spot cash in {0}", ViewBag.DisplayName);
			ViewBag.Title = string.Format("cash for credit card in {0} | Credit Card to Cash in {0} | Spot Cash on Credit Card in {0}", ViewBag.DisplayName);

			//Mon, 22 Jul 2002 11:12:01 GMT
			return View();
		}
	}
}