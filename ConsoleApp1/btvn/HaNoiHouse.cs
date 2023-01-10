using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.btvn
{
    public class HaNoiHouse : House
    {
        private string TenQuan { get; set; }
        public HaNoiHouse() { }
        public HaNoiHouse(string tenQuan, string SoNha, string DiaChi, string LoaiNha) : base(SoNha, DiaChi, LoaiNha)
        {
            TenQuan = tenQuan;

        }
    }
}
