using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BaiThi
{
    public class Cylinder
    {
        public float Radius { get; set; }
        public float Height { get; set; }
        public Cylinder(float radius, float height)
        {
            Radius = radius;
            Height = height;
        }
        public float BaseArea;
        public float LateralArea;
        public float TotalArea;
        public float Volume;
        public void Process()
        {
            BaseArea = (float)((float)Radius * Radius * Math.PI);
            LateralArea = (float)(2 * Math.PI* Radius *Height);
            TotalArea = (float)(2 * Math.PI * Radius * (Height + Radius));
            Volume = (float)(Math.PI * Radius * Radius * Height);

        }
        public float ResultBaseArea()
        {
            this.Process();
            return BaseArea;
        }
        public float ResultLateralArea()
        {
            this.Process();
            return LateralArea;
        }
        public float ResultTotalArea()
        {
            this.Process();
            return TotalArea;
        }
        public float ResultVolume()
        {
            this.Process();
            return Volume;
        }


    }
}
