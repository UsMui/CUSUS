﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session3
{
    internal class Product
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public double discountPercentage { get; set; }
        public double rating { get; set; }
        public int stock { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public string thumbnail { get; set; }
        public List<string> images { get; set; }
    }
}
