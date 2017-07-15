using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace XamarinLearn.Lib
{
    public class PM25DataService
    {
        public List<PM25Data> Items { get; private set; }

       public async Task<List<PM25Data>> GetDataFromOpenDataAsync()
        {
            Items = new List<PM25Data>();
            string url = @"http://opendata.epa.gov.tw/ws/Data/REWXQA/?$orderby=SiteName&$skip=0&$top=1000&format=json";

            var client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                content = content.Replace("PM2.5", "PM25");

                //Items = JsonConvert.DeserializeObject<List<PM25Data>>(content);
                Items = JsonConvert.DeserializeObject<List<PM25Data>>(content)
                    .OrderBy(x => x.County)
                    .ThenBy(x => x.SiteName)
                    .ToList();
            }
            return Items;
        }
    }
}
