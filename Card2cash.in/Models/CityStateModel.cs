using System.Collections.Generic;

namespace Card2cashin.Models
{  
    public class City
    {
        public string name { get; set; }
    }

    public class CityStateModel
    {
        //Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
        public string name { get; set; }
        public string state_code { get; set; }
        public List<City> cities { get; set; }
    }


}