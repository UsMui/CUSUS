using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.btvn
{
    public class ManageHouse
    {
        public List<HaNoiHouse> HouseList;
        
        public ManageHouse()
        {
           HouseList = new List<HaNoiHouse>();
        
        }
        public void Sort()
        {
            HouseList.Sort ((o1, o2) =>
            {
                return o1.DiaChi.CompareTo(o2.DiaChi);
            });
        }
    }
}
