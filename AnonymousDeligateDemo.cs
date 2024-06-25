using System;
namespace AnonymousDeligateDemo
{
    class AnonymousDeligateDemo
    {
        public delegate int SumDeligate(int x, int y);
        public static void Main(string[] args)
        {
            SumDeligate sd1 = delegate (int x, int y)
            {
                return x + y;


            };
            Console.WriteLine(sd1(300, 300));
        }
    }
}