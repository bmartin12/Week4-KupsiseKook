using System;

namespace KüpsiseKook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mitu küpsist lai on kook?");
            int Wide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mitu küpsist pikk on kook?");
            int Long = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mitu kihti on koogil?");
            int Layer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kui palju küpsiseid on pakkis?");
            int Pack = Convert.ToInt32(Console.ReadLine());
            int Area = Long * Wide;
            int All = Layer * Area;
            int CAll = Convert.ToInt32(Math.Round((double)All / Pack));
            Console.WriteLine($"Sul on vaja {CAll} pakki küpsiseid");
        }
    }
}
