using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.session1
{
    internal class Human
    {
        public string name;
        public int age;
        public static int xyz;
        private int id;
        public Human()
        {

        }
        public Human(string s)
        {
            this.Name = s;
        }
        public void Run()
        {
            Console.WriteLine("Run...");
            this.name = "Do Van Thang";
        }
        public static void ScreenShot()
        {

        }
        public virtual void Eat()
        {

        }
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }
        public string Email { get; set;}//Khi tạo đối tượng không có ô nhớ cho Email, khi gán giá trị mới tự động sinh ra



    }
}
