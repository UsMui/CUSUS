using ConsoleApp1.BaiThi;
using ConsoleApp1.btvn;
using ConsoleApp1.session1;
using ConsoleApp1.session2;
using ConsoleApp1.session3;
using System.Security.Cryptography;

public class Program

{
    static void Main(string[] args)
    {
        Lion li = new Lion(200, "Lion");
        Tiger ti = new Tiger(100, "Tiger");
        li.Show();
        ti.Show();

    }
    static void Main2(string[] args)

    {
        Cylinder c = new Cylinder((float)38.64, (float)22.48);
        c.ResultLateralArea();
        c.ResultBaseArea();
        c.ResultTotalArea();
        c.ResultVolume();
        Console.WriteLine(c.LateralArea);
        Console.WriteLine(c.TotalArea);
        Console.WriteLine(c.Volume);
        Console.WriteLine(c.BaseArea);

    }

}
