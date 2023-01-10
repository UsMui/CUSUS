using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.btvn
{
    public class House : IHouse
    {
        private string soNha;
        private string diaChi;
        private string loaiNha;
        public string SoNha 
        {
            get => soNha;
            set => soNha = value;
        
        }
        public string DiaChi 
        { 
            get => diaChi;
            set=> diaChi = value;
        }
        public string LoaiNha {
            get => loaiNha; 
            set => loaiNha = value;
        }
        public House() { }
        public House(string soNha, string diaChi, string loaiNha)
        {
            soNha = soNha;
            diaChi = diaChi;
            loaiNha = loaiNha;
        }

        public void display()
        {
            Console.WriteLine(this.ToString());
        }

        public void input()

        {

        }
    }
}
