using ConsoleApp1.session1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session2
{
    internal class Student : Human
    {
        private string[] telephone = new string[3];
        public Student() 
        { 
        }
        public Student(string s, int a) :base(s)
        {
            this.Age = a;
        }
        public void Study()
        {
            base.Run();
            this.Run();
        }
        public new void Run()
        {

        }
        public override void Eat()
        {
            
        }
        public string this[int index]
        {
            get => telephone[index];
            set => telephone[index] = value;
        }
    }

}
