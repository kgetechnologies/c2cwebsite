using Card2cashin.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Card2cashin
{
	public class Helper
	{
		public static Dictionary<string, String> States
		{
			get
			{
				var op = new Dictionary<string, String>();
				op.Add("/state/Andaman-and-Nicobar-Islands", "Andaman and Nicobar Islands");
				op.Add("/state/Andhra-Pradesh", "Andhra Pradesh");
				op.Add("/state/Arunachal-Pradesh", "Arunachal Pradesh");
				op.Add("/state/Assam", "Assam");
				op.Add("/state/Bihar", "Bihar");
				op.Add("/state/Chandigarh", "Chandigarh");
				op.Add("/state/Chhattisgarh", "Chhattisgarh");
				op.Add("/state/Dadra-and-Nagar-Haveli-and-Daman-and-Diu", "Dadra and Nagar Haveli and Daman and Diu");
				op.Add("/state/Delhi", "Delhi");
				op.Add("/state/Goa", "Goa");
				op.Add("/state/Gujarat", "Gujarat");
				op.Add("/state/Haryana", "Haryana");
				op.Add("/state/Himachal-Pradesh", "Himachal Pradesh");
				op.Add("/state/Jammu-and-Kashmir", "Jammu and Kashmir");
				op.Add("/state/Jharkhand", "Jharkhand");
				op.Add("/state/Karnataka", "Karnataka");
				op.Add("/state/Kerala", "Kerala");
				op.Add("/state/Ladakh", "Ladakh");
				op.Add("/state/Lakshadweep", "Lakshadweep");
				op.Add("/state/Madhya-Pradesh", "Madhya Pradesh");
				op.Add("/state/Maharashtra", "Maharashtra");
				op.Add("/state/Manipur", "Manipur");
				op.Add("/state/Meghalaya", "Meghalaya");
				op.Add("/state/Mizoram", "Mizoram");
				op.Add("/state/Nagaland", "Nagaland");
				op.Add("/state/Odisha", "Odisha");
				op.Add("/state/Puducherry", "Puducherry");
				op.Add("/state/Punjab", "Punjab");
				op.Add("/state/Rajasthan", "Rajasthan");
				op.Add("/state/Sikkim", "Sikkim");
				op.Add("/state/Tamil-Nadu", "Tamil Nadu");
				op.Add("/state/Telangana", "Telangana");
				op.Add("/state/Tripura", "Tripura");
				op.Add("/state/Uttar-Pradesh", "Uttar Pradesh");
				op.Add("/state/Uttarakhand", "Uttarakhand");
				op.Add("/state/West-Bengal", "West Bengal");
				return op;
			}
		}

		public static Dictionary<string, string> CitiesByStateName(string stateName)
		{
			List<CityStateModel> op = new List<CityStateModel>();
			var result = new Dictionary<string, String>();
			using (StreamReader sr = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~/states-cities.json")))
			{
				op = JsonConvert.DeserializeObject<List<CityStateModel>>(sr.ReadToEnd());
			}

			if (op == null || !op.Any())
				return result;

			if (!string.IsNullOrEmpty(stateName))
			{
				op.ForEach(f =>
			{
				f.name = RemoveSpecialCharacters(f.name);
				if (f.name.Replace(" ", "-").ToLower() == stateName.ToLower())
				{
					if (f.cities != null && f.cities.Any())
					{
						f.cities.ForEach(c =>
						{
							c.name = RemoveSpecialCharacters(c.name);
						});
					}
				}
			});
				var op1 = op.FirstOrDefault(f => f.name.Replace(" ", "-").ToLower() == stateName.ToLower())?.cities;
				if (op1 != null)
				{
					op1.ForEach(a => result.Add($"/cities/credit-card-to-cash-in-{a.name.Replace(" ", "-")}", a.name));
				}
			}
			return result;
		}

		private static string RemoveSpecialCharacters(string input)
		{
			Regex r = new Regex("(?:[^a-zA-Z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
			return r.Replace(input, String.Empty);
		}
	}
}