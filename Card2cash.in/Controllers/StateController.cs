using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Policy;
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
			ViewBag.CanonicalUri = ("credit-card-to-cash-in-" + stateName?.Replace(" ", "-")).ToLower();

			ViewBag.desc = string.Format("cash for credit card in {0} | Credit card to Cash in {0}, Cheap card to cash service in {0},credit card to instant cash in {0},credit card to Spot cash in {0}", ViewBag.DisplayName);
			ViewBag.Title = string.Format("cash for credit card in {0} | Credit Card to Cash in {0} | Spot Cash on Credit Card in {0}", ViewBag.DisplayName);
			ViewBag.TestImage = CreateStateBanner(ViewBag.DisplayName, Color.Magenta, 80, 550, 910);
			//Mon, 22 Jul 2002 11:12:01 GMT
			return View();
		}

		const string CdnDomain = "https://cdn.card2cash.in/MvcImages/State.jpg";
		
		public string CreateStateBanner(string sText, Color color, int fontSize = 40, int x = 250, int y = 225)
		{
			try
			{
				using (var client = new WebClient())
				{
					var content = client.DownloadData(CdnDomain);
					using (var stream = new MemoryStream(content))
					{

						using (Bitmap oBitmap = new Bitmap(Image.FromStream(stream)))
						{
							Graphics oGraphic = Graphics.FromImage(oBitmap);

							PointF oPoint = default(PointF);
							SolidBrush oBrushBlack = new SolidBrush(color);
							Font oFont = new Font("Arial", fontSize, FontStyle.Bold);

							oPoint = new PointF(x, y);
							oGraphic.DrawString(sText, oFont, oBrushBlack, oPoint);

							using (MemoryStream memory = new MemoryStream())
							{
								oBitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
								byte[] bytesArray = memory.ToArray();
								return Convert.ToBase64String(bytesArray, 0, bytesArray.Length);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				return CdnDomain;
			}			
		}
	}
}