
using System;

namespace Solution_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8) Verilmis ededdin axirdan 3 - cu reqemi ile sonuncu reqeminin cemini tap
            int a = 123456;

            bool dogru = a >= 1000 && a < 10000;
            if (!dogru)
            {
                Console.WriteLine("4 reqemli deyil");
            }
            int a3;
            int a6;
            a6 = a % 10;
            Console.WriteLine("ededin son reqemi : " + a6);
            a = a / 100;
            a3 = a % 10;
            Console.WriteLine("ededin 3cu  reqemi : "+ a3);
            int sum = a3 + a6;
            Console.WriteLine("bu reqemlerin cemi : " + sum);
        }
    }
}
