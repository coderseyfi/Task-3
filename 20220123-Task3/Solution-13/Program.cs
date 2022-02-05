using System;

namespace Solution_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13) 3 dene 5 reqemli eded var.
            // Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet.Alinan neticeleri topla
            // Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.

            int a = 12345;
            int b = 23456;
            int c = 34567;
            int a1=0;
            int b1=0;
            int c1=0;
            int sum;
            int Total;
            bool dogru = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000;
            if (!dogru)
            {
                Console.WriteLine("5 reqemli deyil");
            }

            a1 = a / 10000;
            a1 = a1 * 10 + a % 10;
            Console.WriteLine(a1);
            b1 = b / 10000;
            b1 = b1 * 10 + a % 10;
            Console.WriteLine(b1);
            c1 = c / 10000;
            c1 = c1 * 10 + a % 10;
            Console.WriteLine(c1);

            sum = a1 + b1 + c1;
            Total = sum + (sum * 50) / 100;
            Console.WriteLine("total : " + Total);

        }

    }
}
