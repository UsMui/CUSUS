using System;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace ConsoleApp1.session3
{
    public class CallClouds
    {
        public async Task<Clouds> FetchData()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            HttpClient client = new HttpClient();
            var rs = await client.GetAsync(url);
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                Clouds c = JsonConvert.DeserializeObject<Clouds>(responseText);
                return c;
            }
            return null;
        }
    }
}
