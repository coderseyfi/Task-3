using System;

namespace Solution_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 11) 8 reqemli ededin reqemlerini iki -iki qruplashdir.
            //Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            //Sonra cavabin ozunden onun 18 % ni cix;

            int a = 12345678;
            bool isSuccess = a >= 10000000 && a < 100000000;
            if (!isSuccess)
            {
                Console.WriteLine("8 reqemli deyil");
            }

            int b=0;
            int c=0;
            int d=0;
            int e=0;
            int qaliq;
            double TotalSum=0;
            while (a>0)
            {
                qaliq = a % 100;
                b = b + qaliq;
                a /= 100;
                qaliq = a % 100;
                c = c + qaliq;
                a /= 100;
                qaliq = a % 100;
                d = d + qaliq;
                a /= 100;
                qaliq = a % 100;
                e = e + qaliq;
                a /= 100;
            }

            TotalSum = b + c + d + e;
            Console.WriteLine("2-2 qrupla cemi : " +TotalSum);
            TotalSum = TotalSum * 100 + 99;
            Console.WriteLine("neticenin sonuna 99 artir : " +TotalSum);
            TotalSum = TotalSum - ((TotalSum * 18) / 100);
            Console.WriteLine("neticenin ozunen 18%'ni cix : " +TotalSum);

        }
    }
}
