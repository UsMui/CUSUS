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




    //static void Main(string[] args)
    //{
    //    Console.WriteLine("Nhap mot ngoi nha o Ha Noi");
    //    Console.WriteLine("Nhap so nha");
    //    String sn = Console.ReadLine();
    //    Console.WriteLine("Nhap dia chi");
    //    String dc = Console.ReadLine();
    //    Console.WriteLine("Nhap loai nha");
    //    String ln = Console.ReadLine() ;
    //    Console.WriteLine("Nhap ten quan");
    //    String tq = Console.ReadLine() ;
    //    HaNoiHouse hn = new HaNoiHouse(tq,sn,dc,ln);
    //    hn.display();
    //    List<HaNoiHouse> list = new List<HaNoiHouse>();
    //    list.Add(hn);

      
    //    Console.WriteLine("Nhap mot ngoi nha o Ha Noi");
    //    Console.WriteLine("Nhap so nha");
    //    String sn1 = Console.ReadLine();
    //    Console.WriteLine("Nhap dia chi");
    //    String dc1 = Console.ReadLine();
    //    Console.WriteLine("Nhap loai nha");
    //    String ln1 = Console.ReadLine();
    //    Console.WriteLine("Nhap ten quan");
    //    String tq1 = Console.ReadLine();
    //    HaNoiHouse hn1 = new HaNoiHouse(tq1, sn1, dc1, ln1);
    //    list.Add(hn1);
    //    list.Sort((o1, o2) =>
    //    {
    //        return o1.DiaChi.CompareTo(o2.DiaChi);
    //    });
    //    list.ToString();

    //}
    //static void Main6(string[] args)
    //{
    //    CallApi call= new CallApi();
    //    call.FetchData();
    //}
    //static void Main3(string[] args)
    //{
    //    //Thread t1 = new Thread(ThreadRun);
    //    //Thread t2 = new Thread(ThreadRunParam);
    //    //t2.IsBackground= true;
    //    //t1.Start();
    //    //t2.Start("T2203E");
    //    Number num = new Number() { X = 0,Y=0 } ;
    //    Thread n1 = new Thread(ThreadLock);
    //    Thread n2 = new Thread(ThreadLock);
    //    n1.Start(num);
    //    //n2.Start(num);
    //}
    //static void ThreadRun()
    //{
    //    for(int i=0;i<20;i++)
    //    {
    //        Console.WriteLine("i=" + i);
    //        try
    //        {
    //            Thread.Sleep(1000);
    //        }catch(Exception e) { }
    //    }
    //}
    //static void ThreadRunParam(object msg)
    //{
    //    for (int i = 0; i < 20; i++)
    //    {
    //        Console.WriteLine("i=" + i);
    //        try
    //        {
    //            Thread.Sleep(1000);
    //        }
    //        catch (Exception e) { }
    //    }
    //}
    //static void ThreadLock(object o)
    //{
    //    Number n = (Number)o;
    //    for(int i = 0; i < 20; i++)
    //    {
    //        lock(n)
    //        {
    //            n.ChangeXY();
    //            n.PrintXY();
    //        }
         
    //        try
    //        {
    //            Thread.Sleep(1000);

    //        }catch(Exception e) { }
    //    }
    //}
   
    //static void Main(string[] args)
    //{
    //    try
    //    {
    //        int x = 0;
    //        int y = 0;
    //        float z = x / y;
    //    }catch(Exception ex)
    //    {
    //        Console.WriteLine(ex.Message);

    //    }
    //    finally { 
    //    }
    //    Human h = new Human();
    //    h.Run();
    //    h.Age = 19;
    //    h.Email = "abc@gmail.com";
    //    Console.WriteLine(h.Age);
    //    Student s = new Student();
    //    s[0] = "099999999";
    //    s[1] = "088888888";
    //    List<string> ls = new List<string>();
    //    ls.Add("hello");
    //    ls.Add("world");
    //    ls.Add("moring");
    //    for(int i = 0; i < ls.Count; i++)
    //    {
    //        Console.WriteLine(ls[i]);
    //    }
    //    foreach(string l in ls)
    //    {
    //        Console.WriteLine(l);
    //    }
    //    PhanSo a = new PhanSo(1,2);
    //    a.InPhanSo();
        
    //    a.InPhanSo();
        


        
    //}
}
