using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1.session3
{
    public class CallApi
    {
        public async Task<Product> FetchData()
        {
            string url = "http://dummyjson.com/products/1";
            HttpClient c = new HttpClient();
            var rs = await c.GetAsync(url);
            if(rs.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                Product p = JsonConvert.DeserializeObject<Product>(responseText);
                return p;
            }
            return null;
        }
    }
}
