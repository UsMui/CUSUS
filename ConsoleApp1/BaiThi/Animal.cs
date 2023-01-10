using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BaiThi
{
    public class Animal
    {
        public int weight { get; set; }
        public string name { get; set; }
        public Animal(int weight,string name)
        {
            this.weight = weight;
            this.name = name;
        }
        public void Show()
        {
            Console.WriteLine("Name : " + this.name + "Weight : " + this.weight);
        }
        public void SetMe(int weight,string name)
        {
            this.weight=weight;
            this.name = name;
        }

    }
}
